namespace ProyectoACOES
{
    partial class AñadirNota
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
            this.lCodigo = new System.Windows.Forms.Label();
            this.tCodigo = new System.Windows.Forms.TextBox();
            this.lAsignatura = new System.Windows.Forms.Label();
            this.tAsignatura = new System.Windows.Forms.TextBox();
            this.lNota = new System.Windows.Forms.Label();
            this.tNota = new System.Windows.Forms.TextBox();
            this.dFecha = new System.Windows.Forms.DateTimePicker();
            this.lFecha = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.titulo.Location = new System.Drawing.Point(187, 27);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(204, 39);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Añadir nota";
            // 
            // lCodigo
            // 
            this.lCodigo.AutoSize = true;
            this.lCodigo.Location = new System.Drawing.Point(205, 109);
            this.lCodigo.Name = "lCodigo";
            this.lCodigo.Size = new System.Drawing.Size(40, 13);
            this.lCodigo.TabIndex = 1;
            this.lCodigo.Text = "Código";
            // 
            // tCodigo
            // 
            this.tCodigo.Location = new System.Drawing.Point(251, 109);
            this.tCodigo.Name = "tCodigo";
            this.tCodigo.Size = new System.Drawing.Size(100, 20);
            this.tCodigo.TabIndex = 2;
            // 
            // lAsignatura
            // 
            this.lAsignatura.AutoSize = true;
            this.lAsignatura.Location = new System.Drawing.Point(188, 160);
            this.lAsignatura.Name = "lAsignatura";
            this.lAsignatura.Size = new System.Drawing.Size(57, 13);
            this.lAsignatura.TabIndex = 3;
            this.lAsignatura.Text = "Asignatura";
            // 
            // tAsignatura
            // 
            this.tAsignatura.Location = new System.Drawing.Point(251, 157);
            this.tAsignatura.Name = "tAsignatura";
            this.tAsignatura.Size = new System.Drawing.Size(100, 20);
            this.tAsignatura.TabIndex = 4;
            // 
            // lNota
            // 
            this.lNota.AutoSize = true;
            this.lNota.Location = new System.Drawing.Point(215, 205);
            this.lNota.Name = "lNota";
            this.lNota.Size = new System.Drawing.Size(30, 13);
            this.lNota.TabIndex = 5;
            this.lNota.Text = "Nota";
            // 
            // tNota
            // 
            this.tNota.Location = new System.Drawing.Point(251, 205);
            this.tNota.Name = "tNota";
            this.tNota.Size = new System.Drawing.Size(100, 20);
            this.tNota.TabIndex = 6;
            // 
            // dFecha
            // 
            this.dFecha.Location = new System.Drawing.Point(251, 248);
            this.dFecha.Name = "dFecha";
            this.dFecha.Size = new System.Drawing.Size(200, 20);
            this.dFecha.TabIndex = 7;
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Location = new System.Drawing.Point(208, 254);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(37, 13);
            this.lFecha.TabIndex = 8;
            this.lFecha.Text = "Fecha";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(251, 315);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 9;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // AñadirNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 350);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.lFecha);
            this.Controls.Add(this.dFecha);
            this.Controls.Add(this.tNota);
            this.Controls.Add(this.lNota);
            this.Controls.Add(this.tAsignatura);
            this.Controls.Add(this.lAsignatura);
            this.Controls.Add(this.tCodigo);
            this.Controls.Add(this.lCodigo);
            this.Controls.Add(this.titulo);
            this.Name = "AñadirNota";
            this.Text = "AñadirNota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label lCodigo;
        private System.Windows.Forms.TextBox tCodigo;
        private System.Windows.Forms.Label lAsignatura;
        private System.Windows.Forms.TextBox tAsignatura;
        private System.Windows.Forms.Label lNota;
        private System.Windows.Forms.TextBox tNota;
        private System.Windows.Forms.DateTimePicker dFecha;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Button bAceptar;
    }
}