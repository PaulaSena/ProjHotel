
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.pnlForms = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlBarraTop = new System.Windows.Forms.Panel();
            this.pictBoxRestaurar = new System.Windows.Forms.PictureBox();
            this.pictBoxMax = new System.Windows.Forms.PictureBox();
            this.pictBoxMin = new System.Windows.Forms.PictureBox();
            this.pictBoxFechar = new System.Windows.Forms.PictureBox();
            this.btnGClient = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnGReserv = new System.Windows.Forms.Button();
            this.btnGFunc = new System.Windows.Forms.Button();
            this.pictBoxGUser = new System.Windows.Forms.PictureBox();
            this.panelConteudo.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlBarraTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxGUser)).BeginInit();
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
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.Location = new System.Drawing.Point(276, 38);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(624, 612);
            this.pnlForms.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlMenu.Controls.Add(this.btnGClient);
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
            // btnGClient
            // 
            this.btnGClient.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGClient.Location = new System.Drawing.Point(12, 325);
            this.btnGClient.Name = "btnGClient";
            this.btnGClient.Size = new System.Drawing.Size(252, 54);
            this.btnGClient.TabIndex = 105;
            this.btnGClient.Text = "GERENCIAR CLIENTES";
            this.btnGClient.UseVisualStyleBackColor = false;
            this.btnGClient.Click += new System.EventHandler(this.btnGClient_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(88, 449);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 104;
            this.lblEmail.Text = "Email";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(88, 433);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 103;
            this.lblNome.Text = "Name";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(88, 417);
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
            this.btnDashboard.Location = new System.Drawing.Point(12, 145);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(252, 54);
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
            this.btnGReserv.Location = new System.Drawing.Point(13, 265);
            this.btnGReserv.Name = "btnGReserv";
            this.btnGReserv.Size = new System.Drawing.Size(252, 54);
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
            this.btnGFunc.Location = new System.Drawing.Point(13, 205);
            this.btnGFunc.Name = "btnGFunc";
            this.btnGFunc.Size = new System.Drawing.Size(252, 54);
            this.btnGFunc.TabIndex = 99;
            this.btnGFunc.Text = "GERENCIAR FUNCIONÁRIO";
            this.btnGFunc.UseVisualStyleBackColor = false;
            this.btnGFunc.Click += new System.EventHandler(this.btnGFunc_Click);
            // 
            // pictBoxGUser
            // 
            this.pictBoxGUser.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxGUser.Image")));
            this.pictBoxGUser.Location = new System.Drawing.Point(25, 409);
            this.pictBoxGUser.Name = "pictBoxGUser";
            this.pictBoxGUser.Size = new System.Drawing.Size(57, 59);
            this.pictBoxGUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBoxGUser.TabIndex = 98;
            this.pictBoxGUser.TabStop = false;
            this.pictBoxGUser.Click += new System.EventHandler(this.pictBoxGUser_Click);
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
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlBarraTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxGUser)).EndInit();
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
        private System.Windows.Forms.Button btnGClient;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnGReserv;
        private System.Windows.Forms.Button btnGFunc;
        private System.Windows.Forms.PictureBox pictBoxGUser;
    }
}

