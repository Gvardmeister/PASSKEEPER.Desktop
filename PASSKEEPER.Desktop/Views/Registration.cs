using PASSKEEPER.Desktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASSKEEPER.Desktop.Views
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Login_B_Click(object sender, EventArgs e)
        {
            try 
            {
                String Login = Login_TB.Text.Trim();

                if (String.IsNullOrWhiteSpace(Login))
                {
                    throw new Exception("Логин должнен содержать значение");
                }

                String Password = Password_TB.Text.Trim();

                if (String.IsNullOrWhiteSpace(Password))
                {
                    throw new Exception("Пароль должнен содержать значение");
                }

                using (UserContext db = new UserContext())
                {
                    User user = new User { Login = Login_TB.Text.Trim(), Password = Password_TB.Text.Trim() };

                    User uservalid = db.Users.FirstOrDefault(u => u.Login == user.Login);

                    if (uservalid == null)
                    {
                        db.Users.Add(user);
                        db.SaveChanges();

                        MessageBox.Show("Пользователь успешно зарегистрирован", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Aut_B_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.ShowDialog();

            //Program.applicationContext.MainForm = new Authorization();
            //Program.applicationContext.MainForm.Show();
        }

        private void CH_B_CheckedChanged(object sender, EventArgs e)
        {
            Password_TB.UseSystemPasswordChar = !CH_B.Checked;
        }
    }
}
