using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        private Button lastClickedButton;

        public Form1()
        {
            InitializeComponent();
            MostrarFormulario(new FrmBanner());
        }

        public void MostrarFormulario(Form formulario)
        {
            // Limpiar el panel antes de agregar un nuevo formulario
            pnl_contenedor.Controls.Clear();

            // Configurar el formulario hijo
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agregar el formulario al panel y mostrarlo
            pnl_contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void btn_Principal_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Gestion Ganadera";
            ChangeButtonColor((Button)sender);
            MostrarFormulario(new FrmBanner());
        }

        private void btn_Animales_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Animales";
            ChangeButtonColor((Button)sender);
            MostrarFormulario(new FrmAnimales());
        }

        private void btn_Vacunas_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Vacunas";
            ChangeButtonColor((Button)sender);
            MostrarFormulario(new FrmVacunas());
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Reportes";
            ChangeButtonColor((Button)sender);
            MostrarFormulario(new FrmReportes());
        }

        private void btn_Ajustes_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Ajustes";
            ChangeButtonColor((Button)sender);
            MostrarFormulario(new FrmAjustes());
        }

        /// <summary>
        /// Cambia el color del botón seleccionado y restaura el color del botón anterior.
        /// </summary>
        /// <param name="clickedButton"></param>
        private void ChangeButtonColor(Button clickedButton)
        {
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = SystemColors.ControlDarkDark;
            }

            clickedButton.BackColor = Color.Lime;
            lastClickedButton = clickedButton;
        }
    }
}
