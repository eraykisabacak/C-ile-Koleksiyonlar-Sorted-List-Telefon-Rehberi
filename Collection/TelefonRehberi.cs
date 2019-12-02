using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class TelefonRehberi
    {
        static void Main(string[] args)
        {
            if(!File.Exists("../../veriler.txt"))
            {
                Console.WriteLine("Dosya Bulunamadı");
                Console.ReadLine();
                return;
            }

            string dosya_yolu = "../../veriler.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            SortedDictionary<string, SortedDictionary<string, string>> rehber = new SortedDictionary<string, SortedDictionary<string, string>>();

            string yazi = sr.ReadLine();

            while(yazi != null)
            {
                string[] dizi = yazi.Split('|');
                if (rehber.ContainsKey(dizi[1]))
                {
                    rehber[dizi[1]].Add(dizi[0], dizi[2]);
                }
                else
                {
                    rehber.Add(dizi[1], new SortedDictionary<string, string>());
                    rehber[dizi[1]].Add(dizi[0], dizi[2]);
                }
                yazi = sr.ReadLine();
            }

            sr.Close();
            fs.Close();

            foreach(var obje in rehber)
            {
                Console.WriteLine(obje.Key + " : ");

                foreach (var bilgiler in obje.Value)
                {
                    string txt = "\t" + bilgiler.Key;
                    for(int i = 0; i < 15-(bilgiler.Key.Length); i++)
                    {
                        txt += " ";
                    }
                    txt += " - ";
                    for (int i = 0; i < 20 - (bilgiler.Value.Length); i++)
                    {
                        txt += " ";
                    }
                    Console.WriteLine(txt + bilgiler.Value);
                }
            }

            Console.ReadLine();
        }
    }
}
