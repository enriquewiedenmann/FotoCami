using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoCami2._0.Model
{
    class Seleccion
    {
        public string Numero { get; set; }
        public string Orden { get; set; }
        public Boolean SNEncontrada { get; set; }

        public Seleccion()
        {
            SNEncontrada = false;
        }
    }
}
