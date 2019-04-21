using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using ZXing;

namespace Demo_Zxing_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Creapdf417("< TED version = '1.0' >< DD >< RE > 99999999 - 9 </ RE >< TD > 33 </ TD >< F > 1 </ F >< FE > 2014 - 05 - 28 </ FE >< RR > 77777777 - 7 </ RR >< RSR > DotNetcr </ RSR >< MNT > 119000 </ MNT >< IT1 > Nombre del Articulo.</ IT1 >< CAF version = '1.0' >< DA >< RE > 33333333 - 3 </ RE >< RS > NOMBRE DEL CLIENTE </ RS >< TD > 33 </ TD >< RNG >< D > 1 </ D >< H > 50 </ H ></ RNG >< FA > 2014 - 05 - 26 </ FA >< RSAPK >< M > uJ + OZ5qO9diB / c9MoZuwPs9ltKGAS1IbEymF7W3X3ZTq6ElExVkrlfp7uDoGR0DiBndor6Vyc + X4MRbsk6KC9w ==</ M >< E > Aw ==</ E ></ RSAPK >< IDK > 100 </ IDK ></ DA >< FRMA algoritmo = 'SHA1withRSA' > SGKR9otZoN8 / 5sIaKFJIbo08Jbt95UBh76fcFv21lfNsgauAcyzUF0FARrMyphMagJ0zzChJzU7R / Q0mrDvYvQ ==</ FRMA ></ CAF >< TSTED > 2014 - 05 - 28T09: 33:20 </ TSTED ></ DD >< FRMT algoritmo = 'SHA1withRSA' > GK7FRnNjgHLyRspdygg2WudvqqJ + OQchn8k / 6TUrndBBNHsFHInEN34 + KLTy\nFgRG / bmDIjclV4VTlgs3TIg / 7A ==\n </ FRMT ></ TED >");
        }

        public static void Creapdf417(String valor)
        {
            try
            {
                Console.WriteLine("Demo ZXing C#");

                BarcodeWriter mWriter = new BarcodeWriter();
                mWriter.Format = BarcodeFormat.PDF_417;
                mWriter.Options.Width = 341;
                mWriter.Options.Height = 162;
                
                mWriter.Options.Margin = 5;

                Bitmap mBitmap;
                //mBitmap = mWriter.Write("Texto Opcion 1 del PDF417");
                mBitmap = mWriter.Write(valor);

                mBitmap.Save(@"C:\Temp\ZXing_cs_01.jpg", ImageFormat.Jpeg);

                Console.WriteLine("Imagen generada satisfactoriamente.");
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }

        //public void Opcion2()
        //{
        //    try
        //    {
        //        BarcodeWriter mWriter = new BarcodeWriter();
        //        mWriter.Format = BarcodeFormat.PDF_417;
        //        mWriter.Options.Width = 1000;
        //        mWriter.Options.Height = 200;

        //        mWriter.Options.Margin = 5;

        //        Bitmap mBitmap;
        //        mBitmap = mWriter.Write("Texto Opcion 2 del PDF417");

        //        Image mImage;
        //        mImage = mBitmap.GetThumbnailImage(1000, 200,null,null);

        //        // Opcional:
        //        // Salvar la imagen en un archivo del formato que se quiera jpg, png, etc.
        //        mImage.Save(@"C:\Temp\prueba5.jpg", ImageFormat.Jpeg);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        Console.Read();
        //    }
        //}

        //public void Opcion3()
        //{
        //    try
        //    {
        //        BarcodeWriter mWriter = new BarcodeWriter();
        //        mWriter.Format = BarcodeFormat.PDF_417;
        //        mWriter.Options.Width = 1000;
        //        mWriter.Options.Height = 200;

        //        mWriter.Options.Margin = 5;

        //        Bitmap mBitmap;
        //        mBitmap = mWriter.Write("Texto Opcion 1 del PDF417");

        //        // Salvar el bitmap directamente a un archivo de imagen
        //        mBitmap.Save(@"C:\Temp\prueba16.jpg", ImageFormat.Jpeg);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        Console.Read();
        //    }
        //}
    }
}
