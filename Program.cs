using System;
using System.Collections;

namespace bm102._1
{
class Program
 {
        static void Main(string[] args)
        {
            Hashtable kutup = new Hashtable();
            Random sıra = new Random();
            Random sifre = new Random();
            int sayisi = kutup.Count;
            int sayisi2 = kutup.Count;
            ; int toplam = 100;
            int a;
            do
            {
                Console.WriteLine("oturmak için 1 silmek için 2 ye basınız,çıkmak için 0 a baınız");
                string b = Console.ReadLine();
                a = Convert.ToInt32(b);



                switch (a)
                {
                    case 1:

                        if (toplam > 1)
                        {


                            do
                            {

                                Console.Clear();
                                int oturma1 = sıra.Next(1, 100);
                                int oturmasifre1 = sifre.Next(10000, 100000);
                                bool kontrol1 = kutup.ContainsKey(oturma1);
                                bool kontrol2 = kutup.ContainsValue(oturmasifre1);
                                if (kontrol1 || kontrol2)
                                {
                                    do
                                    {
                                        int oturma2 = sıra.Next(1, 100);
                                        int oturmasifre2 = sifre.Next(10000, 100000);
                                        if (kutup.ContainsKey(oturma2) || kutup.ContainsValue(oturmasifre2))
                                        {

                                        }
                                        else
                                        {
                                            kutup.Add(oturma2, oturmasifre2);
                                            sayisi2++;
                                            Console.WriteLine("oturacağınız sıra= {0}, şifreniz={1}", oturma2.ToString(), oturmasifre2.ToString());
                                        }

                                    } while (sayisi == sayisi2);
                                    sayisi++;
                                }
                                else
                                {
                                    kutup.Add(oturma1, oturmasifre1);
                                    sayisi++;
                                    sayisi2++;
                                    Console.WriteLine("oturacağınız sıra= {0}, şifreniz={1}", oturma1.ToString(), oturmasifre1.ToString());

                                }



                                Console.WriteLine("yeni giriş eklemek için E / istemiyorsanız H basınız");
                                toplam--;

                            } while (Console.ReadLine().ToUpper() == "E");

                            if (toplam == 1)
                            {
                                Console.WriteLine("yer kalmamıştır.");
                                System.Threading.Thread.Sleep(5000);

                            }
                        }

                        break;
                    case 2:
                        Console.WriteLine("Lütfen koltuk numaranızı giriniz.");
                        string koltuk = Console.ReadLine();
                        int koltuk1 = Convert.ToInt32(koltuk);
                        Console.WriteLine("Lütfen şifrenizi giriniz.");
                        string sifre1 = Console.ReadLine();




                        if (Convert.ToString(kutup[koltuk1]) == sifre1)
                        {
                            kutup.Remove(koltuk1);
                            Console.WriteLine("koltuk kaldırılmıştır.");
                            System.Threading.Thread.Sleep(5000);

                        }
                        else
                        {
                            Console.WriteLine("şifre ve ya koltuk numarası yanlıştır.");
                        }



                        break;


                    default:
                        break;


                }
            } while (a != 0);


        }
    }
}
