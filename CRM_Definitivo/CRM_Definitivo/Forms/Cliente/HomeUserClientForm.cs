using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms.Cliente
{
    public partial class HomeUserClientForm : Form
    {
        public HomeUserClientForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            userAccountLabel.Text = AuthUser.UserAccount;
            timeLabel.Text = DateTime.Now.ToString("g");
        }
    }
}
