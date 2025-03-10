using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Lectura_Metadatos
{
    class Program
    {
        static void Main(string[] args)
        {
            string urlImage = @"C:\\Users\\AlbertPc\\source\\repos\\Lectura-Metadatos\\Lectura-Metadatos\\speaker.jpg";

            Image image = new Bitmap(urlImage);

            PropertyItem[] propiedades = image.PropertyItems;

            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();

            foreach (var propiedad in propiedades)
            {
                if (propiedad.Value != null)
                {
                    string valor = encoding.GetString(propiedad.Value);

                    Console.WriteLine(valor);

                }
            }
        }
    }
}
