namespace Les_Tels
{
    partial class Relatorios
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
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnSolicitacoes = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnProducoes = new System.Windows.Forms.Button();
            this.lblRelatorios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVendas
            // 
            this.btnVendas.BackgroundImage = global::Les_Tels.Properties.Resources.Vendas_Cinza_Preto;
            this.btnVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVendas.Location = new System.Drawing.Point(199, 135);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(218, 77);
            this.btnVendas.TabIndex = 0;
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnSolicitacoes
            // 
            this.btnSolicitacoes.BackgroundImage = global::Les_Tels.Properties.Resources.Solicitações_Cinza_Preto;
            this.btnSolicitacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSolicitacoes.Location = new System.Drawing.Point(633, 135);
            this.btnSolicitacoes.Name = "btnSolicitacoes";
            this.btnSolicitacoes.Size = new System.Drawing.Size(218, 77);
            this.btnSolicitacoes.TabIndex = 1;
            this.btnSolicitacoes.UseVisualStyleBackColor = true;
            this.btnSolicitacoes.Click += new System.EventHandler(this.btnSolicitacoes_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(633, 301);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(218, 77);
            this.btn.TabIndex = 2;
            this.btn.UseVisualStyleBackColor = true;
            // 
            // btnProducoes
            // 
            this.btnProducoes.BackgroundImage = global::Les_Tels.Properties.Resources.Produtos_Cinza_Preto;
            this.btnProducoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProducoes.Location = new System.Drawing.Point(199, 301);
            this.btnProducoes.Name = "btnProducoes";
            this.btnProducoes.Size = new System.Drawing.Size(218, 77);
            this.btnProducoes.TabIndex = 3;
            this.btnProducoes.UseVisualStyleBackColor = true;
            this.btnProducoes.Click += new System.EventHandler(this.btnProducoes_Click);
            // 
            // lblRelatorios
            // 
            this.lblRelatorios.AutoSize = true;
            this.lblRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatorios.Location = new System.Drawing.Point(389, 35);
            this.lblRelatorios.Name = "lblRelatorios";
            this.lblRelatorios.Size = new System.Drawing.Size(217, 51);
            this.lblRelatorios.TabIndex = 4;
            this.lblRelatorios.Text = "Relatórios";
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRelatorios);
            this.Controls.Add(this.btnProducoes);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnSolicitacoes);
            this.Controls.Add(this.btnVendas);
            this.Name = "Relatorios";
            this.Size = new System.Drawing.Size(1110, 540);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnSolicitacoes;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnProducoes;
        private System.Windows.Forms.Label lblRelatorios;
    }
}
