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
    public partial class FrmModificarProducto : Form
    {
        public FrmModificarProducto()
        {
            InitializeComponent();
        }

        private ProductoData _productoData;

        public FrmModificarProducto(ProductoData productoData)
        {
            InitializeComponent();
            _productoData = productoData;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            _productoData.Descripciones = txtDescripcion.Text;
            _productoData.Costo = numCosto.Value;
            _productoData.PrecioVenta = numPrecioVenta.Value;
            _productoData.Stock = (int)numStock.Value;
            _productoData.IdUsuario = int.Parse(txtUsuario.Text);

            Contexto.ModificarProducto(_productoData);
            MessageBox.Show("Se modificó Correctamente");
        }

        private void FrmModificarProducto_Load(object sender, EventArgs e)
        {
            this.txtUsuario.Text = _productoData.IdUsuario.ToString();
            this.txtDescripcion.Text = _productoData.Descripciones;
            this.numCosto.Value = _productoData.Costo;
            this.numPrecioVenta.Value = _productoData.PrecioVenta;
            this.numStock.Value = _productoData.Stock;
            
        }
    }
}
