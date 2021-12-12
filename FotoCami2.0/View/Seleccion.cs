using FotoCami2._0.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoCami2._0.View
{
    public partial class Seleccion : Form
    {
        public Seleccion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingresar los numeros de fotos a seleccionar en forma de lista:\n111\n112\n117\n120\n" +
                "En caso de querer un orden espcifico puede colocar el nro de esta forma 112;3. El sistema antepondra el segundo nro en el nombre para un mejor ordenamiento de las fotos");
        }

        private void Seleccion_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConfigController cc = ConfigController.GetInstance();
            try
            {
                cc.CargarSeleccion(this.txtSeleccion.Text);

                this.Close();
            }catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }
    }
}
