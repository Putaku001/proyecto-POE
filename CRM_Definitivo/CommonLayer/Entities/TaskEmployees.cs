using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class TaskEmployees
    {
        public int idTask {  get; set; }
        public string codeProject { get; set; }
        public string nameTask { get; set; }
        public string descriptionTask { get; set; }
        public int idEmployee { get; set; }
        public DateTime dateEnd { get; set; }
    }
}
