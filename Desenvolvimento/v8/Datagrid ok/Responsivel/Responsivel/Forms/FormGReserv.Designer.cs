
namespace Responsivel
{
    partial class FormGReserv
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.placeholderTextBox1 = new PlaceholderTextBox.PlaceholderTextBox();
            this.gridUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.horaData = new System.Windows.Forms.Timer(this.components);
            this.pnlOrcamento = new System.Windows.Forms.Panel();
            this.txtPreco = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtOrcam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmricUH = new System.Windows.Forms.NumericUpDown();
            this.cboxAcomod = new System.Windows.Forms.ComboBox();
            this.iconButnNovoF = new FontAwesome.Sharp.IconButton();
            this.iconBtnExc = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboxRestau = new System.Windows.Forms.ComboBox();
            this.dateCkeckIn = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.gpBoxPeriodo = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateCkeckOut = new System.Windows.Forms.DateTimePicker();
            this.ckLBoxServic = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).BeginInit();
            this.pnlOrcamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmricUH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpBoxPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gerenciar Reserva";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(826, 110);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 190);
            this.vScrollBar1.TabIndex = 191;
            // 
            // placeholderTextBox1
            // 
            this.placeholderTextBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox1.Location = new System.Drawing.Point(27, 77);
            this.placeholderTextBox1.Name = "placeholderTextBox1";
            this.placeholderTextBox1.PlaceholderText = "Buscar...";
            this.placeholderTextBox1.Size = new System.Drawing.Size(468, 27);
            this.placeholderTextBox1.TabIndex = 186;
            // 
            // gridUser
            // 
            this.gridUser.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Maroon;
            this.gridUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUser.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridUser.ColumnHeadersHeight = 30;
            this.gridUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUser.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridUser.GridColor = System.Drawing.Color.Gainsboro;
            this.gridUser.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.gridUser.Location = new System.Drawing.Point(27, 110);
            this.gridUser.Name = "gridUser";
            this.gridUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridUser.RowHeadersVisible = false;
            this.gridUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.gridUser.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.gridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUser.Size = new System.Drawing.Size(796, 190);
            this.gridUser.TabIndex = 185;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "idUser";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "tipoUser";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "senha";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "estadLogin";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "loginUser";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            dataGridViewCellStyle9.Format = "F";
            dataGridViewCellStyle9.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column6.HeaderText = "dataDeAceUser";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.FillWeight = 50F;
            this.Column7.HeaderText = "fotoPerfil";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "idPessoa";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.NullValue = false;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column9.HeaderText = "idAceite";
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "dFunc_FK";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "idHosp_FK";
            this.Column11.Name = "Column11";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblHora.Location = new System.Drawing.Point(344, 560);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(73, 25);
            this.lblHora.TabIndex = 193;
            this.lblHora.Text = "lblHora";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblData.Location = new System.Drawing.Point(423, 560);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(72, 25);
            this.lblData.TabIndex = 192;
            this.lblData.Text = "lblData";
            // 
            // horaData
            // 
            this.horaData.Enabled = true;
            // 
            // pnlOrcamento
            // 
            this.pnlOrcamento.Controls.Add(this.ckLBoxServic);
            this.pnlOrcamento.Controls.Add(this.gpBoxPeriodo);
            this.pnlOrcamento.Controls.Add(this.label11);
            this.pnlOrcamento.Controls.Add(this.label10);
            this.pnlOrcamento.Controls.Add(this.cboxRestau);
            this.pnlOrcamento.Controls.Add(this.label9);
            this.pnlOrcamento.Controls.Add(this.label8);
            this.pnlOrcamento.Controls.Add(this.txtPreco);
            this.pnlOrcamento.Controls.Add(this.btnGuardar);
            this.pnlOrcamento.Controls.Add(this.txtOrcam);
            this.pnlOrcamento.Controls.Add(this.label5);
            this.pnlOrcamento.Controls.Add(this.txtDesc);
            this.pnlOrcamento.Controls.Add(this.label6);
            this.pnlOrcamento.Controls.Add(this.label7);
            this.pnlOrcamento.Controls.Add(this.label2);
            this.pnlOrcamento.Controls.Add(this.nmricUH);
            this.pnlOrcamento.Controls.Add(this.cboxAcomod);
            this.pnlOrcamento.Enabled = false;
            this.pnlOrcamento.Location = new System.Drawing.Point(371, 349);
            this.pnlOrcamento.Name = "pnlOrcamento";
            this.pnlOrcamento.Size = new System.Drawing.Size(464, 208);
            this.pnlOrcamento.TabIndex = 194;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(270, 100);
            this.txtPreco.Mask = "00.000,00";
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(184, 20);
            this.txtPreco.TabIndex = 23;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(268, 150);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(184, 35);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar:";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtOrcam
            // 
            this.txtOrcam.Location = new System.Drawing.Point(270, 124);
            this.txtOrcam.Name = "txtOrcam";
            this.txtOrcam.Size = new System.Drawing.Size(184, 20);
            this.txtOrcam.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Orçamento:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(270, 69);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(184, 20);
            this.txtDesc.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Descrição:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Serviços:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "UH - Unidade Hotel:";
            // 
            // nmricUH
            // 
            this.nmricUH.Location = new System.Drawing.Point(110, 8);
            this.nmricUH.Name = "nmricUH";
            this.nmricUH.Size = new System.Drawing.Size(80, 20);
            this.nmricUH.TabIndex = 1;
            // 
            // cboxAcomod
            // 
            this.cboxAcomod.FormattingEnabled = true;
            this.cboxAcomod.Items.AddRange(new object[] {
            "Tradicional",
            "Luxo",
            "Premium",
            "Master"});
            this.cboxAcomod.Location = new System.Drawing.Point(87, 34);
            this.cboxAcomod.Name = "cboxAcomod";
            this.cboxAcomod.Size = new System.Drawing.Size(103, 21);
            this.cboxAcomod.TabIndex = 0;
            // 
            // iconButnNovoF
            // 
            this.iconButnNovoF.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconButnNovoF.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButnNovoF.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButnNovoF.IconColor = System.Drawing.Color.Black;
            this.iconButnNovoF.IconSize = 25;
            this.iconButnNovoF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButnNovoF.Location = new System.Drawing.Point(212, 306);
            this.iconButnNovoF.Name = "iconButnNovoF";
            this.iconButnNovoF.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.iconButnNovoF.Rotation = 0D;
            this.iconButnNovoF.Size = new System.Drawing.Size(83, 37);
            this.iconButnNovoF.TabIndex = 190;
            this.iconButnNovoF.Text = "Novo";
            this.iconButnNovoF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButnNovoF.UseVisualStyleBackColor = true;
            // 
            // iconBtnExc
            // 
            this.iconBtnExc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconBtnExc.FlatAppearance.BorderSize = 0;
            this.iconBtnExc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnExc.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconBtnExc.IconColor = System.Drawing.Color.Black;
            this.iconBtnExc.IconSize = 22;
            this.iconBtnExc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnExc.Location = new System.Drawing.Point(524, 306);
            this.iconBtnExc.Name = "iconBtnExc";
            this.iconBtnExc.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.iconBtnExc.Rotation = 0D;
            this.iconBtnExc.Size = new System.Drawing.Size(83, 37);
            this.iconBtnExc.TabIndex = 189;
            this.iconBtnExc.Text = "Excluir";
            this.iconBtnExc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnExc.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconSize = 22;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(371, 306);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnEditar.Rotation = 0D;
            this.btnEditar.Size = new System.Drawing.Size(83, 37);
            this.btnEditar.TabIndex = 188;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconSize = 30;
            this.btnBuscar.Location = new System.Drawing.Point(501, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Rotation = 0D;
            this.btnBuscar.Size = new System.Drawing.Size(54, 27);
            this.btnBuscar.TabIndex = 187;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 349);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(353, 193);
            this.dataGridView1.TabIndex = 195;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Preço:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Acomodação:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Restaurante:";
            // 
            // cboxRestau
            // 
            this.cboxRestau.FormattingEnabled = true;
            this.cboxRestau.Items.AddRange(new object[] {
            "Café",
            "Meia Pensão",
            "Pensão Completa"});
            this.cboxRestau.Location = new System.Drawing.Point(87, 64);
            this.cboxRestau.Name = "cboxRestau";
            this.cboxRestau.Size = new System.Drawing.Size(103, 21);
            this.cboxRestau.TabIndex = 26;
            // 
            // dateCkeckIn
            // 
            this.dateCkeckIn.Location = new System.Drawing.Point(6, 37);
            this.dateCkeckIn.Name = "dateCkeckIn";
            this.dateCkeckIn.Size = new System.Drawing.Size(179, 20);
            this.dateCkeckIn.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Restaurante:";
            // 
            // gpBoxPeriodo
            // 
            this.gpBoxPeriodo.Controls.Add(this.dateCkeckOut);
            this.gpBoxPeriodo.Controls.Add(this.label13);
            this.gpBoxPeriodo.Controls.Add(this.label12);
            this.gpBoxPeriodo.Controls.Add(this.dateCkeckIn);
            this.gpBoxPeriodo.Location = new System.Drawing.Point(6, 91);
            this.gpBoxPeriodo.Name = "gpBoxPeriodo";
            this.gpBoxPeriodo.Size = new System.Drawing.Size(200, 114);
            this.gpBoxPeriodo.TabIndex = 30;
            this.gpBoxPeriodo.TabStop = false;
            this.gpBoxPeriodo.Text = "Período";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Check-In:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Check-Out:";
            // 
            // dateCkeckOut
            // 
            this.dateCkeckOut.Location = new System.Drawing.Point(5, 79);
            this.dateCkeckOut.Name = "dateCkeckOut";
            this.dateCkeckOut.Size = new System.Drawing.Size(179, 20);
            this.dateCkeckOut.TabIndex = 33;
            // 
            // ckLBoxServic
            // 
            this.ckLBoxServic.FormattingEnabled = true;
            this.ckLBoxServic.Items.AddRange(new object[] {
            "Wifi",
            "Arcondicionado",
            "Televisão",
            "Frigobar",
            "Estacionamento Vip",
            "Sauna",
            "Spa",
            "Banheira"});
            this.ckLBoxServic.Location = new System.Drawing.Point(276, 8);
            this.ckLBoxServic.Name = "ckLBoxServic";
            this.ckLBoxServic.Size = new System.Drawing.Size(176, 49);
            this.ckLBoxServic.TabIndex = 196;
            // 
            // FormGReserv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 603);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlOrcamento);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.iconButnNovoF);
            this.Controls.Add(this.iconBtnExc);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.placeholderTextBox1);
            this.Controls.Add(this.gridUser);
            this.Controls.Add(this.label1);
            this.Name = "FormGReserv";
            this.Text = "Gerenciar Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).EndInit();
            this.pnlOrcamento.ResumeLayout(false);
            this.pnlOrcamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmricUH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpBoxPeriodo.ResumeLayout(false);
            this.gpBoxPeriodo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private FontAwesome.Sharp.IconButton iconButnNovoF;
        private FontAwesome.Sharp.IconButton iconBtnExc;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private PlaceholderTextBox.PlaceholderTextBox placeholderTextBox1;
        private System.Windows.Forms.DataGridView gridUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer horaData;
        private System.Windows.Forms.Panel pnlOrcamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmricUH;
        private System.Windows.Forms.ComboBox cboxAcomod;
        private System.Windows.Forms.MaskedTextBox txtPreco;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtOrcam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpBoxPeriodo;
        private System.Windows.Forms.DateTimePicker dateCkeckOut;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateCkeckIn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboxRestau;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox ckLBoxServic;
    }
}