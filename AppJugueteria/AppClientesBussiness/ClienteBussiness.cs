using AppClientesData;
using AppClientesEntitis;
namespace AppClientesBussiness
{
    public static class ClienteBussiness
    {
        public static List<Cliente> GetCliente()
        {
            return AppClientesData.GetClientes();
        }

    }
}