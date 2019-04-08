using System;
namespace SistemaVenta
{
    public class Usuario
    {
        private string nombre;
        private string password;

        public Usuario(string nombre, string password)
        {
            this.nombre = nombre;
            this.password = password;
        }

        public bool setPwd(string actual, string nueva)
        {
            if (this.password.Equals(actual))
            {
                this.password = nueva;
                return true;
            }
            return false;
        }

        public bool tienePrivilegiosPara(string privilegio)
        {
            string priv = privilegio.ToUpper();
            bool response = false;
            switch (priv)
            {
                case "ADMINISTRADOR":
                    response = (this is Administrador) ? true : false;
                    break;
                case "CLIENTE":
                    response = (this is Cliente) ? true : false;
                    break;
                case "VENDEDOR":
                    response = (this is Vendedor) ? true : false;
                    break;
                default:
                    response = false;
                    break;
            }

            return response;
        }
    }
}
