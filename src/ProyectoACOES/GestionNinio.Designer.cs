namespace ProyectoACOES
{
    partial class GestionNinio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.ninioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCOESDataSet = new ProyectoACOES.ACOESDataSet();
            this.ninioTableAdapter = new ProyectoACOES.ACOESDataSetTableAdapters.NinioTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.tObservaciones = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tFechaSalidaP = new System.Windows.Forms.DateTimePicker();
            this.tFechaEntradaP = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tComunidadP = new System.Windows.Forms.TextBox();
            this.tProyecto = new System.Windows.Forms.TextBox();
            this.tBeca = new System.Windows.Forms.TextBox();
            this.tEstado = new System.Windows.Forms.TextBox();
            this.tApellido = new System.Windows.Forms.TextBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tSexo = new System.Windows.Forms.CheckedListBox();
            this.tCurso = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.tComunidadA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.tFechaEntradaACOES = new System.Windows.Forms.DateTimePicker();
            this.tFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.tFechaSalidACOES = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new ProyectoACOES.ACOESDataSetTableAdapters.UsuarioTableAdapter();
            this.tAgente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ninioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCOESDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
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
            this.dataGridView1.DataSource = this.ninioBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(43, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 184);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.FillWeight = 252.1009F;
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 64;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.FillWeight = 218.264F;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 67;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.FillWeight = 189.1662F;
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.Width = 73;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.FillWeight = 164.1437F;
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.Width = 64;
            // 
            // becaDataGridViewTextBoxColumn
            // 
            this.becaDataGridViewTextBoxColumn.DataPropertyName = "beca";
            this.becaDataGridViewTextBoxColumn.FillWeight = 142.6257F;
            this.becaDataGridViewTextBoxColumn.HeaderText = "beca";
            this.becaDataGridViewTextBoxColumn.Name = "becaDataGridViewTextBoxColumn";
            this.becaDataGridViewTextBoxColumn.Width = 56;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.FillWeight = 124.1215F;
            this.sexoDataGridViewTextBoxColumn.HeaderText = "sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.Width = 54;
            // 
            // agenteDataGridViewTextBoxColumn
            // 
            this.agenteDataGridViewTextBoxColumn.DataPropertyName = "agente";
            this.agenteDataGridViewTextBoxColumn.FillWeight = 108.2089F;
            this.agenteDataGridViewTextBoxColumn.HeaderText = "agente";
            this.agenteDataGridViewTextBoxColumn.Name = "agenteDataGridViewTextBoxColumn";
            this.agenteDataGridViewTextBoxColumn.Width = 65;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.FillWeight = 94.52498F;
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "fechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.Width = 112;
            // 
            // fechaEntradaAcoesDataGridViewTextBoxColumn
            // 
            this.fechaEntradaAcoesDataGridViewTextBoxColumn.DataPropertyName = "fechaEntradaAcoes";
            this.fechaEntradaAcoesDataGridViewTextBoxColumn.FillWeight = 82.75754F;
            this.fechaEntradaAcoesDataGridViewTextBoxColumn.HeaderText = "fechaEntradaAcoes";
            this.fechaEntradaAcoesDataGridViewTextBoxColumn.Name = "fechaEntradaAcoesDataGridViewTextBoxColumn";
            this.fechaEntradaAcoesDataGridViewTextBoxColumn.Width = 126;
            // 
            // proyectoDataGridViewTextBoxColumn
            // 
            this.proyectoDataGridViewTextBoxColumn.DataPropertyName = "proyecto";
            this.proyectoDataGridViewTextBoxColumn.FillWeight = 72.63821F;
            this.proyectoDataGridViewTextBoxColumn.HeaderText = "proyecto";
            this.proyectoDataGridViewTextBoxColumn.Name = "proyectoDataGridViewTextBoxColumn";
            this.proyectoDataGridViewTextBoxColumn.Width = 73;
            // 
            // fechaEntradaProyectoDataGridViewTextBoxColumn
            // 
            this.fechaEntradaProyectoDataGridViewTextBoxColumn.DataPropertyName = "fechaEntradaProyecto";
            this.fechaEntradaProyectoDataGridViewTextBoxColumn.FillWeight = 63.93617F;
            this.fechaEntradaProyectoDataGridViewTextBoxColumn.HeaderText = "fechaEntradaProyecto";
            this.fechaEntradaProyectoDataGridViewTextBoxColumn.Name = "fechaEntradaProyectoDataGridViewTextBoxColumn";
            this.fechaEntradaProyectoDataGridViewTextBoxColumn.Width = 138;
            // 
            // fechaSalidaProyectoDataGridViewTextBoxColumn
            // 
            this.fechaSalidaProyectoDataGridViewTextBoxColumn.DataPropertyName = "fechaSalidaProyecto";
            this.fechaSalidaProyectoDataGridViewTextBoxColumn.FillWeight = 56.4529F;
            this.fechaSalidaProyectoDataGridViewTextBoxColumn.HeaderText = "fechaSalidaProyecto";
            this.fechaSalidaProyectoDataGridViewTextBoxColumn.Name = "fechaSalidaProyectoDataGridViewTextBoxColumn";
            this.fechaSalidaProyectoDataGridViewTextBoxColumn.Width = 130;
            // 
            // fechaAltaDataGridViewTextBoxColumn
            // 
            this.fechaAltaDataGridViewTextBoxColumn.DataPropertyName = "fechaAlta";
            this.fechaAltaDataGridViewTextBoxColumn.FillWeight = 50.01769F;
            this.fechaAltaDataGridViewTextBoxColumn.HeaderText = "fechaAlta";
            this.fechaAltaDataGridViewTextBoxColumn.Name = "fechaAltaDataGridViewTextBoxColumn";
            this.fechaAltaDataGridViewTextBoxColumn.Width = 77;
            // 
            // fechaSalidaAcoesDataGridViewTextBoxColumn
            // 
            this.fechaSalidaAcoesDataGridViewTextBoxColumn.DataPropertyName = "fechaSalidaAcoes";
            this.fechaSalidaAcoesDataGridViewTextBoxColumn.FillWeight = 44.48378F;
            this.fechaSalidaAcoesDataGridViewTextBoxColumn.HeaderText = "fechaSalidaAcoes";
            this.fechaSalidaAcoesDataGridViewTextBoxColumn.Name = "fechaSalidaAcoesDataGridViewTextBoxColumn";
            this.fechaSalidaAcoesDataGridViewTextBoxColumn.Width = 118;
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "curso";
            this.cursoDataGridViewTextBoxColumn.FillWeight = 39.72493F;
            this.cursoDataGridViewTextBoxColumn.HeaderText = "curso";
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            this.cursoDataGridViewTextBoxColumn.Width = 58;
            // 
            // comunidadProcDataGridViewTextBoxColumn
            // 
            this.comunidadProcDataGridViewTextBoxColumn.DataPropertyName = "comunidadProc";
            this.comunidadProcDataGridViewTextBoxColumn.FillWeight = 35.63258F;
            this.comunidadProcDataGridViewTextBoxColumn.HeaderText = "comunidadProc";
            this.comunidadProcDataGridViewTextBoxColumn.Name = "comunidadProcDataGridViewTextBoxColumn";
            this.comunidadProcDataGridViewTextBoxColumn.Width = 106;
            // 
            // comunidadActDataGridViewTextBoxColumn
            // 
            this.comunidadActDataGridViewTextBoxColumn.DataPropertyName = "comunidadAct";
            this.comunidadActDataGridViewTextBoxColumn.FillWeight = 32.1134F;
            this.comunidadActDataGridViewTextBoxColumn.HeaderText = "comunidadAct";
            this.comunidadActDataGridViewTextBoxColumn.Name = "comunidadActDataGridViewTextBoxColumn";
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.FillWeight = 29.08709F;
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            this.observacionesDataGridViewTextBoxColumn.Width = 101;
            // 
            // ninioBindingSource
            // 
            this.ninioBindingSource.DataMember = "Ninio";
            this.ninioBindingSource.DataSource = this.aCOESDataSet;
            // 
            // aCOESDataSet
            // 
            this.aCOESDataSet.DataSetName = "ACOESDataSet";
            this.aCOESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ninioTableAdapter
            // 
            this.ninioTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Niños/Jovenes";
            // 
            // tObservaciones
            // 
            this.tObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tObservaciones.Location = new System.Drawing.Point(424, 582);
            this.tObservaciones.Multiline = true;
            this.tObservaciones.Name = "tObservaciones";
            this.tObservaciones.Size = new System.Drawing.Size(388, 95);
            this.tObservaciones.TabIndex = 84;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label20.Location = new System.Drawing.Point(420, 559);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(114, 20);
            this.label20.TabIndex = 83;
            this.label20.Text = "Observaciones";
            // 
            // tFechaSalidaP
            // 
            this.tFechaSalidaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tFechaSalidaP.Location = new System.Drawing.Point(600, 433);
            this.tFechaSalidaP.Name = "tFechaSalidaP";
            this.tFechaSalidaP.Size = new System.Drawing.Size(200, 26);
            this.tFechaSalidaP.TabIndex = 82;
            // 
            // tFechaEntradaP
            // 
            this.tFechaEntradaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tFechaEntradaP.Location = new System.Drawing.Point(600, 382);
            this.tFechaEntradaP.Name = "tFechaEntradaP";
            this.tFechaEntradaP.Size = new System.Drawing.Size(200, 26);
            this.tFechaEntradaP.TabIndex = 81;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label19.Location = new System.Drawing.Point(420, 484);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 20);
            this.label19.TabIndex = 80;
            this.label19.Text = "Fecha de alta";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label18.Location = new System.Drawing.Point(420, 438);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 40);
            this.label18.TabIndex = 79;
            this.label18.Text = "Fecha de salida\r\nen el proyecto\r\n";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label17.Location = new System.Drawing.Point(293, 297);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 20);
            this.label17.TabIndex = 77;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(39, 519);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 40);
            this.label15.TabIndex = 70;
            this.label15.Text = "Comunidad \r\nde procedencia\r\n";
            // 
            // tComunidadP
            // 
            this.tComunidadP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tComunidadP.Location = new System.Drawing.Point(163, 533);
            this.tComunidadP.Name = "tComunidadP";
            this.tComunidadP.Size = new System.Drawing.Size(173, 26);
            this.tComunidadP.TabIndex = 68;
            // 
            // tProyecto
            // 
            this.tProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tProyecto.Location = new System.Drawing.Point(163, 445);
            this.tProyecto.Name = "tProyecto";
            this.tProyecto.Size = new System.Drawing.Size(173, 26);
            this.tProyecto.TabIndex = 66;
            // 
            // tBeca
            // 
            this.tBeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tBeca.Location = new System.Drawing.Point(163, 382);
            this.tBeca.Name = "tBeca";
            this.tBeca.Size = new System.Drawing.Size(173, 26);
            this.tBeca.TabIndex = 64;
            // 
            // tEstado
            // 
            this.tEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tEstado.Location = new System.Drawing.Point(163, 349);
            this.tEstado.Name = "tEstado";
            this.tEstado.Size = new System.Drawing.Size(173, 26);
            this.tEstado.TabIndex = 63;
            // 
            // tApellido
            // 
            this.tApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tApellido.Location = new System.Drawing.Point(163, 316);
            this.tApellido.Name = "tApellido";
            this.tApellido.Size = new System.Drawing.Size(173, 26);
            this.tApellido.TabIndex = 62;
            // 
            // tNombre
            // 
            this.tNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tNombre.Location = new System.Drawing.Point(163, 282);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(173, 26);
            this.tNombre.TabIndex = 60;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(324, 384);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 20);
            this.label13.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(43, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Curso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(42, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "Proyecto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(43, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Sexo (*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(42, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Beca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(42, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(42, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(42, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nombre (*)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(336, -53);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 39);
            this.label22.TabIndex = 47;
            this.label22.Text = "Socios";
            // 
            // tSexo
            // 
            this.tSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tSexo.FormattingEnabled = true;
            this.tSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Otros"});
            this.tSexo.Location = new System.Drawing.Point(163, 414);
            this.tSexo.Name = "tSexo";
            this.tSexo.Size = new System.Drawing.Size(173, 25);
            this.tSexo.TabIndex = 87;
            // 
            // tCurso
            // 
            this.tCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tCurso.Location = new System.Drawing.Point(163, 477);
            this.tCurso.Name = "tCurso";
            this.tCurso.Size = new System.Drawing.Size(173, 26);
            this.tCurso.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(42, 572);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 60);
            this.label9.TabIndex = 88;
            this.label9.Text = "Comunidad \r\nactual\r\n\r\n";
            // 
            // tComunidadA
            // 
            this.tComunidadA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tComunidadA.Location = new System.Drawing.Point(163, 582);
            this.tComunidadA.Name = "tComunidadA";
            this.tComunidadA.Size = new System.Drawing.Size(173, 26);
            this.tComunidadA.TabIndex = 89;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(420, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 40);
            this.label10.TabIndex = 90;
            this.label10.Text = "Fecha de\r\nentrada ACOES";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(420, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 40);
            this.label11.TabIndex = 91;
            this.label11.Text = "Fecha de\r\nnacimiento\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(420, 382);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 40);
            this.label12.TabIndex = 92;
            this.label12.Text = "Fecha de entrada \r\nen proyecto actual";
            // 
            // tFechaNacimiento
            // 
            this.tFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tFechaNacimiento.Location = new System.Drawing.Point(600, 282);
            this.tFechaNacimiento.Name = "tFechaNacimiento";
            this.tFechaNacimiento.Size = new System.Drawing.Size(200, 26);
            this.tFechaNacimiento.TabIndex = 93;
            // 
            // tFechaEntradaACOES
            // 
            this.tFechaEntradaACOES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tFechaEntradaACOES.Location = new System.Drawing.Point(600, 333);
            this.tFechaEntradaACOES.Name = "tFechaEntradaACOES";
            this.tFechaEntradaACOES.Size = new System.Drawing.Size(200, 26);
            this.tFechaEntradaACOES.TabIndex = 94;
            // 
            // tFechaAlta
            // 
            this.tFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tFechaAlta.Location = new System.Drawing.Point(600, 479);
            this.tFechaAlta.Name = "tFechaAlta";
            this.tFechaAlta.Size = new System.Drawing.Size(200, 26);
            this.tFechaAlta.TabIndex = 95;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(420, 505);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 40);
            this.label14.TabIndex = 96;
            this.label14.Text = "Fecha de\r\nsalida ACOES\r\n";
            // 
            // tFechaSalidACOES
            // 
            this.tFechaSalidACOES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tFechaSalidACOES.Location = new System.Drawing.Point(600, 519);
            this.tFechaSalidACOES.Name = "tFechaSalidACOES";
            this.tFechaSalidACOES.Size = new System.Drawing.Size(200, 26);
            this.tFechaSalidACOES.TabIndex = 97;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(392, 710);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 28);
            this.button1.TabIndex = 98;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(297, 710);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 28);
            this.button2.TabIndex = 99;
            this.button2.Text = "Insertar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(487, 710);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 28);
            this.button3.TabIndex = 100;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(664, 710);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 28);
            this.button4.TabIndex = 101;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(43, 632);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 20);
            this.label16.TabIndex = 102;
            this.label16.Text = "Agente";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button5.Location = new System.Drawing.Point(74, 710);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 28);
            this.button5.TabIndex = 104;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.aCOESDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tAgente
            // 
            this.tAgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tAgente.Location = new System.Drawing.Point(163, 626);
            this.tAgente.Name = "tAgente";
            this.tAgente.Size = new System.Drawing.Size(173, 26);
            this.tAgente.TabIndex = 105;
            // 
            // GestionNinio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(851, 766);
            this.Controls.Add(this.tAgente);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tFechaSalidACOES);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tFechaAlta);
            this.Controls.Add(this.tFechaEntradaACOES);
            this.Controls.Add(this.tFechaNacimiento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tComunidadA);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tCurso);
            this.Controls.Add(this.tSexo);
            this.Controls.Add(this.tObservaciones);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tFechaSalidaP);
            this.Controls.Add(this.tFechaEntradaP);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tComunidadP);
            this.Controls.Add(this.tProyecto);
            this.Controls.Add(this.tBeca);
            this.Controls.Add(this.tEstado);
            this.Controls.Add(this.tApellido);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GestionNinio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionNinio";
            this.Load += new System.EventHandler(this.GestionNinio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ninioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCOESDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ACOESDataSet aCOESDataSet;
        private System.Windows.Forms.BindingSource ninioBindingSource;
        private ACOESDataSetTableAdapters.NinioTableAdapter ninioTableAdapter;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tObservaciones;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker tFechaSalidaP;
        private System.Windows.Forms.DateTimePicker tFechaEntradaP;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tComunidadP;
        private System.Windows.Forms.TextBox tProyecto;
        private System.Windows.Forms.TextBox tBeca;
        private System.Windows.Forms.TextBox tEstado;
        private System.Windows.Forms.TextBox tApellido;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckedListBox tSexo;
        private System.Windows.Forms.NumericUpDown tCurso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tComunidadA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker tFechaNacimiento;
        private System.Windows.Forms.DateTimePicker tFechaEntradaACOES;
        private System.Windows.Forms.DateTimePicker tFechaAlta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker tFechaSalidACOES;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private ACOESDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.TextBox tAgente;
    }
}