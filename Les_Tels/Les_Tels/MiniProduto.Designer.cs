
namespace Les_Tels
{
    partial class MiniProduto
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
            System.Windows.Forms.Label lblcodProduto;
            System.Windows.Forms.Label lbldescricao;
            System.Windows.Forms.Label precoLabel;
            System.Windows.Forms.Label unidadeLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label estoqueMinimoLabel;
            System.Windows.Forms.Label dataValidadeLabel;
            System.Windows.Forms.Label codTipoLabel;
            this.setConnection = new Les_Tels.SetConnection();
            this.producoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producoesTableAdapter = new Les_Tels.SetConnectionTableAdapters.producoesTableAdapter();
            this.tableAdapterManager = new Les_Tels.SetConnectionTableAdapters.TableAdapterManager();
            this.produtosTableAdapter = new Les_Tels.SetConnectionTableAdapters.produtosTableAdapter();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtcodProduto = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtunidade = new System.Windows.Forms.TextBox();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.txtestoqueMinimo = new System.Windows.Forms.TextBox();
            this.dtpdataValidade = new System.Windows.Forms.DateTimePicker();
            this.txtcodTipo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            lblcodProduto = new System.Windows.Forms.Label();
            lbldescricao = new System.Windows.Forms.Label();
            precoLabel = new System.Windows.Forms.Label();
            unidadeLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            estoqueMinimoLabel = new System.Windows.Forms.Label();
            dataValidadeLabel = new System.Windows.Forms.Label();
            codTipoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.setConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcodProduto
            // 
            lblcodProduto.AutoSize = true;
            lblcodProduto.Location = new System.Drawing.Point(29, 18);
            lblcodProduto.Name = "lblcodProduto";
            lblcodProduto.Size = new System.Drawing.Size(69, 13);
            lblcodProduto.TabIndex = 19;
            lblcodProduto.Text = "Cod Produto:";
            // 
            // lbldescricao
            // 
            lbldescricao.AutoSize = true;
            lbldescricao.Location = new System.Drawing.Point(29, 44);
            lbldescricao.Name = "lbldescricao";
            lbldescricao.Size = new System.Drawing.Size(58, 13);
            lbldescricao.TabIndex = 21;
            lbldescricao.Text = "Descricao:";
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Location = new System.Drawing.Point(29, 70);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new System.Drawing.Size(38, 13);
            precoLabel.TabIndex = 23;
            precoLabel.Text = "Preco:";
            // 
            // unidadeLabel
            // 
            unidadeLabel.AutoSize = true;
            unidadeLabel.Location = new System.Drawing.Point(29, 96);
            unidadeLabel.Name = "unidadeLabel";
            unidadeLabel.Size = new System.Drawing.Size(50, 13);
            unidadeLabel.TabIndex = 25;
            unidadeLabel.Text = "Unidade:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(29, 122);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 27;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // estoqueMinimoLabel
            // 
            estoqueMinimoLabel.AutoSize = true;
            estoqueMinimoLabel.Location = new System.Drawing.Point(29, 148);
            estoqueMinimoLabel.Name = "estoqueMinimoLabel";
            estoqueMinimoLabel.Size = new System.Drawing.Size(87, 13);
            estoqueMinimoLabel.TabIndex = 29;
            estoqueMinimoLabel.Text = "Estoque Mínimo:";
            // 
            // dataValidadeLabel
            // 
            dataValidadeLabel.AutoSize = true;
            dataValidadeLabel.Location = new System.Drawing.Point(29, 175);
            dataValidadeLabel.Name = "dataValidadeLabel";
            dataValidadeLabel.Size = new System.Drawing.Size(77, 13);
            dataValidadeLabel.TabIndex = 31;
            dataValidadeLabel.Text = "Data Validade:";
            // 
            // codTipoLabel
            // 
            codTipoLabel.AutoSize = true;
            codTipoLabel.Location = new System.Drawing.Point(29, 200);
            codTipoLabel.Name = "codTipoLabel";
            codTipoLabel.Size = new System.Drawing.Size(53, 13);
            codTipoLabel.TabIndex = 33;
            codTipoLabel.Text = "Cod Tipo:";
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
            this.tableAdapterManager.produtosTableAdapter = this.produtosTableAdapter;
            this.tableAdapterManager.solicitacoesTableAdapter = null;
            this.tableAdapterManager.tiposTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Les_Tels.SetConnectionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendasTableAdapter = null;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.setConnection;
            // 
            // txtcodProduto
            // 
            this.txtcodProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "codProduto", true));
            this.txtcodProduto.Enabled = false;
            this.txtcodProduto.Location = new System.Drawing.Point(119, 15);
            this.txtcodProduto.Name = "txtcodProduto";
            this.txtcodProduto.Size = new System.Drawing.Size(200, 20);
            this.txtcodProduto.TabIndex = 20;
            // 
            // txtdescricao
            // 
            this.txtdescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "descricao", true));
            this.txtdescricao.Location = new System.Drawing.Point(119, 41);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(200, 20);
            this.txtdescricao.TabIndex = 22;
            // 
            // txtpreco
            // 
            this.txtpreco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "preco", true));
            this.txtpreco.Location = new System.Drawing.Point(119, 67);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(200, 20);
            this.txtpreco.TabIndex = 24;
            // 
            // txtunidade
            // 
            this.txtunidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "unidade", true));
            this.txtunidade.Location = new System.Drawing.Point(119, 93);
            this.txtunidade.Name = "txtunidade";
            this.txtunidade.Size = new System.Drawing.Size(200, 20);
            this.txtunidade.TabIndex = 26;
            // 
            // txtquantidade
            // 
            this.txtquantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "quantidade", true));
            this.txtquantidade.Location = new System.Drawing.Point(119, 119);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(200, 20);
            this.txtquantidade.TabIndex = 28;
            // 
            // txtestoqueMinimo
            // 
            this.txtestoqueMinimo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "estoqueMinimo", true));
            this.txtestoqueMinimo.Location = new System.Drawing.Point(119, 145);
            this.txtestoqueMinimo.Name = "txtestoqueMinimo";
            this.txtestoqueMinimo.Size = new System.Drawing.Size(200, 20);
            this.txtestoqueMinimo.TabIndex = 30;
            // 
            // dtpdataValidade
            // 
            this.dtpdataValidade.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.produtosBindingSource, "dataValidade", true));
            this.dtpdataValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdataValidade.Location = new System.Drawing.Point(119, 171);
            this.dtpdataValidade.Name = "dtpdataValidade";
            this.dtpdataValidade.Size = new System.Drawing.Size(200, 20);
            this.dtpdataValidade.TabIndex = 32;
            // 
            // txtcodTipo
            // 
            this.txtcodTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "codTipo", true));
            this.txtcodTipo.Location = new System.Drawing.Point(119, 197);
            this.txtcodTipo.Name = "txtcodTipo";
            this.txtcodTipo.Size = new System.Drawing.Size(200, 20);
            this.txtcodTipo.TabIndex = 34;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(32, 236);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(244, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // MiniProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 275);
            this.Controls.Add(lblcodProduto);
            this.Controls.Add(this.txtcodProduto);
            this.Controls.Add(lbldescricao);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(precoLabel);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(unidadeLabel);
            this.Controls.Add(this.txtunidade);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(estoqueMinimoLabel);
            this.Controls.Add(this.txtestoqueMinimo);
            this.Controls.Add(dataValidadeLabel);
            this.Controls.Add(this.dtpdataValidade);
            this.Controls.Add(codTipoLabel);
            this.Controls.Add(this.txtcodTipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "MiniProduto";
            this.Text = "Mini Produto";
            this.Load += new System.EventHandler(this.Novo_Produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.setConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SetConnection setConnection;
        private System.Windows.Forms.BindingSource producoesBindingSource;
        private SetConnectionTableAdapters.producoesTableAdapter producoesTableAdapter;
        private SetConnectionTableAdapters.TableAdapterManager tableAdapterManager;
        private SetConnectionTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private System.Windows.Forms.TextBox txtcodProduto;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtunidade;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.TextBox txtestoqueMinimo;
        private System.Windows.Forms.DateTimePicker dtpdataValidade;
        private System.Windows.Forms.TextBox txtcodTipo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}