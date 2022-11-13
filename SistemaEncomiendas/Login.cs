using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEncomiendas
{
    internal class Login
    {
        public string cuit { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }

        public string archivoDatosUsuarios = @"../../datos/Usuarios.txt";

        public Login(string cuit, string nombreUsuario, string contraseña)
        {
            this.cuit = cuit;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
        }

        public bool validarUsuario()
        {
            bool usuarioValido = false;
            var stream = File.OpenRead(archivoDatosUsuarios);
            var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                string[] datos = linea.Split(';');

                if (datos[0].Equals(cuit) &&
                    datos[1].Equals(nombreUsuario) &&
                    datos[2].Equals(contraseña))
                {
                    usuarioValido = true;
                    break;
                }
            }

            stream.Close();
            return usuarioValido;
        }

    }
}
