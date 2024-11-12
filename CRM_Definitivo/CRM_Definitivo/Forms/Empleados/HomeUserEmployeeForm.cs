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

namespace PresentationLayer.Forms.Empleados
{
    public partial class HomeUserEmployeeForm : Form
    {
        public HomeUserEmployeeForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            labelUserAccount.Text = AuthUser.UserAccount;
            lblHoraUsuario.Text = DateTime.Now.ToString("g");
        }
    }
}
