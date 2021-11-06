
namespace Responsivel
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lblMsgErro = new System.Windows.Forms.Label();
            this.pctBoxMsgErro = new System.Windows.Forms.PictureBox();
            this.linkLblEsqSenha = new System.Windows.Forms.LinkLabel();
            this.linkLblNaotenho = new System.Windows.Forms.LinkLabel();
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictBoxMin = new System.Windows.Forms.PictureBox();
            this.pictBoxFechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMsgErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsgErro
            // 
            this.lblMsgErro.AutoSize = true;
            this.lblMsgErro.Location = new System.Drawing.Point(205, 299);
            this.lblMsgErro.Name = "lblMsgErro";
            this.lblMsgErro.Size = new System.Drawing.Size(99, 13);
            this.lblMsgErro.TabIndex = 141;
            this.lblMsgErro.Text = "Mensagem de Erro ";
            this.lblMsgErro.Visible = false;
            // 
            // pctBoxMsgErro
            // 
            this.pctBoxMsgErro.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxMsgErro.Image")));
            this.pctBoxMsgErro.Location = new System.Drawing.Point(176, 296);
            this.pctBoxMsgErro.Name = "pctBoxMsgErro";
            this.pctBoxMsgErro.Size = new System.Drawing.Size(37, 19);
            this.pctBoxMsgErro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxMsgErro.TabIndex = 142;
            this.pctBoxMsgErro.TabStop = false;
            this.pctBoxMsgErro.Visible = false;
            // 
            // linkLblEsqSenha
            // 
            this.linkLblEsqSenha.AutoSize = true;
            this.linkLblEsqSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.linkLblEsqSenha.Location = new System.Drawing.Point(254, 502);
            this.linkLblEsqSenha.Name = "linkLblEsqSenha";
            this.linkLblEsqSenha.Size = new System.Drawing.Size(94, 13);
            this.linkLblEsqSenha.TabIndex = 140;
            this.linkLblEsqSenha.TabStop = true;
            this.linkLblEsqSenha.Text = "Esqueci senha ";
            // 
            // linkLblNaotenho
            // 
            this.linkLblNaotenho.AutoSize = true;
            this.linkLblNaotenho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.linkLblNaotenho.Location = new System.Drawing.Point(242, 528);
            this.linkLblNaotenho.Name = "linkLblNaotenho";
            this.linkLblNaotenho.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.linkLblNaotenho.Size = new System.Drawing.Size(119, 13);
            this.linkLblNaotenho.TabIndex = 139;
            this.linkLblNaotenho.TabStop = true;
            this.linkLblNaotenho.Text = "Não tenho cadastro";
            this.linkLblNaotenho.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblNaotenho_LinkClicked);
            // 
            // cbxVerSenha
            // 
            this.cbxVerSenha.AutoSize = true;
            this.cbxVerSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxVerSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbxVerSenha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbxVerSenha.Location = new System.Drawing.Point(185, 333);
            this.cbxVerSenha.Name = "cbxVerSenha";
            this.cbxVerSenha.Size = new System.Drawing.Size(117, 17);
            this.cbxVerSenha.TabIndex = 138;
            this.cbxVerSenha.Text = "Visualizar Senha";
            this.cbxVerSenha.UseVisualStyleBackColor = true;
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.BackColor = System.Drawing.Color.GhostWhite;
            this.txtBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUser.Location = new System.Drawing.Point(185, 202);
            this.txtBoxUser.Multiline = true;
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(225, 27);
            this.txtBoxUser.TabIndex = 137;
            // 
            // cbxLembrarSenha
            // 
            this.cbxLembrarSenha.AutoSize = true;
            this.cbxLembrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxLembrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbxLembrarSenha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbxLembrarSenha.Location = new System.Drawing.Point(185, 356);
            this.cbxLembrarSenha.Name = "cbxLembrarSenha";
            this.cbxLembrarSenha.Size = new System.Drawing.Size(108, 17);
            this.cbxLembrarSenha.TabIndex = 136;
            this.cbxLembrarSenha.Text = "Lembrar Senha";
            this.cbxLembrarSenha.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.Location = new System.Drawing.Point(58, 411);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(225, 39);
            this.btnLimpar.TabIndex = 135;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(186, 240);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(44, 13);
            this.lblSenha.TabIndex = 134;
            this.lblSenha.Text = "SENHA";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfo2.Location = new System.Drawing.Point(402, 238);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(16, 17);
            this.lblInfo2.TabIndex = 133;
            this.lblInfo2.Text = "?";
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSenha.Location = new System.Drawing.Point(185, 256);
            this.txtBoxSenha.Multiline = true;
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.PasswordChar = '*';
            this.txtBoxSenha.Size = new System.Drawing.Size(225, 27);
            this.txtBoxSenha.TabIndex = 132;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(186, 186);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(56, 13);
            this.lblUser.TabIndex = 131;
            this.lblUser.Text = "USUARIO";
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfo1.Location = new System.Drawing.Point(401, 183);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(16, 17);
            this.lblInfo1.TabIndex = 130;
            this.lblInfo1.Text = "?";
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.Transparent;
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogar.Location = new System.Drawing.Point(323, 411);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(225, 39);
            this.btnLogar.TabIndex = 129;
            this.btnLogar.Text = "LOGAR";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.BtnLogar_Click);
            // 
            // pctbxLogo
            // 
            this.pctbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctbxLogo.Image")));
            this.pctbxLogo.Location = new System.Drawing.Point(247, 35);
            this.pctbxLogo.Name = "pctbxLogo";
            this.pctbxLogo.Size = new System.Drawing.Size(101, 114);
            this.pctbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbxLogo.TabIndex = 128;
            this.pctbxLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 143;
            this.label1.Text = "LOGIN";
            // 
            // pictBoxMin
            // 
            this.pictBoxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBoxMin.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxMin.Image")));
            this.pictBoxMin.Location = new System.Drawing.Point(531, 2);
            this.pictBoxMin.Name = "pictBoxMin";
            this.pictBoxMin.Size = new System.Drawing.Size(37, 26);
            this.pictBoxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictBoxMin.TabIndex = 145;
            this.pictBoxMin.TabStop = false;
            this.pictBoxMin.Click += new System.EventHandler(this.PictBoxMin_Click);
            // 
            // pictBoxFechar
            // 
            this.pictBoxFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBoxFechar.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxFechar.Image")));
            this.pictBoxFechar.Location = new System.Drawing.Point(567, 2);
            this.pictBoxFechar.Name = "pictBoxFechar";
            this.pictBoxFechar.Size = new System.Drawing.Size(32, 26);
            this.pictBoxFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictBoxFechar.TabIndex = 144;
            this.pictBoxFechar.TabStop = false;
            this.pictBoxFechar.Click += new System.EventHandler(this.PictBoxFechar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(602, 569);
            this.Controls.Add(this.pictBoxMin);
            this.Controls.Add(this.pictBoxFechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsgErro);
            this.Controls.Add(this.pctBoxMsgErro);
            this.Controls.Add(this.linkLblEsqSenha);
            this.Controls.Add(this.linkLblNaotenho);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMsgErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsgErro;
        private System.Windows.Forms.PictureBox pctBoxMsgErro;
        private System.Windows.Forms.LinkLabel linkLblEsqSenha;
        private System.Windows.Forms.LinkLabel linkLblNaotenho;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictBoxMin;
        private System.Windows.Forms.PictureBox pictBoxFechar;
    }
}