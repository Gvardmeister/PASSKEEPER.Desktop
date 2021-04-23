using PASSKEEPER.Desktop.Infrastructure;
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
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();

            context = new Infrastructure.UserContext();

            InitializeListOfMessage();
        }

        private Infrastructure.UserContext context;
        private SortableBindingList<Models.Message> Messages;

        private void InitializeListOfMessage()
        {
            Messages = new SortableBindingList<Models.Message>(context.Messages.ToList());

            List_DGV.DataSource = Messages;
        }

        private void Message_Load(object sender, EventArgs e)
        {

        }

        private void Add_B_Click(object sender, EventArgs e)
        {
            try
            {
                MessageText messageText = new MessageText();

                if (messageText.ShowDialog() == DialogResult.OK)
                { 
                    using (UserContext db = new UserContext())
                    {
                        Models.Message message = new Models.Message { Text = messageText.TB_message.Text };

                        db.Messages.Add(message);
                        db.SaveChanges();

                        Messages.Add(message);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Update_B_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Delete_B_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите удалить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                //    Model modelDB = List_DGV.CurrentRow.DataBoundItem as Model;

                //    _context.Models.Remove(modelDB);
                //    _context.SaveChanges();

                //    Models.Remove(modelDB);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Exit_B_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
