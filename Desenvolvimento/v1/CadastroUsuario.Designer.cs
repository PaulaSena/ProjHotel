
namespace CadastroUsuario
{
    partial class FormCadUsu
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
            this.lblCadUsu = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.lblSen = new System.Windows.Forms.Label();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblInfo4 = new System.Windows.Forms.Label();
            this.txtBoxTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.chkBoxEmail = new System.Windows.Forms.CheckBox();
            this.btnCadUsu = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCadUsu
            // 
            this.lblCadUsu.AutoSize = true;
            this.lblCadUsu.Location = new System.Drawing.Point(51, 36);
            this.lblCadUsu.Name = "lblCadUsu";
            this.lblCadUsu.Size = new System.Drawing.Size(88, 13);
            this.lblCadUsu.TabIndex = 1;
            this.lblCadUsu.Text = "Cadastro Usuário";
            this.lblCadUsu.Click += new System.EventHandler(this.lblCadUsu_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(68, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(71, 101);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(194, 20);
            this.txtBoxEmail.TabIndex = 3;
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Location = new System.Drawing.Point(240, 85);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(13, 13);
            this.lblInfo1.TabIndex = 4;
            this.lblInfo1.Text = "?";
            this.lblInfo1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Location = new System.Drawing.Point(240, 141);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(13, 13);
            this.lblInfo2.TabIndex = 7;
            this.lblInfo2.Text = "?";
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(71, 157);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(194, 20);
            this.txtBoxPass.TabIndex = 6;
            // 
            // lblSen
            // 
            this.lblSen.AutoSize = true;
            this.lblSen.Location = new System.Drawing.Point(68, 141);
            this.lblSen.Name = "lblSen";
            this.lblSen.Size = new System.Drawing.Size(41, 13);
            this.lblSen.TabIndex = 5;
            this.lblSen.Text = "Senha:";
            this.lblSen.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblInfo3
            // 
            this.lblInfo3.AutoSize = true;
            this.lblInfo3.Location = new System.Drawing.Point(240, 195);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(13, 13);
            this.lblInfo3.TabIndex = 10;
            this.lblInfo3.Text = "?";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(71, 211);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(194, 20);
            this.txtBoxNome.TabIndex = 9;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(68, 195);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(85, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome Completo:";
            // 
            // lblInfo4
            // 
            this.lblInfo4.AutoSize = true;
            this.lblInfo4.Location = new System.Drawing.Point(240, 248);
            this.lblInfo4.Name = "lblInfo4";
            this.lblInfo4.Size = new System.Drawing.Size(13, 13);
            this.lblInfo4.TabIndex = 13;
            this.lblInfo4.Text = "?";
            // 
            // txtBoxTel
            // 
            this.txtBoxTel.Location = new System.Drawing.Point(71, 264);
            this.txtBoxTel.Name = "txtBoxTel";
            this.txtBoxTel.Size = new System.Drawing.Size(194, 20);
            this.txtBoxTel.TabIndex = 12;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(68, 248);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 11;
            this.lblTel.Text = "Telefone:";
            // 
            // chkBoxEmail
            // 
            this.chkBoxEmail.AutoSize = true;
            this.chkBoxEmail.Location = new System.Drawing.Point(72, 309);
            this.chkBoxEmail.Name = "chkBoxEmail";
            this.chkBoxEmail.Size = new System.Drawing.Size(186, 17);
            this.chkBoxEmail.TabIndex = 14;
            this.chkBoxEmail.Text = "Aceito receber emails informativos";
            this.chkBoxEmail.UseVisualStyleBackColor = true;
            // 
            // btnCadUsu
            // 
            this.btnCadUsu.Location = new System.Drawing.Point(72, 376);
            this.btnCadUsu.Name = "btnCadUsu";
            this.btnCadUsu.Size = new System.Drawing.Size(75, 23);
            this.btnCadUsu.TabIndex = 15;
            this.btnCadUsu.Text = "Cadastrar";
            this.btnCadUsu.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(190, 376);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // FormCadUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCadUsu);
            this.Controls.Add(this.chkBoxEmail);
            this.Controls.Add(this.lblInfo4);
            this.Controls.Add(this.txtBoxTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblInfo3);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.lblSen);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCadUsu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadUsu";
            this.Text = "CadastroUsuario";
            this.Load += new System.EventHandler(this.FormCadUsu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadUsu;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Label lblSen;
        private System.Windows.Forms.Label lblInfo3;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblInfo4;
        private System.Windows.Forms.TextBox txtBoxTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.CheckBox chkBoxEmail;
        private System.Windows.Forms.Button btnCadUsu;
        private System.Windows.Forms.Button btnLogin;
    }
}

