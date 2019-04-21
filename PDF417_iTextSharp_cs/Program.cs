using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;

namespace ConsoleApp_iTextSharp_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Creapdf417("< TED version = '1.0' >< DD >< RE > 99999999 - 9 </ RE >< TD > 33 </ TD >< F > 1 </ F >< FE > 2014 - 05 - 28 </ FE >< RR > 77777777 - 7 </ RR >< RSR > DotNetcr </ RSR >< MNT > 119000 </ MNT >< IT1 > Nombre del Articulo.</ IT1 >< CAF version = '1.0' >< DA >< RE > 33333333 - 3 </ RE >< RS > NOMBRE DEL CLIENTE </ RS >< TD > 33 </ TD >< RNG >< D > 1 </ D >< H > 50 </ H ></ RNG >< FA > 2014 - 05 - 26 </ FA >< RSAPK >< M > uJ + OZ5qO9diB / c9MoZuwPs9ltKGAS1IbEymF7W3X3ZTq6ElExVkrlfp7uDoGR0DiBndor6Vyc + X4MRbsk6KC9w ==</ M >< E > Aw ==</ E ></ RSAPK >< IDK > 100 </ IDK ></ DA >< FRMA algoritmo = 'SHA1withRSA' > SGKR9otZoN8 / 5sIaKFJIbo08Jbt95UBh76fcFv21lfNsgauAcyzUF0FARrMyphMagJ0zzChJzU7R / Q0mrDvYvQ ==</ FRMA ></ CAF >< TSTED > 2014 - 05 - 28T09: 33:20 </ TSTED ></ DD >< FRMT algoritmo = 'SHA1withRSA' > GK7FRnNjgHLyRspdygg2WudvqqJ + OQchn8k / 6TUrndBBNHsFHInEN34 + KLTy\nFgRG / bmDIjclV4VTlgs3TIg / 7A ==\n </ FRMT ></ TED >");
        }

        static void Creapdf417(String dd)
        {
            Console.WriteLine("Demo iTextSharp C#");

            BarcodePDF417 pdf417 = new BarcodePDF417();
            pdf417.Options = BarcodePDF417.PDF417_USE_ASPECT_RATIO;
            pdf417.ErrorLevel = 8;
           
            pdf417.Options = BarcodePDF417.PDF417_FORCE_BINARY;

            Encoding iso = Encoding.GetEncoding("ISO-8859-1");
            byte[] isoBytes = iso.GetBytes(dd);

            pdf417.Text = isoBytes;
            // pdf417.SetText(contenido);
            
            pdf417.CreateDrawingImage(Color.Black, Color.White).
                Save("C:\\Temp\\PDF417_iTextSharp_cs_01.jpg", ImageFormat.Jpeg);

            //Bitmap imagen = new Bitmap(pdf417.CreateDrawingImage(Color.Black, Color.White));
            //imagen.Save("C:\\Temp\\iTextSharp_02.jpg", ImageFormat.Jpeg);

            Console.WriteLine("Imagen generada satisfactoriamente.");
            Console.Read();
        }
    }
}
