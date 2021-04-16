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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Ent_B_Click(object sender, EventArgs e)
        {
            try
            {
                using (UserContext db = new UserContext())
                {
                    User user = new User { Login = login_TBAvtor.Text.Trim(), Password = Pas_TBAvtor.Text.Trim() };

                    User usercontext = db.Users.FirstOrDefault(u => u.Login == user.Login && u.Password == user.Password);

                    if (usercontext != null)
                    {
                        Message message = new Message();
                        message.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Введен неправильно логин или пароль", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CH_B_CheckedChanged(object sender, EventArgs e)
        {
            Pas_TBAvtor.UseSystemPasswordChar = !CH_B.Checked;
        }
    }
}
