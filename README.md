# Crear código PDF417 con iTextSharp y XZing en C# .NET

En este ejemplo vamos explicamos como utilizar dos herramientas gratuitas disponibles en NuGet de .Net, iTextSharp y XZing.

Ver ejemplo completo en http://www.royrojas.com/crear-codigo-pdf417-con-itextsharp-y-xzing-en-c-net/

### Nuget: iTextSharp 
Versión del ejemplo 5.5.13

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
            Save("C:\\Temp\\iTextSharp_cs_01.jpg", ImageFormat.Jpeg);

        //Bitmap imagen = new Bitmap(pdf417.CreateDrawingImage(Color.Black, Color.White));
        //imagen.Save("C:\\Temp\\iTextSharp_02.jpg", ImageFormat.Jpeg);

        Console.WriteLine("Imagen generada satisfactoriamente.");
        Console.Read();
    }

### NuGet: ZXing.Net 
Version del ejemplo 0.16.4

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



