using System;
using System.Linq;
using System.Threading;

namespace SmartPro305C3
{
    class Program
    {
        static string[] islemler = { "1-Cevresini Hesaplama", "2-Alanin Hesaplama" };
        static int IslemSecimi = 0, milliseconds = 2000;
        static string[] sekil1 = { "1-Kare", "2-Üçgen", "3-Dikdörtgen", "4-Küre", "5-Koni", "6-Yamuk" };
        static string[] SecimMesajlar = { "Cevresini Hesaplayi Sectiniz...",
            "Alanin Hesaplayi Sectiniz..."};

        static void Main(string[] args)
        {
            try
            {
                #region 18-05-2022
                #region Ornek1

                //int sayac = 0;
                //do
                //{
                //    Console.WriteLine("Sayacin Degeri :"+sayac);
                //    sayac++;

                //} while (sayac<12);



                //Console.ReadLine();
                #endregion
                #region Ornek2

                //for (int i = 0; i < Sayilar.Length; i++)
                //{
                //    if (Sayilar[i]%2==0)
                //    {

                //        break;
                //    }else if (Sayilar[i]%2!=0)
                //    {
                //        Console.WriteLine(Sayilar[Sayac]);
                //        Sayac++;
                //    }
                //}

                #endregion
                #region Ornek3
                //int[] Sayilar = { 11, 15, 17, 21, 6, 9, 4, 2, 0 };
                //int Sayac = 0;
                //bool buldum = false;

                //do
                //{
                //    if (Sayilar[Sayac] % 2 == 0)
                //    {
                //        buldum = true;
                //    }
                //    else
                //    {
                //        buldum = false;
                //        Console.WriteLine(Sayilar[Sayac]);
                //    }
                //    Sayac++;

                //} while (buldum==false);


                //Console.ReadLine();

                #endregion
                #region Ornek4
                //string[] isimler = {"Tuba","Baris","Abdullah","Can","Ahmet","Ayse","Mersin"};
                //bool data = false;
                //int boy = 0;
                //int Sayac = 0;
                //do
                //{
                //    boy = isimler[Sayac].ToString().Length;
                //    Console.WriteLine(isimler[Sayac].ToString());
                //    Sayac++;
                //} while (boy>3);
                //Console.ReadKey();
                #endregion
                #region Ornek5

                //int Sayi = 0;
                //int SayiAdeti = 0;
                //bool denetleme = false;
                //do
                //{
                //    if (Sayi%3==0||Sayi%7==0)
                //    {
                //        if (Sayi!=0)
                //        {
                //            Console.WriteLine(SayiAdeti + " :" + Sayi);

                //        }
                //        if (SayiAdeti==20)
                //        {
                //            denetleme = true;
                //        }
                //        SayiAdeti++;
                //    }
                //    Sayi++;

                //} while (denetleme==false);

                //Console.ReadKey();
                #endregion
                #region Ornek6
                //int[] d = { 1, 2, 3, 4, 5 };
                //int[] e = { 5, 4, 3, 2, 1 };
                //int[] f = new int[d.Length];
                //int sayac = 0;
                //do
                //{
                //    f[sayac] = d[sayac] * e[sayac];
                //    if (f[sayac]%9==0)
                //    {
                //        break;
                //    }
                //    else
                //    {
                //        Console.WriteLine(f[sayac]);
                //    }
                //    sayac++;

                //} while (true);
                #endregion
                #region Ornek7
                //Console.WriteLine("============Ornek 7============");
                //string[] isimler = { "Tuba", "Baris", "Abdullah", "Canan","Can","Ahmet", "Ayse", "Mersin" };
                //bool buldum = false;
                //int boy = 0;
                //int sayac = 0;
                //while (isimler[sayac].ToString().Length>3||isimler.Length<sayac)
                //{
                //    boy = isimler[sayac].ToString().Length;
                //    Console.WriteLine(isimler[sayac].ToString());
                //    sayac++;
                //}

                #endregion
                #region Ornek8
                //int[] numbers = { 11, 15, 17, 21, 6, 9, 4, 2, 0 };
                //int loops = 0;
                //while (numbers[loops]%2!=0)
                //{
                //    Console.WriteLine(numbers[loops].ToString());
                //    loops++;
                //}
                #endregion
                #region Ornek9
                // Ornek9();


                #endregion
                #region Ornek10
                // menu();
                #endregion
                #region Ornek11

                //Random rnd = new Random();
                //int Numberheld = rnd.Next(0, 100);
                //SayiTahminOyunu(Numberheld);

                #endregion
                #region Ornek 12
                AlanVeCevreHesaplama();

                #endregion


                #endregion
                Console.ReadKey();

            }
            catch (Exception)
            {


            }

        }

