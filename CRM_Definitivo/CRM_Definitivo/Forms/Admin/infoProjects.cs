using BusinessLayer.Services.InterfacesServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms.Admin
{
    public partial class infoProjects : Form
    {
        public string codeProject { get; set; }
        private int idTasks;

        private readonly IProyectsServices _proyectsServices;
        public infoProjects(IProyectsServices proyectsServices)
        {
            _proyectsServices = proyectsServices;
            InitializeComponent();
        }

        
        private void infoProjects_Load(object sender, EventArgs e)
        {
            dataGridViewGetTask.DataSource = _proyectsServices.GetTasksByCode(codeProject);
            dataGridViewGetTask.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGetTask.Columns["idTask"].Visible = false;
            dataGridViewGetTask.Columns["idStatusTask"].Visible = false;
            dataGridViewGetTask.Columns["dateEnd"].Visible = false;
            dataGridViewGetTask.Columns["fileTask"].Visible = false;
        }

        private void dataGridViewGetTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBoxDescription.Text = dataGridViewGetTask.Rows[e.RowIndex].Cells["descriptionTask"].Value.ToString();
                textBoxTask.Text = dataGridViewGetTask.Rows[e.RowIndex].Cells["nameTask"].Value.ToString();

                linkLabelDownloadTask.Visible = true;
            }

            var idtaskSelected = dataGridViewGetTask.Rows[e.RowIndex].Cells["idTask"].Value.ToString();
            idTasks = Convert.ToInt32(idtaskSelected);
        }


        private void linkLabelDownloadTask_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {            
                int idTask = idTasks;
                byte[] content = _proyectsServices.DownloadTask(idTask);

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    FileName = "Tarea",
                    Filter = "Todos los archivos|*.*"
                };

                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    File.WriteAllBytes(filePath, content);

                    MessageBox.Show("Tarea descargada correctamente");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en la descargar la tarea: " + ex.Message);
            }
        }        
    }
}
