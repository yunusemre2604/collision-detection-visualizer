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
    public class Nokta : GeometrikSekiller
    {
        int x, y;
        public int X
        {
            get { return x; }
            set { x = value; }

        }
        public int Y
        {
            set { y = value; }
            get { return y; }
        }
        public Nokta()
        {
            Random random = new Random();
            X = random.Next(1, 200);
            Y = random.Next(1, 200);

        }
        public Nokta(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }
        public override void ciz(Panel panel)
        {



            Graphics g1 = panel.CreateGraphics(); // Panel üzerine çizmek için Graphics nesnesi oluştur

            Pen pen = new Pen(Color.Black);
            Rectangle dikdortgen = new Rectangle(X, Y, 1, 1);

            // Kullanıcının girdiği şekle göre çizimi gerçekleştir
            g1.DrawEllipse(pen, dikdortgen);

        }

    }
}
