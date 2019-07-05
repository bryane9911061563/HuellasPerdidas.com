using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace HuellitasPerdidas.BO
{
    public class ClientesBO
    {
        int idCliente,idCiudad,idEstado,idZona;
        string Nombres,ApellidoP,ApellidoM,ImagenPerfil,email,pasw,direccion;
        DateTime fecha_nac;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdCiudad { get => idCiudad; set => idCiudad = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }
        public int IdZona { get => idZona; set => idZona = value; }
        public string Nombres1 { get => Nombres; set => Nombres = value; }
        public string ApellidoP1 { get => ApellidoP; set => ApellidoP = value; }
        public string ApellidoM1 { get => ApellidoM; set => ApellidoM = value; }
        public string ImagenPerfil1 { get => ImagenPerfil; set => ImagenPerfil = value; }
        public string Email { get => email; set => email = value; }
        public string Pasw { get => pasw; set => pasw = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime Fecha_nac { get => fecha_nac; set => fecha_nac = value; }

        public Image RedimencionarImagen(Image Imgoriginal, int Altoimg)
        {
            var Radio = (double)Altoimg / Imgoriginal.Height;//diferencia entre la imagenes
            var NuevoAncho = (int)(Imgoriginal.Width * Radio);
            var NuevoAlto = (int)(Imgoriginal.Height * Radio);
            var ImagenRedimencionada = new Bitmap(NuevoAncho, NuevoAlto);
            //creo archivo apartir del bitmap con las nuevas dimensiones
            var g = Graphics.FromImage(ImagenRedimencionada);
            g.DrawImage(Imgoriginal, 0, 0, NuevoAncho, NuevoAlto);
            return ImagenRedimencionada;
        }
    }
}