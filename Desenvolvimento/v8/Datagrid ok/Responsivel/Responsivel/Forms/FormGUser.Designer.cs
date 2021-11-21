
namespace Responsivel
{
    partial class FormGUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.btnNovoUser = new FontAwesome.Sharp.IconButton();
            this.btnDeleteUser = new FontAwesome.Sharp.IconButton();
            this.btnEditUser = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.placeholderTextBox1 = new PlaceholderTextBox.PlaceholderTextBox();
            this.gridUser = new System.Windows.Forms.DataGridView();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.horaData = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gerenciar Usuário";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(811, 140);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 156);
            this.vScrollBar1.TabIndex = 191;
            // 
            // btnNovoUser
            // 
            this.btnNovoUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNovoUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNovoUser.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnNovoUser.IconColor = System.Drawing.Color.Black;
            this.btnNovoUser.IconSize = 25;
            this.btnNovoUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoUser.Location = new System.Drawing.Point(196, 302);
            this.btnNovoUser.Name = "btnNovoUser";
            this.btnNovoUser.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnNovoUser.Rotation = 0D;
            this.btnNovoUser.Size = new System.Drawing.Size(83, 37);
            this.btnNovoUser.TabIndex = 190;
            this.btnNovoUser.Text = "Novo";
            this.btnNovoUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoUser.UseVisualStyleBackColor = true;
            this.btnNovoUser.Click += new System.EventHandler(this.btnNovoUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDeleteUser.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteUser.IconColor = System.Drawing.Color.Black;
            this.btnDeleteUser.IconSize = 22;
            this.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteUser.Location = new System.Drawing.Point(512, 302);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnDeleteUser.Rotation = 0D;
            this.btnDeleteUser.Size = new System.Drawing.Size(83, 37);
            this.btnDeleteUser.TabIndex = 189;
            this.btnDeleteUser.Text = "Excluir";
            this.btnDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEditUser.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditUser.IconColor = System.Drawing.Color.Black;
            this.btnEditUser.IconSize = 22;
            this.btnEditUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditUser.Location = new System.Drawing.Point(356, 302);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnEditUser.Rotation = 0D;
            this.btnEditUser.Size = new System.Drawing.Size(83, 37);
            this.btnEditUser.TabIndex = 188;
            this.btnEditUser.Text = "Editar";
            this.btnEditUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditUser.UseVisualStyleBackColor = true;
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
            this.btnBuscar.Location = new System.Drawing.Point(481, 85);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Rotation = 0D;
            this.btnBuscar.Size = new System.Drawing.Size(54, 27);
            this.btnBuscar.TabIndex = 187;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // placeholderTextBox1
            // 
            this.placeholderTextBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox1.Location = new System.Drawing.Point(41, 84);
            this.placeholderTextBox1.Name = "placeholderTextBox1";
            this.placeholderTextBox1.PlaceholderText = "Buscar...";
            this.placeholderTextBox1.Size = new System.Drawing.Size(439, 27);
            this.placeholderTextBox1.TabIndex = 186;
            // 
            // gridUser
            // 
            this.gridUser.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Maroon;
            this.gridUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUser.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridUser.ColumnHeadersHeight = 30;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUser.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridUser.GridColor = System.Drawing.Color.Gainsboro;
            this.gridUser.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.gridUser.Location = new System.Drawing.Point(12, 140);
            this.gridUser.Name = "gridUser";
            this.gridUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridUser.RowHeadersVisible = false;
            this.gridUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.gridUser.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.gridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUser.Size = new System.Drawing.Size(796, 156);
            this.gridUser.TabIndex = 185;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblHora.Location = new System.Drawing.Point(351, 472);
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
            this.lblData.Location = new System.Drawing.Point(351, 497);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(72, 25);
            this.lblData.TabIndex = 192;
            this.lblData.Text = "lblData";
            // 
            // horaData
            // 
            this.horaData.Enabled = true;
            this.horaData.Tick += new System.EventHandler(this.horaData_Tick_1);
            // 
            // FormGUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 569);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btnNovoUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.placeholderTextBox1);
            this.Controls.Add(this.gridUser);
            this.Controls.Add(this.label1);
            this.Name = "FormGUser";
            this.Text = "Gerenciar Usuário";
            this.Load += new System.EventHandler(this.FormGUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private FontAwesome.Sharp.IconButton btnNovoUser;
        private FontAwesome.Sharp.IconButton btnDeleteUser;
        private FontAwesome.Sharp.IconButton btnEditUser;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private PlaceholderTextBox.PlaceholderTextBox placeholderTextBox1;
        private System.Windows.Forms.DataGridView gridUser;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer horaData;
    }
}