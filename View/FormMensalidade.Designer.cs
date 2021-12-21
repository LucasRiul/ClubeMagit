namespace CLube.View
{
    partial class FormMensalidade
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
            this.lblMensalidade = new System.Windows.Forms.Label();
            this.lblNomeSocio = new System.Windows.Forms.Label();
            this.cbxNomeSocio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataVencimento = new System.Windows.Forms.TextBox();
            this.lblDataBaixa = new System.Windows.Forms.Label();
            this.txtDataBaixa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorPagamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.txtValorMensalidade = new System.Windows.Forms.TextBox();
            this.btnGerarBoleto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensalidade
            // 
            this.lblMensalidade.AutoSize = true;
            this.lblMensalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensalidade.Location = new System.Drawing.Point(342, 30);
            this.lblMensalidade.Name = "lblMensalidade";
            this.lblMensalidade.Size = new System.Drawing.Size(188, 32);
            this.lblMensalidade.TabIndex = 0;
            this.lblMensalidade.Text = "Mensalidade";
            // 
            // lblNomeSocio
            // 
            this.lblNomeSocio.AutoSize = true;
            this.lblNomeSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeSocio.Location = new System.Drawing.Point(12, 111);
            this.lblNomeSocio.Name = "lblNomeSocio";
            this.lblNomeSocio.Size = new System.Drawing.Size(178, 32);
            this.lblNomeSocio.TabIndex = 1;
            this.lblNomeSocio.Text = "Nome Sócio";
            // 
            // cbxNomeSocio
            // 
            this.cbxNomeSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNomeSocio.FormattingEnabled = true;
            this.cbxNomeSocio.Location = new System.Drawing.Point(279, 108);
            this.cbxNomeSocio.Name = "cbxNomeSocio";
            this.cbxNomeSocio.Size = new System.Drawing.Size(559, 39);
            this.cbxNomeSocio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Venc.";
            // 
            // txtDataVencimento
            // 
            this.txtDataVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataVencimento.Location = new System.Drawing.Point(279, 200);
            this.txtDataVencimento.Name = "txtDataVencimento";
            this.txtDataVencimento.Size = new System.Drawing.Size(559, 38);
            this.txtDataVencimento.TabIndex = 4;
            // 
            // lblDataBaixa
            // 
            this.lblDataBaixa.AutoSize = true;
            this.lblDataBaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBaixa.Location = new System.Drawing.Point(12, 292);
            this.lblDataBaixa.Name = "lblDataBaixa";
            this.lblDataBaixa.Size = new System.Drawing.Size(163, 32);
            this.lblDataBaixa.TabIndex = 5;
            this.lblDataBaixa.Text = "Data Baixa";
            // 
            // txtDataBaixa
            // 
            this.txtDataBaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataBaixa.Location = new System.Drawing.Point(279, 289);
            this.txtDataBaixa.Name = "txtDataBaixa";
            this.txtDataBaixa.Size = new System.Drawing.Size(559, 38);
            this.txtDataBaixa.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor Mens. (R$)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtValorPagamento
            // 
            this.txtValorPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPagamento.Location = new System.Drawing.Point(333, 542);
            this.txtValorPagamento.Name = "txtValorPagamento";
            this.txtValorPagamento.Size = new System.Drawing.Size(505, 38);
            this.txtValorPagamento.TabIndex = 8;
            this.txtValorPagamento.TextChanged += new System.EventHandler(this.txtValorPagamento_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Juros (%)";
            // 
            // txtJuros
            // 
            this.txtJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJuros.Location = new System.Drawing.Point(279, 459);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(559, 38);
            this.txtJuros.TabIndex = 10;
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPago.Location = new System.Drawing.Point(12, 545);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(315, 32);
            this.lblValorPago.TabIndex = 11;
            this.lblValorPago.Text = "Valor Pagamento (R$)";
            // 
            // txtValorMensalidade
            // 
            this.txtValorMensalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorMensalidade.Location = new System.Drawing.Point(279, 373);
            this.txtValorMensalidade.Name = "txtValorMensalidade";
            this.txtValorMensalidade.Size = new System.Drawing.Size(559, 38);
            this.txtValorMensalidade.TabIndex = 12;
            // 
            // btnGerarBoleto
            // 
            this.btnGerarBoleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarBoleto.Location = new System.Drawing.Point(327, 661);
            this.btnGerarBoleto.Name = "btnGerarBoleto";
            this.btnGerarBoleto.Size = new System.Drawing.Size(212, 54);
            this.btnGerarBoleto.TabIndex = 13;
            this.btnGerarBoleto.Text = "Gerar Boleto";
            this.btnGerarBoleto.UseVisualStyleBackColor = true;
            this.btnGerarBoleto.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMensalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 748);
            this.Controls.Add(this.btnGerarBoleto);
            this.Controls.Add(this.txtValorMensalidade);
            this.Controls.Add(this.lblValorPago);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorPagamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDataBaixa);
            this.Controls.Add(this.lblDataBaixa);
            this.Controls.Add(this.txtDataVencimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxNomeSocio);
            this.Controls.Add(this.lblNomeSocio);
            this.Controls.Add(this.lblMensalidade);
            this.Name = "FormMensalidade";
            this.Text = "FormMensalidade";
            this.Load += new System.EventHandler(this.FormMensalidade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensalidade;
        private System.Windows.Forms.Label lblNomeSocio;
        private System.Windows.Forms.ComboBox cbxNomeSocio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataVencimento;
        private System.Windows.Forms.Label lblDataBaixa;
        private System.Windows.Forms.TextBox txtDataBaixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Label lblValorPago;
        private System.Windows.Forms.TextBox txtValorMensalidade;
        private System.Windows.Forms.Button btnGerarBoleto;
    }
}