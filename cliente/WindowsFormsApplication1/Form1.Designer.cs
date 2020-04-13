namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mayusculas = new System.Windows.Forms.RadioButton();
            this.palindromo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.alturaBox = new System.Windows.Forms.TextBox();
            this.altura = new System.Windows.Forms.RadioButton();
            this.Longitud = new System.Windows.Forms.RadioButton();
            this.Bonito = new System.Windows.Forms.RadioButton();
            this.conectar_btn = new System.Windows.Forms.Button();
            this.desconectar_btn = new System.Windows.Forms.Button();
            this.servicios = new System.Windows.Forms.Button();
            this.contlbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(155, 38);
            this.nombre.Margin = new System.Windows.Forms.Padding(4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(217, 22);
            this.nombre.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 263);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.mayusculas);
            this.groupBox1.Controls.Add(this.palindromo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.alturaBox);
            this.groupBox1.Controls.Add(this.altura);
            this.groupBox1.Controls.Add(this.Longitud);
            this.groupBox1.Controls.Add(this.Bonito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(16, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(484, 347);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // mayusculas
            // 
            this.mayusculas.AutoSize = true;
            this.mayusculas.Location = new System.Drawing.Point(152, 232);
            this.mayusculas.Margin = new System.Windows.Forms.Padding(4);
            this.mayusculas.Name = "mayusculas";
            this.mayusculas.Size = new System.Drawing.Size(275, 21);
            this.mayusculas.TabIndex = 13;
            this.mayusculas.TabStop = true;
            this.mayusculas.Text = "Devuelveme mi nombre en mayusculas";
            this.mayusculas.UseVisualStyleBackColor = true;
            // 
            // palindromo
            // 
            this.palindromo.AutoSize = true;
            this.palindromo.Location = new System.Drawing.Point(152, 203);
            this.palindromo.Margin = new System.Windows.Forms.Padding(4);
            this.palindromo.Name = "palindromo";
            this.palindromo.Size = new System.Drawing.Size(238, 21);
            this.palindromo.TabIndex = 12;
            this.palindromo.TabStop = true;
            this.palindromo.Text = "Dime si mi nombre es palindromo";
            this.palindromo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Altura";
            // 
            // alturaBox
            // 
            this.alturaBox.Location = new System.Drawing.Point(155, 78);
            this.alturaBox.Name = "alturaBox";
            this.alturaBox.Size = new System.Drawing.Size(100, 22);
            this.alturaBox.TabIndex = 10;
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Location = new System.Drawing.Point(152, 174);
            this.altura.Margin = new System.Windows.Forms.Padding(4);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(128, 21);
            this.altura.TabIndex = 9;
            this.altura.TabStop = true;
            this.altura.Text = "Dime si soy alto";
            this.altura.UseVisualStyleBackColor = true;
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(152, 145);
            this.Longitud.Margin = new System.Windows.Forms.Padding(4);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(220, 21);
            this.Longitud.TabIndex = 7;
            this.Longitud.TabStop = true;
            this.Longitud.Text = "Dime la longitud de mi nombre";
            this.Longitud.UseVisualStyleBackColor = true;
            // 
            // Bonito
            // 
            this.Bonito.AutoSize = true;
            this.Bonito.Location = new System.Drawing.Point(155, 116);
            this.Bonito.Margin = new System.Windows.Forms.Padding(4);
            this.Bonito.Name = "Bonito";
            this.Bonito.Size = new System.Drawing.Size(207, 21);
            this.Bonito.TabIndex = 8;
            this.Bonito.TabStop = true;
            this.Bonito.Text = "Dime si mi nombre es bonito";
            this.Bonito.UseVisualStyleBackColor = true;
            // 
            // conectar_btn
            // 
            this.conectar_btn.Location = new System.Drawing.Point(75, 53);
            this.conectar_btn.Name = "conectar_btn";
            this.conectar_btn.Size = new System.Drawing.Size(148, 43);
            this.conectar_btn.TabIndex = 7;
            this.conectar_btn.Text = "conectar";
            this.conectar_btn.UseVisualStyleBackColor = true;
            this.conectar_btn.Click += new System.EventHandler(this.conectar_btn_Click);
            // 
            // desconectar_btn
            // 
            this.desconectar_btn.Location = new System.Drawing.Point(75, 535);
            this.desconectar_btn.Name = "desconectar_btn";
            this.desconectar_btn.Size = new System.Drawing.Size(124, 50);
            this.desconectar_btn.TabIndex = 8;
            this.desconectar_btn.Text = "desconectar";
            this.desconectar_btn.UseVisualStyleBackColor = true;
            this.desconectar_btn.Click += new System.EventHandler(this.desconectar_btn_Click);
            // 
            // servicios
            // 
            this.servicios.Location = new System.Drawing.Point(560, 140);
            this.servicios.Margin = new System.Windows.Forms.Padding(4);
            this.servicios.Name = "servicios";
            this.servicios.Size = new System.Drawing.Size(100, 28);
            this.servicios.TabIndex = 9;
            this.servicios.Text = "Nº servicios";
            this.servicios.UseVisualStyleBackColor = true;
            this.servicios.Click += new System.EventHandler(this.servicios_Click);
            // 
            // contlbl
            // 
            this.contlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contlbl.Location = new System.Drawing.Point(560, 178);
            this.contlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contlbl.Name = "contlbl";
            this.contlbl.Size = new System.Drawing.Size(85, 62);
            this.contlbl.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 692);
            this.Controls.Add(this.contlbl);
            this.Controls.Add(this.servicios);
            this.Controls.Add(this.desconectar_btn);
            this.Controls.Add(this.conectar_btn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Longitud;
        private System.Windows.Forms.RadioButton Bonito;
        private System.Windows.Forms.RadioButton altura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox alturaBox;
        private System.Windows.Forms.Button conectar_btn;
        private System.Windows.Forms.Button desconectar_btn;
        private System.Windows.Forms.RadioButton mayusculas;
        private System.Windows.Forms.RadioButton palindromo;
        private System.Windows.Forms.Button servicios;
        private System.Windows.Forms.Label contlbl;
    }
}

