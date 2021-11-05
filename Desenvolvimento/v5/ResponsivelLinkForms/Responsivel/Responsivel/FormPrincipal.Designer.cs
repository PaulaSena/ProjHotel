
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGHosp = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnGReserv = new System.Windows.Forms.Button();
            this.btnGFunc = new System.Windows.Forms.Button();
            this.pictBoxGUser = new System.Windows.Forms.PictureBox();
            this.pnlBarraTop = new System.Windows.Forms.Panel();
            this.pictBoxRestaurar = new System.Windows.Forms.PictureBox();
            this.pictBoxMax = new System.Windows.Forms.PictureBox();
            this.pictBoxMin = new System.Windows.Forms.PictureBox();
            this.pictBoxFechar = new System.Windows.Forms.PictureBox();
            this.horaData = new System.Windows.Forms.Timer(this.components);
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pctbxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelConteudo.SuspendLayout();
            this.pnlForms.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxGUser)).BeginInit();
            this.pnlBarraTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panelConteudo.Size = new System.Drawing.Size(900, 650);
            this.panelConteudo.TabIndex = 0;
            // 
            // pnlForms
            // 
            this.pnlForms.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlForms.Controls.Add(this.pctbxLogo);
            this.pnlForms.Controls.Add(this.lblHora);
            this.pnlForms.Controls.Add(this.lblData);
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.Location = new System.Drawing.Point(276, 38);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(624, 612);
            this.pnlForms.TabIndex = 2;
            this.pnlForms.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlForms_Paint);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.SlateGray;
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.iconButton1);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.btnGHosp);
            this.pnlMenu.Controls.Add(this.lblEmail);
            this.pnlMenu.Controls.Add(this.lblNome);
            this.pnlMenu.Controls.Add(this.lblPosition);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.btnGReserv);
            this.pnlMenu.Controls.Add(this.btnGFunc);
            this.pnlMenu.Controls.Add(this.pictBoxGUser);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 38);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(276, 612);
            this.pnlMenu.TabIndex = 1;
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
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblHora.Location = new System.Drawing.Point(278, 553);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(73, 25);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "lblHora";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 41);
            this.button1.TabIndex = 106;
            this.button1.Text = "RELATÓRIOS";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnGHosp
            // 
            this.btnGHosp.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGHosp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGHosp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGHosp.Location = new System.Drawing.Point(13, 315);
            this.btnGHosp.Name = "btnGHosp";
            this.btnGHosp.Size = new System.Drawing.Size(252, 41);
            this.btnGHosp.TabIndex = 105;
            this.btnGHosp.Text = "GERENCIAR HÓSPEDES";
            this.btnGHosp.UseVisualStyleBackColor = false;
            this.btnGHosp.Click += new System.EventHandler(this.btnGClient_Click);
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
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(12, 174);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(252, 41);
            this.btnDashboard.TabIndex = 101;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnGReserv
            // 
            this.btnGReserv.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGReserv.Location = new System.Drawing.Point(13, 268);
            this.btnGReserv.Name = "btnGReserv";
            this.btnGReserv.Size = new System.Drawing.Size(252, 41);
            this.btnGReserv.TabIndex = 100;
            this.btnGReserv.Text = "GERENCIAR RESERVAS";
            this.btnGReserv.UseVisualStyleBackColor = false;
            this.btnGReserv.Click += new System.EventHandler(this.btnGReserv_Click);
            // 
            // btnGFunc
            // 
            this.btnGFunc.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGFunc.Location = new System.Drawing.Point(13, 221);
            this.btnGFunc.Name = "btnGFunc";
            this.btnGFunc.Size = new System.Drawing.Size(252, 41);
            this.btnGFunc.TabIndex = 99;
            this.btnGFunc.Text = "GERENCIAR FUNCIONÁRIO";
            this.btnGFunc.UseVisualStyleBackColor = false;
            this.btnGFunc.Click += new System.EventHandler(this.btnGFunc_Click);
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
            this.pictBoxGUser.Click += new System.EventHandler(this.pictBoxGUser_Click);
            // 
            // pnlBarraTop
            // 
            this.pnlBarraTop.BackColor = System.Drawing.Color.Indigo;
            this.pnlBarraTop.Controls.Add(this.pictBoxRestaurar);
            this.pnlBarraTop.Controls.Add(this.pictBoxMax);
            this.pnlBarraTop.Controls.Add(this.pictBoxMin);
            this.pnlBarraTop.Controls.Add(this.pictBoxFechar);
            this.pnlBarraTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTop.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTop.Name = "pnlBarraTop";
            this.pnlBarraTop.Size = new System.Drawing.Size(900, 38);
            this.pnlBarraTop.TabIndex = 0;
            this.pnlBarraTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTop_MouseMove);
            // 
            // pictBoxRestaurar
            // 
            this.pictBoxRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBoxRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxRestaurar.Image")));
            this.pictBoxRestaurar.Location = new System.Drawing.Point(829, 6);
            this.pictBoxRestaurar.Name = "pictBoxRestaurar";
            this.pictBoxRestaurar.Size = new System.Drawing.Size(37, 26);
            this.pictBoxRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictBoxRestaurar.TabIndex = 3;
            this.pictBoxRestaurar.TabStop = false;
            this.pictBoxRestaurar.Click += new System.EventHandler(this.pictBoxRestaurar_Click);
            // 
            // pictBoxMax
            // 
            this.pictBoxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBoxMax.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxMax.Image")));
            this.pictBoxMax.Location = new System.Drawing.Point(829, 6);
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
            this.pictBoxMin.Location = new System.Drawing.Point(793, 6);
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
            this.pictBoxFechar.Location = new System.Drawing.Point(865, 6);
            this.pictBoxFechar.Name = "pictBoxFechar";
            this.pictBoxFechar.Size = new System.Drawing.Size(32, 26);
            this.pictBoxFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictBoxFechar.TabIndex = 0;
            this.pictBoxFechar.TabStop = false;
            this.pictBoxFechar.Click += new System.EventHandler(this.pictBoxFechar_Click);
            // 
            // horaData
            // 
            this.horaData.Enabled = true;
            this.horaData.Tick += new System.EventHandler(this.horaData_Tick);
            // 
            // iconButton1
            // 
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(13, 118);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(251, 50);
            this.iconButton1.TabIndex = 107;
            this.iconButton1.UseVisualStyleBackColor = true;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 123;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxGUser)).EndInit();
            this.pnlBarraTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnGHosp;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnGReserv;
        private System.Windows.Forms.Button btnGFunc;
        private System.Windows.Forms.PictureBox pictBoxGUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer horaData;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.PictureBox pctbxLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

