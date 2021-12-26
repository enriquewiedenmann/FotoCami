using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FotoCami4._0.Controller;


namespace FotoCami4._0.Front
{
    public partial class FotoCami : Form
    {
        public FotoCami()
        {
            InitializeComponent();
        }

        private void FotoCami_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lDestino_Click(object sender, EventArgs e)
        {

        }

        private void btnOrigen_Click(object sender, EventArgs e)
        {
            folderBrowserOrigen.ShowDialog();
            txtOrigen.Text = folderBrowserOrigen.SelectedPath;
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            folderBrowserDestino.ShowDialog();
            txtDestino.Text = folderBrowserDestino.SelectedPath;

            DialogResult dr = MessageBox.Show("Desea Borrar archivos prexistentes en destino?",
                      "Borrar destino", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    DirectoryInfo di = new DirectoryInfo(folderBrowserDestino.SelectedPath);
                    foreach(var fi in di.GetFiles())
                    {
                        fi.Delete();
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnAuxLista_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debe ingresar los nro de fotos en forma de lista (ejemplo):\n1234\n1235\n1236","Ayuda");
        }

        private void btnAuxData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si el nombre de archivo es IMG_12345.jpeg, el prefijo es IMG_ y el sufijo .jpeg","Ayuda");
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            txtLog.Text =  Controller.Controller.GetInstance().Procesar(this.txtOrigen.Text,
                                                                        this.txtPrefijo.Text,
                                                                        this.txtSufijo.Text,
                                                                        this.txtDestino.Text,
                                                                        this.txtLista.Text,
                                                                        this.snOrdenLista.Checked).ToString();

            DialogResult dr = MessageBox.Show("Desea abrir la carpeta de Destino?",
                  "Abrir destino", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    try
                    {
                        System.Diagnostics.Process.Start(txtDestino.Text);
                    }
                    catch { }
                    break;
                case DialogResult.No:
                    break;
            }

        }
    }
}
