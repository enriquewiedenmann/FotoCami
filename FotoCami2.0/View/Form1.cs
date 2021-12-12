using FotoCami2._0.Controller;
using FotoCami2._0.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoCami2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Origen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFileOrigen_Click(object sender, EventArgs e)
        {
            folderOrigen.ShowDialog();
            txtFileOrigen. Text= folderOrigen.SelectedPath;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabConfig_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarDetino_Click(object sender, EventArgs e)
        {
            folderDestino.ShowDialog();
            txtDestino.Text = folderDestino.SelectedPath;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En un archivo de nombre IMG_777.jpg el caratcer anterior es '_' y el posterior '.' ");
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnCargarArchivos_Click(object sender, EventArgs e)
        {
            ConfigController cc = ConfigController.GetInstance();
            if (txtFileOrigen.Text.Length ==0 | txtPrefijo.Text.Length==0 | txtSufijo.Text.Length==0)
            {
                this.txtLog.AppendText("verifique los datos ingesados en config origen, sufijo o prefijo incompletos\n");
                MessageBox.Show("verifique los datos ingesados en config origen , sufijo o prefijo incompletos");
            }
            else
            {
                try
                {
                    dataArchivos.DataSource = cc.CargarArchivos(txtFileOrigen.Text, txtPrefijo.Text.FirstOrDefault(), txtSufijo.Text.FirstOrDefault(), snLimpiar.Checked);
                    dataArchivos.Columns[0].HeaderText = "Orden";
                    dataArchivos.Columns[1].HeaderText = "Seleccionado";
                    dataArchivos.Columns[2].HeaderText = "Numero de foto";
                    dataArchivos.Columns[3].HeaderText = "Nombre";
                    dataArchivos.Columns[4].HeaderText = "Ruta";
                    dataArchivos.AutoResizeColumns();

                    this.txtLog.AppendText(cc.Log.ToString());
                }
                catch (Exception ee)
                {
                    this.txtLog.AppendText(ee.Message + "\n");
                    MessageBox.Show(ee.Message);
                }
            }
        }

        private void btnIngSel_Click(object sender, EventArgs e)
        {
            Seleccion s = new Seleccion();
            s.Show();
            this.txtLog.AppendText(ConfigController.GetInstance().Log+"\n");
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {

            ConfigController cc = ConfigController.GetInstance();
            dataArchivos.DataSource =  cc.HacerMatch();
            this.txtLog.AppendText(cc.Log+"\n");
            dataArchivos.Columns[0].HeaderText = "Orden";
            dataArchivos.Columns[1].HeaderText = "Seleccionado";
            dataArchivos.Columns[2].HeaderText = "Numero de foto";
            dataArchivos.Columns[3].HeaderText = "Nombre";
            dataArchivos.Columns[4].HeaderText = "Ruta";
            dataArchivos.AutoResizeColumns();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            try
            {
                ConfigController cc = ConfigController.GetInstance();
                if (this.txtDestino.Text.Length > 0)
                {
                    cc.CopiarArchivos(this.txtDestino.Text,SNBorrarAnteriores.Checked);
                }
                else
                {
                    this.txtLog.AppendText("Revisar carpeta de destino.\n");
                    MessageBox.Show("Revisar carpeta de destino");
                }
            }catch(Exception ee)
            {
                this.txtLog.AppendText(ee.Message+"\n");
                MessageBox.Show(ee.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
