using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class BaseContext : DbContext
    {
        public DbSet<Processador> Processador { get; set; }
        public BaseContext() : base(@"Data Source=192.168.0.196;Initial Catalog=Processador;Persist Security Info=True;User ID=a;Password=123")
        {

        }
    }
}
