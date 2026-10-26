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
        [Ignore]
        public int Id { get; set; }

        [Index(1)]
        public string Nombre { get; set; }

        [Index(0)]
        public int IdEstado { get; set; }
    }
}