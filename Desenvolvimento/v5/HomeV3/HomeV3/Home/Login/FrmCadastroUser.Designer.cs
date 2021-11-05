
namespace Login
{
    partial class FrmCadastroUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUser));
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.lblInf3 = new System.Windows.Forms.Label();
            this.txtBoxConfSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cbxVerSenha = new System.Windows.Forms.CheckBox();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.cbxLembrarSenha = new System.Windows.Forms.CheckBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.pctbxLogo = new System.Windows.Forms.PictureBox();
            this.lblRealizarCadastro = new System.Windows.Forms.Label();
            this.linkLblJaTenho = new System.Windows.Forms.LinkLabel();
            this.lblMsgErro = new System.Windows.Forms.Label();
            this.pctBoxMsgErro = new System.Windows.Forms.PictureBox();
            this.pictBoxSair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMsgErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxSair)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblConfSenha.ForeColor = System.Drawing.Color.White;
            this.lblConfSenha.Location = new System.Drawing.Point(239, 387);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(111, 13);
            this.lblConfSenha.TabIndex = 94;
            this.lblConfSenha.Text = "CONFIRMAR SENHA";
            // 
            // lblInf3
            // 
            this.lblInf3.AutoSize = true;
            this.lblInf3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInf3.ForeColor = System.Drawing.Color.Maroon;
            this.lblInf3.Location = new System.Drawing.Point(458, 386);
            this.lblInf3.Name = "lblInf3";
            this.lblInf3.Size = new System.Drawing.Size(16, 17);
            this.lblInf3.TabIndex = 93;
            this.lblInf3.Text = "?";
            // 
            // txtBoxConfSenha
            // 
            this.txtBoxConfSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfSenha.Location = new System.Drawing.Point(244, 405);
            this.txtBoxConfSenha.Multiline = true;
            this.txtBoxConfSenha.Name = "txtBoxConfSenha";
            this.txtBoxConfSenha.PasswordChar = '*';
            this.txtBoxConfSenha.Size = new System.Drawing.Size(225, 27);
            this.txtBoxConfSenha.TabIndex = 92;
            this.txtBoxConfSenha.TextChanged += new System.EventHandler(this.txtBoxConfSenha_TextChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastrar.Location = new System.Drawing.Point(353, 532);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(225, 39);
            this.btnCadastrar.TabIndex = 91;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cbxVerSenha
            // 
            this.cbxVerSenha.AutoSize = true;
            this.cbxVerSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxVerSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbxVerSenha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbxVerSenha.Location = new System.Drawing.Point(244, 475);
            this.cbxVerSenha.Name = "cbxVerSenha";
            this.cbxVerSenha.Size = new System.Drawing.Size(117, 17);
            this.cbxVerSenha.TabIndex = 130;
            this.cbxVerSenha.Text = "Visualizar Senha";
            this.cbxVerSenha.UseVisualStyleBackColor = true;
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.BackColor = System.Drawing.Color.GhostWhite;
            this.txtBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUser.Location = new System.Drawing.Point(244, 293);
            this.txtBoxUser.Multiline = true;
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(225, 27);
            this.txtBoxUser.TabIndex = 129;
            // 
            // cbxLembrarSenha
            // 
            this.cbxLembrarSenha.AutoSize = true;
            this.cbxLembrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxLembrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbxLembrarSenha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbxLembrarSenha.Location = new System.Drawing.Point(244, 498);
            this.cbxLembrarSenha.Name = "cbxLembrarSenha";
            this.cbxLembrarSenha.Size = new System.Drawing.Size(108, 17);
            this.cbxLembrarSenha.TabIndex = 128;
            this.cbxLembrarSenha.Text = "Lembrar Senha";
            this.cbxLembrarSenha.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.Location = new System.Drawing.Point(97, 532);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(225, 39);
            this.btnLimpar.TabIndex = 127;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(239, 331);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(44, 13);
            this.lblSenha.TabIndex = 126;
            this.lblSenha.Text = "SENHA";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfo2.Location = new System.Drawing.Point(459, 329);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(16, 17);
            this.lblInfo2.TabIndex = 125;
            this.lblInfo2.Text = "?";
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSenha.Location = new System.Drawing.Point(244, 347);
            this.txtBoxSenha.Multiline = true;
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.PasswordChar = '*';
            this.txtBoxSenha.Size = new System.Drawing.Size(225, 27);
            this.txtBoxSenha.TabIndex = 124;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(239, 277);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(56, 13);
            this.lblUser.TabIndex = 123;
            this.lblUser.Text = "USUARIO";
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfo1.Location = new System.Drawing.Point(458, 274);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(16, 17);
            this.lblInfo1.TabIndex = 122;
            this.lblInfo1.Text = "?";
            // 
            // pctbxLogo
            // 
            this.pctbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctbxLogo.Image")));
            this.pctbxLogo.Location = new System.Drawing.Point(295, 113);
            this.pctbxLogo.Name = "pctbxLogo";
            this.pctbxLogo.Size = new System.Drawing.Size(122, 145);
            this.pctbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbxLogo.TabIndex = 121;
            this.pctbxLogo.TabStop = false;
            // 
            // lblRealizarCadastro
            // 
            this.lblRealizarCadastro.AutoSize = true;
            this.lblRealizarCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblRealizarCadastro.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealizarCadastro.ForeColor = System.Drawing.Color.White;
            this.lblRealizarCadastro.Location = new System.Drawing.Point(266, 37);
            this.lblRealizarCadastro.Name = "lblRealizarCadastro";
            this.lblRealizarCadastro.Size = new System.Drawing.Size(181, 30);
            this.lblRealizarCadastro.TabIndex = 131;
            this.lblRealizarCadastro.Text = "Realizar Cadastro";
            // 
            // linkLblJaTenho
            // 
            this.linkLblJaTenho.AutoSize = true;
            this.linkLblJaTenho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.linkLblJaTenho.ForeColor = System.Drawing.Color.Maroon;
            this.linkLblJaTenho.LinkColor = System.Drawing.Color.Maroon;
            this.linkLblJaTenho.Location = new System.Drawing.Point(292, 636);
            this.linkLblJaTenho.Name = "linkLblJaTenho";
            this.linkLblJaTenho.Size = new System.Drawing.Size(133, 13);
            this.linkLblJaTenho.TabIndex = 132;
            this.linkLblJaTenho.TabStop = true;
            this.linkLblJaTenho.Text = "Já possui um cadastro";
            this.linkLblJaTenho.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblJaTenho_LinkClicked);
            // 
            // lblMsgErro
            // 
            this.lblMsgErro.AutoSize = true;
            this.lblMsgErro.Location = new System.Drawing.Point(261, 447);
            this.lblMsgErro.Name = "lblMsgErro";
            this.lblMsgErro.Size = new System.Drawing.Size(99, 13);
            this.lblMsgErro.TabIndex = 133;
            this.lblMsgErro.Text = "Mensagem de Erro ";
            this.lblMsgErro.Visible = false;
            // 
            // pctBoxMsgErro
            // 
            this.pctBoxMsgErro.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxMsgErro.Image")));
            this.pctBoxMsgErro.Location = new System.Drawing.Point(233, 444);
            this.pctBoxMsgErro.Name = "pctBoxMsgErro";
            this.pctBoxMsgErro.Size = new System.Drawing.Size(37, 19);
            this.pctBoxMsgErro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxMsgErro.TabIndex = 134;
            this.pctBoxMsgErro.TabStop = false;
            this.pctBoxMsgErro.Visible = false;
            // 
            // pictBoxSair
            // 
            this.pictBoxSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBoxSair.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pictBoxSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictBoxSair.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxSair.Image")));
            this.pictBoxSair.Location = new System.Drawing.Point(676, 12);
            this.pictBoxSair.Name = "pictBoxSair";
            this.pictBoxSair.Size = new System.Drawing.Size(25, 25);
            this.pictBoxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBoxSair.TabIndex = 135;
            this.pictBoxSair.TabStop = false;
            this.pictBoxSair.Click += new System.EventHandler(this.pictBoxSair_Click);
            // 
            // FrmCadastroUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(713, 715);
            this.Controls.Add(this.pictBoxSair);
            this.Controls.Add(this.lblMsgErro);
            this.Controls.Add(this.pctBoxMsgErro);
            this.Controls.Add(this.linkLblJaTenho);
            this.Controls.Add(this.lblRealizarCadastro);
            this.Controls.Add(this.cbxVerSenha);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.cbxLembrarSenha);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.txtBoxSenha);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.pctbxLogo);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblConfSenha);
            this.Controls.Add(this.lblInf3);
            this.Controls.Add(this.txtBoxConfSenha);
            this.Name = "FrmCadastroUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroUser.cs";
            this.Load += new System.EventHandler(this.FrmCadastroUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMsgErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConfSenha;
        private System.Windows.Forms.Label lblInf3;
        private System.Windows.Forms.TextBox txtBoxConfSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.CheckBox cbxVerSenha;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.CheckBox cbxLembrarSenha;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.PictureBox pctbxLogo;
        private System.Windows.Forms.Label lblRealizarCadastro;
        private System.Windows.Forms.LinkLabel linkLblJaTenho;
        private System.Windows.Forms.Label lblMsgErro;
        private System.Windows.Forms.PictureBox pctBoxMsgErro;
        private System.Windows.Forms.PictureBox pictBoxSair;
    }
}