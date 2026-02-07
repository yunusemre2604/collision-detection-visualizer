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
using System.Text;
using System.Threading.Tasks;

namespace odev2deneme3.Sekiller
{
    public class DikdortgenPrizma : GeometrikSekiller
    {
        _3BoyuttaNokta nokta;
        int en; // EN
        int boy; //BOY
        int derinlik; // DERİNLİK
        public _3BoyuttaNokta NOKTA
        {
            get { return nokta; }
            set { nokta = value; }

        }
        public int EN
        {
            set { en = value; }
            get { return en; }


        }
        public int BOY
        {
            set { boy = value; }
            get { return boy; }

        }
        public int DERİNLİK
        {
            set { derinlik = value; }
            get { return derinlik; }



        }
        public DikdortgenPrizma()
        {
            en = 0;
            boy = 0;
            derinlik = 0;
            nokta = new _3BoyuttaNokta();

        }
        public DikdortgenPrizma(_3BoyuttaNokta _nokta, int _x, int _y, int _z)

        {
            nokta = _nokta;
            en = _x;
            boy = _y;
            derinlik = _z;

        }
        public override void ciz(Panel panel)
        {
            
        


        Graphics g = panel.CreateGraphics(); // Panel üzerine çizmek için Graphics nesnesi oluştur

        Pen pen = new Pen(Color.Black);
            /*Rectangle dikdortgen = new Rectangle(nokta.X, nokta.Y, en, boy);
             Brush brush = new SolidBrush(Color.Blue);
            // Kullanıcının girdiği şekle göre çizimi gerçekleştir
            g1.FillRectangle(brush, dikdortgen);*/
           
                g.DrawRectangle(Pens.Black, nokta.X, nokta.Y, en, boy);
                g.DrawRectangle(Pens.Black, nokta.X + en, nokta.Y + en, en, boy); ;     //Koordinat bilgileri ile ikinci dikdörtgen çizilir

                g.DrawLine(Pens.Black, nokta.X, nokta.Y, nokta.X + en, nokta.Y + en);                                //İki dikdörtgenenin köşeleri çizgiler ile birleştirildi
                g.DrawLine(Pens.Black, nokta.X + en, nokta.Y, nokta.X + 2 * en, nokta.Y + en);
                g.DrawLine(Pens.Black, nokta.X, nokta.Y + boy, nokta.X + en, nokta.Y + en + boy);
                g.DrawLine(Pens.Black, nokta.X + en, nokta.Y + boy, nokta.X + 2 * en, nokta.Y + en + boy);




            /*Graphics g1 = panel.CreateGraphics();
            Pen pen = new Pen(Color.DarkGreen);

            Rectangle dikdörtgen1 = new Rectangle(_3dNokta.X, _3dNokta.Y, en / _3dNokta.Z, boy / _3dNokta.Z);
            g1.DrawRectangle(pen, dikdörtgen1);
            if (derinlik == 0)
            {
                derinlik = 1;
            }

            if ((en - derinlik) - (2 * derinlik) > 0 && (boy - derinlik) - (2 * derinlik) > 0)
            {
                Rectangle dikdörtgen2 = new Rectangle(_3dNokta.X + derinlik, _3dNokta.Y + derinlik, (en - derinlik) - (2 * derinlik), (boy - derinlik) - (2 * derinlik));
                g1.DrawRectangle(pen, dikdörtgen2);
            }
            else if ((en - derinlik) - (2 * derinlik) <= 0 || (boy - derinlik) - (2 * derinlik) <= 0)
            {
                Rectangle dikdörtgen2 = new Rectangle((_3dNokta.X + en) / 2, (_3dNokta.Y + en) / 2, 1, 1);*/
            //g1.DrawRectangle(pen, dikdörtgen2);
            //}


            /* g1.DrawRectangle(pen, _3dNokta.X, _3dNokta.Y , x, z);
             g1.DrawRectangle(pen, _3dNokta.X + y, _3dNokta.Y + y, x, z);
             g1.DrawLine(pen, _3dNokta.X, _3dNokta.Y, _3dNokta.X + x, _3dNokta.Y + z);

             g1.DrawLine(pen, _3dNokta.X+x, _3dNokta.Y, _3dNokta.X + y+z, _3dNokta.Y+z);

             g1.DrawLine(pen, _3dNokta.X , _3dNokta.Y +x, _3dNokta.X +z, _3dNokta.Y +x +z);

             g1.DrawLine(pen, _3dNokta.X + y, _3dNokta.Y + x, _3dNokta.X+x + z +y , _3dNokta.Y + x + z);*/

        }


    }
}
