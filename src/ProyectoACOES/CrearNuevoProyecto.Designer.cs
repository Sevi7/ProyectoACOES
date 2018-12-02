namespace ProyectoACOES
{
    partial class CrearNuevoProyecto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaSocios = new System.Windows.Forms.ListBox();
            this.bAñadirSocio = new System.Windows.Forms.Button();
            this.tSocio = new System.Windows.Forms.TextBox();
            this.tResponsable = new System.Windows.Forms.TextBox();
            this.tCoordinador = new System.Windows.Forms.TextBox();
            this.tTipoProyecto = new System.Windows.Forms.TextBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tLocalidad = new System.Windows.Forms.TextBox();
            this.listaBeneficiarios = new System.Windows.Forms.ListBox();
            this.bAñadirBeneficiario = new System.Windows.Forms.Button();
            this.tBeneficiario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bCrearProyecto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaSocios
            // 
            this.listaSocios.FormattingEnabled = true;
            this.listaSocios.Location = new System.Drawing.Point(530, 430);
            this.listaSocios.Name = "listaSocios";
            this.listaSocios.Size = new System.Drawing.Size(110, 134);
            this.listaSocios.TabIndex = 27;
            // 
            // bAñadirSocio
            // 
            this.bAñadirSocio.Location = new System.Drawing.Point(370, 430);
            this.bAñadirSocio.Name = "bAñadirSocio";
            this.bAñadirSocio.Size = new System.Drawing.Size(75, 23);
            this.bAñadirSocio.TabIndex = 26;
            this.bAñadirSocio.Text = "Añadir";
            this.bAñadirSocio.UseVisualStyleBackColor = true;
            this.bAñadirSocio.Click += new System.EventHandler(this.bAñadirSocio_Click);
            // 
            // tSocio
            // 
            this.tSocio.Location = new System.Drawing.Point(176, 438);
            this.tSocio.Name = "tSocio";
            this.tSocio.Size = new System.Drawing.Size(161, 20);
            this.tSocio.TabIndex = 25;
            // 
            // tResponsable
            // 
            this.tResponsable.Location = new System.Drawing.Point(425, 277);
            this.tResponsable.Name = "tResponsable";
            this.tResponsable.Size = new System.Drawing.Size(315, 20);
            this.tResponsable.TabIndex = 24;
            // 
            // tCoordinador
            // 
            this.tCoordinador.Location = new System.Drawing.Point(425, 233);
            this.tCoordinador.Name = "tCoordinador";
            this.tCoordinador.Size = new System.Drawing.Size(315, 20);
            this.tCoordinador.TabIndex = 23;
            // 
            // tTipoProyecto
            // 
            this.tTipoProyecto.Location = new System.Drawing.Point(425, 191);
            this.tTipoProyecto.Name = "tTipoProyecto";
            this.tTipoProyecto.Size = new System.Drawing.Size(315, 20);
            this.tTipoProyecto.TabIndex = 22;
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(425, 150);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(315, 20);
            this.tNombre.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "NIF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Socios participantes en el proyecto (Opcional)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Responsable económico del proyecto (N.I.F)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Coordinador del proyecto (N.I.F)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tipo de Proyecto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(155, 74);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(535, 39);
            this.titulo.TabIndex = 14;
            this.titulo.Text = "Creación de un Nuevo Proyecto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Localidad";
            // 
            // tLocalidad
            // 
            this.tLocalidad.Location = new System.Drawing.Point(425, 322);
            this.tLocalidad.Name = "tLocalidad";
            this.tLocalidad.Size = new System.Drawing.Size(315, 20);
            this.tLocalidad.TabIndex = 29;
            // 
            // listaBeneficiarios
            // 
            this.listaBeneficiarios.FormattingEnabled = true;
            this.listaBeneficiarios.Location = new System.Drawing.Point(530, 658);
            this.listaBeneficiarios.Name = "listaBeneficiarios";
            this.listaBeneficiarios.Size = new System.Drawing.Size(110, 134);
            this.listaBeneficiarios.TabIndex = 33;
            // 
            // bAñadirBeneficiario
            // 
            this.bAñadirBeneficiario.Location = new System.Drawing.Point(370, 658);
            this.bAñadirBeneficiario.Name = "bAñadirBeneficiario";
            this.bAñadirBeneficiario.Size = new System.Drawing.Size(75, 23);
            this.bAñadirBeneficiario.TabIndex = 32;
            this.bAñadirBeneficiario.Text = "Añadir";
            this.bAñadirBeneficiario.UseVisualStyleBackColor = true;
            this.bAñadirBeneficiario.Click += new System.EventHandler(this.bAñadirBeneficiario_Click);
            // 
            // tBeneficiario
            // 
            this.tBeneficiario.Location = new System.Drawing.Point(176, 666);
            this.tBeneficiario.Name = "tBeneficiario";
            this.tBeneficiario.Size = new System.Drawing.Size(161, 20);
            this.tBeneficiario.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(267, 617);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(295, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Beneficiarios pertenecen en el proyecto (Opcional)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 673);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Codigo";
            // 
            // bCrearProyecto
            // 
            this.bCrearProyecto.Location = new System.Drawing.Point(336, 846);
            this.bCrearProyecto.Name = "bCrearProyecto";
            this.bCrearProyecto.Size = new System.Drawing.Size(148, 26);
            this.bCrearProyecto.TabIndex = 37;
            this.bCrearProyecto.Text = "Crear Proyecto";
            this.bCrearProyecto.UseVisualStyleBackColor = true;
            this.bCrearProyecto.Click += new System.EventHandler(this.bCrearProyecto_Click);
            // 
            // CrearNuevoProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 929);
            this.Controls.Add(this.bCrearProyecto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listaBeneficiarios);
            this.Controls.Add(this.bAñadirBeneficiario);
            this.Controls.Add(this.tBeneficiario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tLocalidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listaSocios);
            this.Controls.Add(this.bAñadirSocio);
            this.Controls.Add(this.tSocio);
            this.Controls.Add(this.tResponsable);
            this.Controls.Add(this.tCoordinador);
            this.Controls.Add(this.tTipoProyecto);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.Name = "CrearNuevoProyecto";
            this.Text = "Crear Nuevo Proyecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaSocios;
        private System.Windows.Forms.Button bAñadirSocio;
        private System.Windows.Forms.TextBox tSocio;
        private System.Windows.Forms.TextBox tResponsable;
        private System.Windows.Forms.TextBox tCoordinador;
        private System.Windows.Forms.TextBox tTipoProyecto;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tLocalidad;
        private System.Windows.Forms.ListBox listaBeneficiarios;
        private System.Windows.Forms.Button bAñadirBeneficiario;
        private System.Windows.Forms.TextBox tBeneficiario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bCrearProyecto;
    }
}