using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp
{
    public class Municipio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        [Name("IdEstado(fk)")]
        public int IdEstado { get; set; }
    }
}
