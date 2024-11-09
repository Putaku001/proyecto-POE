﻿using BusinessLayer.Services.Interfaces;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Reports
{
    public class UserReports : IUserReports
    {
        private IUsersServices _userServices;

        public UserReports(IUsersServices userServices)
        {
            _userServices = userServices;
        }
        public void GenerateReports()
        {
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(1, Unit.Centimetre);
                    page.Size(PageSizes.A4);

                    page.Header().Element(ComposeHeader);
                    page.Content().Element(ComposeContent);
                });
            });

            document.GeneratePdfAndShow();
        }

        private void ComposeHeader(IContainer container)
        {
            container.Row(Row =>
            {
                Row.ConstantItem(75).Height(50).Text($"{DateTime.Now.ToShortDateString()}");

                Row.ConstantItem(375)
                .Height(50)
                .Text("Reporte De Usuarios")
                .AlignCenter()
                .FontSize(24)
                .FontColor(Colors.Black);

                Row.ConstantItem(50).Height(50).Placeholder();
            });
        }

        private void ComposeContent(IContainer container)
        {
            container.PaddingVertical(80).Column(column =>
            {
                column.Spacing(5);
                column.Item().Element(ComposeTable);
            });
        }

        private void ComposeTable(IContainer container)
        {
            container.Table(table =>
            {
                // step 1
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(); 
                    columns.RelativeColumn(); 
                    columns.RelativeColumn();
                    columns.RelativeColumn(); 
                    columns.RelativeColumn();
                    columns.RelativeColumn(); 
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                });

                // step 2
                table.Header(header =>
                {
                    //esto es para el estilo el cellstyle
                    header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1).Text("idUser").Bold().FontColor(Colors.White);
                    header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1).Text("UserAccount").Bold().FontColor(Colors.White);
                    header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1).Text("birthdate").Bold().FontColor(Colors.White);
                    header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1).Text("numberPhone").Bold().FontColor(Colors.White);
                    header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1).Text("passworduser").Bold().FontColor(Colors.White);
                    header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1).Text("country").Bold().FontColor(Colors.White);
                    header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1).Text("city").Bold().FontColor(Colors.White);
                    header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1).Text("statususer").Bold().FontColor(Colors.White);
                    header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1).Text("DateRegistration").Bold().FontColor(Colors.White);

                    static IContainer CellStyle(IContainer container)
                    {
                        return container.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(10).BorderBottom(1).BorderColor(Colors.Black);
                    }
                });

                var users = _userServices.GetUsers();
                // step 3
                foreach (var item in users)
                {
                    table.Cell().Element(CellStyle).Text($"{item.IdUser}");
                    table.Cell().Element(CellStyle).Text($"{item.UserAccount}");
                    table.Cell().Element(CellStyle).Text($"{item.Birthdate}");
                    table.Cell().Element(CellStyle).Text($"{item.NumberPhone}");
                    table.Cell().Element(CellStyle).Text($"{item.passworduser}");
                    table.Cell().Element(CellStyle).Text($"{item.Country}");
                    table.Cell().Element(CellStyle).Text($"{item.City}");
                    table.Cell().Element(CellStyle).Text($"{item.Statususer}");
                    table.Cell().Element(CellStyle).Text($"{item.DateRegistration}");

                    static IContainer CellStyle(IContainer container)
                    {
                        return container.BorderBottom(1).PaddingVertical(10).PaddingHorizontal(5).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
                    }
                }
            });


        }


        //private static IContainer CellStyle(IContainer container)
        //{
        //    return container
        //        .Border(1) // Borde de 1 unidad
        //        .BorderColor(Colors.Black) // Color del borde
        //        .PaddingVertical(5) // Espaciado vertical
        //        .PaddingHorizontal(5) // Espaciado horizontal
        //        .DefaultTextStyle(x => x.SemiBold()); // Estilo de texto
        //}
    }
}
