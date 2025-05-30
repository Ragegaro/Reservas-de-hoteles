﻿using CadenaHotelera.Pantallas;
using CadenaHotelera.PantallasAdm.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadenaHotelera.PantallasAdm
{
    public partial class FormReportes : Form
    {
        private Form currentChildForm;

        public FormReportes()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelReportes.Controls.Add(childForm);
            panelReportes.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ocupacionPorHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormOcupHotel());
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormVentas());
        }

        private void historialDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHistorialCliente());
        }
    }
}
