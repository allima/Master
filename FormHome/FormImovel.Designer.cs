namespace FormHome
{
    partial class FormImovel
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imovelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterimovelDataSet = new FormHome.masterimovelDataSet();
            this.imovelTableAdapter = new FormHome.masterimovelDataSetTableAdapters.imovelTableAdapter();
            this.masterimovelDataSet1 = new FormHome.masterimovelDataSet1();
            this.imovelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.imovelTableAdapter1 = new FormHome.masterimovelDataSet1TableAdapters.imovelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imovelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imovelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.decricaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.imovelBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(42, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // decricaoDataGridViewTextBoxColumn
            // 
            this.decricaoDataGridViewTextBoxColumn.DataPropertyName = "decricao";
            this.decricaoDataGridViewTextBoxColumn.HeaderText = "decricao";
            this.decricaoDataGridViewTextBoxColumn.Name = "decricaoDataGridViewTextBoxColumn";
            // 
            // imovelBindingSource
            // 
            this.imovelBindingSource.DataMember = "imovel";
            this.imovelBindingSource.DataSource = this.masterimovelDataSet;
            // 
            // masterimovelDataSet
            // 
            this.masterimovelDataSet.DataSetName = "masterimovelDataSet";
            this.masterimovelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imovelTableAdapter
            // 
            this.imovelTableAdapter.ClearBeforeFill = true;
            // 
            // masterimovelDataSet1
            // 
            this.masterimovelDataSet1.DataSetName = "masterimovelDataSet1";
            this.masterimovelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imovelBindingSource1
            // 
            this.imovelBindingSource1.DataMember = "imovel";
            this.imovelBindingSource1.DataSource = this.masterimovelDataSet1;
            // 
            // imovelTableAdapter1
            // 
            this.imovelTableAdapter1.ClearBeforeFill = true;
            // 
            // FormImovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormImovel";
            this.Text = "FormImovel";
            this.Load += new System.EventHandler(this.FormImovel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imovelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imovelBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private masterimovelDataSet masterimovelDataSet;
        private System.Windows.Forms.BindingSource imovelBindingSource;
        private masterimovelDataSetTableAdapters.imovelTableAdapter imovelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decricaoDataGridViewTextBoxColumn;
        private masterimovelDataSet1 masterimovelDataSet1;
        private System.Windows.Forms.BindingSource imovelBindingSource1;
        private masterimovelDataSet1TableAdapters.imovelTableAdapter imovelTableAdapter1;
    }
}