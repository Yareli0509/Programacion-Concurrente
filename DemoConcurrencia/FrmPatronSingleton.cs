using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConcurrencia
{
    public partial class FrmPatronSingleton : Form
    {
        public FrmPatronSingleton()
        {
            InitializeComponent();
        }

        private void btnAsignarcadenaconexion_Click(object sender, EventArgs e)
        {
            Singleton cadenaConexion = Singleton.Instance;
            cadenaConexion.CadenaConexion = txtCadenaConexion.Text;
        }

        private void btnObtenercadenaconexion_Click(object sender, EventArgs e)
        {
            Singleton cadenaConexion = Singleton.Instance;
            LblCadenaconexion.Text = cadenaConexion.CadenaConexion;
        }
    }
}
