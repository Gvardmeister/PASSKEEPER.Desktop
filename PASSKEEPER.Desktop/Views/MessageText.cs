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

        private void MessageText_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    String Text = TB_message.Text.Trim();

                    if (String.IsNullOrWhiteSpace(Text))
                    {
                        throw new Exception("Сообщение не может быть пустым");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }
    }
}
