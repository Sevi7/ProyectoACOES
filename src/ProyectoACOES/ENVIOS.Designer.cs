namespace ProyectoACOES
{
    partial class ENVIOS
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
            this.bModificar = new System.Windows.Forms.Button();
            this.bInsertar = new System.Windows.Forms.Button();
            this.tSocio = new System.Windows.Forms.TextBox();
            this.lAsignatura = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.dgEnvios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tNiño = new System.Windows.Forms.TextBox();
            this.tCodigo = new System.Windows.Forms.TextBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.cbRemitente = new System.Windows.Forms.ComboBox();
            this.bSalir = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEnvios)).BeginInit();
            this.SuspendLayout();
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bModificar.Location = new System.Drawing.Point(294, 543);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(81, 30);
            this.bModificar.TabIndex = 19;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bInsertar
            // 
            this.bInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bInsertar.Location = new System.Drawing.Point(185, 543);
            this.bInsertar.Name = "bInsertar";
            this.bInsertar.Size = new System.Drawing.Size(81, 30);
            this.bInsertar.TabIndex = 18;
            this.bInsertar.Text = "Insertar";
            this.bInsertar.UseVisualStyleBackColor = true;
            this.bInsertar.Click += new System.EventHandler(this.bInsertar_Click);
            // 
            // tSocio
            // 
            this.tSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tSocio.Location = new System.Drawing.Point(281, 342);
            this.tSocio.Name = "tSocio";
            this.tSocio.Size = new System.Drawing.Size(371, 26);
            this.tSocio.TabIndex = 17;
            // 
            // lAsignatura
            // 
            this.lAsignatura.AutoSize = true;
            this.lAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lAsignatura.Location = new System.Drawing.Point(33, 298);
            this.lAsignatura.Name = "lAsignatura";
            this.lAsignatura.Size = new System.Drawing.Size(83, 20);
            this.lAsignatura.TabIndex = 16;
            this.lAsignatura.Text = "Remitente";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.titulo.Location = new System.Drawing.Point(218, 40);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(298, 39);
            this.titulo.TabIndex = 15;
            this.titulo.Text = "Gestionar Envíos";
            // 
            // dgEnvios
            // 
            this.dgEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEnvios.Location = new System.Drawing.Point(37, 126);
            this.dgEnvios.Name = "dgEnvios";
            this.dgEnvios.Size = new System.Drawing.Size(615, 145);
            this.dgEnvios.TabIndex = 20;
            this.dgEnvios.SelectionChanged += new System.EventHandler(this.dgEnvios_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(33, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Socio (Nombre, Apellidos)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(33, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Niño/a (Nombre, Apellidos)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(33, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Código paquete";
            // 
            // tNiño
            // 
            this.tNiño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tNiño.Location = new System.Drawing.Point(281, 386);
            this.tNiño.Name = "tNiño";
            this.tNiño.Size = new System.Drawing.Size(371, 26);
            this.tNiño.TabIndex = 24;
            // 
            // tCodigo
            // 
            this.tCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tCodigo.Location = new System.Drawing.Point(279, 440);
            this.tCodigo.Name = "tCodigo";
            this.tCodigo.Size = new System.Drawing.Size(164, 26);
            this.tCodigo.TabIndex = 25;
            // 
            // bEliminar
            // 
            this.bEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bEliminar.Location = new System.Drawing.Point(403, 543);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(81, 30);
            this.bEliminar.TabIndex = 26;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbRemitente
            // 
            this.cbRemitente.FormattingEnabled = true;
            this.cbRemitente.Location = new System.Drawing.Point(281, 297);
            this.cbRemitente.Name = "cbRemitente";
            this.cbRemitente.Size = new System.Drawing.Size(121, 21);
            this.cbRemitente.TabIndex = 27;
            // 
            // bSalir
            // 
            this.bSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bSalir.Location = new System.Drawing.Point(35, 520);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(81, 53);
            this.bSalir.TabIndex = 28;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bLimpiar.Location = new System.Drawing.Point(571, 543);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(81, 30);
            this.bLimpiar.TabIndex = 29;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // ENVIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(689, 620);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.cbRemitente);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.tCodigo);
            this.Controls.Add(this.tNiño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgEnvios);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bInsertar);
            this.Controls.Add(this.tSocio);
            this.Controls.Add(this.lAsignatura);
            this.Controls.Add(this.titulo);
            this.Name = "ENVIOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENVIOS";
            this.Load += new System.EventHandler(this.ENVIOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEnvios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bInsertar;
        private System.Windows.Forms.TextBox tSocio;
        private System.Windows.Forms.Label lAsignatura;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.DataGridView dgEnvios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tNiño;
        private System.Windows.Forms.TextBox tCodigo;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.ComboBox cbRemitente;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button bLimpiar;
    }
}