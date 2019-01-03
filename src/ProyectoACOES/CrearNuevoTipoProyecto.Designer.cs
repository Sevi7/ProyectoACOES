namespace ProyectoACOES
{
    partial class CrearNuevoTipoProyecto
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
            this.titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.tCoordinador = new System.Windows.Forms.TextBox();
            this.tResponsable = new System.Windows.Forms.TextBox();
            this.tSocio = new System.Windows.Forms.TextBox();
            this.bAñadir = new System.Windows.Forms.Button();
            this.listaSocios = new System.Windows.Forms.ListBox();
            this.bCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(33, 120);
            this.titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(994, 61);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Creación de un Nuevo Tipo de Proyecto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 255);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 318);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 412);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Coordinador del tipo de proyecto (N.I.F)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 475);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Responsable económico del tipo de proyecto (N.I.F)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(322, 565);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(414, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Socios donantes del tipo de proyecto (Opcional)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 645);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "NIF";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(560, 245);
            this.tNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(470, 26);
            this.tNombre.TabIndex = 7;
            // 
            // tDescripcion
            // 
            this.tDescripcion.Location = new System.Drawing.Point(560, 308);
            this.tDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(470, 61);
            this.tDescripcion.TabIndex = 8;
            // 
            // tCoordinador
            // 
            this.tCoordinador.Location = new System.Drawing.Point(560, 402);
            this.tCoordinador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tCoordinador.Name = "tCoordinador";
            this.tCoordinador.Size = new System.Drawing.Size(470, 26);
            this.tCoordinador.TabIndex = 9;
            // 
            // tResponsable
            // 
            this.tResponsable.Location = new System.Drawing.Point(560, 471);
            this.tResponsable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tResponsable.Name = "tResponsable";
            this.tResponsable.Size = new System.Drawing.Size(470, 26);
            this.tResponsable.TabIndex = 10;
            // 
            // tSocio
            // 
            this.tSocio.Location = new System.Drawing.Point(186, 640);
            this.tSocio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tSocio.Name = "tSocio";
            this.tSocio.Size = new System.Drawing.Size(240, 26);
            this.tSocio.TabIndex = 11;
            // 
            // bAñadir
            // 
            this.bAñadir.Location = new System.Drawing.Point(477, 628);
            this.bAñadir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bAñadir.Name = "bAñadir";
            this.bAñadir.Size = new System.Drawing.Size(112, 35);
            this.bAñadir.TabIndex = 12;
            this.bAñadir.Text = "Añadir";
            this.bAñadir.UseVisualStyleBackColor = true;
            this.bAñadir.Click += new System.EventHandler(this.bAñadir_Click);
            // 
            // listaSocios
            // 
            this.listaSocios.FormattingEnabled = true;
            this.listaSocios.ItemHeight = 20;
            this.listaSocios.Location = new System.Drawing.Point(717, 628);
            this.listaSocios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listaSocios.Name = "listaSocios";
            this.listaSocios.Size = new System.Drawing.Size(163, 204);
            this.listaSocios.TabIndex = 13;
            // 
            // bCrear
            // 
            this.bCrear.Location = new System.Drawing.Point(392, 918);
            this.bCrear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(237, 52);
            this.bCrear.TabIndex = 14;
            this.bCrear.Text = "Crear Tipo Proyecto";
            this.bCrear.UseVisualStyleBackColor = true;
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
            // 
            // CrearNuevoTipoProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 1050);
            this.Controls.Add(this.bCrear);
            this.Controls.Add(this.listaSocios);
            this.Controls.Add(this.bAñadir);
            this.Controls.Add(this.tSocio);
            this.Controls.Add(this.tResponsable);
            this.Controls.Add(this.tCoordinador);
            this.Controls.Add(this.tDescripcion);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CrearNuevoTipoProyecto";
            this.Text = "Crear Nuevo Tipo Proyecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.TextBox tCoordinador;
        private System.Windows.Forms.TextBox tResponsable;
        private System.Windows.Forms.TextBox tSocio;
        private System.Windows.Forms.Button bAñadir;
        private System.Windows.Forms.ListBox listaSocios;
        private System.Windows.Forms.Button bCrear;
    }
}