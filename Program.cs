using System;

namespace bilgi_yarismasi1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bilgi Yarışmasına Hoşgeldiniz");
            Console.WriteLine();
            Console.WriteLine("*************");
            string cevap;
            //çift tırnak
            int soru = 1;
            if(soru==1)
            {
                Console.WriteLine("1-Hangisi dünyanın bir harikasıdır? ");
                Console.WriteLine();
                Console.WriteLine("A-) Max Verstappen.");
                Console.WriteLine("B-) Şeftali.");
                Console.WriteLine("C-) Bateri.");
                Console.WriteLine("D-) Bunu okuyan sen... :) ");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap == "d" | cevap == "D")
                {
                    Console.Write("Doğru cevap.");
                    soru = soru + 1;

                }
                else
                {
                    Console.Write("Yanlış cevap. ");
                   
                }

                if(soru==2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("2-29 Ekim 1923 nedir?");
                    Console.WriteLine();
                    Console.WriteLine("A-) Ramazan Bayramı.");
                    Console.WriteLine("B-) Cumhuriyet'in ilanı.");
                    Console.WriteLine("C-) Zafer Bayramı.");
                    Console.WriteLine("D-) TBMM'nin açılması.");
                    Console.WriteLine();
                    Console.Write("Cevabınız: ");
                    cevap = Console.ReadLine();

                    if(cevap=="b" || cevap=="B")
                    {
                        Console.Write("Doğru cevap.");
                        soru = soru + 1;
                    }
                    else
                    {
                        Console.Write("Yanlış cevap.");
                    }



                }
                if(soru==3)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("3-Hamza hangisini çok seviyordur?");
                    Console.WriteLine();
                    Console.WriteLine("A-) Travis Scott.");
                    Console.WriteLine("B-) MGK.");
                    Console.WriteLine("C-) Hepsi.");
                    Console.WriteLine("D-) Linkin Park.");
                    Console.WriteLine();
                    Console.Write("Cevabınız: ");
                    cevap = Console.ReadLine();
                    if(cevap=="c" || cevap=="C")
                    {
                        Console.WriteLine("Beni tanıyorsun aferin");

                        
                    }
                    else
                    {
                        Console.Write("yanılmışsın güzelim..");
                    }


                }

               

            }
            Console.WriteLine();
            
            Console.Read();
           

        }

    }
}
