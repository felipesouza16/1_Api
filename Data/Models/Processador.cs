using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Processador : BaseModels
    {
        public string Marca { get; set; }
        public int Nucleos { get; set; }
        public int Threads { get; set; }
    }
}
