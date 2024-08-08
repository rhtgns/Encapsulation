using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Kitap
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }


        private int kapiSayisi;

        public int KapiSayisi
        {

            //burda kapı saysını kapsülleme işlemi yapacagız
            get { return kapiSayisi; }
            set
            {
                //eger kapı sayısı 2 ve ya 4 ise deger atayacagız ama degılse ekrana uyarı cıktısı verecegız

                if (value == 2 || value == 4)
                {

                    kapiSayisi = value;
                }
                else
                {
                    Console.WriteLine("Uyarı:Kapı sayisi sdaece 2 ve 4 olabilir.");
                    kapiSayisi = -1; // burda gecerli olmazsa  kapı syısını bir düşürür                }

                }
            }
        }

        // yapıcı fonskiyonumuzu yazalım (constructor)

        public Araba(string marka, string model, string renk, int kapiSayisi)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            KapiSayisi = kapiSayisi;//bu kodda en başından planladıgımız kapsülleme devreye giriyor
        }

    }