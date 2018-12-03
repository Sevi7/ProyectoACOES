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
            this.insertBen = new System.Windows.Forms.Button();
            this.eliminarBen = new System.Windows.Forms.Button();
            this.crearTipoProyecto = new System.Windows.Forms.Button();
            this.crearProyecto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insertBen
            // 
            this.insertBen.Location = new System.Drawing.Point(49, 35);
            this.insertBen.Name = "insertBen";
            this.insertBen.Size = new System.Drawing.Size(126, 23);
            this.insertBen.TabIndex = 0;
            this.insertBen.Text = "InsertarBenefeciario";
            this.insertBen.UseVisualStyleBackColor = true;
            this.insertBen.Click += new System.EventHandler(this.insertBen_Click);
            // 
            // eliminarBen
            // 
            this.eliminarBen.Location = new System.Drawing.Point(223, 35);
            this.eliminarBen.Name = "eliminarBen";
            this.eliminarBen.Size = new System.Drawing.Size(127, 23);
            this.eliminarBen.TabIndex = 1;
            this.eliminarBen.Text = "EliminarBeneficiario";
            this.eliminarBen.UseVisualStyleBackColor = true;
            this.eliminarBen.Click += new System.EventHandler(this.button2_Click);
            // 
            // crearTipoProyecto
            // 
            this.crearTipoProyecto.Location = new System.Drawing.Point(223, 136);
            this.crearTipoProyecto.Name = "crearTipoProyecto";
            this.crearTipoProyecto.Size = new System.Drawing.Size(127, 23);
            this.crearTipoProyecto.TabIndex = 2;
            this.crearTipoProyecto.Text = "crearTipoProyecto";
            this.crearTipoProyecto.UseVisualStyleBackColor = true;
            this.crearTipoProyecto.Click += new System.EventHandler(this.crearTipoProyecto_Click);
            // 
            // crearProyecto
            // 
            this.crearProyecto.Location = new System.Drawing.Point(49, 136);
            this.crearProyecto.Name = "crearProyecto";
            this.crearProyecto.Size = new System.Drawing.Size(126, 23);
            this.crearProyecto.TabIndex = 3;
            this.crearProyecto.TabStop = false;
            this.crearProyecto.Text = "CrearProyecto";
            this.crearProyecto.UseVisualStyleBackColor = true;
            this.crearProyecto.Click += new System.EventHandler(this.crearProyecto_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 235);
            this.Controls.Add(this.crearProyecto);
            this.Controls.Add(this.crearTipoProyecto);
            this.Controls.Add(this.eliminarBen);
            this.Controls.Add(this.insertBen);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button insertBen;
        private System.Windows.Forms.Button eliminarBen;
        private System.Windows.Forms.Button crearTipoProyecto;
        private System.Windows.Forms.Button crearProyecto;
    }
}