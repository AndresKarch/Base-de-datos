namespace Base_de_datos
{
    partial class Torneos
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
            this.Dgv_torneo = new System.Windows.Forms.DataGridView();
            this.tP_BaseDatosDataSet2 = new Base_de_datos.TP_BaseDatosDataSet2();
            this.torneoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.torneoTableAdapter = new Base_de_datos.TP_BaseDatosDataSet2TableAdapters.TorneoTableAdapter();
            this.tP_BaseDatosDataSet3 = new Base_de_datos.TP_BaseDatosDataSet3();
            this.participacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.participacionTableAdapter = new Base_de_datos.TP_BaseDatosDataSet3TableAdapters.ParticipacionTableAdapter();
            this.codtorneoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coddeportistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codestiloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiemposegundosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codclubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tP_BaseDatosDataSet4 = new Base_de_datos.TP_BaseDatosDataSet4();
            this.deportistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deportistaTableAdapter = new Base_de_datos.TP_BaseDatosDataSet4TableAdapters.DeportistaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tP_BaseDatosDataSet5 = new Base_de_datos.TP_BaseDatosDataSet5();
            this.tPBaseDatosDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tP_BaseDatosDataSet6 = new Base_de_datos.TP_BaseDatosDataSet6();
            this.tPBaseDatosDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tP_BaseDatosDataSet7 = new Base_de_datos.TP_BaseDatosDataSet7();
            this.deportistaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deportistaTableAdapter1 = new Base_de_datos.TP_BaseDatosDataSet7TableAdapters.DeportistaTableAdapter();
            this.coddeportistaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_torneo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP_BaseDatosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torneoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP_BaseDatosDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP_BaseDatosDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deportistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP_BaseDatosDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPBaseDatosDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP_BaseDatosDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPBaseDatosDataSet6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP_BaseDatosDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deportistaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_torneo
            // 
            this.Dgv_torneo.AutoGenerateColumns = false;
            this.Dgv_torneo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_torneo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codtorneoDataGridViewTextBoxColumn,
            this.coddeportistaDataGridViewTextBoxColumn,
            this.codestiloDataGridViewTextBoxColumn,
            this.puestoDataGridViewTextBoxColumn,
            this.tiemposegundosDataGridViewTextBoxColumn,
            this.codclubDataGridViewTextBoxColumn});
            this.Dgv_torneo.DataSource = this.participacionBindingSource;
            this.Dgv_torneo.Location = new System.Drawing.Point(12, 92);
            this.Dgv_torneo.Name = "Dgv_torneo";
            this.Dgv_torneo.Size = new System.Drawing.Size(776, 182);
            this.Dgv_torneo.TabIndex = 7;
            this.Dgv_torneo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_torneo_CellContentClick);
            // 
            // tP_BaseDatosDataSet2
            // 
            this.tP_BaseDatosDataSet2.DataSetName = "TP_BaseDatosDataSet2";
            this.tP_BaseDatosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // torneoBindingSource
            // 
            this.torneoBindingSource.DataMember = "Torneo";
            this.torneoBindingSource.DataSource = this.tP_BaseDatosDataSet2;
            // 
            // torneoTableAdapter
            // 
            this.torneoTableAdapter.ClearBeforeFill = true;
            // 
            // tP_BaseDatosDataSet3
            // 
            this.tP_BaseDatosDataSet3.DataSetName = "TP_BaseDatosDataSet3";
            this.tP_BaseDatosDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // participacionBindingSource
            // 
            this.participacionBindingSource.DataMember = "Participacion";
            this.participacionBindingSource.DataSource = this.tP_BaseDatosDataSet3;
            // 
            // participacionTableAdapter
            // 
            this.participacionTableAdapter.ClearBeforeFill = true;
            // 
            // codtorneoDataGridViewTextBoxColumn
            // 
            this.codtorneoDataGridViewTextBoxColumn.DataPropertyName = "Cod_torneo";
            this.codtorneoDataGridViewTextBoxColumn.HeaderText = "Cod_torneo";
            this.codtorneoDataGridViewTextBoxColumn.Name = "codtorneoDataGridViewTextBoxColumn";
            // 
            // coddeportistaDataGridViewTextBoxColumn
            // 
            this.coddeportistaDataGridViewTextBoxColumn.DataPropertyName = "Cod_deportista";
            this.coddeportistaDataGridViewTextBoxColumn.HeaderText = "Cod_deportista";
            this.coddeportistaDataGridViewTextBoxColumn.Name = "coddeportistaDataGridViewTextBoxColumn";
            // 
            // codestiloDataGridViewTextBoxColumn
            // 
            this.codestiloDataGridViewTextBoxColumn.DataPropertyName = "Cod_estilo";
            this.codestiloDataGridViewTextBoxColumn.HeaderText = "Cod_estilo";
            this.codestiloDataGridViewTextBoxColumn.Name = "codestiloDataGridViewTextBoxColumn";
            // 
            // puestoDataGridViewTextBoxColumn
            // 
            this.puestoDataGridViewTextBoxColumn.DataPropertyName = "Puesto";
            this.puestoDataGridViewTextBoxColumn.HeaderText = "Puesto";
            this.puestoDataGridViewTextBoxColumn.Name = "puestoDataGridViewTextBoxColumn";
            // 
            // tiemposegundosDataGridViewTextBoxColumn
            // 
            this.tiemposegundosDataGridViewTextBoxColumn.DataPropertyName = "Tiempo_segundos";
            this.tiemposegundosDataGridViewTextBoxColumn.HeaderText = "Tiempo_segundos";
            this.tiemposegundosDataGridViewTextBoxColumn.Name = "tiemposegundosDataGridViewTextBoxColumn";
            // 
            // codclubDataGridViewTextBoxColumn
            // 
            this.codclubDataGridViewTextBoxColumn.DataPropertyName = "Cod_club";
            this.codclubDataGridViewTextBoxColumn.HeaderText = "Cod_club";
            this.codclubDataGridViewTextBoxColumn.Name = "codclubDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mejor/es deportista/s del torneo";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.torneoBindingSource;
            this.comboBox1.DisplayMember = "Cod_torneo";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 342);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "Cod_torneo";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tP_BaseDatosDataSet4
            // 
            this.tP_BaseDatosDataSet4.DataSetName = "TP_BaseDatosDataSet4";
            this.tP_BaseDatosDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deportistaBindingSource
            // 
            this.deportistaBindingSource.DataMember = "Deportista";
            this.deportistaBindingSource.DataSource = this.tP_BaseDatosDataSet4;
            // 
            // deportistaTableAdapter
            // 
            this.deportistaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coddeportistaDataGridViewTextBoxColumn1,
            this.nombreApellidoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deportistaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(319, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tP_BaseDatosDataSet5
            // 
            this.tP_BaseDatosDataSet5.DataSetName = "TP_BaseDatosDataSet5";
            this.tP_BaseDatosDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tPBaseDatosDataSet5BindingSource
            // 
            this.tPBaseDatosDataSet5BindingSource.DataSource = this.tP_BaseDatosDataSet5;
            this.tPBaseDatosDataSet5BindingSource.Position = 0;
            // 
            // tP_BaseDatosDataSet6
            // 
            this.tP_BaseDatosDataSet6.DataSetName = "TP_BaseDatosDataSet6";
            this.tP_BaseDatosDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tPBaseDatosDataSet6BindingSource
            // 
            this.tPBaseDatosDataSet6BindingSource.DataSource = this.tP_BaseDatosDataSet6;
            this.tPBaseDatosDataSet6BindingSource.Position = 0;
            // 
            // tP_BaseDatosDataSet7
            // 
            this.tP_BaseDatosDataSet7.DataSetName = "TP_BaseDatosDataSet7";
            this.tP_BaseDatosDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deportistaBindingSource1
            // 
            this.deportistaBindingSource1.DataMember = "Deportista";
            this.deportistaBindingSource1.DataSource = this.tP_BaseDatosDataSet7;
            // 
            // deportistaTableAdapter1
            // 
            this.deportistaTableAdapter1.ClearBeforeFill = true;
            // 
            // coddeportistaDataGridViewTextBoxColumn1
            // 
            this.coddeportistaDataGridViewTextBoxColumn1.DataPropertyName = "Cod_deportista";
            this.coddeportistaDataGridViewTextBoxColumn1.HeaderText = "Cod_deportista";
            this.coddeportistaDataGridViewTextBoxColumn1.Name = "coddeportistaDataGridViewTextBoxColumn1";
            // 
            // nombreApellidoDataGridViewTextBoxColumn
            // 
            this.nombreApellidoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Apellido";
            this.nombreApellidoDataGridViewTextBoxColumn.HeaderText = "Nombre_Apellido";
            this.nombreApellidoDataGridViewTextBoxColumn.Name = "nombreApellidoDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "*Procedimiento almacenado para obtener el o los deportistas que mas veces sacaron" +
    " puesto 1";
            // 
            // Torneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_torneo);
            this.Name = "Torneos";
            this.Text = "Torneos";
            this.Load += new System.EventHandler(this.Torneos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_torneo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP_BaseDatosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torneoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP_BaseDatosDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP_BaseDatosDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deportistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP_BaseDatosDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPBaseDatosDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP_BaseDatosDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPBaseDatosDataSet6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP_BaseDatosDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deportistaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgv_torneo;
        private TP_BaseDatosDataSet2 tP_BaseDatosDataSet2;
        private System.Windows.Forms.BindingSource torneoBindingSource;
        private TP_BaseDatosDataSet2TableAdapters.TorneoTableAdapter torneoTableAdapter;
        private TP_BaseDatosDataSet3 tP_BaseDatosDataSet3;
        private System.Windows.Forms.BindingSource participacionBindingSource;
        private TP_BaseDatosDataSet3TableAdapters.ParticipacionTableAdapter participacionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codtorneoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddeportistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codestiloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiemposegundosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codclubDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private TP_BaseDatosDataSet4 tP_BaseDatosDataSet4;
        private System.Windows.Forms.BindingSource deportistaBindingSource;
        private TP_BaseDatosDataSet4TableAdapters.DeportistaTableAdapter deportistaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tPBaseDatosDataSet5BindingSource;
        private TP_BaseDatosDataSet5 tP_BaseDatosDataSet5;
        private System.Windows.Forms.BindingSource tPBaseDatosDataSet6BindingSource;
        private TP_BaseDatosDataSet6 tP_BaseDatosDataSet6;
        private TP_BaseDatosDataSet7 tP_BaseDatosDataSet7;
        private System.Windows.Forms.BindingSource deportistaBindingSource1;
        private TP_BaseDatosDataSet7TableAdapters.DeportistaTableAdapter deportistaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddeportistaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}