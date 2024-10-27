using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class ListProyects
    {
        public int idProyect { get; set; }
        public string titleName { get; set; }
        public string description { get; set; }
        public int idClient { get; set; }
        public int idEmployee { get; set; }
        public DateTime dateInit {  get; set; }
        public DateTime dateEnd { get; set; }

    }
}
