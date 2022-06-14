namespace Les_Tels
{
    partial class Solicitacoes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnExcluirSolicitacao = new System.Windows.Forms.Button();
            this.btnEditarSolicitacao = new System.Windows.Forms.Button();
            this.btnNovaSolicitacao = new System.Windows.Forms.Button();
            this.setConnection = new Les_Tels.SetConnection();
            this.solicitacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solicitacoesTableAdapter = new Les_Tels.SetConnectionTableAdapters.solicitacoesTableAdapter();
            this.tableAdapterManager = new Les_Tels.SetConnectionTableAdapters.TableAdapterManager();
            this.solicitacoesDataGridView = new System.Windows.Forms.DataGridView();
            this.itensSolicitacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itensSolicitacaoTableAdapter = new Les_Tels.SetConnectionTableAdapters.itensSolicitacaoTableAdapter();
            this.itensSolicitacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblItemSolicitacao = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.setConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitacoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitacoesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensSolicitacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensSolicitacaoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(607, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(459, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // btnExcluirSolicitacao
            // 
            this.btnExcluirSolicitacao.Location = new System.Drawing.Point(311, 12);
            this.btnExcluirSolicitacao.Name = "btnExcluirSolicitacao";
            this.btnExcluirSolicitacao.Size = new System.Drawing.Size(142, 23);
            this.btnExcluirSolicitacao.TabIndex = 8;
            this.btnExcluirSolicitacao.Text = "Excluir Solicitação";
            this.btnExcluirSolicitacao.UseVisualStyleBackColor = true;
            // 
            // btnEditarSolicitacao
            // 
            this.btnEditarSolicitacao.Location = new System.Drawing.Point(163, 12);
            this.btnEditarSolicitacao.Name = "btnEditarSolicitacao";
            this.btnEditarSolicitacao.Size = new System.Drawing.Size(142, 23);
            this.btnEditarSolicitacao.TabIndex = 7;
            this.btnEditarSolicitacao.Text = "Editar Solicitação";
            this.btnEditarSolicitacao.UseVisualStyleBackColor = true;
            // 
            // btnNovaSolicitacao
            // 
            this.btnNovaSolicitacao.Location = new System.Drawing.Point(15, 12);
            this.btnNovaSolicitacao.Name = "btnNovaSolicitacao";
            this.btnNovaSolicitacao.Size = new System.Drawing.Size(142, 23);
            this.btnNovaSolicitacao.TabIndex = 6;
            this.btnNovaSolicitacao.Text = "Nova Solicitação";
            this.btnNovaSolicitacao.UseVisualStyleBackColor = true;
            // 
            // setConnection
            // 
            this.setConnection.DataSetName = "SetConnection";
            this.setConnection.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // solicitacoesBindingSource
            // 
            this.solicitacoesBindingSource.DataMember = "solicitacoes";
            this.solicitacoesBindingSource.DataSource = this.setConnection;
            // 
            // solicitacoesTableAdapter
            // 
            this.solicitacoesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.fornecedoresTableAdapter = null;
            this.tableAdapterManager.itensSolicitacaoTableAdapter = this.itensSolicitacaoTableAdapter;
            this.tableAdapterManager.producoesTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.solicitacoesTableAdapter = this.solicitacoesTableAdapter;
            this.tableAdapterManager.tiposTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Les_Tels.SetConnectionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendasTableAdapter = null;
            // 
            // solicitacoesDataGridView
            // 
            this.solicitacoesDataGridView.AllowUserToAddRows = false;
            this.solicitacoesDataGridView.AllowUserToDeleteRows = false;
            this.solicitacoesDataGridView.AllowUserToResizeColumns = false;
            this.solicitacoesDataGridView.AllowUserToResizeRows = false;
            this.solicitacoesDataGridView.AutoGenerateColumns = false;
            this.solicitacoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.solicitacoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.solicitacoesDataGridView.DataSource = this.solicitacoesBindingSource;
            this.solicitacoesDataGridView.Location = new System.Drawing.Point(15, 56);
            this.solicitacoesDataGridView.MultiSelect = false;
            this.solicitacoesDataGridView.Name = "solicitacoesDataGridView";
            this.solicitacoesDataGridView.ReadOnly = true;
            this.solicitacoesDataGridView.RowHeadersVisible = false;
            this.solicitacoesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.solicitacoesDataGridView.Size = new System.Drawing.Size(1068, 220);
            this.solicitacoesDataGridView.TabIndex = 11;
            // 
            // itensSolicitacaoBindingSource
            // 
            this.itensSolicitacaoBindingSource.DataMember = "itensSolicitacao";
            this.itensSolicitacaoBindingSource.DataSource = this.setConnection;
            // 
            // itensSolicitacaoTableAdapter
            // 
            this.itensSolicitacaoTableAdapter.ClearBeforeFill = true;
            // 
            // itensSolicitacaoDataGridView
            // 
            this.itensSolicitacaoDataGridView.AllowUserToAddRows = false;
            this.itensSolicitacaoDataGridView.AllowUserToDeleteRows = false;
            this.itensSolicitacaoDataGridView.AllowUserToResizeColumns = false;
            this.itensSolicitacaoDataGridView.AllowUserToResizeRows = false;
            this.itensSolicitacaoDataGridView.AutoGenerateColumns = false;
            this.itensSolicitacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itensSolicitacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.itensSolicitacaoDataGridView.DataSource = this.itensSolicitacaoBindingSource;
            this.itensSolicitacaoDataGridView.Location = new System.Drawing.Point(15, 304);
            this.itensSolicitacaoDataGridView.MultiSelect = false;
            this.itensSolicitacaoDataGridView.Name = "itensSolicitacaoDataGridView";
            this.itensSolicitacaoDataGridView.ReadOnly = true;
            this.itensSolicitacaoDataGridView.RowHeadersVisible = false;
            this.itensSolicitacaoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itensSolicitacaoDataGridView.Size = new System.Drawing.Size(1068, 220);
            this.itensSolicitacaoDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "codSolicitacao";
            this.dataGridViewTextBoxColumn7.HeaderText = "codSolicitacao";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "codProduto";
            this.dataGridViewTextBoxColumn8.HeaderText = "codProduto";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn9.HeaderText = "quantidade";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(836, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(755, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 20;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblItemSolicitacao
            // 
            this.lblItemSolicitacao.AutoSize = true;
            this.lblItemSolicitacao.Location = new System.Drawing.Point(12, 288);
            this.lblItemSolicitacao.Name = "lblItemSolicitacao";
            this.lblItemSolicitacao.Size = new System.Drawing.Size(100, 13);
            this.lblItemSolicitacao.TabIndex = 22;
            this.lblItemSolicitacao.Text = "Itens da Solicitação";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codSolicitacao";
            this.dataGridViewTextBoxColumn1.HeaderText = "codSolicitacao";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codFornecedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "codFornecedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dataPedido";
            this.dataGridViewTextBoxColumn3.HeaderText = "dataPedido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dataEntrega";
            this.dataGridViewTextBoxColumn4.HeaderText = "dataEntrega";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "obs";
            this.dataGridViewTextBoxColumn5.HeaderText = "obs";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Solicitacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblItemSolicitacao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.itensSolicitacaoDataGridView);
            this.Controls.Add(this.solicitacoesDataGridView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnExcluirSolicitacao);
            this.Controls.Add(this.btnEditarSolicitacao);
            this.Controls.Add(this.btnNovaSolicitacao);
            this.Name = "Solicitacoes";
            this.Size = new System.Drawing.Size(1110, 540);
            ((System.ComponentModel.ISupportInitialize)(this.setConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitacoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitacoesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensSolicitacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensSolicitacaoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnExcluirSolicitacao;
        private System.Windows.Forms.Button btnEditarSolicitacao;
        private System.Windows.Forms.Button btnNovaSolicitacao;
        private SetConnection setConnection;
        private System.Windows.Forms.BindingSource solicitacoesBindingSource;
        private SetConnectionTableAdapters.solicitacoesTableAdapter solicitacoesTableAdapter;
        private SetConnectionTableAdapters.TableAdapterManager tableAdapterManager;
        private SetConnectionTableAdapters.itensSolicitacaoTableAdapter itensSolicitacaoTableAdapter;
        private System.Windows.Forms.DataGridView solicitacoesDataGridView;
        private System.Windows.Forms.BindingSource itensSolicitacaoBindingSource;
        private System.Windows.Forms.DataGridView itensSolicitacaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblItemSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
