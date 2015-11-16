namespace FormHome
{
    partial class FormCorretor
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
            this.dgv_Corretor = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corretorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.masterimovelDataSet1 = new FormHome.masterimovelDataSet1();
            this.corretorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterimovelDataSet = new FormHome.masterimovelDataSet();
            this.corretorTableAdapter = new FormHome.masterimovelDataSetTableAdapters.corretorTableAdapter();
            this.btn_novo_corretor = new System.Windows.Forms.Button();
            this.corretorTableAdapter1 = new FormHome.masterimovelDataSet1TableAdapters.corretorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Corretor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corretorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corretorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Corretor
            // 
            this.dgv_Corretor.AutoGenerateColumns = false;
            this.dgv_Corretor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Corretor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dgv_Corretor.DataSource = this.corretorBindingSource1;
            this.dgv_Corretor.Location = new System.Drawing.Point(31, 39);
            this.dgv_Corretor.Name = "dgv_Corretor";
            this.dgv_Corretor.Size = new System.Drawing.Size(751, 186);
            this.dgv_Corretor.TabIndex = 0;
            this.dgv_Corretor.DoubleClick += new System.EventHandler(this.dgv_Corretor_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "rg";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // corretorBindingSource1
            // 
            this.corretorBindingSource1.DataMember = "corretor";
            this.corretorBindingSource1.DataSource = this.masterimovelDataSet1;
            // 
            // masterimovelDataSet1
            // 
            this.masterimovelDataSet1.DataSetName = "masterimovelDataSet1";
            this.masterimovelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // corretorBindingSource
            // 
            this.corretorBindingSource.DataMember = "corretor";
            this.corretorBindingSource.DataSource = this.masterimovelDataSet;
            // 
            // masterimovelDataSet
            // 
            this.masterimovelDataSet.DataSetName = "masterimovelDataSet";
            this.masterimovelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // corretorTableAdapter
            // 
            this.corretorTableAdapter.ClearBeforeFill = true;
            // 
            // btn_novo_corretor
            // 
            this.btn_novo_corretor.Location = new System.Drawing.Point(72, 268);
            this.btn_novo_corretor.Name = "btn_novo_corretor";
            this.btn_novo_corretor.Size = new System.Drawing.Size(91, 23);
            this.btn_novo_corretor.TabIndex = 1;
            this.btn_novo_corretor.Text = "Novo Corretor";
            this.btn_novo_corretor.UseVisualStyleBackColor = true;
            this.btn_novo_corretor.Click += new System.EventHandler(this.btn_novo_corretor_Click);
            // 
            // corretorTableAdapter1
            // 
            this.corretorTableAdapter1.ClearBeforeFill = true;
            // 
            // FormCorretor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 344);
            this.Controls.Add(this.btn_novo_corretor);
            this.Controls.Add(this.dgv_Corretor);
            this.Name = "FormCorretor";
            this.Text = "Corretores";
            this.Activated += new System.EventHandler(this.FormCorretor_Activated);
            this.Load += new System.EventHandler(this.FormCorretor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Corretor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corretorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corretorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Corretor;
        private masterimovelDataSet masterimovelDataSet;
        private System.Windows.Forms.BindingSource corretorBindingSource;
        private masterimovelDataSetTableAdapters.corretorTableAdapter corretorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_novo_corretor;
        private masterimovelDataSet1 masterimovelDataSet1;
        private System.Windows.Forms.BindingSource corretorBindingSource1;
        private masterimovelDataSet1TableAdapters.corretorTableAdapter corretorTableAdapter1;
    }
}