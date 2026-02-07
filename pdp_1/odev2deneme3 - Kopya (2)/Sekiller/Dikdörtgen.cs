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
    public class Dikdörtgen : GeometrikSekiller
    {
        _3BoyuttaNokta  nokta;
        int en, boy;
        public _3BoyuttaNokta NOKTA
        {
            set
            {
                nokta = value;
            }
            get
            {
                return nokta;
            }

        }
        public int EN
        {
            get { return en; }
            set { en = value; }

        }
        public int BOY
        {
            set { boy = value; }
            get { return boy; }
        }
        public Dikdörtgen()
        {
            Random random = new Random();
            EN = random.Next(1, 200);
            BOY = random.Next(1, 200);
            nokta = new _3BoyuttaNokta();


        }
        public Dikdörtgen(int _en, int _boy, _3BoyuttaNokta _nokta)
        {
            EN = _en;
            BOY = _boy;
            NOKTA = _nokta;
        }
        public override void ciz(Panel panel)
        {


            Graphics g1 = panel.CreateGraphics(); // Panel üzerine çizmek için Graphics nesnesi oluştur

            Pen pen = new Pen(Color.Black);
            Rectangle dikdortgen = new Rectangle(nokta.X, nokta.Y, en, boy);
            Brush brush = new SolidBrush(Color.Blue);
            // Kullanıcının girdiği şekle göre çizimi gerçekleştir
            g1.DrawRectangle(pen, dikdortgen);

        }



    }
}
