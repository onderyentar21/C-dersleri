using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyKullanimi
{
     class PersonelInfo
    {
        private String TcNo;


        public String TCKIMLIKNO {
            get
            {
                return TcNo.Substring(0, 4)+"******";

            }

            set
            {
                bool kontrol = false;

                if (value.Length == 11)
                {
                    for(int i =0; i<value.Length; i++)
                    {

                     bool sayimi =  char.IsNumber(value[i]);

                        if (sayimi)
                        {
                            // yapmam gereken bişi yok
                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    if(kontrol)
                    {
                        Console.WriteLine("Lütfen TC kimlik No içinde sayi kullanınnız..");
                        Console.ReadLine();
                    }
                    else
                    {
                        TcNo = value;
                    }
                    
                }
                else
                {
                    Console.WriteLine("GİRDİĞİNİZ TC 11 HANELİ DEĞİLDİR.");
                    Console.ReadLine();
                }
            }


        
        }
    }
}
