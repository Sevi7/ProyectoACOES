namespace ProyectoACOES
{
    partial class GestionarCalificacion
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
            this.lAsignatura = new System.Windows.Forms.Label();
            this.tAsignatura = new System.Windows.Forms.TextBox();
            this.lNota = new System.Windows.Forms.Label();
            this.dFecha = new System.Windows.Forms.DateTimePicker();
            this.lFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCalificaciones = new System.Windows.Forms.DataGridView();
            this.bInsertar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.tNota = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.titulo.Location = new System.Drawing.Point(153, 32);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(378, 39);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Gestionar Calificación";
            // 
            // lAsignatura
            // 
            this.lAsignatura.AutoSize = true;
            this.lAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lAsignatura.Location = new System.Drawing.Point(22, 586);
            this.lAsignatura.Name = "lAsignatura";
            this.lAsignatura.Size = new System.Drawing.Size(86, 20);
            this.lAsignatura.TabIndex = 3;
            this.lAsignatura.Text = "Asignatura";
            // 
            // tAsignatura
            // 
            this.tAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tAsignatura.Location = new System.Drawing.Point(25, 620);
            this.tAsignatura.Name = "tAsignatura";
            this.tAsignatura.Size = new System.Drawing.Size(100, 26);
            this.tAsignatura.TabIndex = 4;
            // 
            // lNota
            // 
            this.lNota.AutoSize = true;
            this.lNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lNota.Location = new System.Drawing.Point(251, 586);
            this.lNota.Name = "lNota";
            this.lNota.Size = new System.Drawing.Size(43, 20);
            this.lNota.TabIndex = 5;
            this.lNota.Text = "Nota";
            // 
            // dFecha
            // 
            this.dFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dFecha.Location = new System.Drawing.Point(462, 616);
            this.dFecha.Name = "dFecha";
            this.dFecha.Size = new System.Drawing.Size(200, 26);
            this.dFecha.TabIndex = 7;
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lFecha.Location = new System.Drawing.Point(458, 586);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(54, 20);
            this.lFecha.TabIndex = 8;
            this.lFecha.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(22, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Alumno";
            // 
            // dataGridViewAlumnos
            // 
            this.dataGridViewAlumnos.AllowUserToAddRows = false;
            this.dataGridViewAlumnos.AllowUserToOrderColumns = true;
            this.dataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(25, 145);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(637, 150);
            this.dataGridViewAlumnos.TabIndex = 10;
            this.dataGridViewAlumnos.SelectionChanged += new System.EventHandler(this.alumnoSeleccionado);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(21, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Calificaciones";
            // 
            // dataGridViewCalificaciones
            // 
            this.dataGridViewCalificaciones.AllowUserToAddRows = false;
            this.dataGridViewCalificaciones.AllowUserToOrderColumns = true;
            this.dataGridViewCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalificaciones.Location = new System.Drawing.Point(25, 373);
            this.dataGridViewCalificaciones.Name = "dataGridViewCalificaciones";
            this.dataGridViewCalificaciones.Size = new System.Drawing.Size(637, 166);
            this.dataGridViewCalificaciones.TabIndex = 12;
            this.dataGridViewCalificaciones.SelectionChanged += new System.EventHandler(this.calificacionSeleccionada);
            // 
            // bInsertar
            // 
            this.bInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bInsertar.Location = new System.Drawing.Point(220, 677);
            this.bInsertar.Name = "bInsertar";
            this.bInsertar.Size = new System.Drawing.Size(81, 30);
            this.bInsertar.TabIndex = 13;
            this.bInsertar.Text = "Insertar";
            this.bInsertar.UseVisualStyleBackColor = true;
            this.bInsertar.Click += new System.EventHandler(this.bInsertar_click);
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bModificar.Location = new System.Drawing.Point(301, 677);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(81, 30);
            this.bModificar.TabIndex = 14;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_click);
            // 
            // bEliminar
            // 
            this.bEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bEliminar.Location = new System.Drawing.Point(382, 677);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(81, 30);
            this.bEliminar.TabIndex = 15;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bLimpiar.Location = new System.Drawing.Point(581, 677);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(81, 30);
            this.bLimpiar.TabIndex = 16;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_click);
            // 
            // tNota
            // 
            this.tNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tNota.Location = new System.Drawing.Point(255, 616);
            this.tNota.Name = "tNota";
            this.tNota.Size = new System.Drawing.Size(100, 26);
            this.tNota.TabIndex = 18;
            this.tNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros);
            // 
            // GestionarCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(688, 735);
            this.Controls.Add(this.tNota);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bInsertar);
            this.Controls.Add(this.dataGridViewCalificaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewAlumnos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lFecha);
            this.Controls.Add(this.dFecha);
            this.Controls.Add(this.lNota);
            this.Controls.Add(this.tAsignatura);
            this.Controls.Add(this.lAsignatura);
            this.Controls.Add(this.titulo);
            this.Name = "GestionarCalificacion";
            this.Text = "AñadirNota";
            this.Load += new System.EventHandler(this.GestionarCalificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label lAsignatura;
        private System.Windows.Forms.TextBox tAsignatura;
        private System.Windows.Forms.Label lNota;
        private System.Windows.Forms.DateTimePicker dFecha;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAlumnos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewCalificaciones;
        private System.Windows.Forms.Button bInsertar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.TextBox tNota;
    }
}