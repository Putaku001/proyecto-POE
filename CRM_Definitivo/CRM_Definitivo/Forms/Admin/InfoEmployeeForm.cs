using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Services.Interfaces;
using CommonLayer.Entities;
using FluentValidation;
using FluentValidation.Results;
using PresentationLayer.Validations;

namespace PresentationLayer.Forms.Admin
{
    public partial class InfoEmployeeForm : Form
    {
        public InfoEmployeeForm()
        {
            InitializeComponent();
        }

        private void iconSaveInformationButton_Click(object sender, EventArgs e)
        {
            try
            {

                var informationEmployee = new Employee
                {
                    comment = professionsTextBox.Text,
                    workStation = workStationTextBox.Text
                };

                InformationEmployeeValidation employeeValidation = new InformationEmployeeValidation();
                ValidationResult validationResult = employeeValidation.Validate(informationEmployee);

                if (!validationResult.IsValid)
                {
                    DisplayValidationErrors(validationResult);
                    return;
                }

                MessageBox.Show("Las validaciones son correctas. La información no ha sido guardada en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                workStationTextBox.Clear();
                professionsTextBox.Clear();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show($"Error de validación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DisplayValidationErrors(ValidationResult result)
        {
            errorValidation.Clear();
            ResetErrorLabels();

            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(Employee.comment):
                        errorValidation.SetError(professionsTextBox, error.ErrorMessage);
                        errorProfessionLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(Employee.workStation):
                        errorValidation.SetError(workStationTextBox, error.ErrorMessage);
                        errorWorkStationLabel.Text = error.ErrorMessage;
                        break;
                    default:
                        Console.WriteLine($"Error en un campo no reconocido: {error.PropertyName}");
                        break;
                }
            }
        }

        private void ResetErrorLabels()
        {
            errorProfessionLabel.Text = string.Empty;
            errorWorkStationLabel.Text = string.Empty;

            errorValidation.SetError(professionsTextBox, string.Empty);
            errorValidation.SetError(workStationTextBox, string.Empty);
        }

    }
}
