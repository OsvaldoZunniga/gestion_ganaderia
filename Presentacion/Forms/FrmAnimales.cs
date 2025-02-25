using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms
{
    public partial class FrmAnimales : Form
    {
        
        public FrmAnimales()
        {
            InitializeComponent();
            
        }
        private void AbrirVentana(Form ventana)
        {
            ventana.Show();
            ventana.BringToFront();
        }

        private void dtg_Animales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_InfoAnimales frm_InfoAnimales = new Frm_InfoAnimales();
            AbrirVentana(frm_InfoAnimales);

        }
    }
}
