
namespace Responsivel
{
    partial class FormDelDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDelDados));
            this.lblDelCadastro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtBoxDeseja = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDelCadastro
            // 
            this.lblDelCadastro.AutoSize = true;
            this.lblDelCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblDelCadastro.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelCadastro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDelCadastro.Location = new System.Drawing.Point(195, 38);
            this.lblDelCadastro.Name = "lblDelCadastro";
            this.lblDelCadastro.Size = new System.Drawing.Size(176, 34);
            this.lblDelCadastro.TabIndex = 170;
            this.lblDelCadastro.Text = "EXCLUIR DADOS";
            this.lblDelCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDelCadastro.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDel.Location = new System.Drawing.Point(171, 316);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(225, 39);
            this.btnDel.TabIndex = 172;
            this.btnDel.Text = "EXCLUIR";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // txtBoxDeseja
            // 
            this.txtBoxDeseja.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxDeseja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDeseja.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDeseja.Location = new System.Drawing.Point(55, 97);
            this.txtBoxDeseja.Multiline = true;
            this.txtBoxDeseja.Name = "txtBoxDeseja";
            this.txtBoxDeseja.Size = new System.Drawing.Size(456, 170);
            this.txtBoxDeseja.TabIndex = 173;
            this.txtBoxDeseja.Text = resources.GetString("txtBoxDeseja.Text");
            // 
            // FormDelDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(567, 415);
            this.Controls.Add(this.txtBoxDeseja);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDelCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormDelDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Deletar Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDelCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtBoxDeseja;
    }
}