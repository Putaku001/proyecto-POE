﻿using BusinessLayer.Services.InterfacesServices;
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
        public string codeProyect { get; set; }
        public string Description { get; set; }
        public string nameProject { get; set; }

        private readonly IServiceProvider _servicesProvider;
        private readonly IProyectsServices _proyectsServices;
        public AnswerProyectClient(IServiceProvider serviceProvider, IProyectsServices _proyectServices)
        {
            InitializeComponent();
            _servicesProvider = serviceProvider;
            _proyectsServices = _proyectServices;
            
        }
        private void AnswerProyectClient_Load(object sender, EventArgs e)
        {
            textBoxDescriptionProject.Text = Description;
            labelCodeProject.Text = codeProyect;
            labelNameProject.Text = nameProject;
        }
       
        private void iconButtonRefusedProject_Click(object sender, EventArgs e)
        {
            _proyectsServices.StatusProject(codeProyect, 8);
            MessageBox.Show($"El Proyecto '{nameProject}' a sido Rechazado");
            this.Close();
        }

        private void IconButtonApprovedProject_Click(object sender, EventArgs e)
        {
            _proyectsServices.StatusProject(codeProyect, 9);
            MessageBox.Show($"El Proyecto '{nameProject}' a sido Aceptado");
            this.Close();
        }

        
    }
}