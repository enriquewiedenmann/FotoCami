using FotoCami4._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoCami4._0.Controller
{
    public class Controller
    {
        private static Controller Inst;
        public StringBuilder Log { get; set; }
        private Controller()
        {
            Log = new StringBuilder();
           
        }
        public static Controller GetInstance()
        {
            if (Inst == null)
                Inst = new Controller();

            return Inst;
        }

        public StringBuilder Procesar(string origen, string prefijo, string sufijo, string destino, string lista, bool snOrdenLista)
        {
            Log.Clear();
            if (ValidarEntrada(origen, prefijo, sufijo, destino, lista))
            {

                string[] fotoList = lista.Split('\n');
                for (int i = 0; i < fotoList.Length; i++)
                {
                    Archivo a = new Archivo();
                    a.Destino = destino;
                    a.Origen = origen;
                    a.Nombre = prefijo + fotoList[i] + sufijo;
                    a.Orden = i + 1;

                    Log.Append(a.MeCopio(snOrdenLista) + "\n");

                }
            }


                return Log;
        }

        private bool ValidarEntrada(string origen, string prefijo, string sufijo, string destino, string lista)
        {
            bool status = true;
            
            if(origen == null)
            {
                Log.Append("Error: El origen no puede estar vacio\n");
                status = false;
            }

            if (destino == null)
            {
                Log.Append("Error: El destino no puede estar vacio\n");
                status = false;
            }

            if(prefijo == null)
            {
                Log.Append("Advertencia: El prefijo esta vacio\n");
            }
            if (sufijo == null)
            {
                Log.Append("Advertencia: El sufijo esta vacio\n");
            }
            if (lista == null)
            {
                Log.Append("Error: La lista no puede estar vacia\n");
                status = false;
            }
            return status;
        }
    }
}
