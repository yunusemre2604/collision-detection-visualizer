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


using odev2deneme3.Sekiller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace odev2deneme3.Sekiller
{
    public class Kure :GeometrikSekiller
    {
        _3BoyuttaNokta nokta;
        int yaricap;
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
        public Kure()
        {

            nokta = new _3BoyuttaNokta();
            yaricap = 0;
        }
        public Kure(_3BoyuttaNokta Nokta, int _yaricap)
        {
            nokta = Nokta;
            yaricap = _yaricap;
        }
        public override void ciz(Panel panel)
        {
            Graphics g1 = panel.CreateGraphics(); // Panel üzerine çizmek için Graphics nesnesi oluştur

            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Black);
            /*Rectangle dikdortgen = new Rectangle(nokta.X, nokta.Y, yaricap, yaricap);
            g1.FillEllipse(brush, dikdortgen);*/
            g1.DrawEllipse(Pens.Black, nokta.X  ,nokta. Y , yaricap,  yaricap);     //Kürenin tamamını çizer
            g1.DrawEllipse(Pens.Black, nokta.X, nokta.Y +yaricap/(50/18), yaricap, 0.2f * yaricap);      // Kürenin ekvatorunu çizer
            g1.DrawPie(Pens.Black, nokta.X , nokta.Y ,  yaricap,  yaricap, 0, 180);     //Kürenin yarısını çizer

        }


    }
}
