using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;

namespace pr2
{
    class Program
    {
        static void Main(string[] args)
        {
  Yliopilane Kalle = new Yliopilane("Mees", "Kalle", 2000, 2, 450, "EUAS", "Veebiteh");
            Kalle.print();
            Kalle.kursus = 3;
            Kalle.stip = 480;
            Kalle.print();
            Yliopilane uusyliopilane = new Yliopilane();
            uusyliopilane.print();
            Yliopilane voorasYliopilane = new Yliopilane("Naine", "Piia");
            voorasYliopilane.print();

            Tootaja Juku = new Tootaja("Mees", "Juku",1995,"Wise","Admin",2400);
            Juku.print();
            Tootaja JukuKloon = new Tootaja(Juku);
            JukuKloon.print();

            GymnaasiumiOpilane John = new GymnaasiumiOpilane("Mees", "John", 2003, "Miina Härma", 12, "Filosoofia");
            John.print();

            GymnaasiumiOpilane Kelly = new GymnaasiumiOpilane("Naine", "Kelly", 2004, "Reaalkool", 11, "Fyysika");
            Kelly.print();

            Tootaja Pille = new Tootaja("Naine", "Pille", 1997, "Skype", "Testija", 2500);
            Pille.print();

            Yliopilane Rene = new Yliopilane("Mees", "Rene", 2001, 3, 410, "TTY", "Java Prog");
            Rene.print();

            List<Isik> kohvikuKylastajad = new List<Isik>();
            kohvikuKylastajad.Add(Pille);
            kohvikuKylastajad.Add(Rene);
            kohvikuKylastajad.Add(John);
            kohvikuKylastajad.Add(Kelly);
            kohvikuKylastajad.Add(Juku);
            kohvikuKylastajad.Add(Kalle);
            Console.WriteLine("\n");
            StreamWriter sw = new StreamWriter(@"..\..\..\file.txt", false);
            foreach (Isik x in kohvikuKylastajad) 
            {
                sw.WriteLine(x.nimi + ","  + x.sugu + ",");
            }
            sw.Close();
            
            List<Tootaja> tootajad = new List<Tootaja>();
            StreamReader sr = new StreamReader(@"..\..\..\file.txt");
            string text;
            while ((text=sr.ReadLine())!=null)
            {
                string[] rida = text.Split(',');
                tootajad.Add(new Tootaja(rida[0], rida[1]));
            }
            sr.Close();
            foreach (var item in tootajad)
            {
                Console.WriteLine(item.nimi+" "+item.sugu);
            }
            Console.ReadLine();
           
            

        }

        
    }
}
