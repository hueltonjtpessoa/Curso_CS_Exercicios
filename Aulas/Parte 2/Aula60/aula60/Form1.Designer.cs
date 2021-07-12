
namespace aula60
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_google = new System.Windows.Forms.Button();
            this.lb_linkPag = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_google
            // 
            this.btn_google.BackColor = System.Drawing.Color.White;
            this.btn_google.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_google.ForeColor = System.Drawing.Color.Red;
            this.btn_google.Location = new System.Drawing.Point(12, 62);
            this.btn_google.Name = "btn_google";
            this.btn_google.Size = new System.Drawing.Size(124, 76);
            this.btn_google.TabIndex = 0;
            this.btn_google.Text = "Google";
            this.btn_google.UseVisualStyleBackColor = false;
            // 
            // lb_linkPag
            // 
            this.lb_linkPag.AutoSize = true;
            this.lb_linkPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_linkPag.Location = new System.Drawing.Point(8, 39);
            this.lb_linkPag.Name = "lb_linkPag";
            this.lb_linkPag.Size = new System.Drawing.Size(128, 20);
            this.lb_linkPag.TabIndex = 1;
            this.lb_linkPag.Text = "www.google.com";
            this.lb_linkPag.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(12, 144);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(124, 20);
            this.tb_nome.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_linkPag);
            this.Controls.Add(this.btn_google);
            this.Name = "Form1";
            this.Text = "Teste de C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_google;
        private System.Windows.Forms.Label lb_linkPag;
        private System.Windows.Forms.TextBox tb_nome;
    }
}

