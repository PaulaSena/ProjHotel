
namespace Responsivel
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.pnlForms = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.pnlBarraTop = new System.Windows.Forms.Panel();
            this.horaData = new System.Windows.Forms.Timer(this.components);
            this.pctbxLogo = new System.Windows.Forms.PictureBox();
            this.btnFormGFunc = new FontAwesome.Sharp.IconButton();
            this.btnFormGReser = new FontAwesome.Sharp.IconButton();
            this.btnFormGHosp = new FontAwesome.Sharp.IconButton();
            this.btnFormRelat = new FontAwesome.Sharp.IconButton();
            this.btnFormGUser = new FontAwesome.Sharp.IconButton();
            this.btnDashboard2 = new FontAwesome.Sharp.IconButton();
            this.pctBoxLogoHome = new System.Windows.Forms.PictureBox();
            this.pictBoxGUser = new System.Windows.Forms.PictureBox();
            this.pictBoxMax = new System.Windows.Forms.PictureBox();
            this.pictBoxMin = new System.Windows.Forms.PictureBox();
            this.pictBoxFechar = new System.Windows.Forms.PictureBox();
            this.pictBoxRestaurar = new System.Windows.Forms.PictureBox();
            this.panelConteudo.SuspendLayout();
            this.pnlForms.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlBarraTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogoHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxGUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxRestaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConteudo
            // 
            this.panelConteudo.BackColor = System.Drawing.Color.SlateBlue;
            this.panelConteudo.Controls.Add(this.pnlForms);
            this.panelConteudo.Controls.Add(this.pnlMenu);
            this.panelConteudo.Controls.Add(this.pnlBarraTop);
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(0, 0);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(1054, 650);
            this.panelConteudo.TabIndex = 0;
            // 
            // pnlForms
            // 
            this.pnlForms.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlForms.Controls.Add(this.pctbxLogo);
            this.pnlForms.Controls.Add(this.lblHora);
            this.pnlForms.Controls.Add(this.lblData);
            this.pnlForms.Location = new System.Drawing.Point(276, 38);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(778, 612);
            this.pnlForms.TabIndex = 2;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblHora.Location = new System.Drawing.Point(278, 553);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(73, 25);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "lblHora";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblData.Location = new System.Drawing.Point(278, 578);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(72, 25);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "lblData";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.SlateGray;
            this.pnlMenu.Controls.Add(this.btnFormGFunc);
            this.pnlMenu.Controls.Add(this.btnFormGReser);
            this.pnlMenu.Controls.Add(this.btnFormGHosp);
            this.pnlMenu.Controls.Add(this.btnFormRelat);
            this.pnlMenu.Controls.Add(this.btnFormGUser);
            this.pnlMenu.Controls.Add(this.btnDashboard2);
            this.pnlMenu.Controls.Add(this.pctBoxLogoHome);
            this.pnlMenu.Controls.Add(this.lblEmail);
            this.pnlMenu.Controls.Add(this.lblNome);
            this.pnlMenu.Controls.Add(this.lblPosition);
            this.pnlMenu.Controls.Add(this.pictBoxGUser);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlMenu.Location = new System.Drawing.Point(0, 38);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(276, 612);
            this.pnlMenu.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(90, 494);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 104;
            this.lblEmail.Text = "Email";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(90, 478);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 103;
            this.lblNome.Text = "Name";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(90, 462);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(57, 16);
            this.lblPosition.TabIndex = 102;
            this.lblPosition.Text = "Position";
            // 
            // pnlBarraTop
            // 
            this.pnlBarraTop.BackColor = System.Drawing.Color.Indigo;
            this.pnlBarraTop.Controls.Add(this.pictBoxMax);
            this.pnlBarraTop.Controls.Add(this.pictBoxMin);
            this.pnlBarraTop.Controls.Add(this.pictBoxFechar);
            this.pnlBarraTop.Controls.Add(this.pictBoxRestaurar);
            this.pnlBarraTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTop.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTop.Name = "pnlBarraTop";
            this.pnlBarraTop.Size = new System.Drawing.Size(1054, 38);
            this.pnlBarraTop.TabIndex = 0;
            this.pnlBarraTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTop_MouseMove);
            // 
            // horaData
            // 
            this.horaData.Enabled = true;
            this.horaData.Tick += new System.EventHandler(this.horaData_Tick);
            // 
            // pctbxLogo
            // 
            this.pctbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctbxLogo.Image")));
            this.pctbxLogo.Location = new System.Drawing.Point(249, 141);
            this.pctbxLogo.Name = "pctbxLogo";
            this.pctbxLogo.Size = new System.Drawing.Size(199, 227);
            this.pctbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbxLogo.TabIndex = 122;
            this.pctbxLogo.TabStop = false;
            // 
            // btnFormGFunc
            // 
            this.btnFormGFunc.BackColor = System.Drawing.Color.CadetBlue;
            this.btnFormGFunc.FlatAppearance.BorderSize = 0;
            this.btnFormGFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormGFunc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFormGFunc.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormGFunc.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnFormGFunc.IconColor = System.Drawing.Color.Black;
            this.btnFormGFunc.IconSize = 35;
            this.btnFormGFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFormGFunc.Location = new System.Drawing.Point(13, 176);
            this.btnFormGFunc.Margin = new System.Windows.Forms.Padding(0);
            this.btnFormGFunc.Name = "btnFormGFunc";
            this.btnFormGFunc.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btnFormGFunc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFormGFunc.Rotation = 0D;
            this.btnFormGFunc.Size = new System.Drawing.Size(252, 40);
            this.btnFormGFunc.TabIndex = 130;
            this.btnFormGFunc.Text = "Funcionário";
            this.btnFormGFunc.UseVisualStyleBackColor = false;
            this.btnFormGFunc.Click += new System.EventHandler(this.btnFormGFunc_Click);
            // 
            // btnFormGReser
            // 
            this.btnFormGReser.BackColor = System.Drawing.Color.CadetBlue;
            this.btnFormGReser.FlatAppearance.BorderSize = 0;
            this.btnFormGReser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormGReser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFormGReser.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormGReser.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnFormGReser.IconColor = System.Drawing.Color.Black;
            this.btnFormGReser.IconSize = 35;
            this.btnFormGReser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFormGReser.Location = new System.Drawing.Point(13, 227);
            this.btnFormGReser.Margin = new System.Windows.Forms.Padding(0);
            this.btnFormGReser.Name = "btnFormGReser";
            this.btnFormGReser.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btnFormGReser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFormGReser.Rotation = 0D;
            this.btnFormGReser.Size = new System.Drawing.Size(252, 40);
            this.btnFormGReser.TabIndex = 129;
            this.btnFormGReser.Text = "Reserva  ";
            this.btnFormGReser.UseVisualStyleBackColor = false;
            this.btnFormGReser.Click += new System.EventHandler(this.btnFormGReser_Click);
            // 
            // btnFormGHosp
            // 
            this.btnFormGHosp.BackColor = System.Drawing.Color.CadetBlue;
            this.btnFormGHosp.FlatAppearance.BorderSize = 0;
            this.btnFormGHosp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormGHosp.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFormGHosp.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormGHosp.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.btnFormGHosp.IconColor = System.Drawing.Color.Black;
            this.btnFormGHosp.IconSize = 35;
            this.btnFormGHosp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFormGHosp.Location = new System.Drawing.Point(13, 324);
            this.btnFormGHosp.Margin = new System.Windows.Forms.Padding(0);
            this.btnFormGHosp.Name = "btnFormGHosp";
            this.btnFormGHosp.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btnFormGHosp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFormGHosp.Rotation = 0D;
            this.btnFormGHosp.Size = new System.Drawing.Size(252, 40);
            this.btnFormGHosp.TabIndex = 128;
            this.btnFormGHosp.Text = "Hóspede ";
            this.btnFormGHosp.UseVisualStyleBackColor = false;
            this.btnFormGHosp.Click += new System.EventHandler(this.btnFormGHosp_Click);
            // 
            // btnFormRelat
            // 
            this.btnFormRelat.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnFormRelat.FlatAppearance.BorderSize = 0;
            this.btnFormRelat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormRelat.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFormRelat.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormRelat.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btnFormRelat.IconColor = System.Drawing.Color.Black;
            this.btnFormRelat.IconSize = 30;
            this.btnFormRelat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFormRelat.Location = new System.Drawing.Point(13, 375);
            this.btnFormRelat.Margin = new System.Windows.Forms.Padding(0);
            this.btnFormRelat.Name = "btnFormRelat";
            this.btnFormRelat.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btnFormRelat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFormRelat.Rotation = 0D;
            this.btnFormRelat.Size = new System.Drawing.Size(252, 40);
            this.btnFormRelat.TabIndex = 127;
            this.btnFormRelat.Text = "Relatórios";
            this.btnFormRelat.UseVisualStyleBackColor = false;
            // 
            // btnFormGUser
            // 
            this.btnFormGUser.BackColor = System.Drawing.Color.CadetBlue;
            this.btnFormGUser.FlatAppearance.BorderSize = 0;
            this.btnFormGUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormGUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFormGUser.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormGUser.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnFormGUser.IconColor = System.Drawing.Color.Black;
            this.btnFormGUser.IconSize = 35;
            this.btnFormGUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFormGUser.Location = new System.Drawing.Point(13, 278);
            this.btnFormGUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnFormGUser.Name = "btnFormGUser";
            this.btnFormGUser.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btnFormGUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFormGUser.Rotation = 0D;
            this.btnFormGUser.Size = new System.Drawing.Size(252, 40);
            this.btnFormGUser.TabIndex = 126;
            this.btnFormGUser.Text = "Usuários";
            this.btnFormGUser.UseVisualStyleBackColor = false;
            this.btnFormGUser.Click += new System.EventHandler(this.iconBFormGUser_Click);
            // 
            // btnDashboard2
            // 
            this.btnDashboard2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDashboard2.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard2.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnDashboard2.IconColor = System.Drawing.Color.Black;
            this.btnDashboard2.IconSize = 35;
            this.btnDashboard2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard2.Location = new System.Drawing.Point(13, 121);
            this.btnDashboard2.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard2.Name = "btnDashboard2";
            this.btnDashboard2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btnDashboard2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDashboard2.Rotation = 0D;
            this.btnDashboard2.Size = new System.Drawing.Size(252, 50);
            this.btnDashboard2.TabIndex = 124;
            this.btnDashboard2.Text = "Dashboard";
            this.btnDashboard2.UseVisualStyleBackColor = true;
            this.btnDashboard2.Click += new System.EventHandler(this.btnDashboard2_Click_1);
            // 
            // pctBoxLogoHome
            // 
            this.pctBoxLogoHome.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxLogoHome.Image")));
            this.pctBoxLogoHome.Location = new System.Drawing.Point(108, 22);
            this.pctBoxLogoHome.Name = "pctBoxLogoHome";
            this.pctBoxLogoHome.Size = new System.Drawing.Size(71, 79);
            this.pctBoxLogoHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxLogoHome.TabIndex = 123;
            this.pctBoxLogoHome.TabStop = false;
            this.pctBoxLogoHome.Click += new System.EventHandler(this.pctBoxLogoHome_Click);
            // 
            // pictBoxGUser
            // 
            this.pictBoxGUser.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxGUser.Image")));
            this.pictBoxGUser.Location = new System.Drawing.Point(27, 454);
            this.pictBoxGUser.Name = "pictBoxGUser";
            this.pictBoxGUser.Size = new System.Drawing.Size(57, 59);
            this.pictBoxGUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBoxGUser.TabIndex = 98;
            this.pictBoxGUser.TabStop = false;
            // 
            // pictBoxMax
            // 
            this.pictBoxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBoxMax.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxMax.Image")));
            this.pictBoxMax.Location = new System.Drawing.Point(983, 6);
            this.pictBoxMax.Name = "pictBoxMax";
            this.pictBoxMax.Size = new System.Drawing.Size(37, 26);
            this.pictBoxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictBoxMax.TabIndex = 2;
            this.pictBoxMax.TabStop = false;
            this.pictBoxMax.Click += new System.EventHandler(this.pictBoxMax_Click);
            // 
            // pictBoxMin
            // 
            this.pictBoxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBoxMin.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxMin.Image")));
            this.pictBoxMin.Location = new System.Drawing.Point(947, 6);
            this.pictBoxMin.Name = "pictBoxMin";
            this.pictBoxMin.Size = new System.Drawing.Size(37, 26);
            this.pictBoxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictBoxMin.TabIndex = 1;
            this.pictBoxMin.TabStop = false;
            this.pictBoxMin.Click += new System.EventHandler(this.pictBoxMin_Click);
            // 
            // pictBoxFechar
            // 
            this.pictBoxFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBoxFechar.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxFechar.Image")));
            this.pictBoxFechar.Location = new System.Drawing.Point(1019, 6);
            this.pictBoxFechar.Name = "pictBoxFechar";
            this.pictBoxFechar.Size = new System.Drawing.Size(32, 26);
            this.pictBoxFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictBoxFechar.TabIndex = 0;
            this.pictBoxFechar.TabStop = false;
            this.pictBoxFechar.Click += new System.EventHandler(this.pictBoxFechar_Click);
            // 
            // pictBoxRestaurar
            // 
            this.pictBoxRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBoxRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxRestaurar.Image")));
            this.pictBoxRestaurar.Location = new System.Drawing.Point(983, 6);
            this.pictBoxRestaurar.Name = "pictBoxRestaurar";
            this.pictBoxRestaurar.Size = new System.Drawing.Size(37, 26);
            this.pictBoxRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictBoxRestaurar.TabIndex = 3;
            this.pictBoxRestaurar.TabStop = false;
            this.pictBoxRestaurar.Click += new System.EventHandler(this.pictBoxRestaurar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 650);
            this.Controls.Add(this.panelConteudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 612);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.panelConteudo.ResumeLayout(false);
            this.pnlForms.ResumeLayout(false);
            this.pnlForms.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlBarraTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogoHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxGUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxRestaurar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Panel pnlForms;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlBarraTop;
        private System.Windows.Forms.PictureBox pictBoxMax;
        private System.Windows.Forms.PictureBox pictBoxMin;
        private System.Windows.Forms.PictureBox pictBoxFechar;
        private System.Windows.Forms.PictureBox pictBoxRestaurar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.PictureBox pictBoxGUser;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer horaData;
        private System.Windows.Forms.PictureBox pctbxLogo;
        private System.Windows.Forms.PictureBox pctBoxLogoHome;
        private FontAwesome.Sharp.IconButton btnDashboard2;
        private FontAwesome.Sharp.IconButton btnFormGUser;
        private FontAwesome.Sharp.IconButton btnFormRelat;
        private FontAwesome.Sharp.IconButton btnFormGHosp;
        private FontAwesome.Sharp.IconButton btnFormGReser;
        private FontAwesome.Sharp.IconButton btnFormGFunc;
    }
}

