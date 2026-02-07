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
    public class Cember : GeometrikSekiller
    {
        Nokta nokta;
        int r;
        public Nokta NOKTA
        {
            get { return nokta; }
            set { nokta = value; }

        }
        public int R
        {
            set { r = value; }
            get { return r; }
        }
        public Cember()
        {
            Random random = new Random();
            R = 0;
            nokta = new Nokta();

        }
        public Cember(int _x, Nokta _nokta)
        {
            R = _x;
            nokta = _nokta;
        }
        public override void ciz(Panel panel)
        {



            Graphics g1 = panel.CreateGraphics(); // Panel üzerine çizmek için Graphics nesnesi oluştur

            Pen pen = new Pen(Color.Red);
            Rectangle dikdortgen = new Rectangle(nokta.X, nokta.Y, r, r);

            // Kullanıcının girdiği şekle göre çizimi gerçekleştir
            g1.DrawEllipse(pen, dikdortgen);
        }
    }
}
