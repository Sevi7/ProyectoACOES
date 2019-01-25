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
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.titulo.Location = new System.Drawing.Point(283, 24);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(305, 46);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Creación de un";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(51, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(51, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(51, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Coordinador del tipo de proyecto (N.I.F)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(51, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Responsable económico del tipo de proyecto (N.I.F)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label5.Location = new System.Drawing.Point(213, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(393, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Socios donantes del tipo de proyecto (Opcional)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(130, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Código";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tNombre
            // 
            this.tNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tNombre.Location = new System.Drawing.Point(441, 161);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(315, 26);
            this.tNombre.TabIndex = 7;
            // 
            // tDescripcion
            // 
            this.tDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tDescripcion.Location = new System.Drawing.Point(441, 202);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(315, 41);
            this.tDescripcion.TabIndex = 8;
            // 
            // tCoordinador
            // 
            this.tCoordinador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tCoordinador.Location = new System.Drawing.Point(441, 263);
            this.tCoordinador.Name = "tCoordinador";
            this.tCoordinador.Size = new System.Drawing.Size(315, 26);
            this.tCoordinador.TabIndex = 9;
            // 
            // tResponsable
            // 
            this.tResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tResponsable.Location = new System.Drawing.Point(441, 308);
            this.tResponsable.Name = "tResponsable";
            this.tResponsable.Size = new System.Drawing.Size(315, 26);
            this.tResponsable.TabIndex = 10;
            // 
            // tSocio
            // 
            this.tSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tSocio.Location = new System.Drawing.Point(195, 501);
            this.tSocio.Name = "tSocio";
            this.tSocio.Size = new System.Drawing.Size(161, 26);
            this.tSocio.TabIndex = 11;
            // 
            // bAñadir
            // 
            this.bAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bAñadir.Location = new System.Drawing.Point(391, 499);
            this.bAñadir.Name = "bAñadir";
            this.bAñadir.Size = new System.Drawing.Size(83, 31);
            this.bAñadir.TabIndex = 12;
            this.bAñadir.Text = "Añadir";
            this.bAñadir.UseVisualStyleBackColor = true;
            this.bAñadir.Click += new System.EventHandler(this.bAñadir_Click);
            // 
            // listaSocios
            // 
            this.listaSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listaSocios.FormattingEnabled = true;
            this.listaSocios.ItemHeight = 20;
            this.listaSocios.Location = new System.Drawing.Point(541, 435);
            this.listaSocios.Name = "listaSocios";
            this.listaSocios.Size = new System.Drawing.Size(170, 164);
            this.listaSocios.TabIndex = 13;
            // 
            // bCrear
            // 
            this.bCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bCrear.Location = new System.Drawing.Point(307, 600);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(201, 49);
            this.bCrear.TabIndex = 14;
            this.bCrear.Text = "Crear Tipo Proyecto";
            this.bCrear.UseVisualStyleBackColor = true;
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(210, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(472, 46);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nuevo Tipo de Proyecto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CrearNuevoTipoProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(818, 685);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
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
            this.Name = "CrearNuevoTipoProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Nuevo Tipo Proyecto";
            this.Load += new System.EventHandler(this.CrearNuevoTipoProyecto_Load);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}