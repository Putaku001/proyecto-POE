using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Permission
    {
        public int idPermission { get; set; }
        public int idMenu { get; set; }
        public string NameForm { get; set; }
    }
}
