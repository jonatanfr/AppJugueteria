using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class FrmAltaProducto : Form
    {
        public FrmAltaProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAltaProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            ProductoData productoData = new ProductoData();
            productoData.Descripciones = textDescripcion.Text;
            productoData.Costo = numCosto.Value;
            productoData.PrecioVenta = numVenta.Value;
            productoData.Stock = (int)numStock.Value;
            productoData.IdUsuario = int.Parse(txtUsuario.Text);

            Contexto.CrearProducto(productoData);
            MessageBox.Show("Se guardó Correctamente");
        }
    }
}
