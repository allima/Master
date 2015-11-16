namespace FormHome
{
    partial class FormAluguel
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
            this.dgv_aluguel = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idimovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idinquilinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcorretorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locacaoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.masterimovelDataSet1 = new FormHome.masterimovelDataSet1();
            this.locacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterimovelDataSet = new FormHome.masterimovelDataSet();
            this.locacaoTableAdapter = new FormHome.masterimovelDataSetTableAdapters.locacaoTableAdapter();
            this.locacaoTableAdapter1 = new FormHome.masterimovelDataSet1TableAdapters.locacaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aluguel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_aluguel
            // 
            this.dgv_aluguel.AutoGenerateColumns = false;
            this.dgv_aluguel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aluguel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idimovelDataGridViewTextBoxColumn,
            this.idinquilinoDataGridViewTextBoxColumn,
            this.idcorretorDataGridViewTextBoxColumn});
            this.dgv_aluguel.DataSource = this.locacaoBindingSource1;
            this.dgv_aluguel.Location = new System.Drawing.Point(24, 26);
            this.dgv_aluguel.Name = "dgv_aluguel";
            this.dgv_aluguel.Size = new System.Drawing.Size(461, 150);
            this.dgv_aluguel.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // idimovelDataGridViewTextBoxColumn
            // 
            this.idimovelDataGridViewTextBoxColumn.DataPropertyName = "id_imovel";
            this.idimovelDataGridViewTextBoxColumn.HeaderText = "id_imovel";
            this.idimovelDataGridViewTextBoxColumn.Name = "idimovelDataGridViewTextBoxColumn";
            // 
            // idinquilinoDataGridViewTextBoxColumn
            // 
            this.idinquilinoDataGridViewTextBoxColumn.DataPropertyName = "id_inquilino";
            this.idinquilinoDataGridViewTextBoxColumn.HeaderText = "id_inquilino";
            this.idinquilinoDataGridViewTextBoxColumn.Name = "idinquilinoDataGridViewTextBoxColumn";
            // 
            // idcorretorDataGridViewTextBoxColumn
            // 
            this.idcorretorDataGridViewTextBoxColumn.DataPropertyName = "id_corretor";
            this.idcorretorDataGridViewTextBoxColumn.HeaderText = "id_corretor";
            this.idcorretorDataGridViewTextBoxColumn.Name = "idcorretorDataGridViewTextBoxColumn";
            // 
            // locacaoBindingSource1
            // 
            this.locacaoBindingSource1.DataMember = "locacao";
            this.locacaoBindingSource1.DataSource = this.masterimovelDataSet1;
            // 
            // masterimovelDataSet1
            // 
            this.masterimovelDataSet1.DataSetName = "masterimovelDataSet1";
            this.masterimovelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locacaoBindingSource
            // 
            this.locacaoBindingSource.DataMember = "locacao";
            this.locacaoBindingSource.DataSource = this.masterimovelDataSet;
            // 
            // masterimovelDataSet
            // 
            this.masterimovelDataSet.DataSetName = "masterimovelDataSet";
            this.masterimovelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locacaoTableAdapter
            // 
            this.locacaoTableAdapter.ClearBeforeFill = true;
            // 
            // locacaoTableAdapter1
            // 
            this.locacaoTableAdapter1.ClearBeforeFill = true;
            // 
            // FormAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 410);
            this.Controls.Add(this.dgv_aluguel);
            this.Name = "FormAluguel";
            this.Text = "FormAluguel";
            this.Load += new System.EventHandler(this.FormAluguel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aluguel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_aluguel;
        private masterimovelDataSet masterimovelDataSet;
        private System.Windows.Forms.BindingSource locacaoBindingSource;
        private masterimovelDataSetTableAdapters.locacaoTableAdapter locacaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idimovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinquilinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcorretorDataGridViewTextBoxColumn;
        private masterimovelDataSet1 masterimovelDataSet1;
        private System.Windows.Forms.BindingSource locacaoBindingSource1;
        private masterimovelDataSet1TableAdapters.locacaoTableAdapter locacaoTableAdapter1;
    }
}