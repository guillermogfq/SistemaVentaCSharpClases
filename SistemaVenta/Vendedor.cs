using System;
namespace SistemaVenta
{
    public class Vendedor : Usuario
    {
        public Vendedor(string nombre, string password)
            :base(nombre,password)
        {
        }
    }
}
