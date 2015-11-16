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
            this.dgv_imovel = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imovelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.masterimovelDataSet1 = new FormHome.masterimovelDataSet1();
            this.imovelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterimovelDataSet = new FormHome.masterimovelDataSet();
            this.imovelTableAdapter = new FormHome.masterimovelDataSetTableAdapters.imovelTableAdapter();
            this.imovelTableAdapter1 = new FormHome.masterimovelDataSet1TableAdapters.imovelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_imovel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imovelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imovelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_imovel
            // 
            this.dgv_imovel.AutoGenerateColumns = false;
            this.dgv_imovel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_imovel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.decricaoDataGridViewTextBoxColumn});
            this.dgv_imovel.DataSource = this.imovelBindingSource1;
            this.dgv_imovel.Location = new System.Drawing.Point(42, 49);
            this.dgv_imovel.Name = "dgv_imovel";
            this.dgv_imovel.Size = new System.Drawing.Size(428, 150);
            this.dgv_imovel.TabIndex = 0;
            this.dgv_imovel.DoubleClick += new System.EventHandler(this.dgv_imovel_DoubleClick);
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
            // imovelBindingSource1
            // 
            this.imovelBindingSource1.DataMember = "imovel";
            this.imovelBindingSource1.DataSource = this.masterimovelDataSet1;
            // 
            // masterimovelDataSet1
            // 
            this.masterimovelDataSet1.DataSetName = "masterimovelDataSet1";
            this.masterimovelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // imovelTableAdapter1
            // 
            this.imovelTableAdapter1.ClearBeforeFill = true;
            // 
            // FormImovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 262);
            this.Controls.Add(this.dgv_imovel);
            this.Name = "FormImovel";
            this.Text = "FormImovel";
            this.Load += new System.EventHandler(this.FormImovel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_imovel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imovelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imovelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_imovel;
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