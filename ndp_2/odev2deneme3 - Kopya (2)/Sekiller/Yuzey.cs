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
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace odev2deneme3.Sekiller
{
    public class Yuzey : GeometrikSekiller
    {
        _3BoyuttaNokta nokta;
        int en;
        int boy; //boy=1;
        int derinlik;
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
        public Yuzey()
        {
            Random random = new Random();
            en = random.Next(1, 200); ;
            boy = 1;
            derinlik = random.Next(1,200);
            nokta = new _3BoyuttaNokta();

        }
        public Yuzey(_3BoyuttaNokta _nokta, int _x, int _z)

        {
            nokta = _nokta;
            en = _x;
            boy = 1;
            derinlik = _z;

        }
        public override void ciz(Panel panel)
        {
            Graphics g1 = panel.CreateGraphics(); // Panel üzerine çizmek için Graphics nesnesi oluştur

            Pen pen = new Pen(Color.Black);
            // Çizgiyi çiz
            
            g1.DrawLine(pen, nokta.X, nokta.Y, nokta.X + en ,+ nokta.Y);




        }
    }
}
