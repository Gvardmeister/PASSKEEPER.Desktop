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
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
        }

        private void Add_B_Click(object sender, EventArgs e)
        {
            MessageText messageText = new MessageText();

            messageText.ShowDialog();
        }

        private void Update_B_Click(object sender, EventArgs e)
        {

        }

        private void Delete_B_Click(object sender, EventArgs e)
        {

        }

        private void Exit_B_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
