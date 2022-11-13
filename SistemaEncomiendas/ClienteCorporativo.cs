using System;
namespace SistemaEncomiendas
{
	public class ClienteCorporativo
	{

        public string cuit { get; set; }
        public string nombreUsuario { get; set; }


        public ClienteCorporativo()
        {
        }

        public ClienteCorporativo(Login login)
        {
            this.cuit = login.cuit;
            this.nombreUsuario = login.nombreUsuario;
        }

        //public string archivoDatosUsuarios = "../../../usuarios.csv";

        //public ClienteCorporativo traerDatosCliente(String usuario)
        //{
        //    this.nombreUsuario = usuario;

        //    var stream = File.OpenRead(archivoDatosUsuarios);
        //    var reader = new StreamReader(stream);

        //    var counter = 0;

        //    while (!reader.EndOfStream)
        //    {
        //        var linea = reader.ReadLine();

        //        if (counter > 0) {
        //            string[] datos = linea.Split(';');

        //            if (datos[0].Equals(usuario))
        //            {
        //                this.nombreUsuario = usuario;

        //                break;
        //            }
        //        }

        //        counter++;
        //    }

        //    stream.Close();

        //    return this;
        //}
    }

}

