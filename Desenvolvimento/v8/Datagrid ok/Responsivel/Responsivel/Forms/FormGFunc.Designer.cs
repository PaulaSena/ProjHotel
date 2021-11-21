
using System;
using System.Windows.Forms;

namespace Responsivel
{
    partial class FormGFunc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.gridFunc = new System.Windows.Forms.DataGridView();
            this.placeholderTextBox1 = new PlaceholderTextBox.PlaceholderTextBox();
            this.btnConsultar = new FontAwesome.Sharp.IconButton();
            this.iconBtnEdit = new FontAwesome.Sharp.IconButton();
            this.iconBtnExc = new FontAwesome.Sharp.IconButton();
            this.iconButnNovoF = new FontAwesome.Sharp.IconButton();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.horaData = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gerenciar Funcionário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gridFunc
            // 
            this.gridFunc.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            this.gridFunc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridFunc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFunc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridFunc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridFunc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFunc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridFunc.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFunc.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridFunc.GridColor = System.Drawing.Color.Gainsboro;
            this.gridFunc.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.gridFunc.Location = new System.Drawing.Point(12, 112);
            this.gridFunc.Name = "gridFunc";
            this.gridFunc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFunc.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridFunc.RowHeadersVisible = false;
            this.gridFunc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.gridFunc.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.gridFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFunc.Size = new System.Drawing.Size(796, 156);
            this.gridFunc.TabIndex = 3;
            this.gridFunc.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUser_CellContentDoubleClick);
            this.gridFunc.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.GridUser_RowsAdded);
            // 
            // placeholderTextBox1
            // 
            this.placeholderTextBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox1.Location = new System.Drawing.Point(41, 56);
            this.placeholderTextBox1.Name = "placeholderTextBox1";
            this.placeholderTextBox1.PlaceholderText = "Buscar...";
            this.placeholderTextBox1.Size = new System.Drawing.Size(439, 27);
            this.placeholderTextBox1.TabIndex = 9;
            this.placeholderTextBox1.TextChanged += new System.EventHandler(this.PlaceholderTextBox1_TextChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnConsultar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnConsultar.IconColor = System.Drawing.Color.Black;
            this.btnConsultar.IconSize = 30;
            this.btnConsultar.Location = new System.Drawing.Point(481, 57);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Rotation = 0D;
            this.btnConsultar.Size = new System.Drawing.Size(54, 27);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // iconBtnEdit
            // 
            this.iconBtnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconBtnEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconBtnEdit.IconColor = System.Drawing.Color.Black;
            this.iconBtnEdit.IconSize = 22;
            this.iconBtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnEdit.Location = new System.Drawing.Point(356, 274);
            this.iconBtnEdit.Name = "iconBtnEdit";
            this.iconBtnEdit.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.iconBtnEdit.Rotation = 0D;
            this.iconBtnEdit.Size = new System.Drawing.Size(83, 37);
            this.iconBtnEdit.TabIndex = 181;
            this.iconBtnEdit.Text = "Editar";
            this.iconBtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnEdit.UseVisualStyleBackColor = true;
            this.iconBtnEdit.Click += new System.EventHandler(this.IconButnEdit_Click);
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
            this.iconBtnExc.Location = new System.Drawing.Point(512, 274);
            this.iconBtnExc.Name = "iconBtnExc";
            this.iconBtnExc.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.iconBtnExc.Rotation = 0D;
            this.iconBtnExc.Size = new System.Drawing.Size(83, 37);
            this.iconBtnExc.TabIndex = 182;
            this.iconBtnExc.Text = "Excluir";
            this.iconBtnExc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnExc.UseVisualStyleBackColor = true;
            this.iconBtnExc.Click += new System.EventHandler(this.IconBtnExc_Click);
            // 
            // iconButnNovoF
            // 
            this.iconButnNovoF.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconButnNovoF.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButnNovoF.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButnNovoF.IconColor = System.Drawing.Color.Black;
            this.iconButnNovoF.IconSize = 25;
            this.iconButnNovoF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButnNovoF.Location = new System.Drawing.Point(196, 274);
            this.iconButnNovoF.Name = "iconButnNovoF";
            this.iconButnNovoF.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.iconButnNovoF.Rotation = 0D;
            this.iconButnNovoF.Size = new System.Drawing.Size(83, 37);
            this.iconButnNovoF.TabIndex = 183;
            this.iconButnNovoF.Text = "Novo";
            this.iconButnNovoF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButnNovoF.UseVisualStyleBackColor = true;
            this.iconButnNovoF.Click += new System.EventHandler(this.IconButnNovoF_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(811, 112);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 156);
            this.vScrollBar1.TabIndex = 184;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar1_Scroll);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblHora.Location = new System.Drawing.Point(366, 478);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(73, 25);
            this.lblHora.TabIndex = 186;
            this.lblHora.Text = "lblHora";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblData.Location = new System.Drawing.Point(366, 503);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(72, 25);
            this.lblData.TabIndex = 185;
            this.lblData.Text = "lblData";
            // 
            // horaData
            // 
            this.horaData.Enabled = true;
            this.horaData.Tick += new System.EventHandler(this.horaData_Tick_1);
            // 
            // FormGFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 569);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.iconButnNovoF);
            this.Controls.Add(this.iconBtnExc);
            this.Controls.Add(this.iconBtnEdit);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.placeholderTextBox1);
            this.Controls.Add(this.gridFunc);
            this.Controls.Add(this.label1);
            this.Name = "FormGFunc";
            this.Text = "Gerenciar Funcionário";
            this.Load += new System.EventHandler(this.FormGFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void gridUser_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridFunc;
        private PlaceholderTextBox.PlaceholderTextBox placeholderTextBox1;
        private FontAwesome.Sharp.IconButton btnConsultar;
        private FontAwesome.Sharp.IconButton iconBtnEdit;
        private FontAwesome.Sharp.IconButton iconBtnExc;
        private FontAwesome.Sharp.IconButton iconButnNovoF;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private Label lblHora;
        private Label lblData;
        private Timer horaData;
    }
}