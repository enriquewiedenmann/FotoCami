using FotoCami2._0.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoCami2._0.Controller
{
    class ConfigController
    {
        public static int cont;
        public static int contSeleccino;
        private static ConfigController Controller;
        public List<Seleccion> Selecciones { get; set; }
        public List<Archivo> Archivos { get; set; }

        public string Log { get; set; }

        public static ConfigController GetInstance()
        {
            if (Controller == null)
                Controller = new ConfigController();
            return Controller;
        }



        private ConfigController()
        {
            Archivos = new List<Archivo>();
            Selecciones = new List<Seleccion>();
            cont = 1;
            contSeleccino = 1;
        }

        public void Clear()
        {
            Archivos.Clear();
            cont = 1;
        }

       
            



            public DataTable CargarArchivos(string root, char pre, char pos,Boolean limpiar) 
            {

            try
            {
                if (limpiar) this.Clear();
                
                string[] ret = new string[2];
                DirectoryInfo di = new DirectoryInfo(root);

                foreach (var fi in di.GetFiles())
                {
                    Archivo a = new Archivo();
                    a.FullPathFile = fi.FullName.ToString();
                    a.NombreArchivo = fi.Name.ToString();
                    a.NroArchivo = fi.Name.Substring(fi.Name.IndexOf(pre) + 1, fi.Name.IndexOf(pos) - fi.Name.IndexOf(pre) - 1);
                    a.Orden = cont.ToString();
                    a.SNSeleccionado = false;
                    cont++;
                    this.Archivos.Add(a);

                }
            }
            catch
            {
                throw ;
            }
            Log=string.Format("Nro de Archivo en lista: {0}\n", cont);
            return this.ArchivosToVIew();
            


        }

        internal void CargarSeleccion(string text)
        {
            try
            {
                string[] fotoList = text.Split('\n');
                for (int i = 0; i < fotoList.Length; i++)
                {
                    string[] foto = fotoList[i].Split(';');
                    Seleccion s = new Seleccion();
                    s.Numero = foto[0];
                    if (foto.Length == 2)
                    {
                        s.Orden = foto[1];
                    }
                    else
                    {
                        s.Orden = contSeleccino.ToString();
                    }
                    contSeleccino++;
                    if ((from ss in Selecciones where ss.Numero.Equals(s.Numero) select ss).Count() > 0)
                    {
                        this.Log = this.Log + "\n" + s.Numero + ": ya se encuentra en la lista";
                    }
                    else
                    {
                        Selecciones.Add(s);
                    }
                }
            }
            catch (Exception e)
            {

                this.Log = e.Message + "\n";
                throw;
            }
            
        }

        public DataTable ArchivosToVIew()
        {
            DataTable dt = new DataTable();
            DataGridView dgv = new DataGridView();
            dgv.DataSource = dt;
            dt.Columns.Add("0", typeof(int));
            dt.Columns.Add("1", typeof(Boolean));
            dt.Columns.Add("2", typeof(string));
            dt.Columns.Add("3", typeof(string));
            dt.Columns.Add("4", typeof(string));
            
            foreach (Archivo a in this.Archivos)
            {
                dt.Rows.Add(a.Orden, a.SNSeleccionado,a.NroArchivo,a.NombreArchivo,a.FullPathFile);

            }
            return dt;

        }

        public DataTable HacerMatch()
        {
            int c = 0;
            foreach (Archivo a in Archivos)
            {
                var sell = (from sel in Selecciones where sel.Numero.Equals(a.NroArchivo) select sel).FirstOrDefault();
                if (sell != null)
                {
                    a.Orden = sell.Orden;
                    a.SNSeleccionado = true;
                    sell.SNEncontrada = true;
                    c++;
                }
            }
            var noSell = (from sel in Selecciones where sel.SNEncontrada == false select sel);
            this.Log = string.Format("Fotos encontradas:{0}", c);
            foreach(Seleccion s in noSell)
            {
                this.Log = s.Numero + ":No encontrada\n";
            }

            return this.ArchivosToVIew();
        }

        internal void CopiarArchivos(string destino,bool snLimpiar)
        {
            int cont = 0;
            try
            {
                DirectoryInfo di = new DirectoryInfo(destino);

                if (snLimpiar)
                {
                    foreach(var fi in di.GetFiles())
                    {
                        fi.Delete();
                    }
                }
                foreach (Archivo a in Archivos)
                {
                    try
                    {

                        FileInfo fi = new FileInfo(a.FullPathFile);
                        fi.CopyTo(destino + "/" + a.Orden + "_" + fi.Name);
                        cont++;

                    }
                    catch(Exception eee)
                    {
                        Log = Log + "no se pudo copiar: " + a.NombreArchivo + " ," + eee.Message; 
                    }
                }
                Log = Log + "archivos copiados: " + cont;
            }
            catch {
                throw;
                    }
        }
    }
}
