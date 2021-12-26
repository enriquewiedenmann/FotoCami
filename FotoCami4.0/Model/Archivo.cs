using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoCami4._0.Model
{
    class Archivo
    {
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Nombre { get; set; }
        public int Orden { get; set; }

        internal string MeCopio(bool snOrden)
        {
            try
            {

                string destino;
                FileInfo fi = new FileInfo(Origen + "/" + Nombre);
                if (snOrden)
                {
                    destino = Destino + "/" + Orden + "_" + fi.Name;
                }
                else
                {
                    destino = Destino + "/" + fi.Name;
                }

                fi.CopyTo(destino);

                return Nombre + "; copiado";
            }
            catch (Exception e)
            {
                return Nombre + "; " + e.Message;
            }

        }
    }
}
