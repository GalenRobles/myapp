using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp
{
    internal class Persona
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }

        public Persona(int id, string nom, string tel)
        {
            this.Id= id;
            this.nombre = nom;
            this.telefono= tel;
        }
    }
}
