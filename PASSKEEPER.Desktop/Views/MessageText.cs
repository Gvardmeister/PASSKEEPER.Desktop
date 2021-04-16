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
    public partial class MessageText : Form
    {
        public MessageText()
        {
            InitializeComponent();
        }

        private void Save_B_Click(object sender, EventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                Message message = new Message { Text = TB_message.Text };

                //db.Messages.Add(message);
                db.SaveChanges();
            }
        }
    }
}
