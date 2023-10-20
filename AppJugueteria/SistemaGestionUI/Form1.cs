

using System.Data.SqlClient;

namespace SistemaGestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarProductos();

        }

        private void CargarProductos()
        {
            List<ProductoData> lista = Contexto.ListarProductos();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FrmAltaProducto frmAltaProducto = new FrmAltaProducto();
            frmAltaProducto.FormClosed += FrmAltaProducto_FormClosed;
            frmAltaProducto.ShowDialog();
        }

        private void FrmAltaProducto_FormClosed(object? sender, FormClosedEventArgs e)
        {
            CargarProductos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;

            ProductoData productoData = Contexto.ListarProductos().Where(x => x.Id == Id).FirstOrDefault();


            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {

                FrmModificarProducto modificar = new FrmModificarProducto(productoData);
                modificar.FormClosed += FrmAltaProducto_FormClosed;
                modificar.ShowDialog();
            }
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                FrmEliminarProducto eliminar = new FrmEliminarProducto(productoData);

                eliminar.FormClosed += FrmAltaProducto_FormClosed;
                eliminar.ShowDialog();
            }
        }
    }
}