
namespace Les_Tels
{
    partial class MiniProducoes
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
            System.Windows.Forms.Label codProducaoLabel;
            System.Windows.Forms.Label codProdutoLabel;
            System.Windows.Forms.Label dataProducaoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            this.setConnection = new Les_Tels.SetConnection();
            this.producoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producoesTableAdapter = new Les_Tels.SetConnectionTableAdapters.producoesTableAdapter();
            this.tableAdapterManager = new Les_Tels.SetConnectionTableAdapters.TableAdapterManager();
            this.txtCodProducao = new System.Windows.Forms.TextBox();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.dtpDataProducao = new System.Windows.Forms.DateTimePicker();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            codProducaoLabel = new System.Windows.Forms.Label();
            codProdutoLabel = new System.Windows.Forms.Label();
            dataProducaoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.setConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producoesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codProducaoLabel
            // 
            codProducaoLabel.AutoSize = true;
            codProducaoLabel.Location = new System.Drawing.Point(20, 29);
            codProducaoLabel.Name = "codProducaoLabel";
            codProducaoLabel.Size = new System.Drawing.Size(77, 13);
            codProducaoLabel.TabIndex = 1;
            codProducaoLabel.Text = "cod Producao:";
            // 
            // codProdutoLabel
            // 
            codProdutoLabel.AutoSize = true;
            codProdutoLabel.Location = new System.Drawing.Point(20, 55);
            codProdutoLabel.Name = "codProdutoLabel";
            codProdutoLabel.Size = new System.Drawing.Size(68, 13);
            codProdutoLabel.TabIndex = 3;
            codProdutoLabel.Text = "cod Produto:";
            // 
            // dataProducaoLabel
            // 
            dataProducaoLabel.AutoSize = true;
            dataProducaoLabel.Location = new System.Drawing.Point(20, 82);
            dataProducaoLabel.Name = "dataProducaoLabel";
            dataProducaoLabel.Size = new System.Drawing.Size(80, 13);
            dataProducaoLabel.TabIndex = 5;
            dataProducaoLabel.Text = "data Producao:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(20, 107);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(63, 13);
            quantidadeLabel.TabIndex = 7;
            quantidadeLabel.Text = "quantidade:";
            // 
            // setConnection
            // 
            this.setConnection.DataSetName = "SetConnection";
            this.setConnection.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // producoesBindingSource
            // 
            this.producoesBindingSource.DataMember = "producoes";
            this.producoesBindingSource.DataSource = this.setConnection;
            // 
            // producoesTableAdapter
            // 
            this.producoesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.fornecedoresTableAdapter = null;
            this.tableAdapterManager.itensSolicitacaoTableAdapter = null;
            this.tableAdapterManager.producoesTableAdapter = this.producoesTableAdapter;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.solicitacoesTableAdapter = null;
            this.tableAdapterManager.tiposTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Les_Tels.SetConnectionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendasTableAdapter = null;
            // 
            // txtCodProducao
            // 
            this.txtCodProducao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producoesBindingSource, "codProducao", true));
            this.txtCodProducao.Enabled = false;
            this.txtCodProducao.Location = new System.Drawing.Point(106, 26);
            this.txtCodProducao.Name = "txtCodProducao";
            this.txtCodProducao.Size = new System.Drawing.Size(200, 20);
            this.txtCodProducao.TabIndex = 2;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producoesBindingSource, "codProduto", true));
            this.txtCodProduto.Enabled = false;
            this.txtCodProduto.Location = new System.Drawing.Point(106, 52);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(200, 20);
            this.txtCodProduto.TabIndex = 4;
            // 
            // dtpDataProducao
            // 
            this.dtpDataProducao.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.producoesBindingSource, "dataProducao", true));
            this.dtpDataProducao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataProducao.Location = new System.Drawing.Point(106, 78);
            this.dtpDataProducao.Name = "dtpDataProducao";
            this.dtpDataProducao.Size = new System.Drawing.Size(200, 20);
            this.dtpDataProducao.TabIndex = 6;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producoesBindingSource, "quantidade", true));
            this.txtQuantidade.Location = new System.Drawing.Point(106, 104);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(200, 20);
            this.txtQuantidade.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(230, 144);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(22, 144);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // MiniProducoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 186);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(codProducaoLabel);
            this.Controls.Add(this.txtCodProducao);
            this.Controls.Add(codProdutoLabel);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(dataProducaoLabel);
            this.Controls.Add(this.dtpDataProducao);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(this.txtQuantidade);
            this.Name = "MiniProducoes";
            this.Text = "MiniProducoes";
            ((System.ComponentModel.ISupportInitialize)(this.setConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producoesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SetConnection setConnection;
        private System.Windows.Forms.BindingSource producoesBindingSource;
        private SetConnectionTableAdapters.producoesTableAdapter producoesTableAdapter;
        private SetConnectionTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtCodProducao;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.DateTimePicker dtpDataProducao;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}