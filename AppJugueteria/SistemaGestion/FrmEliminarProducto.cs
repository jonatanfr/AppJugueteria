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
    public partial class FrmEliminarProducto : Form
    {
        public FrmEliminarProducto()
        {
            InitializeComponent();
        }

        private ProductoData _productoData;

        public FrmEliminarProducto(ProductoData productoData)
        {
            InitializeComponent();
            _productoData = productoData;
        }


        private void FrmEliminarProducto_Load(object sender, EventArgs e)
        {
            this.txtUsuario.Text = _productoData.IdUsuario.ToString();
            this.txtDescripcion.Text = _productoData.Descripciones;
            this.numCosto.Value = _productoData.Costo;
            this.numPrecioVenta.Value = _productoData.PrecioVenta;
            this.numStock.Value = _productoData.Stock;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            Contexto.EliminarProducto(_productoData);
            MessageBox.Show("Se eliminó Correctamente");
        }
    }
}
