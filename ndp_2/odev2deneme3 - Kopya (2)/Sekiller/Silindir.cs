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
    public class Silindir :GeometrikSekiller
    {
        _3BoyuttaNokta nokta;
        int yaricap;
        int h;
        public int H
        {
            set { h = value; }
            get { return h; }

        }

        public _3BoyuttaNokta NOKTA
        {
            get { return nokta; }
            set { nokta = value; }

        }
        public int YARİCAP
        {
            get
            { return yaricap; }
            set { yaricap = value; }
        }
        public Silindir()
        {

            nokta = new _3BoyuttaNokta();
            yaricap = 0;
            h = 0;
        }
        public Silindir(_3BoyuttaNokta Nokta, int _yaricap, int _h)
        {
            nokta = Nokta;
            yaricap = _yaricap;
            h = _h;
        }
       
        public override void ciz(Panel panel)
        {
             Graphics g = panel.CreateGraphics(); // Panel üzerine çizmek için Graphics nesnesi oluştur

             Pen pen = new Pen(Color.Red);
            /*Rectangle dikdortgen = new Rectangle(nokta.X, nokta.Y,yaricap, yaricap);
            Brush brush = new SolidBrush(Color.Red);
            // Kullanıcının girdiği şekle göre çizimi gerçekleştir
            g1.FillEllipse(brush, dikdortgen);*/


            g.DrawEllipse(Pens.Black, nokta.X ,nokta. Y ,  yaricap, yaricap/2);    //silindirin üst yüzeyi çizilir
                g.DrawEllipse(Pens.Black, nokta.X, nokta.Y + H , yaricap, yaricap/2);     // Silindirin alt yüzeyi çizilir
                g.DrawLine(Pens.Black, nokta.X , nokta.Y + yaricap/4,nokta. X, nokta.Y + H + yaricap/4   );          //Çemberler çizgilerle birleştiriliyor.
                g.DrawLine(Pens.Black,nokta. X + yaricap  , nokta.Y + yaricap/4   , nokta.X + yaricap  , nokta.Y + H + yaricap/4  );
            
        }
    }
}
