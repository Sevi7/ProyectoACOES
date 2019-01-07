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
            this.apadrinamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCOESDataSet = new ProyectoACOES.ACOESDataSet();
            this.apadrinamientoTableAdapter = new ProyectoACOES.ACOESDataSetTableAdapters.ApadrinamientoTableAdapter();
            this.tDinero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tAgente = new System.Windows.Forms.TextBox();
            this.tNiño = new System.Windows.Forms.TextBox();
            this.tSocio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.bApadrinar = new System.Windows.Forms.Button();
            this.bDesapadrinar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apadrinamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCOESDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 104);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // apadrinamientoBindingSource
            // 
            this.apadrinamientoBindingSource.DataMember = "Apadrinamiento";
            this.apadrinamientoBindingSource.DataSource = this.aCOESDataSet;
            // 
            // aCOESDataSet
            // 
            this.aCOESDataSet.DataSetName = "ACOESDataSet";
            this.aCOESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apadrinamientoTableAdapter
            // 
            this.apadrinamientoTableAdapter.ClearBeforeFill = true;
            // 
            // tDinero
            // 
            this.tDinero.Location = new System.Drawing.Point(353, 351);
            this.tDinero.Name = "tDinero";
            this.tDinero.Size = new System.Drawing.Size(98, 20);
            this.tDinero.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Dinero";
            // 
            // tAgente
            // 
            this.tAgente.Location = new System.Drawing.Point(353, 389);
            this.tAgente.Name = "tAgente";
            this.tAgente.Size = new System.Drawing.Size(315, 20);
            this.tAgente.TabIndex = 37;
            // 
            // tNiño
            // 
            this.tNiño.Location = new System.Drawing.Point(353, 316);
            this.tNiño.Name = "tNiño";
            this.tNiño.Size = new System.Drawing.Size(315, 20);
            this.tNiño.TabIndex = 36;
            // 
            // tSocio
            // 
            this.tSocio.Location = new System.Drawing.Point(353, 274);
            this.tSocio.Name = "tSocio";
            this.tSocio.Size = new System.Drawing.Size(315, 20);
            this.tSocio.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Agente (N.I.F.)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Niño/a (Formato: Nombre, Apellidos)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Socio (Formato: Nombre, Apellidos)";
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
            // bApadrinar
            // 
            this.bApadrinar.Location = new System.Drawing.Point(188, 467);
            this.bApadrinar.Name = "bApadrinar";
            this.bApadrinar.Size = new System.Drawing.Size(75, 23);
            this.bApadrinar.TabIndex = 41;
            this.bApadrinar.Text = "Apadrinar";
            this.bApadrinar.UseVisualStyleBackColor = true;
            this.bApadrinar.Click += new System.EventHandler(this.bApadrinar_Click);
            // 
            // bDesapadrinar
            // 
            this.bDesapadrinar.Location = new System.Drawing.Point(353, 467);
            this.bDesapadrinar.Name = "bDesapadrinar";
            this.bDesapadrinar.Size = new System.Drawing.Size(98, 23);
            this.bDesapadrinar.TabIndex = 42;
            this.bDesapadrinar.Text = "Desapadrinar";
            this.bDesapadrinar.UseVisualStyleBackColor = true;
            this.bDesapadrinar.Click += new System.EventHandler(this.bDesapadrinar_Click);
            // 
            // GestionarApadrinamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 664);
            this.Controls.Add(this.bDesapadrinar);
            this.Controls.Add(this.bApadrinar);
            this.Controls.Add(this.tDinero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tAgente);
            this.Controls.Add(this.tNiño);
            this.Controls.Add(this.tSocio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GestionarApadrinamientos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GestionarApadrinamientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apadrinamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCOESDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ACOESDataSet aCOESDataSet;
        private System.Windows.Forms.BindingSource apadrinamientoBindingSource;
        private ACOESDataSetTableAdapters.ApadrinamientoTableAdapter apadrinamientoTableAdapter;
        private System.Windows.Forms.TextBox tDinero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tAgente;
        private System.Windows.Forms.TextBox tNiño;
        private System.Windows.Forms.TextBox tSocio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button bApadrinar;
        private System.Windows.Forms.Button bDesapadrinar;
    }
}