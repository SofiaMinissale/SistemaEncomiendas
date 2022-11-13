using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEncomiendas
{
    public class Login
    {
        public string cuit { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }

        public string archivoDatosUsuarios = @"../../../usuarios.csv";

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

            var counter = 0;

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                if (counter > 0)
                {
                    string[] datos = linea.Split(';');

                    if (datos[0].Equals(cuit) &&
                        datos[1].Equals(nombreUsuario) &&
                        datos[2].Equals(contraseña))
                    {
                        usuarioValido = true;
                        break;
                    }
                }
                    
                counter++;
            }

            stream.Close();
            return usuarioValido;
        }

    }
}
