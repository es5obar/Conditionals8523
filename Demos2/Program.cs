using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adınızı Giriniz : ");
            string adi = Console.ReadLine();
            Console.Write("Yaşınızı Giriniz : ");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Eğitim durumunuzu giriniz(ilkokul :i ortaokul:o,lise:l,üniversite :ü) : ");
            string egitim = Console.ReadLine();
            Console.Write("Renk Körü Müsün ? (evet :e, hayır:h ):");
            string renkKoruMu = Console.ReadLine();

            //if (yas >=18 )
            //{
            //    if (egitim == "l" || egitim == "ü")
            //    {
            //        if (renkKoruMu == "h")
            //        {
            //            Console.WriteLine("Sayın " + adi + ", ehliyet alabilirsiniz.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sayın " + adi + ", ehliyet alamazsınız.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sayın " + adi + ", ehliyet alamazsınız.");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Sayın " + adi + ", ehliyet alamazsınız. ");
            //}
            if (yas >= 18 && (egitim == "l" || egitim == "ü") && renkKoruMu == "h")
                Console.WriteLine("Sayın " + adi + ", ehliyet alabilirsiniz.");
            else // yas < 18 || (egitim != " l" && egitim != "ü" ) || renkKoruMu != "h"
            {
                Console.WriteLine("Sayın " + adi + ", ehliyet alamazsınız.");
            }
            Console.ReadLine();
        }
    }
}