        private static void AlanVeCevreHesaplama()
        {

            string textToEnter = "Welcome To Geometrik Sekillerin Alan Ve Cevresini Hesaplama App";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));

            AnaMenu();


        }

        private static void AnaMenu()
        {
            int choose;


            string title = "Geometrik Sekiller";


            Console.WriteLine();
            Console.WriteLine(title);
            Console.WriteLine();

            for (int i = 0; i < sekil1.Length; i++)
            {
                Console.WriteLine(sekil1[i]);
            }
            Console.Write("Sekil Seciniz :");
            choose = Convert.ToInt16(Console.ReadLine());
            SecimMenu(choose, SecimMesajlar);
        }

        private static void SecimMenu(int choose, string[] SecimMesajlar)
        {

            switch (choose)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Kare'yi Sectiniz...");
                    Thread.Sleep(milliseconds);
                    Console.Clear();

                    try
                    {
                        IslemSecimiAltMenu(choose);
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    break;


                case 2:
                    Ucgen(choose);
                    break;

                case 3:
                    Dikdortgen(choose);
                    break;

                case 4:
                    Kure(choose);
                    break;
                case 5:
                    Koni(choose);
                    break;
                case 6:
                    Yamuk(choose);
                    break;
                default:
                    hataliSecim();
                    break;
            }
        }

        private static void Yamuk(int choose)
        {
            Console.Clear();
            Console.WriteLine("Yamuk Sectiniz...");
            Thread.Sleep(milliseconds);
            Console.Clear();
            IslemSecimiAltMenu(choose);
        }

        private static void Koni(int choose)
        {
            Console.Clear();
            Console.WriteLine("Koni Sectiniz...");
            Thread.Sleep(milliseconds);
            Console.Clear();
            IslemSecimiAltMenu(choose);
        }

        private static void Kure(int choose)
        {
            Console.Clear();
            Console.WriteLine("Kureyi Sectiniz...");
            Thread.Sleep(milliseconds);
            Console.Clear();
            IslemSecimiAltMenu(choose);
        }

        private static void Dikdortgen(int choose)
        {
            Console.Clear();
            Console.WriteLine("Dikdortgeni Sectiniz...");
            Thread.Sleep(milliseconds);
            Console.Clear();
            IslemSecimiAltMenu(choose);
        }

        private static void IslemSecimiAltMenu(int choose)
        {
            for (int i = 0; i < islemler.Length; i++)
            {
                Console.WriteLine(islemler[i]);

            }
            Console.Write("Isleminizi Seciniz:");
            IslemSecimi = Convert.ToInt16(Console.ReadLine());
            if (IslemSecimi == 1)
            {
                Console.Clear();
                Console.Write(SecimMesajlar[0]);
                Thread.Sleep(milliseconds);
                Console.Clear();
                switch (choose)
                {
                    case 1:
                        KareCevresi();
                        break;
                    case 2:
                        UcgenCevresi();
                        break;
                    case 3:
                        DikdortgenCevresi();
                        break;
                    case 4:
                        KureCevresi();
                        break;
                    case 5:
                        KoniCevresi();
                        break;
                    case 6:
                        YamukCevresi();
                        break;

                    default:
                        hataliSecim();
                        break;

                }


            }
            else if (IslemSecimi == 2)
            {
                Console.Clear();
                Console.WriteLine(SecimMesajlar[1]);
                Thread.Sleep(milliseconds);
                Console.Clear();

                switch (choose)
                {
                    case 1:
                        KareAlani();
                        break;
                    case 2:
                        UcgenAlani();
                        break;
                    case 3:
                        DikdortgenAlani();
                        break;
                    case 4:
                        KureAlani();
                        break;
                    case 5:
                        KoniAlani();
                        break;
                    case 6:
                        YamukAlani();
                        break;

                    default:
                        hataliSecim();
                        break;

                }

            }
        }

        private static void hataliSecim()
        {
            Console.Clear();
            Console.WriteLine("Hatali Secim.....");
            Console.Clear();

        }

        private static void YamukAlani()
        {
            int j = 1;
            int[] numbers = new int[2];
            Thread.Sleep(milliseconds);
            GeriMenu();


            Console.Clear();
            for (int i = 0; i < numbers.Length; i++)
            {
                do
                {
                    Console.Write("Yamuk {0}.Kenar(Paralel) Uzunlugunu Giriniz:", j);

                } while (!int.TryParse(Console.ReadLine(), out numbers[i]));
                j++;

            }
            int h;
            do
            {
                Console.Write("Yuksekligi Girin : ");

            } while (!int.TryParse(Console.ReadLine(), out h));
            
            if (numbers[0] == numbers[1])
            {
                Console.Clear();
                Console.WriteLine("Kenar Uzunluklarini Ayni Giriniz Tekrar Giris Yapiniz...");
                Thread.Sleep(milliseconds);
                YamukAlani();
            }

            int result =  ((numbers[0] + numbers[1])/2)*h;
            Console.Clear();

            Console.WriteLine("Sonuc :" + result);
            Thread.Sleep(milliseconds);
            Console.Clear();
            GeriMenu();
        }

        private static void YamukCevresi()
        {
            int j = 0,k=0;
            int[] kenarlar = new int[4];
            for (int i = 0; i < kenarlar.Length; i++)
            {
                j++;
                do
                {
                    Console.Write("{0}.Kenari Girin:" , j);
                } while (!int.TryParse(Console.ReadLine(), out kenarlar[i]));
                
            }

            

            for (int i = 0; i < kenarlar.Length; i++)
            {
                // if (kenarlar[i]== kenarlar[i+1])
                // {
                //     
                //     Console.WriteLine("Kenar Uzunluklari Ayni ");
                //     
                // }
                if (!Enumerable.Range(0, 3).Any(i => kenarlar[i] != kenarlar[i + 1]))
                {
                    Console.Clear();
                    Console.WriteLine("Kenar Uzunluklari Ayni "); 
                    Thread.Sleep(milliseconds);
                    YamukCevresi();
                }
            }
            


            int result = 0;
            for (int i = 0; i < kenarlar.Length; i++)
            {
                result += kenarlar[i];
            }
            Console.Clear();
            Console.WriteLine("Sonuc :" + result);
            Thread.Sleep(milliseconds);
            Console.Clear();
            GeriMenu();
        }


        private static void KoniAlani()
        {
            string[] data = { "h – yükseklik", "s – yanal yüzeyin yarıçapı", "r – çap", "d – yarıçap", "a - Ana doğrusunun uzunluğu" };
            int[] dataInt = new int[4];
            for (int i = 0; i < data.Length; i++)
            {
                do
                {
                    Console.Write("{0}." + i + " " + data[i] + " Giriniz: ");
                } while (!int.TryParse(Console.ReadLine(), out dataInt[i]));
            }

            
            double result=((3.14) * (dataInt[3]) * (dataInt[3])) + (2 * (3.14) * (dataInt[3]) * (dataInt[4]));
            Console.Clear();
            Console.Write("Sonuc :" + result);
            Thread.Sleep(milliseconds);
            Console.Clear();
            GeriMenu();



        }

        private static void KoniCevresi()
        {
            //2.π.r
            int r = 0;
            do
            {
                Console.Write("Yaricapi Giriniz :");
            } while (!int.TryParse(Console.ReadLine(), out r));
            double result = 2 * r * 3.14;
            Console.Clear();
            Console.Write("Sonuc :" + result);
            Thread.Sleep(milliseconds);
            Console.Clear();
            GeriMenu();
        }

        private static void KureAlani()
        {
            //4π.r2
            int r = 0;
            do
            {
                Console.Write("Yaricapi Giriniz :");
            } while (!int.TryParse(Console.ReadLine(), out r));
            double result = 4 * (r*r) * 3.14;
            Console.Clear();
            Console.Write("Sonuc :" + result);
            Thread.Sleep(milliseconds);
            Console.Clear();
            GeriMenu();

        }

        private static void KureCevresi()
        {
            int r = 0;
            do
            {
                Console.Write("Yaricapi Giriniz :");
            } while (!int.TryParse(Console.ReadLine(), out r));
            double result= 2*r*3.14;
            Console.Clear();
            Console.Write("Sonuc :"+result);
            Thread.Sleep(milliseconds);
            Console.Clear();
            GeriMenu();

        }

        private static void DikdortgenAlani()
        {
            int j = 1;
            int[] kenarlar = new int[2];
            for (int i = 0; i < kenarlar.Length; i++)
            {
                do
                {
                    Console.Write("{0}.Kenari Girin:",j);
                } while (!int.TryParse(Console.ReadLine(), out kenarlar[i]));
                j++;
            }
            if (kenarlar[j]==kenarlar[j+1])
            {
                Console.Clear();
                Console.WriteLine("Kenar Uzunluklari Ayni ");
                Thread.Sleep(milliseconds);
                DikdortgenAlani();
            }
            int result = kenarlar[0] * kenarlar[1];
            Console.Clear();
            Console.WriteLine("Sonuc :"+result);
            Thread.Sleep(milliseconds);
            Console.Clear();
            GeriMenu();

        }

        private static void DikdortgenCevresi()
        {
            int j = 1;
            int[] numbers = new int[2];
            

            Console.Clear();
            for (int i = 0; i < numbers.Length; i++)
            {
                do
                {
                    Console.Write("Dikdortgenin {0}.Kenar Uzunlugunu Giriniz:", j);

                } while (!int.TryParse(Console.ReadLine(), out numbers[i]));
                j++;

            }

            if (numbers[0] == numbers[1])
            {
                Console.Clear();
                Console.WriteLine("Kenar Uzunluklarini Ayni Giriniz Tekrar Giris Yapiniz...");
                Thread.Sleep(milliseconds);
                DikdortgenCevresi();
            }

            int result = 2 * (numbers[0] + numbers[1]);
            Console.Clear();

            Console.WriteLine("Sonuc :"+result);
            Thread.Sleep(milliseconds);
            Console.Clear();
            GeriMenu();

        }

        private static void UcgenAlani()
        {

            int taban, yükseklik;

            do
            {
                Console.Write("taban degerini giriniz ");

            } while (!int.TryParse(Console.ReadLine(), out taban));
            Console.Clear();
            do
            {
                Console.Write("yuksekluk degerini giriniz ");


            } while (!int.TryParse(Console.ReadLine(), out yükseklik));
            Console.Clear();
            Console.WriteLine("sonuc " + (taban * yükseklik) / 2);
            Thread.Sleep(milliseconds);
            GeriMenu();
        }

        private static void UcgenCevresi()
        {
            int n1 = 0, n2 = 0, n3 = 0;
            do
            {
                Console.Write("Ucgenin  1.Kenar Uzunlugunu Giriniz:");

            } while (!int.TryParse(Console.ReadLine(), out n1));
            Console.Clear();
            do
            {
                Console.Write("Ucgenin  1.Kenar Uzunlugunu Giriniz:");

            } while (!int.TryParse(Console.ReadLine(), out n2));
            Console.Clear();

            do
            {
                Console.Write("Ucgenin  1.Kenar Uzunlugunu Giriniz:");

            } while (!int.TryParse(Console.ReadLine(), out n3));


            int Sonuc = n1 + n2 + n3;
            Console.Clear();
            Console.WriteLine("Sonuc " + Sonuc);
            Thread.Sleep(milliseconds);
            GeriMenu();
        }

        private static void Ucgen(int choose)
        {
            Console.Clear();
            Console.WriteLine("Ucgenin Sectiniz....");
            Thread.Sleep(milliseconds);
            Console.Clear();
            for (int i = 0; i < islemler.Length; i++)
            {
                Console.WriteLine(islemler[i]);
            }
            IslemSecimiAltMenu(choose);


        }

        private static void KareAlani()
        {
            int uzunluk = 0;
            do
            {
                Console.Write("Karenin Tek Kenarinin Uzunlugunu Giriniz:");

            } while (!int.TryParse(Console.ReadLine(), out uzunluk));

            int sonuc = uzunluk * uzunluk;
            Console.Clear();
            Console.WriteLine("Sonuc " + sonuc);
            Thread.Sleep(milliseconds);
            GeriMenu();
        }

        private static void KareCevresi()
        {

            int uzunluk = 0;
            do
            {
                Console.Write("Karenin Tek Kenarinin Uzunlugunu Giriniz:");

            } while (!int.TryParse(Console.ReadLine(), out uzunluk));

            int sonuc = 4 * uzunluk;
            Console.Clear();
            Console.WriteLine("Sonuc " + sonuc);
            Thread.Sleep(milliseconds);
            GeriMenu();
        }

        private static void GeriMenu()
        {
            Console.Clear();
            Console.Write("Do you want to go back to the menu?(Y/N):");
            string choose = Console.ReadLine().Trim().ToUpper();
            Console.Clear();
            if (choose == "Y")
            {
                AnaMenu();
            }
            else
            {
                System.Environment.Exit(0);

            }
        }

        private static void SayiTahminOyunu(int Numberheld)
        {

            int loop = 0;
            int milliseconds = 2000;

            do
            {
                Console.Write("Enter the Number :");
                int number = Convert.ToInt16(Console.ReadLine());

                if (number > Numberheld)
                {
                    Console.WriteLine("Asagi");
                    Thread.Sleep(milliseconds);

                    Console.Clear();
                    SayiTahminOyunu(Numberheld);
                }
                else if (number < Numberheld)
                {
                    Console.WriteLine("Yukari");
                    Thread.Sleep(milliseconds);

                    Console.Clear();
                    SayiTahminOyunu(Numberheld);
                }
                else if (number == Numberheld)
                {
                    Console.WriteLine("Tahmin Ettin....");
                    Thread.Sleep(milliseconds);

                    System.Environment.Exit(0);

                }



                if (loop > 10)
                {
                    Console.WriteLine("Hakkiniz Bitti...");

                    System.Environment.Exit(0);

                }
                loop++;
            } while (loop <= 10);


        }

        private static void menu()
        {
            Console.Write("Enter the 1.Number:");
            int n1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the 2.Number:");
            int n2 = Convert.ToInt16(Console.ReadLine());


            Console.Clear();
            Console.WriteLine("1- Topla ");
            Console.WriteLine("2- Cikar ");
            Console.WriteLine("3- Carp");
            Console.Write("Seciniz :");
            int choose = Convert.ToInt16(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Toplama Secildi.");
                    topla(n1, n2);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Cikarma  Secildi");
                    cikar(n1, n2);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Carpma  Secildi");
                    carp(n1, n2);
                    break;
                default:
                    Console.WriteLine("Yanlis Secilim");
                    Console.Clear();
                    menu();
                    break;
            }
        }

        private static void carp(int n1, int n2)
        {
            Console.Clear();
            int result = n1 * n2;
            Console.WriteLine("Result is " + result);
            backmenu();
        }

        private static void cikar(int n1, int n2)
        {
            Console.Clear();
            int result = n1 - n2;
            Console.WriteLine("Result is " + result);
            backmenu();
        }

        private static void backmenu()
        {
            Console.Write("Do you want to go back to the menu?(Y/N):");
            string answer = Console.ReadLine().ToUpper().Trim();
            if (answer == "Y")
            {
                Console.Clear();
                menu();
            }
            else if (answer == "N")
            {
                System.Environment.Exit(0);
            }
        }

        private static void topla(int n1, int n2)
        {
            Console.Clear();
            int result = n1 + n2;
            Console.WriteLine("Result is " + result);
            backmenu();

        }

        private static void Ornek9()
        {
            int loop = 0;
            Random rnd = new Random();
            int rastgele = rnd.Next(1, 20);
            Console.Write("Bir Sayi Giriniz :");
            int data = Convert.ToInt16(Console.ReadLine());
            while (rastgele != data)
            {
                if (data > rastgele)
                {
                    Console.WriteLine("Asagi");
                    Console.Write("Bir Sayi Giriniz :");
                    data = Convert.ToInt16(Console.ReadLine());
                }
                else if (data < rastgele)
                {
                    Console.WriteLine("Yukari");
                    Console.Write("Bir Sayi Giriniz :");
                    data = Convert.ToInt16(Console.ReadLine());

                }
                loop++;
            }
            Console.WriteLine("Done " + loop);
        }
    }
}
