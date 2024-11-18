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
    public partial class InforProjectsClient : Form
    {
        private readonly IServiceProvider _servicesProvider;
        public InforProjectsClient(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _servicesProvider = serviceProvider;
        }

        private void iconButtonRefusedProject_Click(object sender, EventArgs e)
        {
            var OpenRefusedForm = _servicesProvider.GetRequiredService<RefusedProjectClient>();
            OpenRefusedForm.ShowDialog();
        }
    }
}
