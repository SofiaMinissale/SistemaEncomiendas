using System;
using System.Runtime.CompilerServices;

namespace SistemaEncomiendas
{
    public class ClienteCorporativo
    {

        public string cuit { get; set; }
        public string nombreUsuario { get; set; }
        public string nroSeguimiento { get; set; }

        public ClienteCorporativo()
        {
        }

        public ClienteCorporativo(Login login)
        {
            this.cuit = login.cuit;
            this.nombreUsuario = login.nombreUsuario;

        }

        public string archivoDatosUsuarios = "../../../envios.csv";

        public ClienteCorporativo traerDatosCliente(String nroSeguimiento)
        {
            this.cuit = cuit;
            this.nroSeguimiento = nroSeguimiento;


            var stream = File.OpenRead(archivoDatosUsuarios);
            var reader = new StreamReader(stream);

            var counter = 0;

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                if (counter > 0)
                {
                    string[] datos = linea.Split(';');

                    if (datos[1].Equals(cuit))
                    {
                        this.cuit = cuit;
                        this.nroSeguimiento = datos[0];

                        break;
                    }
                }

                counter++;
            }

            stream.Close();

            return this;
        }

    }
}



