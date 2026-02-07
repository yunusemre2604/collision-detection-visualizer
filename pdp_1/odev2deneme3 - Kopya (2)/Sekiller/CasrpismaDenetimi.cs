
/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**			         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				         NESNEYE DAYALI PROGRAMLAMA DERSİ
**	
**				ÖDEV NUMARASI…...: 2
**				ÖĞRENCİ ADI...............: Yunus Emre YILDIZ
**				ÖĞRENCİ NUMARASI.: B231210378
**				DERS GRUBU…………: 1. ÖĞRETİM A GRUBU
****************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace odev2deneme3.Sekiller
{
    public static class CarpismaDenetimi
    {
        public static bool noktaCemberCarpismasi(Nokta n1, Cember c)
        {
            double c_yaricap = c.R / 2;
            double c_merkezX = c.NOKTA.X + c_yaricap;
            double c_merkezY = c.NOKTA.Y + c_yaricap;
            double FarkX = Math.Abs(c_merkezX - n1.X);
            double FarkY = Math.Abs(c_merkezY - n1.Y);
            double Hipotenus = Math.Sqrt((FarkX * FarkX) + (FarkY * FarkY));
            if (Hipotenus < c.R / 2) // HİPOTENUS YARIÇAPTAN KÜÇÜKSE true döndür.
            {
                return true;
            }
            return false;



        }
        public static bool DikdörtgenCemberCarpismasi(Dikdörtgen d, Cember c)
        {
            double Hipotenus, FarkX = 0, FarkY = 0;
            double c_yaricap = c.R / 2;
            double c_merkezX = c.NOKTA.X + c_yaricap;
            double c_merkezY = c.NOKTA.Y + c_yaricap;
            double dortgen_merkezX = d.NOKTA.X + d.EN / 2;
            double dortgen_merkezY = d.NOKTA.Y + d.BOY / 2;
            double dortgen_minX = d.NOKTA.X;
            double dortgen_maxX = d.NOKTA.X + d.EN;
            double dortgen_minY = d.NOKTA.Y;
            double dortgen_maxY = d.NOKTA.Y + d.BOY;
            if (c_merkezY < dortgen_minY)
            {
                FarkY = (c_merkezY - dortgen_minY);
            }
            if (c_merkezY > dortgen_maxY)
            {
                FarkY = c_merkezY - dortgen_maxY;
            }
            if (c_merkezX > dortgen_maxX)
            {
                FarkX = c_merkezX - dortgen_maxX;
            }
            if (c_merkezX < dortgen_minX)
            {
                FarkX = c_merkezX - dortgen_minX;
            }
            Hipotenus = Math.Sqrt((FarkX * FarkX) + (FarkY * FarkY));
            if (Hipotenus < c.R / 2) //hipotenüs yarıçaptan küçükse true döndür.
            {
                return true;
            }
            return false;
        }
        public static bool dikdortgenCarp(Dikdörtgen d1, Dikdörtgen d2)
        {
            int Xa = d1.NOKTA.X + d1.EN / 2;
            int Ya = d1.NOKTA.Y + d1.BOY / 2;
            int Xb = d2.NOKTA.X + d2.EN / 2;
            int Yb = d2.NOKTA.Y + d2.BOY / 2;

            if (Math.Abs(Xa - Xb) < (d1.EN / 2 + d2.EN / 2) && Math.Abs(Ya - Yb) < (d1.BOY / 2 + d2.BOY / 2)) // merkez noktalar arasındaki fark enlerin ,boyların yarısının toplamından küçükse true döndür.
                return true;
            else
                return false;
        }
        public static bool circleCarp(Cember c1, Cember c2)
        {
            {
                float d = (float)Math.Sqrt(Math.Pow(((c1.NOKTA.X + (c1.R / 2)) - (c2.NOKTA.X + (c2.R / 2))), 2) + Math.Pow(((c1.NOKTA.Y + (c1.R / 2)) - (c2.NOKTA.Y + (c2.R / 2))), 2));
                //Console.WriteLine(d);
                if (((c1.R / 2) + (c2.R / 2)) > d) // yarıçapların toplamı d den büyükse true döndür.
                    return true;
                else
                    return false;
            }


        }
        public static bool NoktaDikdörtgenCarp(Nokta n1, Dikdörtgen d1)
        {
            if (n1.X > d1.NOKTA.X && n1.X < (d1.NOKTA.X + d1.EN) && n1.Y > d1.NOKTA.Y && n1.Y < d1.NOKTA.Y + d1.BOY)// merkez noktalar arasındaki fark enlerin ,boyların yarısının toplamından küçükse true döndür.
            {
                return true;
            }
            else
                return false;
        }
        public static bool NoktaKureCarp(_3BoyuttaNokta nokta , Kure kure)
        {
            double mx1 = kure.NOKTA.X + kure.YARİCAP / 2;
            double my1 = kure.NOKTA.Y+ kure.YARİCAP/2; 
            double mz1 = kure.NOKTA.Z + kure.YARİCAP / 2;
            double derinlik = kure.YARİCAP;
            if (Math.Abs(nokta.X - mx1) <= kure.YARİCAP / 2 && Math.Abs(nokta.Y - my1) <= kure.YARİCAP / 2 && Math.Abs(nokta.Z - mz1) <= kure.YARİCAP / 2)// merkez noktalar arasındaki fark enlerin ,boyların ,derinliklerin yarısının toplamından küçükse true döndür.
            {
                return true;
            }
            return false;
        }
        public static bool NoktaDikdörtgenPrizmaCarp(_3BoyuttaNokta n1, DikdortgenPrizma p1)
        {
           
            if (n1.X > p1.NOKTA.X && n1.X < (p1.NOKTA.X + p1.EN) && n1.Y > p1.NOKTA.Y && n1.Y < p1.NOKTA.Y + p1.BOY && n1.Z > p1.NOKTA.Z && n1.Z < (p1.NOKTA.Z + p1.DERİNLİK))// merkez noktalar arasındaki fark enlerin ,boyların,derinliklerin yarısının toplamından küçükse true döndür.
            {
                return true;
            }
            else
                return false;

        }
        public static bool NoktaSilindirCarp(_3BoyuttaNokta nokta , Silindir s1)
        {
            double mx1 = s1.NOKTA.X + s1.YARİCAP / 2;
            double my1 = s1.NOKTA.Y + s1.YARİCAP / 2;
            double mz1 = s1.NOKTA.Z + s1.H / 2;
            if (Math.Abs(nokta.X - mx1) <= s1.YARİCAP / 2 && Math.Abs(nokta.Y - my1) <= s1.YARİCAP / 2 && Math.Abs(nokta.Z - mz1) <= s1.H / 2)// merkez noktalar arasındaki fark enlerin ,boyların ,derinliklerin yarısının toplamından küçükse true döndür.
            {
                return true;
            }
            else return false;
        }
        public static bool SilindirCarp(Silindir s1,Silindir s2)
        {
            double mx1 = s1.NOKTA.X + s1.YARİCAP / 2;
            double my1 = s1.NOKTA.Y + s1.YARİCAP / 2;
            double mz1 = s1.NOKTA.Z + s1.H / 2;
            double mx2 = s2.NOKTA.X + s2.YARİCAP / 2;
            double my2 = s2.NOKTA.Y + s2.YARİCAP / 2;
            double mz2 = s2.NOKTA.Z + s2.H / 2;
            if (Math.Abs(mx2 - mx1) <= (s1.YARİCAP / 2 +  s2.YARİCAP / 2) && Math.Abs(my2 - my1) <= (s1.YARİCAP / 2 + s2.YARİCAP / 2) && Math.Abs(mz2 - mz1) <= (s1.H / 2 + s2.H / 2))// merkez noktalar arasındaki fark enlerin ,boyların,derinliklerin  yarısının toplamından küçükse true döndür.
            {
                return true;
            }
            else return false;

        }
        public static bool KureCarp(Kure k1, Kure k2)
        {
            double mx1 = k1.NOKTA.X + k1.YARİCAP / 2;
            double my1 = k1.NOKTA.Y + k1.YARİCAP / 2;
            double mz1 = k1.NOKTA.Z + k1.YARİCAP / 2;
            double mx2 = k2.NOKTA.X + k2.YARİCAP / 2;
            double my2 = k2.NOKTA.Y + k2.YARİCAP / 2;
            double mz2 = k2.NOKTA.Z + k2.YARİCAP / 2;
            if (Math.Abs(mx2 - mx1) <= (k1.YARİCAP / 2 + k2.YARİCAP / 2) && Math.Abs(my2 - my1) <= (k1.YARİCAP / 2 + k2.YARİCAP / 2) && Math.Abs(mz2 - mz1) <= (k1.YARİCAP / 2 + k2.YARİCAP / 2))// merkez noktalar arasındaki fark enlerin ,boyların,derinliklerin  yarısının toplamından küçükse true döndür.
            {
                return true;
            }
            else return false;

        }
        public static bool SilindirKureCarp(Silindir s2, Kure k1)
        {
            double mx1 = k1.NOKTA.X + k1.YARİCAP / 2;
            double my1 = k1.NOKTA.Y + k1.YARİCAP / 2;
            double mz1 = k1.NOKTA.Z + k1.YARİCAP / 2;
            double mx2 = s2.NOKTA.X + s2.YARİCAP / 2;
            double my2 = s2.NOKTA.Y + s2.YARİCAP / 2;
            double mz2 = s2.NOKTA.Z + s2.H / 2;
            if (Math.Abs(mx2 - mx1) <= (k1.YARİCAP / 2 + s2.YARİCAP / 2) && Math.Abs(my2 - my1) <= (k1.YARİCAP / 2 + s2.YARİCAP / 2) && Math.Abs(mz2 - mz1) <= (k1.YARİCAP / 2 + s2.H / 2))// merkez noktalar arasındaki fark enlerin ,boyların,derinliklerin  yarısının toplamından küçükse true döndür.
            {
                return true;
            }
            else return false;

        }
        public static bool YuzeyKureCarp( Kure k1 , Yuzey y2)
        {
            double mx1 = k1.NOKTA.X + k1.YARİCAP / 2;
            double my1 = k1.NOKTA.Y + k1.YARİCAP / 2;
            double mz1 = k1.NOKTA.Z + k1.YARİCAP / 2;
            double mx2 = y2.NOKTA.X + y2.EN / 2;
            
            double mz2 = y2.NOKTA.Z + y2.DERİNLİK / 2;
            if (Math.Abs(mx2 - mx1) <= (k1.YARİCAP / 2 + y2.EN / 2)  && Math.Abs(mz2 - mz1) <= (k1.YARİCAP / 2 + y2.DERİNLİK / 2))// merkez noktalar arasındaki fark enlerin ,boyların,derinliklerin  yarısının toplamından küçükse true döndür.
            {
                return true;
            }
            else return false;
        }
        public static bool YuzeyPrizmaCarp(DikdortgenPrizma p1, Yuzey y2)
        {
            double mx1 = p1.NOKTA.X + p1.EN / 2;
            double my1 = p1.NOKTA.Y + p1.BOY / 2;
            double mz1 = p1.NOKTA.Z + p1.DERİNLİK / 2;
            double mx2 = y2.NOKTA.X + y2.EN / 2;

            double mz2 = y2.NOKTA.Z + y2.DERİNLİK / 2;
           
            if (Math.Abs(mx2 - mx1) <= (p1.EN / 2 + y2.EN / 2) && Math.Abs(mz2 - mz1) <= (p1.DERİNLİK / 2 + y2.DERİNLİK / 2))// merkez noktalar arasındaki fark enlerin ,boyların,derinliklerin  yarısının toplamından küçükse true döndür.
            {
                return true;
            }
            else return false;
        }
        public static bool YuzeySilindirCarp(Silindir s1, Yuzey y2)
        {
            double mx1 = s1.NOKTA.X + s1.YARİCAP / 2;
            double my1 = s1.NOKTA.Y + s1.YARİCAP / 2;
            double mz1 = s1.NOKTA.Z + s1.H / 2;
            double mx2 = y2.NOKTA.X + y2.EN / 2;

            double mz2 = y2.NOKTA.Z + y2.DERİNLİK / 2;

            if (Math.Abs(mx2 - mx1) <= (s1.YARİCAP / 2 + y2.EN / 2) && Math.Abs(mz2 - mz1) <= (s1.H / 2 + y2.DERİNLİK / 2))// merkez noktalar arasındaki fark enlerin ,boyların,derinliklerin  yarısının toplamından küçükse true döndür.
            {
                return true;
            }
            else return false;
        }
        public static bool KurePrizmaCarp(Kure k1, DikdortgenPrizma p2)
        {
            double mx1 = k1.NOKTA.X + k1.YARİCAP / 2;
            double my1 = k1.NOKTA.Y + k1.YARİCAP / 2;
            double mz1 = k1.NOKTA.Z + k1.YARİCAP / 2;
            double mx2 = p2.NOKTA.X + p2.EN / 2;
            double my2 = p2.NOKTA.Y + p2.BOY / 2;
            double mz2 = p2.NOKTA.Z + p2.DERİNLİK / 2;

            if (Math.Abs(mx2 - mx1) <= (k1.YARİCAP / 2 + p2.EN / 2) && Math.Abs(my2 - my1) <= (k1.YARİCAP / 2 + p2.BOY / 2) && Math.Abs(mz2 - mz1) <= (k1.YARİCAP / 2 + p2.DERİNLİK / 2))// merkez noktalar arasındaki fark enlerin ,boyların,derinliklerin  yarısının toplamından küçükse true döndür.
            {
                return true;
            }
            else return false;
        }
        public static bool PrizmaCarp(DikdortgenPrizma p1, DikdortgenPrizma p2)
        {
            double mx1 = p1.NOKTA.X + p1.EN / 2;
            double my1 = p1.NOKTA.Y + p1.BOY / 2;
            double mz1 = p1.NOKTA.Z + p1.DERİNLİK / 2;
            double mx2 = p2.NOKTA.X + p2.EN / 2;
            double my2 = p2.NOKTA.Y + p2.BOY / 2;
            double mz2 = p2.NOKTA.Z + p2.DERİNLİK / 2;

            if (Math.Abs(mx2 - mx1) <= (p1.EN / 2 + p2.EN / 2) && Math.Abs(my2 - my1) <= (p1.BOY / 2 + p2.BOY / 2) && Math.Abs(mz2 - mz1) <= (p1.DERİNLİK / 2 + p2.DERİNLİK / 2))// merkez noktalar arasındaki fark enlerin ,boyların,derinliklerin  yarısının toplamından küçükse true döndür.
            {
                return true;
            }
            else return false;
        }
    }
}
