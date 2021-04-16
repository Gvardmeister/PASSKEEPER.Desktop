
namespace PASSKEEPER.Desktop.Views
{
    partial class Authorization
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
            this.Ent_B = new System.Windows.Forms.Button();
            this.Log_L = new System.Windows.Forms.Label();
            this.Pas_L = new System.Windows.Forms.Label();
            this.login_TBAvtor = new System.Windows.Forms.TextBox();
            this.Pas_TBAvtor = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CH_B = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ent_B
            // 
            this.Ent_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(107)))), ((int)(((byte)(3)))));
            this.Ent_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ent_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ent_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ent_B.ForeColor = System.Drawing.Color.White;
            this.Ent_B.Location = new System.Drawing.Point(10, 101);
            this.Ent_B.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Ent_B.Name = "Ent_B";
            this.Ent_B.Size = new System.Drawing.Size(117, 30);
            this.Ent_B.TabIndex = 4;
            this.Ent_B.Text = "&Вход";
            this.Ent_B.UseVisualStyleBackColor = false;
            this.Ent_B.Click += new System.EventHandler(this.Ent_B_Click);
            // 
            // Log_L
            // 
            this.Log_L.AutoSize = true;
            this.Log_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_L.Location = new System.Drawing.Point(12, 5);
            this.Log_L.Margin = new System.Windows.Forms.Padding(12, 5, 12, 3);
            this.Log_L.Name = "Log_L";
            this.Log_L.Size = new System.Drawing.Size(113, 15);
            this.Log_L.TabIndex = 0;
            this.Log_L.Text = "Логин";
            // 
            // Pas_L
            // 
            this.Pas_L.AutoSize = true;
            this.Pas_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pas_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pas_L.Location = new System.Drawing.Point(12, 52);
            this.Pas_L.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.Pas_L.Name = "Pas_L";
            this.Pas_L.Size = new System.Drawing.Size(113, 17);
            this.Pas_L.TabIndex = 2;
            this.Pas_L.Text = "Пароль:";
            // 
            // login_TBAvtor
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.login_TBAvtor, 2);
            this.login_TBAvtor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_TBAvtor.Location = new System.Drawing.Point(10, 26);
            this.login_TBAvtor.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.login_TBAvtor.Name = "login_TBAvtor";
            this.login_TBAvtor.Size = new System.Drawing.Size(255, 20);
            this.login_TBAvtor.TabIndex = 1;
            // 
            // Pas_TBAvtor
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Pas_TBAvtor, 2);
            this.Pas_TBAvtor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pas_TBAvtor.Location = new System.Drawing.Point(10, 75);
            this.Pas_TBAvtor.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Pas_TBAvtor.Name = "Pas_TBAvtor";
            this.Pas_TBAvtor.Size = new System.Drawing.Size(255, 20);
            this.Pas_TBAvtor.TabIndex = 3;
            this.Pas_TBAvtor.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Log_L, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Pas_TBAvtor, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Ent_B, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.login_TBAvtor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Pas_L, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CH_B, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(275, 137);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // CH_B
            // 
            this.CH_B.AutoSize = true;
            this.CH_B.Location = new System.Drawing.Point(140, 52);
            this.CH_B.Name = "CH_B";
            this.CH_B.Size = new System.Drawing.Size(125, 17);
            this.CH_B.TabIndex = 5;
            this.CH_B.Text = "&Отобразить пароль";
            this.CH_B.UseVisualStyleBackColor = true;
            this.CH_B.CheckedChanged += new System.EventHandler(this.CH_B_CheckedChanged);
            // 
            // Authorization
            // 
            this.AcceptButton = this.Ent_B;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(275, 137);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authorization";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ent_B;
        private System.Windows.Forms.Label Log_L;
        private System.Windows.Forms.Label Pas_L;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TextBox login_TBAvtor;
        public System.Windows.Forms.TextBox Pas_TBAvtor;
        private System.Windows.Forms.CheckBox CH_B;
    }
}