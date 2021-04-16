
namespace PASSKEEPER.Desktop.Views
{
    partial class Message
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.List_DGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spisok_L = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Exit_B = new System.Windows.Forms.Button();
            this.Delete_B = new System.Windows.Forms.Button();
            this.Update_B = new System.Windows.Forms.Button();
            this.Add_B = new System.Windows.Forms.Button();
            this.Description_LHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.List_DGV)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Controls.Add(this.List_DGV, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.Spisok_L, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.Description_LHeader, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1021, 600);
            this.tableLayoutPanel4.TabIndex = 18;
            // 
            // List_DGV
            // 
            this.List_DGV.AllowUserToAddRows = false;
            this.List_DGV.AllowUserToDeleteRows = false;
            this.List_DGV.AllowUserToResizeColumns = false;
            this.List_DGV.AllowUserToResizeRows = false;
            this.List_DGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.List_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.List_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Login,
            this.Message1});
            this.List_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_DGV.Location = new System.Drawing.Point(5, 55);
            this.List_DGV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.List_DGV.MultiSelect = false;
            this.List_DGV.Name = "List_DGV";
            this.List_DGV.ReadOnly = true;
            this.List_DGV.RowHeadersVisible = false;
            this.List_DGV.RowHeadersWidth = 51;
            this.List_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.List_DGV.Size = new System.Drawing.Size(704, 540);
            this.List_DGV.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "Идентифкатор";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Login
            // 
            this.Login.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Login.DataPropertyName = "Login";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Login.DefaultCellStyle = dataGridViewCellStyle3;
            this.Login.HeaderText = "Логин";
            this.Login.MinimumWidth = 6;
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // Message1
            // 
            this.Message1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Message1.DataPropertyName = "Name";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Message1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Message1.HeaderText = "Сообщение";
            this.Message1.MinimumWidth = 6;
            this.Message1.Name = "Message1";
            this.Message1.ReadOnly = true;
            this.Message1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Spisok_L
            // 
            this.Spisok_L.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Spisok_L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Spisok_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spisok_L.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Spisok_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Spisok_L.Location = new System.Drawing.Point(5, 5);
            this.Spisok_L.Margin = new System.Windows.Forms.Padding(5);
            this.Spisok_L.Name = "Spisok_L";
            this.Spisok_L.Padding = new System.Windows.Forms.Padding(3);
            this.Spisok_L.Size = new System.Drawing.Size(704, 45);
            this.Spisok_L.TabIndex = 0;
            this.Spisok_L.Text = "Информация";
            this.Spisok_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.Exit_B, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.Delete_B, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.Update_B, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.Add_B, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(714, 55);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(307, 545);
            this.tableLayoutPanel5.TabIndex = 18;
            // 
            // Exit_B
            // 
            this.Exit_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel5.SetColumnSpan(this.Exit_B, 2);
            this.Exit_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exit_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_B.Location = new System.Drawing.Point(0, 498);
            this.Exit_B.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(302, 42);
            this.Exit_B.TabIndex = 14;
            this.Exit_B.Text = "&Выход";
            this.Exit_B.UseVisualStyleBackColor = false;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            // 
            // Delete_B
            // 
            this.Delete_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel5.SetColumnSpan(this.Delete_B, 2);
            this.Delete_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_B.Location = new System.Drawing.Point(0, 78);
            this.Delete_B.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Delete_B.Name = "Delete_B";
            this.Delete_B.Size = new System.Drawing.Size(302, 34);
            this.Delete_B.TabIndex = 13;
            this.Delete_B.Text = "&Удалить";
            this.Delete_B.UseVisualStyleBackColor = false;
            this.Delete_B.Click += new System.EventHandler(this.Delete_B_Click);
            // 
            // Update_B
            // 
            this.Update_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel5.SetColumnSpan(this.Update_B, 2);
            this.Update_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Update_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update_B.Location = new System.Drawing.Point(0, 39);
            this.Update_B.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Update_B.Name = "Update_B";
            this.Update_B.Size = new System.Drawing.Size(302, 34);
            this.Update_B.TabIndex = 12;
            this.Update_B.Text = "&Изменить";
            this.Update_B.UseVisualStyleBackColor = false;
            this.Update_B.Click += new System.EventHandler(this.Update_B_Click);
            // 
            // Add_B
            // 
            this.Add_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel5.SetColumnSpan(this.Add_B, 2);
            this.Add_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_B.Location = new System.Drawing.Point(0, 0);
            this.Add_B.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(302, 34);
            this.Add_B.TabIndex = 11;
            this.Add_B.Text = "&Добавить";
            this.Add_B.UseVisualStyleBackColor = false;
            this.Add_B.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Description_LHeader
            // 
            this.Description_LHeader.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Description_LHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Description_LHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description_LHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Description_LHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description_LHeader.Location = new System.Drawing.Point(714, 5);
            this.Description_LHeader.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.Description_LHeader.Name = "Description_LHeader";
            this.Description_LHeader.Padding = new System.Windows.Forms.Padding(3);
            this.Description_LHeader.Size = new System.Drawing.Size(302, 45);
            this.Description_LHeader.TabIndex = 1;
            this.Description_LHeader.Text = "ФункциАнал ";
            this.Description_LHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1021, 600);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сведения";
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.List_DGV)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView List_DGV;
        private System.Windows.Forms.Label Spisok_L;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button Exit_B;
        private System.Windows.Forms.Button Delete_B;
        private System.Windows.Forms.Button Update_B;
        private System.Windows.Forms.Button Add_B;
        private System.Windows.Forms.Label Description_LHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message1;
    }
}