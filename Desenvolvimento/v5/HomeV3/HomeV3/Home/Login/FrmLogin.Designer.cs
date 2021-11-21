
namespace Login
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblRealizarLogin = new System.Windows.Forms.Label();
            this.cbxVerSenha = new System.Windows.Forms.CheckBox();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.cbxLembrarSenha = new System.Windows.Forms.CheckBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.btnLogar = new System.Windows.Forms.Button();
            this.pctbxLogo = new System.Windows.Forms.PictureBox();
            this.linkLblNaotenho = new System.Windows.Forms.LinkLabel();
            this.linkLblEsqSenha = new System.Windows.Forms.LinkLabel();
            this.lblMsgErro = new System.Windows.Forms.Label();
            this.pctBoxMsgErro = new System.Windows.Forms.PictureBox();
            this.pictBoxSair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMsgErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxSair)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRealizarLogin
            // 
            this.lblRealizarLogin.AutoSize = true;
            this.lblRealizarLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblRealizarLogin.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealizarLogin.ForeColor = System.Drawing.Color.White;
            this.lblRealizarLogin.Location = new System.Drawing.Point(337, 64);
            this.lblRealizarLogin.Name = "lblRealizarLogin";
            this.lblRealizarLogin.Size = new System.Drawing.Size(151, 30);
            this.lblRealizarLogin.TabIndex = 122;
            this.lblRealizarLogin.Text = "Realizar Login";
            // 
            // cbxVerSenha
            // 
            this.cbxVerSenha.AutoSize = true;
            this.cbxVerSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxVerSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbxVerSenha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbxVerSenha.Location = new System.Drawing.Point(300, 436);
            this.cbxVerSenha.Name = "cbxVerSenha";
            this.cbxVerSenha.Size = new System.Drawing.Size(117, 17);
            this.cbxVerSenha.TabIndex = 120;
            this.cbxVerSenha.Text = "Visualizar Senha";
            this.cbxVerSenha.UseVisualStyleBackColor = true;
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.BackColor = System.Drawing.Color.GhostWhite;
            this.txtBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUser.Location = new System.Drawing.Point(300, 305);
            this.txtBoxUser.Multiline = true;
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(225, 27);
            this.txtBoxUser.TabIndex = 119;
            // 
            // cbxLembrarSenha
            // 
            this.cbxLembrarSenha.AutoSize = true;
            this.cbxLembrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxLembrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbxLembrarSenha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbxLembrarSenha.Location = new System.Drawing.Point(300, 459);
            this.cbxLembrarSenha.Name = "cbxLembrarSenha";
            this.cbxLembrarSenha.Size = new System.Drawing.Size(108, 17);
            this.cbxLembrarSenha.TabIndex = 118;
            this.cbxLembrarSenha.Text = "Lembrar Senha";
            this.cbxLembrarSenha.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.Location = new System.Drawing.Point(173, 514);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(225, 39);
            this.btnLimpar.TabIndex = 117;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(301, 343);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(44, 13);
            this.lblSenha.TabIndex = 116;
            this.lblSenha.Text = "SENHA";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfo2.Location = new System.Drawing.Point(517, 341);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(16, 17);
            this.lblInfo2.TabIndex = 115;
            this.lblInfo2.Text = "?";
           
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSenha.Location = new System.Drawing.Point(300, 359);
            this.txtBoxSenha.Multiline = true;
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.PasswordChar = '*';
            this.txtBoxSenha.Size = new System.Drawing.Size(225, 27);
            this.txtBoxSenha.TabIndex = 114;
           // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(301, 289);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(56, 13);
            this.lblUser.TabIndex = 113;
            this.lblUser.Text = "USUARIO";
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfo1.Location = new System.Drawing.Point(516, 286);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(16, 17);
            this.lblInfo1.TabIndex = 112;
            this.lblInfo1.Text = "?";
           // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.Transparent;
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogar.Location = new System.Drawing.Point(438, 514);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(225, 39);
            this.btnLogar.TabIndex = 111;
            this.btnLogar.Text = "LOGAR";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // pctbxLogo
            // 
            this.pctbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctbxLogo.Image")));
            this.pctbxLogo.Location = new System.Drawing.Point(351, 125);
            this.pctbxLogo.Name = "pctbxLogo";
            this.pctbxLogo.Size = new System.Drawing.Size(122, 145);
            this.pctbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbxLogo.TabIndex = 110;
            this.pctbxLogo.TabStop = false;
            // 
            // linkLblNaotenho
            // 
            this.linkLblNaotenho.AutoSize = true;
            this.linkLblNaotenho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.linkLblNaotenho.Location = new System.Drawing.Point(357, 631);
            this.linkLblNaotenho.Name = "linkLblNaotenho";
            this.linkLblNaotenho.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.linkLblNaotenho.Size = new System.Drawing.Size(119, 13);
            this.linkLblNaotenho.TabIndex = 124;
            this.linkLblNaotenho.TabStop = true;
            this.linkLblNaotenho.Text = "Não tenho cadastro";
            this.linkLblNaotenho.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblNaotenho_LinkClicked);
            // 
            // linkLblEsqSenha
            // 
            this.linkLblEsqSenha.AutoSize = true;
            this.linkLblEsqSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.linkLblEsqSenha.Location = new System.Drawing.Point(369, 605);
            this.linkLblEsqSenha.Name = "linkLblEsqSenha";
            this.linkLblEsqSenha.Size = new System.Drawing.Size(94, 13);
            this.linkLblEsqSenha.TabIndex = 125;
            this.linkLblEsqSenha.TabStop = true;
            this.linkLblEsqSenha.Text = "Esqueci senha ";
            this.linkLblEsqSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblEsqSenha_LinkClicked);
            // 
            // lblMsgErro
            // 
            this.lblMsgErro.AutoSize = true;
            this.lblMsgErro.Location = new System.Drawing.Point(320, 402);
            this.lblMsgErro.Name = "lblMsgErro";
            this.lblMsgErro.Size = new System.Drawing.Size(99, 13);
            this.lblMsgErro.TabIndex = 126;
            this.lblMsgErro.Text = "Mensagem de Erro ";
            this.lblMsgErro.Visible = false;
          // 
            // pctBoxMsgErro
            // 
            this.pctBoxMsgErro.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxMsgErro.Image")));
            this.pctBoxMsgErro.Location = new System.Drawing.Point(291, 399);
            this.pctBoxMsgErro.Name = "pctBoxMsgErro";
            this.pctBoxMsgErro.Size = new System.Drawing.Size(37, 19);
            this.pctBoxMsgErro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxMsgErro.TabIndex = 127;
            this.pctBoxMsgErro.TabStop = false;
            this.pctBoxMsgErro.Visible = false;
            // 
            // pictBoxSair
            // 
            this.pictBoxSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBoxSair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictBoxSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictBoxSair.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxSair.Image")));
            this.pictBoxSair.Location = new System.Drawing.Point(795, 12);
            this.pictBoxSair.Name = "pictBoxSair";
            this.pictBoxSair.Size = new System.Drawing.Size(25, 25);
            this.pictBoxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBoxSair.TabIndex = 128;
            this.pictBoxSair.TabStop = false;
            this.pictBoxSair.Click += new System.EventHandler(this.pictBoxSair_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 713);
            this.Controls.Add(this.pictBoxSair);
            this.Controls.Add(this.lblMsgErro);
            this.Controls.Add(this.pctBoxMsgErro);
            this.Controls.Add(this.linkLblEsqSenha);
            this.Controls.Add(this.linkLblNaotenho);
            this.Controls.Add(this.lblRealizarLogin);
            this.Controls.Add(this.cbxVerSenha);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.cbxLembrarSenha);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.txtBoxSenha);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.pctbxLogo);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
                    
            ((System.ComponentModel.ISupportInitialize)(this.pctbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMsgErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRealizarLogin;
        private System.Windows.Forms.CheckBox cbxVerSenha;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.CheckBox cbxLembrarSenha;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.PictureBox pctbxLogo;
        private System.Windows.Forms.LinkLabel linkLblNaotenho;
        private System.Windows.Forms.LinkLabel linkLblEsqSenha;
        private System.Windows.Forms.Label lblMsgErro;
        private System.Windows.Forms.PictureBox pctBoxMsgErro;
        private System.Windows.Forms.PictureBox pictBoxSair;
    }
}

