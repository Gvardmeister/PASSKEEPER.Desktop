
namespace PASSKEEPER.Desktop.Views
{
    partial class MessageText
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
            this.TLP_1 = new System.Windows.Forms.TableLayoutPanel();
            this.Cancel_B = new System.Windows.Forms.Button();
            this.Save_B = new System.Windows.Forms.Button();
            this.TB_message = new System.Windows.Forms.TextBox();
            this.TLP_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP_1
            // 
            this.TLP_1.ColumnCount = 2;
            this.TLP_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TLP_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TLP_1.Controls.Add(this.Cancel_B, 1, 2);
            this.TLP_1.Controls.Add(this.Save_B, 1, 1);
            this.TLP_1.Controls.Add(this.TB_message, 0, 0);
            this.TLP_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_1.Location = new System.Drawing.Point(0, 0);
            this.TLP_1.Name = "TLP_1";
            this.TLP_1.RowCount = 4;
            this.TLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_1.Size = new System.Drawing.Size(511, 372);
            this.TLP_1.TabIndex = 0;
            // 
            // Cancel_B
            // 
            this.Cancel_B.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancel_B.Location = new System.Drawing.Point(360, 189);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Size = new System.Drawing.Size(148, 30);
            this.Cancel_B.TabIndex = 3;
            this.Cancel_B.Text = "&Отмена";
            this.Cancel_B.UseVisualStyleBackColor = true;
            // 
            // Save_B
            // 
            this.Save_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Save_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Save_B.Location = new System.Drawing.Point(360, 153);
            this.Save_B.Name = "Save_B";
            this.Save_B.Size = new System.Drawing.Size(148, 30);
            this.Save_B.TabIndex = 2;
            this.Save_B.Text = "&Сохранить";
            this.Save_B.UseVisualStyleBackColor = true;
            this.Save_B.Click += new System.EventHandler(this.Save_B_Click);
            // 
            // TB_message
            // 
            this.TB_message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_message.Location = new System.Drawing.Point(3, 3);
            this.TB_message.Multiline = true;
            this.TB_message.Name = "TB_message";
            this.TLP_1.SetRowSpan(this.TB_message, 4);
            this.TB_message.Size = new System.Drawing.Size(351, 366);
            this.TB_message.TabIndex = 4;
            // 
            // MessageText
            // 
            this.AcceptButton = this.Save_B;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.Cancel_B;
            this.ClientSize = new System.Drawing.Size(511, 372);
            this.Controls.Add(this.TLP_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageText";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сообщение пользователя";
            this.TLP_1.ResumeLayout(false);
            this.TLP_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_1;
        private System.Windows.Forms.Button Save_B;
        private System.Windows.Forms.Button Cancel_B;
        public System.Windows.Forms.TextBox TB_message;
    }
}