
using System;

namespace Responsivel
{
    partial class FormEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditUser));
            this.lblMsgErro = new System.Windows.Forms.Label();
            this.pctBoxMsgErro = new System.Windows.Forms.PictureBox();
            this.lblEditCadastro = new System.Windows.Forms.Label();
            this.cbxEmailPromo = new System.Windows.Forms.CheckBox();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInf3 = new System.Windows.Forms.Label();
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.txtBoxConfSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.iconPBoxUser = new FontAwesome.Sharp.IconPictureBox();
            this.iconBtnSalvar = new FontAwesome.Sharp.IconButton();
            this.iconProximo = new FontAwesome.Sharp.IconButton();
            this.iconBtnClear = new FontAwesome.Sharp.IconButton();
            this.ImgAdd = new FontAwesome.Sharp.IconButton();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.horaData = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMsgErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsgErro
            // 
            this.lblMsgErro.AutoSize = true;
            this.lblMsgErro.Location = new System.Drawing.Point(53, 267);
            this.lblMsgErro.Name = "lblMsgErro";
            this.lblMsgErro.Size = new System.Drawing.Size(99, 13);
            this.lblMsgErro.TabIndex = 171;
            this.lblMsgErro.Text = "Mensagem de Erro ";
            this.lblMsgErro.Visible = false;
            // 
            // pctBoxMsgErro
            // 
            this.pctBoxMsgErro.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxMsgErro.Image")));
            this.pctBoxMsgErro.Location = new System.Drawing.Point(25, 264);
            this.pctBoxMsgErro.Name = "pctBoxMsgErro";
            this.pctBoxMsgErro.Size = new System.Drawing.Size(37, 19);
            this.pctBoxMsgErro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxMsgErro.TabIndex = 172;
            this.pctBoxMsgErro.TabStop = false;
            this.pctBoxMsgErro.Visible = false;
            // 
            // lblEditCadastro
            // 
            this.lblEditCadastro.AutoSize = true;
            this.lblEditCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblEditCadastro.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCadastro.ForeColor = System.Drawing.Color.White;
            this.lblEditCadastro.Location = new System.Drawing.Point(227, 21);
            this.lblEditCadastro.Name = "lblEditCadastro";
            this.lblEditCadastro.Size = new System.Drawing.Size(151, 30);
            this.lblEditCadastro.TabIndex = 169;
            this.lblEditCadastro.Text = "Editar Usuário";
            // 
            // cbxEmailPromo
            // 
            this.cbxEmailPromo.AutoSize = true;
            this.cbxEmailPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEmailPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbxEmailPromo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbxEmailPromo.Location = new System.Drawing.Point(30, 289);
            this.cbxEmailPromo.Name = "cbxEmailPromo";
            this.cbxEmailPromo.Size = new System.Drawing.Size(231, 17);
            this.cbxEmailPromo.TabIndex = 168;
            this.cbxEmailPromo.Text = "A ceito receber e-mails promocionais";
            this.cbxEmailPromo.UseVisualStyleBackColor = true;
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfo2.Location = new System.Drawing.Point(249, 151);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(16, 17);
            this.lblInfo2.TabIndex = 163;
            this.lblInfo2.Text = "?";
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSenha.Location = new System.Drawing.Point(31, 171);
            this.txtBoxSenha.Multiline = true;
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.PasswordChar = '*';
            this.txtBoxSenha.Size = new System.Drawing.Size(225, 27);
            this.txtBoxSenha.TabIndex = 162;
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfo1.Location = new System.Drawing.Point(248, 97);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(16, 17);
            this.lblInfo1.TabIndex = 160;
            this.lblInfo1.Text = "?";
            // 
            // lblInf3
            // 
            this.lblInf3.AutoSize = true;
            this.lblInf3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInf3.ForeColor = System.Drawing.Color.Maroon;
            this.lblInf3.Location = new System.Drawing.Point(248, 208);
            this.lblInf3.Name = "lblInf3";
            this.lblInf3.Size = new System.Drawing.Size(16, 17);
            this.lblInf3.TabIndex = 157;
            this.lblInf3.Text = "?";
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblConfSenha.ForeColor = System.Drawing.Color.White;
            this.lblConfSenha.Location = new System.Drawing.Point(29, 215);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(111, 13);
            this.lblConfSenha.TabIndex = 158;
            this.lblConfSenha.Text = "CONFIRMAR SENHA";
            // 
            // txtBoxConfSenha
            // 
            this.txtBoxConfSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfSenha.Location = new System.Drawing.Point(32, 228);
            this.txtBoxConfSenha.Multiline = true;
            this.txtBoxConfSenha.Name = "txtBoxConfSenha";
            this.txtBoxConfSenha.PasswordChar = '*';
            this.txtBoxConfSenha.Size = new System.Drawing.Size(225, 27);
            this.txtBoxConfSenha.TabIndex = 156;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 161;
            this.label1.Text = "USUARIO";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(33, 117);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 27);
            this.textBox1.TabIndex = 167;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(27, 157);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(44, 13);
            this.lblSenha.TabIndex = 164;
            this.lblSenha.Text = "SENHA";
            // 
            // iconPBoxUser
            // 
            this.iconPBoxUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.iconPBoxUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPBoxUser.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconPBoxUser.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPBoxUser.IconSize = 129;
            this.iconPBoxUser.Location = new System.Drawing.Point(341, 85);
            this.iconPBoxUser.Margin = new System.Windows.Forms.Padding(0);
            this.iconPBoxUser.Name = "iconPBoxUser";
            this.iconPBoxUser.Size = new System.Drawing.Size(148, 129);
            this.iconPBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPBoxUser.TabIndex = 174;
            this.iconPBoxUser.TabStop = false;
            this.iconPBoxUser.Click += new System.EventHandler(this.iconPBoxUser_Click);
            // 
            // iconBtnSalvar
            // 
            this.iconBtnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconBtnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconBtnSalvar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnSalvar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconBtnSalvar.IconColor = System.Drawing.Color.Black;
            this.iconBtnSalvar.IconSize = 35;
            this.iconBtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnSalvar.Location = new System.Drawing.Point(217, 339);
            this.iconBtnSalvar.Name = "iconBtnSalvar";
            this.iconBtnSalvar.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.iconBtnSalvar.Rotation = 0D;
            this.iconBtnSalvar.Size = new System.Drawing.Size(138, 41);
            this.iconBtnSalvar.TabIndex = 177;
            this.iconBtnSalvar.Text = "Salvar";
            this.iconBtnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSalvar.UseVisualStyleBackColor = true;
            // 
            // iconProximo
            // 
            this.iconProximo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconProximo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconProximo.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.iconProximo.IconColor = System.Drawing.Color.Black;
            this.iconProximo.IconSize = 35;
            this.iconProximo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconProximo.Location = new System.Drawing.Point(405, 337);
            this.iconProximo.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.iconProximo.Name = "iconProximo";
            this.iconProximo.Padding = new System.Windows.Forms.Padding(5, 0, 8, 0);
            this.iconProximo.Rotation = 0D;
            this.iconProximo.Size = new System.Drawing.Size(135, 42);
            this.iconProximo.TabIndex = 178;
            this.iconProximo.Text = "Próximo";
            this.iconProximo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconProximo.UseVisualStyleBackColor = true;
            this.iconProximo.Click += new System.EventHandler(this.iconProximo_Click_1);
            // 
            // iconBtnClear
            // 
            this.iconBtnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconBtnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconBtnClear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnClear.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconBtnClear.IconColor = System.Drawing.Color.Black;
            this.iconBtnClear.IconSize = 35;
            this.iconBtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnClear.Location = new System.Drawing.Point(18, 339);
            this.iconBtnClear.Name = "iconBtnClear";
            this.iconBtnClear.Padding = new System.Windows.Forms.Padding(7, 0, 8, 0);
            this.iconBtnClear.Rotation = 0D;
            this.iconBtnClear.Size = new System.Drawing.Size(130, 42);
            this.iconBtnClear.TabIndex = 179;
            this.iconBtnClear.Text = "Limpar";
            this.iconBtnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnClear.UseVisualStyleBackColor = true;
            // 
            // ImgAdd
            // 
            this.ImgAdd.FlatAppearance.BorderSize = 0;
            this.ImgAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ImgAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImgAdd.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.ImgAdd.IconColor = System.Drawing.Color.Black;
            this.ImgAdd.IconSize = 35;
            this.ImgAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImgAdd.Location = new System.Drawing.Point(356, 239);
            this.ImgAdd.Name = "ImgAdd";
            this.ImgAdd.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ImgAdd.Rotation = 0D;
            this.ImgAdd.Size = new System.Drawing.Size(148, 41);
            this.ImgAdd.TabIndex = 182;
            this.ImgAdd.Text = "Alterar Foto ";
            this.ImgAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImgAdd.UseVisualStyleBackColor = true;
            this.ImgAdd.Click += new System.EventHandler(this.ImgAdd_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblHora.Location = new System.Drawing.Point(20, 13);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(73, 25);
            this.lblHora.TabIndex = 184;
            this.lblHora.Text = "lblHora";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblData.Location = new System.Drawing.Point(20, 38);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(72, 25);
            this.lblData.TabIndex = 183;
            this.lblData.Text = "lblData";
            // 
            // horaData
            // 
            this.horaData.Enabled = true;
            // 
            // FormEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(572, 418);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.ImgAdd);
            this.Controls.Add(this.iconBtnClear);
            this.Controls.Add(this.iconProximo);
            this.Controls.Add(this.iconBtnSalvar);
            this.Controls.Add(this.iconPBoxUser);
            this.Controls.Add(this.lblMsgErro);
            this.Controls.Add(this.pctBoxMsgErro);
            this.Controls.Add(this.lblEditCadastro);
            this.Controls.Add(this.cbxEmailPromo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxSenha);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.lblConfSenha);
            this.Controls.Add(this.lblInf3);
            this.Controls.Add(this.txtBoxConfSenha);
            this.Name = "FormEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formlário Editar dados de Usuário ";
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMsgErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMsgErro;
        private System.Windows.Forms.PictureBox pctBoxMsgErro;
        private System.Windows.Forms.Label lblEditCadastro;
        private System.Windows.Forms.CheckBox cbxEmailPromo;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInf3;
        private System.Windows.Forms.Label lblConfSenha;
        private System.Windows.Forms.TextBox txtBoxConfSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSenha;
        private FontAwesome.Sharp.IconPictureBox iconPBoxUser;
        private FontAwesome.Sharp.IconButton iconBtnSalvar;
        private FontAwesome.Sharp.IconButton iconProximo;
        private FontAwesome.Sharp.IconButton iconBtnClear;
        private FontAwesome.Sharp.IconButton ImgAdd;
        private EventHandler IconProximo_Click;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer horaData;
    }
}