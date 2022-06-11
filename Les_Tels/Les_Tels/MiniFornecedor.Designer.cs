
namespace Les_Tels
{
    partial class MiniFornecedor
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
            System.Windows.Forms.Label codFornecedorLabel;
            System.Windows.Forms.Label nomeRazaoLabel;
            System.Windows.Forms.Label nomeFantasiaLabel;
            System.Windows.Forms.Label cnpjLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label ufLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label dataCadastroLabel;
            System.Windows.Forms.Label codUsuarioLabel;
            this.setConnection = new Les_Tels.SetConnection();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedoresTableAdapter = new Les_Tels.SetConnectionTableAdapters.fornecedoresTableAdapter();
            this.tableAdapterManager = new Les_Tels.SetConnectionTableAdapters.TableAdapterManager();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.txtNomeRazao = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.dgvDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.txtCodUsuario = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtUf = new System.Windows.Forms.TextBox();
            codFornecedorLabel = new System.Windows.Forms.Label();
            nomeRazaoLabel = new System.Windows.Forms.Label();
            nomeFantasiaLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            ufLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            dataCadastroLabel = new System.Windows.Forms.Label();
            codUsuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.setConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codFornecedorLabel
            // 
            codFornecedorLabel.AutoSize = true;
            codFornecedorLabel.Location = new System.Drawing.Point(69, 19);
            codFornecedorLabel.Name = "codFornecedorLabel";
            codFornecedorLabel.Size = new System.Drawing.Size(85, 13);
            codFornecedorLabel.TabIndex = 1;
            codFornecedorLabel.Text = "cod Fornecedor:";
            // 
            // nomeRazaoLabel
            // 
            nomeRazaoLabel.AutoSize = true;
            nomeRazaoLabel.Location = new System.Drawing.Point(69, 45);
            nomeRazaoLabel.Name = "nomeRazaoLabel";
            nomeRazaoLabel.Size = new System.Drawing.Size(70, 13);
            nomeRazaoLabel.TabIndex = 3;
            nomeRazaoLabel.Text = "nome Razao:";
            // 
            // nomeFantasiaLabel
            // 
            nomeFantasiaLabel.AutoSize = true;
            nomeFantasiaLabel.Location = new System.Drawing.Point(69, 71);
            nomeFantasiaLabel.Name = "nomeFantasiaLabel";
            nomeFantasiaLabel.Size = new System.Drawing.Size(79, 13);
            nomeFantasiaLabel.TabIndex = 5;
            nomeFantasiaLabel.Text = "nome Fantasia:";
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(69, 97);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(30, 13);
            cnpjLabel.TabIndex = 7;
            cnpjLabel.Text = "cnpj:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(69, 123);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(28, 13);
            cepLabel.TabIndex = 9;
            cepLabel.Text = "cep:";
            // 
            // ufLabel
            // 
            ufLabel.AutoSize = true;
            ufLabel.Location = new System.Drawing.Point(69, 149);
            ufLabel.Name = "ufLabel";
            ufLabel.Size = new System.Drawing.Size(19, 13);
            ufLabel.TabIndex = 11;
            ufLabel.Text = "uf:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(69, 175);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(42, 13);
            cidadeLabel.TabIndex = 13;
            cidadeLabel.Text = "cidade:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(69, 201);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(36, 13);
            bairroLabel.TabIndex = 15;
            bairroLabel.Text = "bairro:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(69, 227);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(55, 13);
            enderecoLabel.TabIndex = 17;
            enderecoLabel.Text = "endereco:";
            // 
            // dataCadastroLabel
            // 
            dataCadastroLabel.AutoSize = true;
            dataCadastroLabel.Location = new System.Drawing.Point(69, 254);
            dataCadastroLabel.Name = "dataCadastroLabel";
            dataCadastroLabel.Size = new System.Drawing.Size(76, 13);
            dataCadastroLabel.TabIndex = 19;
            dataCadastroLabel.Text = "data Cadastro:";
            // 
            // codUsuarioLabel
            // 
            codUsuarioLabel.AutoSize = true;
            codUsuarioLabel.Location = new System.Drawing.Point(69, 279);
            codUsuarioLabel.Name = "codUsuarioLabel";
            codUsuarioLabel.Size = new System.Drawing.Size(67, 13);
            codUsuarioLabel.TabIndex = 21;
            codUsuarioLabel.Text = "cod Usuario:";
            // 
            // setConnection
            // 
            this.setConnection.DataSetName = "SetConnection";
            this.setConnection.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "fornecedores";
            this.fornecedoresBindingSource.DataSource = this.setConnection;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.fornecedoresTableAdapter = this.fornecedoresTableAdapter;
            this.tableAdapterManager.itensSolicitacaoTableAdapter = null;
            this.tableAdapterManager.producoesTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.solicitacoesTableAdapter = null;
            this.tableAdapterManager.tiposTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Les_Tels.SetConnectionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendasTableAdapter = null;
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "codFornecedor", true));
            this.txtCodFornecedor.Enabled = false;
            this.txtCodFornecedor.Location = new System.Drawing.Point(160, 16);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Size = new System.Drawing.Size(200, 20);
            this.txtCodFornecedor.TabIndex = 2;
            // 
            // txtNomeRazao
            // 
            this.txtNomeRazao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "nomeRazao", true));
            this.txtNomeRazao.Location = new System.Drawing.Point(160, 42);
            this.txtNomeRazao.Name = "txtNomeRazao";
            this.txtNomeRazao.Size = new System.Drawing.Size(200, 20);
            this.txtNomeRazao.TabIndex = 4;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "nomeFantasia", true));
            this.txtNomeFantasia.Location = new System.Drawing.Point(160, 68);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(200, 20);
            this.txtNomeFantasia.TabIndex = 6;
            // 
            // txtCnpj
            // 
            this.txtCnpj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "cnpj", true));
            this.txtCnpj.Location = new System.Drawing.Point(160, 94);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(200, 20);
            this.txtCnpj.TabIndex = 8;
            // 
            // txtCep
            // 
            this.txtCep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "cep", true));
            this.txtCep.Location = new System.Drawing.Point(160, 120);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(200, 20);
            this.txtCep.TabIndex = 10;
            // 
            // txtCidade
            // 
            this.txtCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "cidade", true));
            this.txtCidade.Location = new System.Drawing.Point(160, 172);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(200, 20);
            this.txtCidade.TabIndex = 14;
            // 
            // txtBairro
            // 
            this.txtBairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "bairro", true));
            this.txtBairro.Location = new System.Drawing.Point(160, 198);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(200, 20);
            this.txtBairro.TabIndex = 16;
            // 
            // txtEndereco
            // 
            this.txtEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "endereco", true));
            this.txtEndereco.Location = new System.Drawing.Point(160, 224);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(200, 20);
            this.txtEndereco.TabIndex = 18;
            // 
            // dgvDataCadastro
            // 
            this.dgvDataCadastro.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fornecedoresBindingSource, "dataCadastro", true));
            this.dgvDataCadastro.Location = new System.Drawing.Point(160, 250);
            this.dgvDataCadastro.Name = "dgvDataCadastro";
            this.dgvDataCadastro.Size = new System.Drawing.Size(200, 20);
            this.dgvDataCadastro.TabIndex = 20;
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "codUsuario", true));
            this.txtCodUsuario.Enabled = false;
            this.txtCodUsuario.Location = new System.Drawing.Point(160, 276);
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.Size = new System.Drawing.Size(200, 20);
            this.txtCodUsuario.TabIndex = 22;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(72, 319);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(285, 319);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtUf
            // 
            this.txtUf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "uf", true));
            this.txtUf.Location = new System.Drawing.Point(160, 146);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(200, 20);
            this.txtUf.TabIndex = 12;
            // 
            // MiniFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 366);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(codFornecedorLabel);
            this.Controls.Add(this.txtCodFornecedor);
            this.Controls.Add(nomeRazaoLabel);
            this.Controls.Add(this.txtNomeRazao);
            this.Controls.Add(nomeFantasiaLabel);
            this.Controls.Add(this.txtNomeFantasia);
            this.Controls.Add(cnpjLabel);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(ufLabel);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(dataCadastroLabel);
            this.Controls.Add(this.dgvDataCadastro);
            this.Controls.Add(codUsuarioLabel);
            this.Controls.Add(this.txtCodUsuario);
            this.Name = "MiniFornecedor";
            this.Text = "MiniFornecedor";
            this.Load += new System.EventHandler(this.MiniFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.setConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SetConnection setConnection;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private SetConnectionTableAdapters.fornecedoresTableAdapter fornecedoresTableAdapter;
        private SetConnectionTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtCodFornecedor;
        private System.Windows.Forms.TextBox txtNomeRazao;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.DateTimePicker dgvDataCadastro;
        private System.Windows.Forms.TextBox txtCodUsuario;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtUf;
    }
}