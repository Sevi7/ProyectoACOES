namespace ProyectoACOES
{
    partial class GestionarApadrinamientos
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aCOESDataSet = new ProyectoACOES.ACOESDataSet();
            this.apadrinamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apadrinamientoTableAdapter = new ProyectoACOES.ACOESDataSetTableAdapters.ApadrinamientoTableAdapter();
            this.socioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ninioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dineroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tLocalidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tCoordinador = new System.Windows.Forms.TextBox();
            this.tTipoProyecto = new System.Windows.Forms.TextBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.bAñadirSocio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCOESDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apadrinamientoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.socioDataGridViewTextBoxColumn,
            this.ninioDataGridViewTextBoxColumn,
            this.agenteDataGridViewTextBoxColumn,
            this.dineroDataGridViewTextBoxColumn,
            this.eliminadoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.apadrinamientoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(69, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 104);
            this.dataGridView1.TabIndex = 0;
            // 
            // aCOESDataSet
            // 
            this.aCOESDataSet.DataSetName = "ACOESDataSet";
            this.aCOESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apadrinamientoBindingSource
            // 
            this.apadrinamientoBindingSource.DataMember = "Apadrinamiento";
            this.apadrinamientoBindingSource.DataSource = this.aCOESDataSet;
            // 
            // apadrinamientoTableAdapter
            // 
            this.apadrinamientoTableAdapter.ClearBeforeFill = true;
            // 
            // socioDataGridViewTextBoxColumn
            // 
            this.socioDataGridViewTextBoxColumn.DataPropertyName = "socio";
            this.socioDataGridViewTextBoxColumn.HeaderText = "socio";
            this.socioDataGridViewTextBoxColumn.Name = "socioDataGridViewTextBoxColumn";
            // 
            // ninioDataGridViewTextBoxColumn
            // 
            this.ninioDataGridViewTextBoxColumn.DataPropertyName = "ninio";
            this.ninioDataGridViewTextBoxColumn.HeaderText = "ninio";
            this.ninioDataGridViewTextBoxColumn.Name = "ninioDataGridViewTextBoxColumn";
            // 
            // agenteDataGridViewTextBoxColumn
            // 
            this.agenteDataGridViewTextBoxColumn.DataPropertyName = "agente";
            this.agenteDataGridViewTextBoxColumn.HeaderText = "agente";
            this.agenteDataGridViewTextBoxColumn.Name = "agenteDataGridViewTextBoxColumn";
            // 
            // dineroDataGridViewTextBoxColumn
            // 
            this.dineroDataGridViewTextBoxColumn.DataPropertyName = "dinero";
            this.dineroDataGridViewTextBoxColumn.HeaderText = "dinero";
            this.dineroDataGridViewTextBoxColumn.Name = "dineroDataGridViewTextBoxColumn";
            // 
            // eliminadoDataGridViewCheckBoxColumn
            // 
            this.eliminadoDataGridViewCheckBoxColumn.DataPropertyName = "eliminado";
            this.eliminadoDataGridViewCheckBoxColumn.HeaderText = "eliminado";
            this.eliminadoDataGridViewCheckBoxColumn.Name = "eliminadoDataGridViewCheckBoxColumn";
            // 
            // tLocalidad
            // 
            this.tLocalidad.Location = new System.Drawing.Point(353, 400);
            this.tLocalidad.Name = "tLocalidad";
            this.tLocalidad.Size = new System.Drawing.Size(119, 20);
            this.tLocalidad.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Dinero";
            // 
            // tCoordinador
            // 
            this.tCoordinador.Location = new System.Drawing.Point(353, 357);
            this.tCoordinador.Name = "tCoordinador";
            this.tCoordinador.Size = new System.Drawing.Size(315, 20);
            this.tCoordinador.TabIndex = 37;
            // 
            // tTipoProyecto
            // 
            this.tTipoProyecto.Location = new System.Drawing.Point(353, 315);
            this.tTipoProyecto.Name = "tTipoProyecto";
            this.tTipoProyecto.Size = new System.Drawing.Size(315, 20);
            this.tTipoProyecto.TabIndex = 36;
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(353, 274);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(315, 20);
            this.tNombre.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Agente (Nombre y Apellidos)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Niño/a (Nombre y Apellidos)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Socio (Nombre y Apellidos)";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(83, 198);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(463, 39);
            this.titulo.TabIndex = 30;
            this.titulo.Text = "Gestionar Apadrinamientos";
            // 
            // bAñadirSocio
            // 
            this.bAñadirSocio.Location = new System.Drawing.Point(181, 548);
            this.bAñadirSocio.Name = "bAñadirSocio";
            this.bAñadirSocio.Size = new System.Drawing.Size(75, 23);
            this.bAñadirSocio.TabIndex = 41;
            this.bAñadirSocio.Text = "Apadrinar";
            this.bAñadirSocio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Desapadrinar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GestionarApadrinamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 664);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bAñadirSocio);
            this.Controls.Add(this.tLocalidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tCoordinador);
            this.Controls.Add(this.tTipoProyecto);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GestionarApadrinamientos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GestionarApadrinamientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCOESDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apadrinamientoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ACOESDataSet aCOESDataSet;
        private System.Windows.Forms.BindingSource apadrinamientoBindingSource;
        private ACOESDataSetTableAdapters.ApadrinamientoTableAdapter apadrinamientoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn socioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ninioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dineroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eliminadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox tLocalidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tCoordinador;
        private System.Windows.Forms.TextBox tTipoProyecto;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button bAñadirSocio;
        private System.Windows.Forms.Button button1;
    }
}