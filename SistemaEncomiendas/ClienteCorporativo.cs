using System;
namespace SistemaEncomiendas
{
	public class ClienteCorporativo
	{
        public string cuit { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
        public string IdOrdenServicio { get; set; }

        public string archivoDatosUsuarios = "../../datos/Usuarios.txt";


        public ClienteCorporativo traerDatosCliente(String usuario)
        {
            this.nombreUsuario = usuario;
            
            var stream = File.OpenRead(archivoDatosUsuarios);
            var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                string[] datos = linea.Split(';');

                if (datos[0].Equals(usuario))
                {
                    this.nombreUsuario = usuario;
                  
                    break;
                }
            }

            stream.Close();

            return this;
        }
    }
}

