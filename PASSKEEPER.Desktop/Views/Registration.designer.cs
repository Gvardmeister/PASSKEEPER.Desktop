
namespace PASSKEEPER.Desktop.Views
{
    partial class Registration
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.Login_L = new System.Windows.Forms.Label();
            this.Password_L = new System.Windows.Forms.Label();
            this.Login_TB = new System.Windows.Forms.TextBox();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.Registration_L = new System.Windows.Forms.Label();
            this.Login_B = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Aut_B = new System.Windows.Forms.Button();
            this.CH_B = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_L
            // 
            this.Login_L.AutoSize = true;
            this.Login_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_L.Location = new System.Drawing.Point(10, 50);
            this.Login_L.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Login_L.Name = "Login_L";
            this.Login_L.Size = new System.Drawing.Size(107, 13);
            this.Login_L.TabIndex = 1;
            this.Login_L.Text = "Введите ваш логин:";
            // 
            // Password_L
            // 
            this.Password_L.AutoSize = true;
            this.Password_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_L.Location = new System.Drawing.Point(10, 95);
            this.Password_L.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Password_L.Name = "Password_L";
            this.Password_L.Size = new System.Drawing.Size(91, 13);
            this.Password_L.TabIndex = 3;
            this.Password_L.Text = "Введите пароль:";
            // 
            // Login_TB
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Login_TB, 2);
            this.Login_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_TB.Location = new System.Drawing.Point(10, 69);
            this.Login_TB.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Login_TB.Name = "Login_TB";
            this.Login_TB.Size = new System.Drawing.Size(579, 20);
            this.Login_TB.TabIndex = 2;
            // 
            // Password_TB
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Password_TB, 2);
            this.Password_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Password_TB.Location = new System.Drawing.Point(10, 118);
            this.Password_TB.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.Size = new System.Drawing.Size(579, 20);
            this.Password_TB.TabIndex = 4;
            this.Password_TB.UseSystemPasswordChar = true;
            // 
            // Registration_L
            // 
            this.Registration_L.AutoSize = true;
            this.Registration_L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.Registration_L, 2);
            this.Registration_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Registration_L.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registration_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration_L.Location = new System.Drawing.Point(10, 5);
            this.Registration_L.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Registration_L.Name = "Registration_L";
            this.Registration_L.Padding = new System.Windows.Forms.Padding(5);
            this.Registration_L.Size = new System.Drawing.Size(579, 37);
            this.Registration_L.TabIndex = 0;
            this.Registration_L.Text = "Регистрация";
            this.Registration_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_B
            // 
            this.Login_B.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_B.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Login_B.Location = new System.Drawing.Point(10, 144);
            this.Login_B.Margin = new System.Windows.Forms.Padding(10, 3, 5, 3);
            this.Login_B.Name = "Login_B";
            this.Login_B.Size = new System.Drawing.Size(164, 30);
            this.Login_B.TabIndex = 5;
            this.Login_B.Text = "&Зарегистрироваться";
            this.Login_B.UseVisualStyleBackColor = false;
            this.Login_B.Click += new System.EventHandler(this.Login_B_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.Registration_L, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Login_B, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Password_TB, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Password_L, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Login_TB, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Login_L, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Aut_B, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.CH_B, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(599, 176);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Aut_B
            // 
            this.Aut_B.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Aut_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Aut_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Aut_B.Location = new System.Drawing.Point(179, 144);
            this.Aut_B.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.Aut_B.Name = "Aut_B";
            this.Aut_B.Size = new System.Drawing.Size(410, 30);
            this.Aut_B.TabIndex = 6;
            this.Aut_B.Text = "&Авторизоваться";
            this.Aut_B.UseVisualStyleBackColor = false;
            this.Aut_B.Click += new System.EventHandler(this.Aut_B_Click);
            // 
            // CH_B
            // 
            this.CH_B.AutoSize = true;
            this.CH_B.Location = new System.Drawing.Point(182, 95);
            this.CH_B.Name = "CH_B";
            this.CH_B.Size = new System.Drawing.Size(125, 17);
            this.CH_B.TabIndex = 7;
            this.CH_B.Text = "&Отобразить пароль";
            this.CH_B.UseVisualStyleBackColor = true;
            this.CH_B.CheckedChanged += new System.EventHandler(this.CH_B_CheckedChanged);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(599, 176);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Password_TB;
        private System.Windows.Forms.Label Registration_L;
        private System.Windows.Forms.Label Login_L;
        private System.Windows.Forms.Label Password_L;
        private System.Windows.Forms.Button Login_B;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Login_TB;
        private System.Windows.Forms.Button Aut_B;
        private System.Windows.Forms.CheckBox CH_B;
    }
}

