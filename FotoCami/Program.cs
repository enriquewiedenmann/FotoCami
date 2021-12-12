using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoCami
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hola Cami!!! \n Por favor ingresa los nro de fotos separados por ',' y peresiona <<enter>> (ej: 273,344,755) \n nros:");
            string fotos =  Console.ReadLine();
            
            string [] fotoList = fotos.Split(',');
            string origen = ConfigurationManager.AppSettings["origen"].ToString();
            string destino = ConfigurationManager.AppSettings["destino"].ToString();
            DirectoryInfo di = new DirectoryInfo(origen);
            
            foreach (var fi in di.GetFiles())
            {
                Console.Write(fi.Name);
                string nro = fi.Name.Substring(fi.Name.IndexOf('_')+1, fi.Name.IndexOf('.') - fi.Name.IndexOf('_')-1);
                if((from  fl in fotoList where nro.Equals(fl) select fl).FirstOrDefault() != null)
                {
                    Console.WriteLine(" copiada");
                    fi.CopyTo(destino + "/"+fi.Name);
                }
                else { Console.WriteLine(" No copiada"); }
            }
            Console.WriteLine("by by Cami ya hice el trabajo por ti. saludos Quiiiii. presiona q para salir");
            Console.ReadKey();


        }
    }
}
