#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <ctype.h>
#include <pthread.h>

int contador;

//Estructura necesaria para acceso excluyente
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;


typedef struct{
	int socket;
}Usuario;

typedef struct{
	Usuario usuario[40];
	int num;
}ListaUsuarios;

ListaUsuarios UsuariosConectados;


void *AtenderCliente (void *socket)
{
	int sock_conn;
	int *s;
	s= (int *) socket;
	sock_conn= *s;
	
	char peticion[512];
	char respuesta[512];
	int ret;
	
	//Bucle de atencion al cliente
	int terminar=0;
	while (terminar ==0 )
	{
		// Ahora recibimos su nombre, que dejamos en buff
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf ("Recibido\n");
		
		// Tenemos que a?adirle la marca de fin de string 
		// para que no escriba lo que hay despues en el buffer
		peticion[ret]='\0';
		
		//Escribimos el nombre en la consola
		printf ("Peticion: %s\n",peticion);
		
		//Vamos a ver que quieren
		char *p = strtok( peticion, "/");
		int codigo =  atoi (p);
		char nombre[20];
		
		if ((codigo !=0) && (codigo !=6))
		{
			p = strtok( NULL, "/");
			strcpy (nombre, p);
			printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
		}
		
		if (codigo==0)
		{
			terminar =1;
		}
		
		else if (codigo ==1) //piden la longitd del nombre
		{
			int longitud = strlen(nombre);
			sprintf (respuesta,"%d", longitud);
		}
		
		else if (codigo ==2 )
		{
			// quieren saber si el nombre es bonito
			if((nombre[0]=='M') || (nombre[0]=='S'))
			strcpy (respuesta,"SI");
			else
				strcpy (respuesta,"NO");
		}
			
		else if(codigo==3) //Decir si es alto
		{
			p = strtok( NULL, "/");
			float altura =  atof (p);
			if (altura>1.70)
				sprintf(respuesta, "%s: eres alto", nombre);
			else
				sprintf(respuesta, "%s: eres bajo", nombre);
			
		}
		
		else if(codigo == 4)
		{
			int NoIguales=0;
			int i=0;
			int l=strlen(nombre)-1;
			while((NoIguales!=1) && (i<l))
			{
				if(nombre[i]!=nombre[l])
					NoIguales=1;
				
				i++;
				l=l-1;
				
			}
			if (NoIguales==1)
				strcpy(respuesta,"NO");
			else
				strcpy(respuesta,"SI");
			
		}
		
		else if(codigo == 5)
		{
			char NombreMayusculas[20]; 
			strcpy(NombreMayusculas,nombre);
			for(int i=0; NombreMayusculas[i] != '\0';i++)
				NombreMayusculas[i] = toupper(NombreMayusculas[i]);
			
			sprintf(respuesta,"%s",NombreMayusculas);
		}
		
		else if(codigo == 6)
		{
			sprintf (respuesta, "%d", contador);
			
		}
		
		if ((codigo == 1)||(codigo == 2)||(codigo == 3)||(codigo == 4)||(codigo == 5))
		{
			pthread_mutex_lock( &mutex ); //No me interrumpe ahora
			contador = contador + 1;
			pthread_mutex_unlock( &mutex ); //ya puedes interrumpir
		}
		
		if (codigo!=0)
		{
			printf ("Respuesta: %s\n", respuesta);
			// Y lo enviamos
			write (sock_conn,respuesta, strlen(respuesta));
		}
			
		
	
		
	}
	close(sock_conn);
	printf("Conexion cerrada\n");
	
}

int main(int argc, char *argv[])
{
	UsuariosConectados.num=0;
	contador=0;
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// escucharemos en el port 9050
	serv_adr.sin_port = htons(9070);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 4) < 0)
		printf("Error en el Listen");
	
	int i;
	pthread_t thread[100];
	i=0;
	for(;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexi?n\n");
		UsuariosConectados.usuario[i].socket=sock_conn;
		//sock_conn es el socket que usaremos para este cliente
				
		// Crear thead y decirle lo que tiene que hacer		
		pthread_create (&thread[i], NULL, AtenderCliente,&UsuariosConectados.usuario[i].socket);
		UsuariosConectados.num=UsuariosConectados.num+1;
		i=i+1;
		
	
	}
}
