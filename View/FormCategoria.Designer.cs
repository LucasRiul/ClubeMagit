namespace CLube.View
{
    partial class FormCategoria
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
            this.lblCadastroCategoria = new System.Windows.Forms.Label();
            this.lblDescricaoCategoria = new System.Windows.Forms.Label();
            this.txtDescricaoCategoria = new System.Windows.Forms.TextBox();
            this.btnSalvarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCadastroCategoria
            // 
            this.lblCadastroCategoria.AutoSize = true;
            this.lblCadastroCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroCategoria.Location = new System.Drawing.Point(245, 31);
            this.lblCadastroCategoria.Name = "lblCadastroCategoria";
            this.lblCadastroCategoria.Size = new System.Drawing.Size(278, 32);
            this.lblCadastroCategoria.TabIndex = 0;
            this.lblCadastroCategoria.Text = "Cadastro Categoria";
            // 
            // lblDescricaoCategoria
            // 
            this.lblDescricaoCategoria.AutoSize = true;
            this.lblDescricaoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoCategoria.Location = new System.Drawing.Point(12, 137);
            this.lblDescricaoCategoria.Name = "lblDescricaoCategoria";
            this.lblDescricaoCategoria.Size = new System.Drawing.Size(149, 32);
            this.lblDescricaoCategoria.TabIndex = 1;
            this.lblDescricaoCategoria.Text = "Descrição";
            // 
            // txtDescricaoCategoria
            // 
            this.txtDescricaoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoCategoria.Location = new System.Drawing.Point(167, 137);
            this.txtDescricaoCategoria.Name = "txtDescricaoCategoria";
            this.txtDescricaoCategoria.Size = new System.Drawing.Size(559, 38);
            this.txtDescricaoCategoria.TabIndex = 2;
            // 
            // btnSalvarCategoria
            // 
            this.btnSalvarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCategoria.Location = new System.Drawing.Point(327, 237);
            this.btnSalvarCategoria.Name = "btnSalvarCategoria";
            this.btnSalvarCategoria.Size = new System.Drawing.Size(111, 39);
            this.btnSalvarCategoria.TabIndex = 12;
            this.btnSalvarCategoria.Text = "Salvar";
            this.btnSalvarCategoria.UseVisualStyleBackColor = true;
            this.btnSalvarCategoria.Click += new System.EventHandler(this.btnSalvarCategoria_Click);
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 323);
            this.Controls.Add(this.btnSalvarCategoria);
            this.Controls.Add(this.txtDescricaoCategoria);
            this.Controls.Add(this.lblDescricaoCategoria);
            this.Controls.Add(this.lblCadastroCategoria);
            this.Name = "FormCategoria";
            this.Text = "FormCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastroCategoria;
        private System.Windows.Forms.Label lblDescricaoCategoria;
        private System.Windows.Forms.TextBox txtDescricaoCategoria;
        private System.Windows.Forms.Button btnSalvarCategoria;
    }
}