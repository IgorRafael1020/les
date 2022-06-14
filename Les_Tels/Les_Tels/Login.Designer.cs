namespace Les_Tels
{
    partial class Login
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.setConnection = new Les_Tels.SetConnection();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Les_Tels.SetConnectionTableAdapters.usuariosTableAdapter();
            this.tableAdapterManager = new Les_Tels.SetConnectionTableAdapters.TableAdapterManager();
            this.rbtnLogar = new CustomControls.RoundButtonControls.RoundButton();
            this.rbtnIcone = new CustomControls.RoundButtonControls.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.setConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(101, 136);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(111, 20);
            this.txtLogin.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(101, 179);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(111, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(50, 139);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 999;
            this.lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(50, 182);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 1000;
            this.lblSenha.Text = "Senha";
            // 
            // setConnection
            // 
            this.setConnection.DataSetName = "SetConnection";
            this.setConnection.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.setConnection;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.fornecedoresTableAdapter = null;
            this.tableAdapterManager.itensSolicitacaoTableAdapter = null;
            this.tableAdapterManager.producoesTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.solicitacoesTableAdapter = null;
            this.tableAdapterManager.tiposTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Les_Tels.SetConnectionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = this.usuariosTableAdapter;
            this.tableAdapterManager.vendasTableAdapter = null;
            // 
            // rbtnLogar
            // 
            this.rbtnLogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(98)))), ((int)(((byte)(147)))));
            this.rbtnLogar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(98)))), ((int)(((byte)(147)))));
            this.rbtnLogar.BorderColor = System.Drawing.Color.Black;
            this.rbtnLogar.BorderRadius = 10;
            this.rbtnLogar.BorderSize = 2;
            this.rbtnLogar.FlatAppearance.BorderSize = 0;
            this.rbtnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnLogar.ForeColor = System.Drawing.Color.White;
            this.rbtnLogar.Location = new System.Drawing.Point(62, 264);
            this.rbtnLogar.Name = "rbtnLogar";
            this.rbtnLogar.Size = new System.Drawing.Size(150, 40);
            this.rbtnLogar.TabIndex = 1002;
            this.rbtnLogar.Text = "Logar";
            this.rbtnLogar.TextColor = System.Drawing.Color.White;
            this.rbtnLogar.UseVisualStyleBackColor = false;
            this.rbtnLogar.Click += new System.EventHandler(this.rbtnLogan_Click);
            // 
            // rbtnIcone
            // 
            this.rbtnIcone.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnIcone.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnIcone.BackgroundImage = global::Les_Tels.Properties.Resources.Bigor_Padaria_Icon;
            this.rbtnIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtnIcone.BorderColor = System.Drawing.Color.Black;
            this.rbtnIcone.BorderRadius = 40;
            this.rbtnIcone.BorderSize = 2;
            this.rbtnIcone.FlatAppearance.BorderSize = 0;
            this.rbtnIcone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnIcone.ForeColor = System.Drawing.Color.Black;
            this.rbtnIcone.Location = new System.Drawing.Point(99, 12);
            this.rbtnIcone.Name = "rbtnIcone";
            this.rbtnIcone.Size = new System.Drawing.Size(80, 80);
            this.rbtnIcone.TabIndex = 1001;
            this.rbtnIcone.TextColor = System.Drawing.Color.Black;
            this.rbtnIcone.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.rbtnLogar);
            this.Controls.Add(this.rbtnIcone);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.setConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private SetConnection setConnection;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private SetConnectionTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private SetConnectionTableAdapters.TableAdapterManager tableAdapterManager;
        private CustomControls.RoundButtonControls.RoundButton rbtnIcone;
        private CustomControls.RoundButtonControls.RoundButton rbtnLogar;
    }
}

