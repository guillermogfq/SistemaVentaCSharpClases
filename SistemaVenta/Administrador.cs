using System;
namespace SistemaVenta
{
    public class Administrador : Usuario
    {
        public Administrador(string nombre, string password)
            : base(nombre, password)
        {
        }
    }
}
