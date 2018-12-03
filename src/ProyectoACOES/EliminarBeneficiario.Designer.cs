﻿namespace ProyectoACOES
{
    partial class EliminarBeneficiario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.aCOESDataSet = new ProyectoACOES.ACOESDataSet();
            this.beneficiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beneficiarioTableAdapter = new ProyectoACOES.ACOESDataSetTableAdapters.BeneficiarioTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.becaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntradaAcoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntradaProyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSalidaProyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSalidaAcoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comunidadProcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comunidadActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCOESDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(136, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar Beneficiario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.becaDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.agenteDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.fechaEntradaAcoesDataGridViewTextBoxColumn,
            this.proyectoDataGridViewTextBoxColumn,
            this.fechaEntradaProyectoDataGridViewTextBoxColumn,
            this.fechaSalidaProyectoDataGridViewTextBoxColumn,
            this.fechaAltaDataGridViewTextBoxColumn,
            this.fechaSalidaAcoesDataGridViewTextBoxColumn,
            this.cursoDataGridViewTextBoxColumn,
            this.comunidadProcDataGridViewTextBoxColumn,
            this.comunidadActDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.beneficiarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aCOESDataSet
            // 
            this.aCOESDataSet.DataSetName = "ACOESDataSet";
            this.aCOESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // beneficiarioBindingSource
            // 
            this.beneficiarioBindingSource.DataMember = "Beneficiario";
            this.beneficiarioBindingSource.DataSource = this.aCOESDataSet;
            // 
            // beneficiarioTableAdapter
            // 
            this.beneficiarioTableAdapter.ClearBeforeFill = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // becaDataGridViewTextBoxColumn
            // 
            this.becaDataGridViewTextBoxColumn.DataPropertyName = "beca";
            this.becaDataGridViewTextBoxColumn.HeaderText = "beca";
            this.becaDataGridViewTextBoxColumn.Name = "becaDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            // 
            // agenteDataGridViewTextBoxColumn
            // 
            this.agenteDataGridViewTextBoxColumn.DataPropertyName = "agente";
            this.agenteDataGridViewTextBoxColumn.HeaderText = "agente";
            this.agenteDataGridViewTextBoxColumn.Name = "agenteDataGridViewTextBoxColumn";
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "fechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            // 
            // fechaEntradaAcoesDataGridViewTextBoxColumn
            // 
            this.fechaEntradaAcoesDataGridViewTextBoxColumn.DataPropertyName = "fechaEntradaAcoes";
            this.fechaEntradaAcoesDataGridViewTextBoxColumn.HeaderText = "fechaEntradaAcoes";
            this.fechaEntradaAcoesDataGridViewTextBoxColumn.Name = "fechaEntradaAcoesDataGridViewTextBoxColumn";
            // 
            // proyectoDataGridViewTextBoxColumn
            // 
            this.proyectoDataGridViewTextBoxColumn.DataPropertyName = "proyecto";
            this.proyectoDataGridViewTextBoxColumn.HeaderText = "proyecto";
            this.proyectoDataGridViewTextBoxColumn.Name = "proyectoDataGridViewTextBoxColumn";
            // 
            // fechaEntradaProyectoDataGridViewTextBoxColumn
            // 
            this.fechaEntradaProyectoDataGridViewTextBoxColumn.DataPropertyName = "fechaEntradaProyecto";
            this.fechaEntradaProyectoDataGridViewTextBoxColumn.HeaderText = "fechaEntradaProyecto";
            this.fechaEntradaProyectoDataGridViewTextBoxColumn.Name = "fechaEntradaProyectoDataGridViewTextBoxColumn";
            // 
            // fechaSalidaProyectoDataGridViewTextBoxColumn
            // 
            this.fechaSalidaProyectoDataGridViewTextBoxColumn.DataPropertyName = "fechaSalidaProyecto";
            this.fechaSalidaProyectoDataGridViewTextBoxColumn.HeaderText = "fechaSalidaProyecto";
            this.fechaSalidaProyectoDataGridViewTextBoxColumn.Name = "fechaSalidaProyectoDataGridViewTextBoxColumn";
            // 
            // fechaAltaDataGridViewTextBoxColumn
            // 
            this.fechaAltaDataGridViewTextBoxColumn.DataPropertyName = "fechaAlta";
            this.fechaAltaDataGridViewTextBoxColumn.HeaderText = "fechaAlta";
            this.fechaAltaDataGridViewTextBoxColumn.Name = "fechaAltaDataGridViewTextBoxColumn";
            // 
            // fechaSalidaAcoesDataGridViewTextBoxColumn
            // 
            this.fechaSalidaAcoesDataGridViewTextBoxColumn.DataPropertyName = "fechaSalidaAcoes";
            this.fechaSalidaAcoesDataGridViewTextBoxColumn.HeaderText = "fechaSalidaAcoes";
            this.fechaSalidaAcoesDataGridViewTextBoxColumn.Name = "fechaSalidaAcoesDataGridViewTextBoxColumn";
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "curso";
            this.cursoDataGridViewTextBoxColumn.HeaderText = "curso";
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            // 
            // comunidadProcDataGridViewTextBoxColumn
            // 
            this.comunidadProcDataGridViewTextBoxColumn.DataPropertyName = "comunidadProc";
            this.comunidadProcDataGridViewTextBoxColumn.HeaderText = "comunidadProc";
            this.comunidadProcDataGridViewTextBoxColumn.Name = "comunidadProcDataGridViewTextBoxColumn";
            // 
            // comunidadActDataGridViewTextBoxColumn
            // 
            this.comunidadActDataGridViewTextBoxColumn.DataPropertyName = "comunidadAct";
            this.comunidadActDataGridViewTextBoxColumn.HeaderText = "comunidadAct";
            this.comunidadActDataGridViewTextBoxColumn.Name = "comunidadActDataGridViewTextBoxColumn";
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            // 
            // EliminarBeneficiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EliminarBeneficiario";
            this.Text = "Eliminar Beneficiario";
            this.Load += new System.EventHandler(this.EliminarBeneficiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCOESDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private ACOESDataSet aCOESDataSet;
        private System.Windows.Forms.BindingSource beneficiarioBindingSource;
        private ACOESDataSetTableAdapters.BeneficiarioTableAdapter beneficiarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn becaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntradaAcoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntradaProyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalidaProyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalidaAcoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comunidadProcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comunidadActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
    }
}