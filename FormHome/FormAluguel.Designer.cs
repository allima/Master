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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masterimovelDataSet = new FormHome.masterimovelDataSet();
            this.locacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locacaoTableAdapter = new FormHome.masterimovelDataSetTableAdapters.locacaoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idimovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idinquilinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcorretorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idimovelDataGridViewTextBoxColumn,
            this.idinquilinoDataGridViewTextBoxColumn,
            this.idcorretorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.locacaoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(461, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // masterimovelDataSet
            // 
            this.masterimovelDataSet.DataSetName = "masterimovelDataSet";
            this.masterimovelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locacaoBindingSource
            // 
            this.locacaoBindingSource.DataMember = "locacao";
            this.locacaoBindingSource.DataSource = this.masterimovelDataSet;
            // 
            // locacaoTableAdapter
            // 
            this.locacaoTableAdapter.ClearBeforeFill = true;
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
            // FormAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 410);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAluguel";
            this.Text = "FormAluguel";
            this.Load += new System.EventHandler(this.FormAluguel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private masterimovelDataSet masterimovelDataSet;
        private System.Windows.Forms.BindingSource locacaoBindingSource;
        private masterimovelDataSetTableAdapters.locacaoTableAdapter locacaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idimovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinquilinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcorretorDataGridViewTextBoxColumn;
    }
}