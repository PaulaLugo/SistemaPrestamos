using business.Layer;
using Entity.Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPrestamos
{
    public partial class Form1 : Form
    {
        Operador opr;
        public Form1()
        {
            InitializeComponent();
            opr = new Operador() { PorcentajeComision = 0.15 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstTipos.DataSource = PrestamosServicies.TraerTipos();
            lstTipos.DisplayMember = "Linea";
            RefrescarPrestamos();

            txtPlazo.Value = 12;
          
        }
    
        private void RefrescarPrestamos()
        {
            opr.Prestamos = PrestamosServicies.TraerPrestamos();
            this.ldtPrestamos.DataSource = opr.Prestamos;
            txtcomision.Text = opr.Comision.ToString("C");
        }

      

        private void btnAlta_click(object sender, EventArgs e)
        {

            Prestamo p = new Prestamo();
            p.tipoPrestamo = (TipoPrestamo)this.lstTipos.SelectedItem;
            p.Monto = Convert.ToDouble(txtMonto.Text);
            p.Plazo = (int)txtPlazo.Value;

            PrestamosServicies.InsertPrestamo(p);
            RefrescarPrestamos();

        }

       
        private void lstTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //llenar campos
            var tipo = (TipoPrestamo)this.lstTipos.SelectedItem;
            txtLinea.Text = tipo.Linea;
            this.txtTna.Text = tipo.TNA.ToString();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            Prestamo p = new Prestamo();
            p.tipoPrestamo = (TipoPrestamo)this.lstTipos.SelectedItem;
            p.Monto = Convert.ToDouble(txtMonto.Text);
            p.Plazo = (int)txtPlazo.Value;
            this.txtCuota.Text= p.CuotaCapital.ToString("C");
            this.txtInteres.Text = p.CuotaInteres.ToString("C");
            this.txtTotal.Text = p.Cuota.ToString("C");
            //this.txtcomision.Text= 
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
