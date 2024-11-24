using Microsoft.Extensions.DependencyInjection;
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
    public partial class AnswerProyectClient : Form
    {
        private readonly IServiceProvider _servicesProvider;
        public AnswerProyectClient(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _servicesProvider = serviceProvider;
        }

        private void iconButtonRefusedProject_Click(object sender, EventArgs e)
        {
            
        }
    }
}
