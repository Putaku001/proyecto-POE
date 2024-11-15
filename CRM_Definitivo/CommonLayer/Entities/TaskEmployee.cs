using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class TaskEmployee
    {
        public int idProyect { get; set; }
        public string titleName { get; set; }
        public string nameTask { get; set; }
        public string descriptionTask { get; set; }
        public int idEmployee { get; set; }
        public int idTask { get; set; }

    }
}
