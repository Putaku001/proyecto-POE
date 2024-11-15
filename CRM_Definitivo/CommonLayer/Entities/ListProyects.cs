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
        public string Client {  get; set; }
        public int idEmployee { get; set; }
        public string Employee {  get; set; }
        public string workStation { get; set; }
        public byte[] file {  get; set; }
        public int idStatusProyect { get; set; }
        public string statusproyect { get; set; }
        public DateTime dateInit {  get; set; }
        public DateTime dateEnd { get; set; }
        

    }
}
