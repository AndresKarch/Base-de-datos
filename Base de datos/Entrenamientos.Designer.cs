namespace Base_de_datos
{
    partial class Entrenamientos
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
            this.Dgv_entrenamientos = new System.Windows.Forms.DataGridView();
            this.tP_BaseDatosDataSet1 = new Base_de_datos.TP_BaseDatosDataSet1();
            this.entrenamientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entrenamientosTableAdapter = new Base_de_datos.TP_BaseDatosDataSet1TableAdapters.EntrenamientosTableAdapter();
            this.fechaentrenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaentrenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDeportistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEntrenadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_entrenamientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP_BaseDatosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrenamientosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_entrenamientos
            // 
            this.Dgv_entrenamientos.AutoGenerateColumns = false;
            this.Dgv_entrenamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_entrenamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaentrenDataGridViewTextBoxColumn,
            this.horaentrenDataGridViewTextBoxColumn,
            this.nombreDeportistaDataGridViewTextBoxColumn,
            this.nombreEntrenadorDataGridViewTextBoxColumn});
            this.Dgv_entrenamientos.DataSource = this.entrenamientosBindingSource;
            this.Dgv_entrenamientos.Location = new System.Drawing.Point(12, 88);
            this.Dgv_entrenamientos.Name = "Dgv_entrenamientos";
            this.Dgv_entrenamientos.Size = new System.Drawing.Size(465, 297);
            this.Dgv_entrenamientos.TabIndex = 0;
            this.Dgv_entrenamientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_entrenamientos_CellContentClick);
            // 
            // tP_BaseDatosDataSet1
            // 
            this.tP_BaseDatosDataSet1.DataSetName = "TP_BaseDatosDataSet1";
            this.tP_BaseDatosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entrenamientosBindingSource
            // 
            this.entrenamientosBindingSource.DataMember = "Entrenamientos";
            this.entrenamientosBindingSource.DataSource = this.tP_BaseDatosDataSet1;
            // 
            // entrenamientosTableAdapter
            // 
            this.entrenamientosTableAdapter.ClearBeforeFill = true;
            // 
            // fechaentrenDataGridViewTextBoxColumn
            // 
            this.fechaentrenDataGridViewTextBoxColumn.DataPropertyName = "Fecha_entren";
            this.fechaentrenDataGridViewTextBoxColumn.HeaderText = "Fecha_entren";
            this.fechaentrenDataGridViewTextBoxColumn.Name = "fechaentrenDataGridViewTextBoxColumn";
            // 
            // horaentrenDataGridViewTextBoxColumn
            // 
            this.horaentrenDataGridViewTextBoxColumn.DataPropertyName = "Hora_entren";
            this.horaentrenDataGridViewTextBoxColumn.HeaderText = "Hora_entren";
            this.horaentrenDataGridViewTextBoxColumn.Name = "horaentrenDataGridViewTextBoxColumn";
            // 
            // nombreDeportistaDataGridViewTextBoxColumn
            // 
            this.nombreDeportistaDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Deportista";
            this.nombreDeportistaDataGridViewTextBoxColumn.HeaderText = "Nombre_Deportista";
            this.nombreDeportistaDataGridViewTextBoxColumn.Name = "nombreDeportistaDataGridViewTextBoxColumn";
            // 
            // nombreEntrenadorDataGridViewTextBoxColumn
            // 
            this.nombreEntrenadorDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Entrenador";
            this.nombreEntrenadorDataGridViewTextBoxColumn.HeaderText = "Nombre_Entrenador";
            this.nombreEntrenadorDataGridViewTextBoxColumn.Name = "nombreEntrenadorDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "*Consulta a vista de entrenamientos";
            // 
            // Entrenamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dgv_entrenamientos);
            this.Name = "Entrenamientos";
            this.Text = "Entrenamientos";
            this.Load += new System.EventHandler(this.Entrenamientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_entrenamientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP_BaseDatosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrenamientosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_entrenamientos;
        private TP_BaseDatosDataSet1 tP_BaseDatosDataSet1;
        private System.Windows.Forms.BindingSource entrenamientosBindingSource;
        private TP_BaseDatosDataSet1TableAdapters.EntrenamientosTableAdapter entrenamientosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaentrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaentrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDeportistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEntrenadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}