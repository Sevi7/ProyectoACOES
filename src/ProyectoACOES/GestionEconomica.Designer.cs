namespace ProyectoACOES
{
    partial class GestionEconomica
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.consultar = new System.Windows.Forms.Button();
            this.ben = new System.Windows.Forms.ComboBox();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.cat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Categoria = new System.Windows.Forms.Label();
            this.des = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.añadir = new System.Windows.Forms.Button();
            this.cant = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCOESDataSet = new ProyectoACOES.ACOESDataSet();
            this.cuentaTableAdapter = new ProyectoACOES.ACOESDataSetTableAdapters.CuentaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCOESDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(600, 242);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(600, 302);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(123, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox2_MouseClick);
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(318, 466);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(75, 23);
            this.consultar.TabIndex = 5;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // ben
            // 
            this.ben.FormattingEnabled = true;
            this.ben.Location = new System.Drawing.Point(146, 242);
            this.ben.Name = "ben";
            this.ben.Size = new System.Drawing.Size(121, 21);
            this.ben.TabIndex = 6;
            // 
            // tipo
            // 
            this.tipo.FormattingEnabled = true;
            this.tipo.Location = new System.Drawing.Point(146, 199);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(121, 21);
            this.tipo.TabIndex = 7;
            // 
            // cat
            // 
            this.cat.FormattingEnabled = true;
            this.cat.Location = new System.Drawing.Point(146, 282);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(121, 21);
            this.cat.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Beneficiario:";
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Location = new System.Drawing.Point(55, 282);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(55, 13);
            this.Categoria.TabIndex = 11;
            this.Categoria.Text = "Categoria:";
            // 
            // des
            // 
            this.des.Location = new System.Drawing.Point(146, 423);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(285, 20);
            this.des.TabIndex = 12;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(146, 381);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 13;
            // 
            // añadir
            // 
            this.añadir.Location = new System.Drawing.Point(237, 466);
            this.añadir.Name = "añadir";
            this.añadir.Size = new System.Drawing.Size(75, 23);
            this.añadir.TabIndex = 14;
            this.añadir.Text = "Añadir";
            this.añadir.UseVisualStyleBackColor = true;
            this.añadir.Click += new System.EventHandler(this.añadir_Click);
            // 
            // cant
            // 
            this.cant.Location = new System.Drawing.Point(146, 329);
            this.cant.Name = "cant";
            this.cant.Size = new System.Drawing.Size(55, 20);
            this.cant.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cuentaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // cuentaBindingSource
            // 
            this.cuentaBindingSource.DataMember = "Cuenta";
            this.cuentaBindingSource.DataSource = this.aCOESDataSet;
            // 
            // aCOESDataSet
            // 
            this.aCOESDataSet.DataSetName = "ACOESDataSet";
            this.aCOESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cuentaTableAdapter
            // 
            this.cuentaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(671, 466);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GestionEconomica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cant);
            this.Controls.Add(this.añadir);
            this.Controls.Add(this.date);
            this.Controls.Add(this.des);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.ben);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "GestionEconomica";
            this.Text = "Gestion Economica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCOESDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.ComboBox ben;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.ComboBox cat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.TextBox des;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button añadir;
        private System.Windows.Forms.TextBox cant;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ACOESDataSet aCOESDataSet;
        private System.Windows.Forms.BindingSource cuentaBindingSource;
        private ACOESDataSetTableAdapters.CuentaTableAdapter cuentaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
    }
}