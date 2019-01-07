namespace ProyectoACOES
{
    partial class Inicio
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
            this.crearTipoProyecto = new System.Windows.Forms.Button();
            this.crearProyecto = new System.Windows.Forms.Button();
            this.bNota = new System.Windows.Forms.Button();
            this.bApadrinamientos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crearTipoProyecto
            // 
            this.crearTipoProyecto.Location = new System.Drawing.Point(212, 88);
            this.crearTipoProyecto.Name = "crearTipoProyecto";
            this.crearTipoProyecto.Size = new System.Drawing.Size(127, 23);
            this.crearTipoProyecto.TabIndex = 2;
            this.crearTipoProyecto.Text = "Crear TipoProyecto";
            this.crearTipoProyecto.UseVisualStyleBackColor = true;
            this.crearTipoProyecto.Click += new System.EventHandler(this.crearTipoProyecto_Click);
            // 
            // crearProyecto
            // 
            this.crearProyecto.Location = new System.Drawing.Point(38, 88);
            this.crearProyecto.Name = "crearProyecto";
            this.crearProyecto.Size = new System.Drawing.Size(126, 23);
            this.crearProyecto.TabIndex = 3;
            this.crearProyecto.TabStop = false;
            this.crearProyecto.Text = "Crear Proyecto";
            this.crearProyecto.UseVisualStyleBackColor = true;
            this.crearProyecto.Click += new System.EventHandler(this.crearProyecto_Click);
            // 
            // bNota
            // 
            this.bNota.Location = new System.Drawing.Point(212, 38);
            this.bNota.Name = "bNota";
            this.bNota.Size = new System.Drawing.Size(127, 23);
            this.bNota.TabIndex = 5;
            this.bNota.Text = "Gestion Calificaciones";
            this.bNota.UseVisualStyleBackColor = true;
            this.bNota.Click += new System.EventHandler(this.bNota_Click);
            // 
            // bApadrinamientos
            // 
            this.bApadrinamientos.Location = new System.Drawing.Point(117, 135);
            this.bApadrinamientos.Name = "bApadrinamientos";
            this.bApadrinamientos.Size = new System.Drawing.Size(154, 23);
            this.bApadrinamientos.TabIndex = 8;
            this.bApadrinamientos.Text = "Gestion Apadrinamientos";
            this.bApadrinamientos.UseVisualStyleBackColor = true;
            this.bApadrinamientos.Click += new System.EventHandler(this.bApadrinamientos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 9;
            this.button1.TabStop = false;
            this.button1.Text = "Gestion Niños/Jovenes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 182);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bApadrinamientos);
            this.Controls.Add(this.bNota);
            this.Controls.Add(this.crearProyecto);
            this.Controls.Add(this.crearTipoProyecto);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button crearTipoProyecto;
        private System.Windows.Forms.Button crearProyecto;
        private System.Windows.Forms.Button bNota;
        private System.Windows.Forms.Button bApadrinamientos;
        private System.Windows.Forms.Button button1;
    }
}