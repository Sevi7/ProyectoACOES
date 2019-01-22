namespace ProyectoACOES
{
    partial class GestionBeneficiario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tNIF = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.Label();
            this.tApellidos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beneficiarioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.aCOESDataSet = new ProyectoACOES.ACOESDataSet();
            this.tDireccion = new System.Windows.Forms.Label();
            this.tNumeroCuenta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tObservaciones = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.beneficiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beneficiarioTableAdapter = new ProyectoACOES.ACOESDataSetTableAdapters.BeneficiarioTableAdapter();
            this.beneficiarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCOESDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beneficiarios";
            // 
            // tNIF
            // 
            this.tNIF.AutoSize = true;
            this.tNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tNIF.Location = new System.Drawing.Point(50, 282);
            this.tNIF.Name = "tNIF";
            this.tNIF.Size = new System.Drawing.Size(35, 20);
            this.tNIF.TabIndex = 2;
            this.tNIF.Text = "NIF";
            // 
            // tNombre
            // 
            this.tNombre.AutoSize = true;
            this.tNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tNombre.Location = new System.Drawing.Point(50, 328);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(65, 20);
            this.tNombre.TabIndex = 3;
            this.tNombre.Text = "Nombre";
            // 
            // tApellidos
            // 
            this.tApellidos.AutoSize = true;
            this.tApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tApellidos.Location = new System.Drawing.Point(50, 373);
            this.tApellidos.Name = "tApellidos";
            this.tApellidos.Size = new System.Drawing.Size(73, 20);
            this.tApellidos.TabIndex = 4;
            this.tApellidos.Text = "Apellidos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIFDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn,
            this.responsableDataGridViewTextBoxColumn,
            this.numCuentaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.beneficiarioBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(54, 99);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(704, 152);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // nIFDataGridViewTextBoxColumn
            // 
            this.nIFDataGridViewTextBoxColumn.DataPropertyName = "NIF";
            this.nIFDataGridViewTextBoxColumn.HeaderText = "NIF";
            this.nIFDataGridViewTextBoxColumn.Name = "nIFDataGridViewTextBoxColumn";
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
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            // 
            // responsableDataGridViewTextBoxColumn
            // 
            this.responsableDataGridViewTextBoxColumn.DataPropertyName = "responsable";
            this.responsableDataGridViewTextBoxColumn.HeaderText = "responsable";
            this.responsableDataGridViewTextBoxColumn.Name = "responsableDataGridViewTextBoxColumn";
            // 
            // numCuentaDataGridViewTextBoxColumn
            // 
            this.numCuentaDataGridViewTextBoxColumn.DataPropertyName = "numCuenta";
            this.numCuentaDataGridViewTextBoxColumn.HeaderText = "numCuenta";
            this.numCuentaDataGridViewTextBoxColumn.Name = "numCuentaDataGridViewTextBoxColumn";
            // 
            // beneficiarioBindingSource2
            // 
            this.beneficiarioBindingSource2.DataMember = "Beneficiario";
            this.beneficiarioBindingSource2.DataSource = this.aCOESDataSet;
            // 
            // aCOESDataSet
            // 
            this.aCOESDataSet.DataSetName = "ACOESDataSet";
            this.aCOESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tDireccion
            // 
            this.tDireccion.AutoSize = true;
            this.tDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tDireccion.Location = new System.Drawing.Point(50, 416);
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.Size = new System.Drawing.Size(75, 20);
            this.tDireccion.TabIndex = 6;
            this.tDireccion.Text = "Direccion";
            // 
            // tNumeroCuenta
            // 
            this.tNumeroCuenta.AutoSize = true;
            this.tNumeroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tNumeroCuenta.Location = new System.Drawing.Point(50, 458);
            this.tNumeroCuenta.Name = "tNumeroCuenta";
            this.tNumeroCuenta.Size = new System.Drawing.Size(140, 20);
            this.tNumeroCuenta.TabIndex = 7;
            this.tNumeroCuenta.Text = "Numero de cuenta";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(226, 279);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 26);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(226, 321);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 26);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox3.Location = new System.Drawing.Point(226, 365);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 26);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox4.Location = new System.Drawing.Point(226, 408);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(167, 26);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox5.Location = new System.Drawing.Point(226, 451);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(167, 26);
            this.textBox5.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(440, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Observaciones";
            // 
            // tObservaciones
            // 
            this.tObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tObservaciones.Location = new System.Drawing.Point(443, 308);
            this.tObservaciones.Multiline = true;
            this.tObservaciones.Name = "tObservaciones";
            this.tObservaciones.Size = new System.Drawing.Size(315, 129);
            this.tObservaciones.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(226, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(330, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(432, 515);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 29);
            this.button3.TabIndex = 17;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(610, 515);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 29);
            this.button4.TabIndex = 18;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // beneficiarioBindingSource1
            // 
            this.beneficiarioBindingSource1.DataMember = "Beneficiario";
            this.beneficiarioBindingSource1.DataSource = this.aCOESDataSet;
            // 
            // GestionBeneficiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 592);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tObservaciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tNumeroCuenta);
            this.Controls.Add(this.tDireccion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tApellidos);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.tNIF);
            this.Controls.Add(this.label1);
            this.Name = "GestionBeneficiario";
            this.Text = "Gestion Beneficiario";
            this.Load += new System.EventHandler(this.GestionBeneficiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCOESDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ACOESDataSet aCOESDataSet;
        private System.Windows.Forms.BindingSource beneficiarioBindingSource;
        private ACOESDataSetTableAdapters.BeneficiarioTableAdapter beneficiarioTableAdapter;
        private System.Windows.Forms.Label tNIF;
        private System.Windows.Forms.Label tNombre;
        private System.Windows.Forms.Label tApellidos;
        private System.Windows.Forms.BindingSource beneficiarioBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource beneficiarioBindingSource2;
        private System.Windows.Forms.Label tDireccion;
        private System.Windows.Forms.Label tNumeroCuenta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tObservaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}