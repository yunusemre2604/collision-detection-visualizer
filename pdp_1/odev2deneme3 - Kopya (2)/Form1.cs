using odev2deneme3.Sekiller;

namespace odev2deneme3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<GeometrikSekiller> GeometrikSekillerrr = new List<GeometrikSekiller>();
        Dikdörtgen d1 = new Dikdörtgen();
        Dikdörtgen d2 = new Dikdörtgen();
        Cember c1 = new Cember();
        Cember c2 = new Cember();
        Nokta n1 = new Nokta();
        Kure k1 = new Kure();
        Kure k2 = new Kure();
        _3BoyuttaNokta n3d1 = new _3BoyuttaNokta();
        _3BoyuttaNokta n3d2 = new _3BoyuttaNokta();
        DikdortgenPrizma prizma1 = new DikdortgenPrizma();
        DikdortgenPrizma prizma2 = new DikdortgenPrizma();
        Silindir silindir1 = new Silindir();
        Silindir silindir2 = new Silindir();
        Yuzey y1 = new Yuzey();
        Yuzey y2 = new Yuzey();

        private void button1_Click(object sender, EventArgs e)
        {
            //System.Drawing.Graphics grafiknesnem;
            /*grafiknesnem = this.CreateGraphics();
            Pen kalem = new Pen(System.Drawing.Color.Green, 5);
            
            DikdortgenPrizma d =new DikdortgenPrizma();
            Dikdörtgen d1 = new Dikdörtgen();
            Nokta n =new Nokta();
            Cember cember = new Cember();
            d._3DNOKTA.X = int.Parse(tbX1.Text);
            d._3DNOKTA.Y = int.Parse(tbY1.Text);
            d._3DNOKTA.Z  = int.Parse(tbZ1.Text);
            d.EN = int.Parse(tbEn1.Text);  
            d.BOY = int.Parse(tbBoy1.Text);
            d.DERÝNLÝK = int.Parse(tbDerinlik1.Text);*/


            // n.X = int.Parse(tbX3.Text);
            //n.Y = int.Parse(tby3.Text);

            //d1.NOKTA.X = int.Parse(tbx2.Text);
            //d1.NOKTA.Y = int.Parse(tby2.Text);
            //d1.EN = int.Parse(TBen2.Text);
            //d1.BOY = int.Parse(tbboy2.Text);

            /*cember.NOKTA.X = int.Parse(tbX3.Text);
            cember.NOKTA.Y = int.Parse(tby3.Text);
            cember.R = int.Parse(tbyaricap.Text);*/



            /*d.ciz(form2);
            //n.ciz(form2);
            //cember.DrawCircle(form2);*/
            if (comboBox1.SelectedIndex == 0) // nokta dikdörtgen çarpýþmasý seçili ise
            {

                panel1.Refresh();
                d1.NOKTA.X = int.Parse(tbX1.Text);
                d1.NOKTA.Y = int.Parse(tbY1.Text);
                d1.EN = int.Parse(tbEn1.Text);
                d1.BOY = int.Parse(tbBoy1.Text);
                n1.X = int.Parse(tbX2.Text);
                n1.Y = int.Parse(tbY2.Text);
                GeometrikSekillerrr.Add(n1);
                GeometrikSekillerrr.Add(d1);
                n1.ciz(panel1);
                d1.ciz(panel1);
                if (CarpismaDenetimi.NoktaDikdörtgenCarp(n1, d1)) // çarpýþýyorsa bloða gir
                {
                    MessageBox.Show("Cisimler Çarpýþýyor.");
                }
                else
                {
                    MessageBox.Show("Cisimler Çarpýþmýyor.");
                }

            }
            if (comboBox1.SelectedIndex == 1) //nokta çember çarpýþmasý seçili ise
            {
                panel1.Refresh();
                n1.X = int.Parse(tbX1.Text);
                n1.Y = (int.Parse(tbY1.Text));
                c1.NOKTA.X = (int.Parse(tbX2.Text));
                c1.NOKTA.Y = (int.Parse(tbY2.Text));
                c1.R = int.Parse(tbYaricap2.Text);
                n1.ciz(panel1);
                c1.ciz(panel1);
                GeometrikSekillerrr.Add(n1);
                GeometrikSekillerrr.Add(c1);
                if (CarpismaDenetimi.noktaCemberCarpismasi(n1, c1))// çarpýþýyorsa bloða gir
                {
                    MessageBox.Show("Cisimler Çarpýþýyor.");
                }
                else
                {
                    MessageBox.Show("Cisimler Çarpýþmýyor.");
                }

            }
            if (comboBox1.SelectedIndex == 2) // dikdörtgen çarpýþmasý seçili ise
            {

                panel1.Refresh();
                d1.NOKTA.X = int.Parse(tbX1.Text);
                d1.NOKTA.Y = int.Parse(tbY1.Text);
                d1.EN = int.Parse(tbEn1.Text);
                d1.BOY = int.Parse(tbBoy1.Text);
                d2.NOKTA.X = int.Parse(tbX2.Text);
                d2.NOKTA.Y = int.Parse(tbY2.Text);
                d2.EN = int.Parse(tbEn2.Text);
                d2.BOY = int.Parse(tbBoy2.Text);
                GeometrikSekillerrr.Add(d2);
                GeometrikSekillerrr.Add(d1);
                d1.ciz(panel1);
                d2.ciz(panel1);
                if (CarpismaDenetimi.dikdortgenCarp(d1, d2))// çarpýþýyorsa bloða gir
                {
                    MessageBox.Show("Cisimler Çarpýþýyor.");
                }
                else
                {
                    MessageBox.Show("Cisimler Çarpýþmýyor.");
                }

            }
            if (comboBox1.SelectedIndex == 3) // dikdörtgen çember çarpýþmasý seçili ise
            {
                panel1.Refresh();
                c1.NOKTA.X = int.Parse(tbX2.Text);
                c1.NOKTA.Y = int.Parse(tbY2.Text);
                d1.NOKTA.X = int.Parse(tbX1.Text);
                d1.NOKTA.Y = int.Parse(tbY1.Text);
                d1.EN = int.Parse(tbEn1.Text);
                d1.BOY = int.Parse(tbBoy1.Text);
                c1.R = int.Parse(tbYaricap2.Text);
                GeometrikSekillerrr.Add(c1);
                GeometrikSekillerrr.Add(d1);
                c1.ciz(panel1);
                d1.ciz(panel1);
                if (CarpismaDenetimi.DikdörtgenCemberCarpismasi(d1, c1))// çarpýþýyorsa bloða gir
                {
                    MessageBox.Show("Cisimler Çarpýþýyor.");
                }
                else
                {
                    MessageBox.Show("Cisimler Çarpýþmýyor.");
                }

            }
            if (comboBox1.SelectedIndex == 4) // cember cember seçili ise
            {
                panel1.Refresh();
                c1.NOKTA.X = int.Parse(tbX1.Text);
                c1.NOKTA.Y = int.Parse(tbY1.Text);
                c2.NOKTA.X = int.Parse(tbX2.Text);
                c2.NOKTA.Y = int.Parse(tbY2.Text);
                c1.R = int.Parse(tbYaricap1.Text);
                c2.R = int.Parse(tbYaricap2.Text);
                GeometrikSekillerrr.Add(c2);
                GeometrikSekillerrr.Add(c1);
                c1.ciz(panel1);
                c2.ciz(panel1);
                if (CarpismaDenetimi.circleCarp(c1, c2))// çarpýþýyorsa bloða gir
                {
                    MessageBox.Show("Cisimler Çarpýþýyor.");
                }
                else
                {
                    MessageBox.Show("Cisimler Çarpýþmýyor.");
                }

            }
            if (comboBox1.SelectedIndex == 5) // küre nokta seçili ise
            {
                panel1.Refresh();
                k1.NOKTA.X = int.Parse(tbX1.Text);
                k1.NOKTA.Y = int.Parse(tbY1.Text);
                k1.NOKTA.Z = int.Parse(tbZ1.Text);
                n3d1.X = int.Parse(tbX2.Text);
                n3d1.Y = int.Parse(tbY2.Text);
                n3d1.Z = int.Parse(tbZ2.Text);
                k1.YARÝCAP = int.Parse(tbYaricap1.Text);
                GeometrikSekillerrr.Add(n3d1);
                GeometrikSekillerrr.Add(k1);
                k1.ciz(panel1);
                n3d1.ciz(panel1);
                if (CarpismaDenetimi.NoktaKureCarp(n3d1, k1))// çarpýþýyorsa bloða gir
                {
                    MessageBox.Show("Cisimler Çarpýþýyor.");
                }
                else
                {
                    MessageBox.Show("Cisimler Çarpýþmýyor.");
                }

            }
            if (comboBox1.SelectedIndex == 6) //nokta dikdörtgen prizma seçili ise
            {
                panel1.Refresh();
                prizma1.NOKTA.X = int.Parse(tbX1.Text);
                prizma1.NOKTA.Y = int.Parse(tbY1.Text);
                prizma1.NOKTA.Z = int.Parse(tbZ1.Text);
                prizma1.EN = int.Parse(tbEn1.Text);
                prizma1.BOY = int.Parse(tbBoy1.Text);
                prizma1.DERÝNLÝK = int.Parse(tbDerinlik1.Text);
                n3d1.X = int.Parse(tbX2.Text);
                n3d1.Y = int.Parse(tbY2.Text);
                n3d1.Z = int.Parse(tbZ2.Text);
                GeometrikSekillerrr.Add(prizma1);
                GeometrikSekillerrr.Add(n3d1);

                prizma1.ciz(panel1);
                n3d1.ciz(panel1);
                if (CarpismaDenetimi.NoktaDikdörtgenPrizmaCarp(n3d1, prizma1))// çarpýþýyorsa bloða gir
                {
                    MessageBox.Show("Cisimler Çarpýþýyor.");
                }
                else
                {
                    MessageBox.Show("Cisimler Çarpýþmýyor.");
                }
            }
            if (comboBox1.SelectedIndex == 7)
            {
                panel1.Refresh();
                n3d1.X = int.Parse(tbX2.Text);
                n3d1.Y = int.Parse(tbY2.Text);
                n3d1.Z = int.Parse(tbZ2.Text);
                silindir1.NOKTA.Z = int.Parse(tbZ1.Text);
                silindir1.NOKTA.Y = int.Parse(tbY1.Text);
                silindir1.NOKTA.X = int.Parse(tbX1.Text);
                silindir1.YARÝCAP = int.Parse(tbYaricap1.Text);
                silindir1.H = int.Parse(tbYukseklik1.Text);
                GeometrikSekillerrr.Add(silindir1);
                GeometrikSekillerrr.Add(n3d1);
                silindir1.ciz(panel1);
                n3d1.ciz(panel1);
                if (CarpismaDenetimi.NoktaSilindirCarp(n3d1, silindir1))// çarpýþýyorsa bloða gir
                {
                    MessageBox.Show("Cisimler Çarpýþýyor.");
                }
                else
                {
                    MessageBox.Show("Cisimler Çarpýþmýyor.");
                }
            }
            if (comboBox1.SelectedIndex == 8) // silindir silindir
            {
                panel1.Refresh();
                silindir1.NOKTA.Z = int.Parse(tbZ2.Text);
                silindir1.NOKTA.Y = int.Parse(tbY2.Text);
                silindir1.NOKTA.X = int.Parse(tbX2.Text);
                silindir1.YARÝCAP = int.Parse(tbYaricap2.Text);
                silindir1.H = int.Parse(tbYukseklik2.Text);
                silindir2.NOKTA.Z = int.Parse(tbZ1.Text);
                silindir2.NOKTA.Y = int.Parse(tbY1.Text);
                silindir2.NOKTA.X = int.Parse(tbX1.Text);
                silindir2.YARÝCAP = int.Parse(tbYaricap1.Text);
                silindir2.H = int.Parse(tbYukseklik1.Text);
                GeometrikSekillerrr.Add(silindir2);
                GeometrikSekillerrr.Add(silindir1);
                silindir1.ciz(panel1);
                silindir2.ciz(panel1);
                if (CarpismaDenetimi.SilindirCarp(silindir1, silindir2))// çarpýþýyorsa bloða gir
                {
                    MessageBox.Show("Cisimler Çarpýþýyor.");
                }
                else
                {
                    MessageBox.Show("Cisimler Çarpýþmýyor.");
                }
            }
            if (comboBox1.SelectedIndex == 9)
            {
                panel1.Refresh();
                k1.NOKTA.Z = int.Parse(tbZ2.Text);
                k1.NOKTA.Y = int.Parse(tbY2.Text);
                k1.NOKTA.X = int.Parse(tbX2.Text);
                k1.YARÝCAP = int.Parse(tbYaricap2.Text);

                k2.NOKTA.Z = int.Parse(tbZ1.Text);
                k2.NOKTA.Y = int.Parse(tbY1.Text);
                k2.NOKTA.X = int.Parse(tbX1.Text);
                k2.YARÝCAP = int.Parse(tbYaricap1.Text);
                GeometrikSekillerrr.Add(k2);
                GeometrikSekillerrr.Add(k1);
                k1.ciz(panel1);
                k2.ciz(panel1);
                if (CarpismaDenetimi.KureCarp(k1, k2))// çarpýþýyorsa bloða gir
                {
                    MessageBox.Show("Cisimler Çarpýþýyor.");
                }
                else
                {
                    MessageBox.Show("Cisimler Çarpýþmýyor.");
                }
            }
            if (comboBox1.SelectedIndex == 10) //silindir küre

            {
                panel1.Refresh();
                k1.NOKTA.Z = int.Parse(tbZ2.Text);
                k1.NOKTA.Y = int.Parse(tbY2.Text);
                k1.NOKTA.X = int.Parse(tbX2.Text);
                k1.YARÝCAP = int.Parse(tbYaricap2.Text);

                silindir1.NOKTA.Z = int.Parse(tbZ1.Text);
                silindir1.NOKTA.Y = int.Parse(tbY1.Text);
                silindir1.NOKTA.X = int.Parse(tbX1.Text);
                silindir1.YARÝCAP = int.Parse(tbYaricap1.Text);
                silindir1.H = int.Parse(tbYukseklik1.Text);
                GeometrikSekillerrr.Add(silindir1);
                GeometrikSekillerrr.Add(k1);
                k1.ciz(panel1);
                silindir1.ciz(panel1);
                if (CarpismaDenetimi.SilindirKureCarp(silindir1, k1))// çarpýþýyorsa bloða gir
                {
                    MessageBox.Show("Cisimler Çarpýþýyor.");
                }
                else
                {
                    MessageBox.Show("Cisimler Çarpýþmýyor.");
                }
            }
            if (comboBox1.SelectedIndex == 11) //YÜZEY küre

            {
                panel1.Refresh();
                k1.NOKTA.Z = int.Parse(tbZ2.Text);
                k1.NOKTA.Y = int.Parse(tbY2.Text);
                k1.NOKTA.X = int.Parse(tbX2.Text);
                k1.YARÝCAP = int.Parse(tbYaricap2.Text);

                y1.NOKTA.Z = int.Parse(tbZ1.Text);
                y1.NOKTA.Y = int.Parse(tbY1.Text);
                y1.NOKTA.X = int.Parse(tbX1.Text);
                y1.EN = int.Parse(tbEn1.Text);
                y1.DERÝNLÝK = int.Parse(tbDerinlik1.Text);
                GeometrikSekillerrr.Add(k1);
                GeometrikSekillerrr.Add(y1);
                k1.ciz(panel1);
                y1.ciz(panel1);
                if (CarpismaDenetimi.YuzeyKureCarp(k1, y1))// çarpýþýyorsa bloða gir
                {
                    MessageBox.Show("Cisimler Çarpýþýyor.");
                }
                else
                {
                    MessageBox.Show("Cisimler Çarpýþmýyor.");
                }
            }
            if (comboBox1.SelectedIndex == 12) //YÜZEY prizma

            {
                panel1.Refresh();
                prizma1.NOKTA.Z = int.Parse(tbZ2.Text);
                prizma1.NOKTA.Y = int.Parse(tbY2.Text);
                prizma1.NOKTA.X = int.Parse(tbX2.Text);
                prizma1.EN = int.Parse(tbEn2.Text);
                prizma1.BOY = int.Parse(tbBoy2.Text);
                prizma1.DERÝNLÝK = int.Parse(tbDerinlik2.Text);

                y1.NOKTA.Z = int.Parse(tbZ1.Text);
                y1.NOKTA.Y = int.Parse(tbY1.Text);
                y1.NOKTA.X = int.Parse(tbX1.Text);
                y1.EN = int.Parse(tbEn1.Text);
                y1.DERÝNLÝK = int.Parse(tbDerinlik1.Text);
                GeometrikSekillerrr.Add(prizma1);
                GeometrikSekillerrr.Add(y1);
                prizma1.ciz(panel1);
                y1.ciz(panel1);
                if (CarpismaDenetimi.YuzeyPrizmaCarp(prizma1, y1))// çarpýþýyorsa bloða gir
                {
                    MessageBox.Show("Cisimler Çarpýþýyor.");
                }
                else
                {
                    MessageBox.Show("Cisimler Çarpýþmýyor.");
                }
            }
            if (comboBox1.SelectedIndex == 13) //YÜZEY silindir

            {
                panel1.Refresh();
                silindir1.NOKTA.Z = int.Parse(tbZ2.Text);
                silindir1.NOKTA.Y = int.Parse(tbY2.Text);
                silindir1.NOKTA.X = int.Parse(tbX2.Text);
                silindir1.H = int.Parse(tbYukseklik2.Text);
                silindir1.YARÝCAP = int.Parse(tbYaricap2.Text);


                y1.NOKTA.Z = int.Parse(tbZ1.Text);
                y1.NOKTA.Y = int.Parse(tbY1.Text);
                y1.NOKTA.X = int.Parse(tbX1.Text);
                y1.EN = int.Parse(tbEn1.Text);
                y1.DERÝNLÝK = int.Parse(tbDerinlik1.Text);
                GeometrikSekillerrr.Add(y1);
                GeometrikSekillerrr.Add(silindir1);
                silindir1.ciz(panel1);
                y1.ciz(panel1);
                if (CarpismaDenetimi.YuzeySilindirCarp(silindir1, y1))// çarpýþýyorsa bloða gir
                {
                    MessageBox.Show("Cisimler Çarpýþýyor.");
                }
                else
                {
                    MessageBox.Show("Cisimler Çarpýþmýyor.");
                }
            }
            if (comboBox1.SelectedIndex == 14) //Küre prizma

            {
                panel1.Refresh();
                prizma1.NOKTA.Z = int.Parse(tbZ2.Text);
                prizma1.NOKTA.Y = int.Parse(tbY2.Text);
                prizma1.NOKTA.X = int.Parse(tbX2.Text);
                prizma1.EN = int.Parse(tbEn2.Text);
                prizma1.BOY = int.Parse(tbBoy2.Text);
                prizma1.DERÝNLÝK = int.Parse(tbDerinlik2.Text);


                k1.NOKTA.Z = int.Parse(tbZ1.Text);
                k1.NOKTA.Y = int.Parse(tbY1.Text);
                k1.NOKTA.X = int.Parse(tbX1.Text);
                k1.YARÝCAP = int.Parse(tbYaricap1.Text);

                GeometrikSekillerrr.Add(prizma1);
                GeometrikSekillerrr.Add(k1);
                prizma1.ciz(panel1);
                k1.ciz(panel1);
                if (CarpismaDenetimi.KurePrizmaCarp(k1, prizma1))// çarpýþýyorsa bloða gir
                {
                    MessageBox.Show("Cisimler Çarpýþýyor.");
                }
                else
                {
                    MessageBox.Show("Cisimler Çarpýþmýyor.");
                }
            }
            if (comboBox1.SelectedIndex == 15) //prizma prizma

            {
                panel1.Refresh();
                prizma1.NOKTA.Z = int.Parse(tbZ1.Text);
                prizma1.NOKTA.Y = int.Parse(tbY1.Text);
                prizma1.NOKTA.X = int.Parse(tbX1.Text);
                prizma1.EN = int.Parse(tbEn1.Text);
                prizma1.BOY = int.Parse(tbBoy1.Text);
                prizma1.DERÝNLÝK = int.Parse(tbDerinlik1.Text);

                prizma2.NOKTA.Z = int.Parse(tbZ2.Text);
                prizma2.NOKTA.Y = int.Parse(tbY2.Text);
                prizma2.NOKTA.X = int.Parse(tbX2.Text);
                prizma2.EN = int.Parse(tbEn2.Text);
                prizma2.BOY = int.Parse(tbBoy2.Text);
                GeometrikSekillerrr.Add(prizma2);
                GeometrikSekillerrr.Add(prizma1);

                prizma1.ciz(panel1);
                prizma2.ciz(panel1);
                if (CarpismaDenetimi.PrizmaCarp(prizma1, prizma2))// çarpýþýyorsa bloða gir
                {
                    MessageBox.Show("Cisimler Çarpýþýyor.");
                }
                else
                {
                    MessageBox.Show("Cisimler Çarpýþmýyor.");
                }
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {

                tbX1.Visible = true;
                tbX2.Visible = true;
                tbY1.Visible = true;
                tbY2.Visible = true;
                tbZ1.Visible = false;
                tbZ2.Visible = false;
                tbEn1.Visible = true;
                tbEn2.Visible = false;
                tbBoy1.Visible = true;
                tbBoy2.Visible = false;
                tbDerinlik1.Visible = false;
                tbDerinlik2.Visible = false;

                tbYukseklik1.Visible = false;
                tbYukseklik2.Visible = false;
                tbYaricap1.Visible = false;
                tbYaricap2.Visible = false;
                label1.Text = "Dikdörtgen";
                label2.Text = "Nokta";





            }
            if (comboBox1.SelectedIndex == 1)
            {

                tbX1.Visible = true;
                tbX2.Visible = true;
                tbY1.Visible = true;
                tbY2.Visible = true;
                tbZ1.Visible = false;
                tbZ2.Visible = false;
                tbEn1.Visible = false;
                tbEn2.Visible = false;
                tbBoy1.Visible = false;
                tbBoy2.Visible = false;
                tbDerinlik1.Visible = false;
                tbDerinlik2.Visible = false;

                tbYukseklik1.Visible = false;
                tbYukseklik2.Visible = false;
                tbYaricap1.Visible = false;
                tbYaricap2.Visible = true;
                label1.Text = "Nokta";
                label2.Text = "Çember";





            }
            if (comboBox1.SelectedIndex == 2)
            {

                tbX1.Visible = true;
                tbX2.Visible = true;
                tbY1.Visible = true;
                tbY2.Visible = true;
                tbZ1.Visible = false;
                tbZ2.Visible = false;
                tbEn1.Visible = true;
                tbEn2.Visible = true;
                tbBoy1.Visible = true;
                tbBoy2.Visible = true;
                tbDerinlik1.Visible = false;
                tbDerinlik2.Visible = false;

                tbYukseklik1.Visible = false;
                tbYukseklik2.Visible = false;
                tbYaricap1.Visible = false;
                tbYaricap2.Visible = false;
                label1.Text = "1. Dikdörtgen";
                label2.Text = "2. Dikdörtgen";





            }
            if (comboBox1.SelectedIndex == 3)
            {

                tbX1.Visible = true;
                tbX2.Visible = true;
                tbY1.Visible = true;
                tbY2.Visible = true;
                tbZ1.Visible = false;
                tbZ2.Visible = false;
                tbEn1.Visible = true;
                tbEn2.Visible = false;
                tbBoy1.Visible = true;
                tbBoy2.Visible = false;
                tbDerinlik1.Visible = false;
                tbDerinlik2.Visible = false;

                tbYukseklik1.Visible = false;
                tbYukseklik2.Visible = false;
                tbYaricap1.Visible = false;
                tbYaricap2.Visible = true;
                label1.Text = "Dikdörtgen";
                label2.Text = "Çember";





            }
            if (comboBox1.SelectedIndex == 4)
            {

                tbX1.Visible = true;
                tbX2.Visible = true;
                tbY1.Visible = true;
                tbY2.Visible = true;
                tbZ1.Visible = false;
                tbZ2.Visible = false;
                tbEn1.Visible = false;
                tbEn2.Visible = false;
                tbBoy1.Visible = false;
                tbBoy2.Visible = false;
                tbDerinlik1.Visible = false;
                tbDerinlik2.Visible = false;

                tbYukseklik1.Visible = false;
                tbYukseklik2.Visible = false;
                tbYaricap1.Visible = true;
                tbYaricap2.Visible = true;
                label1.Text = "1. Çember";
                label2.Text = "2. Çember";





            }
            if (comboBox1.SelectedIndex == 5) // lüre nokta
            {

                tbX1.Visible = true;
                tbX2.Visible = true;
                tbY1.Visible = true;
                tbY2.Visible = true;
                tbZ1.Visible = true;
                tbZ2.Visible = true;
                tbEn1.Visible = false;
                tbEn2.Visible = false;
                tbBoy1.Visible = false;
                tbBoy2.Visible = false;
                tbDerinlik1.Visible = false;
                tbDerinlik2.Visible = false;

                tbYukseklik1.Visible = false;
                tbYukseklik2.Visible = false;
                tbYaricap1.Visible = true;
                tbYaricap2.Visible = false;
                label1.Text = "Küre";
                label2.Text = "Nokta";





            }
            if (comboBox1.SelectedIndex == 6)
            {

                tbX1.Visible = true;
                tbX2.Visible = true;
                tbY1.Visible = true;
                tbY2.Visible = true;
                tbZ1.Visible = true;
                tbZ2.Visible = true;
                tbEn1.Visible = true;
                tbEn2.Visible = false;
                tbBoy1.Visible = true;
                tbBoy2.Visible = false;
                tbDerinlik1.Visible = true;
                tbDerinlik2.Visible = false;

                tbYukseklik1.Visible = false;
                tbYukseklik2.Visible = false;
                tbYaricap1.Visible = false;
                tbYaricap2.Visible = false;
                label1.Text = "Dikdörtgen Prizma";
                label2.Text = "Nokta";





            }
            if (comboBox1.SelectedIndex == 7) //nokta silindir
            {

                tbX1.Visible = true;
                tbX2.Visible = true;
                tbY1.Visible = true;
                tbY2.Visible = true;
                tbZ1.Visible = true;
                tbZ2.Visible = true;
                tbEn1.Visible = false;
                tbEn2.Visible = false;
                tbBoy1.Visible = false;
                tbBoy2.Visible = false;
                tbDerinlik1.Visible = false;
                tbDerinlik2.Visible = false;

                tbYukseklik1.Visible = true;
                tbYukseklik2.Visible = false;
                tbYaricap1.Visible = true;
                tbYaricap2.Visible = false;
                label1.Text = "Silindir";
                label2.Text = "Nokta";





            }
            if (comboBox1.SelectedIndex == 8)// silindir silindir
            {

                tbX1.Visible = true;
                tbX2.Visible = true;
                tbY1.Visible = true;
                tbY2.Visible = true;
                tbZ1.Visible = true;
                tbZ2.Visible = true;
                tbEn1.Visible = false;
                tbEn2.Visible = false;
                tbBoy1.Visible = false;
                tbBoy2.Visible = false;
                tbDerinlik1.Visible = false;
                tbDerinlik2.Visible = false;

                tbYukseklik1.Visible = true;
                tbYukseklik2.Visible = true;
                tbYaricap1.Visible = true;
                tbYaricap2.Visible = true;
                label1.Text = "1. Silindir";
                label2.Text = "2. Silindir";





            }
            if (comboBox1.SelectedIndex == 9) //küre küre 
            {

                tbX1.Visible = true;
                tbX2.Visible = true;
                tbY1.Visible = true;
                tbY2.Visible = true;
                tbZ1.Visible = true;
                tbZ2.Visible = true;
                tbEn1.Visible = false;
                tbEn2.Visible = false;
                tbBoy1.Visible = false;
                tbBoy2.Visible = false;
                tbDerinlik1.Visible = false;
                tbDerinlik2.Visible = false;

                tbYukseklik1.Visible = false;
                tbYukseklik2.Visible = false;
                tbYaricap1.Visible = true;
                tbYaricap2.Visible = true;
                label1.Text = "1. Küre";
                label2.Text = "2. Küre";





            }
            if (comboBox1.SelectedIndex == 10) //küre silindir
            {

                tbX1.Visible = true;
                tbX2.Visible = true;
                tbY1.Visible = true;
                tbY2.Visible = true;
                tbZ1.Visible = true;
                tbZ2.Visible = true;
                tbEn1.Visible = false;
                tbEn2.Visible = false;
                tbBoy1.Visible = false;
                tbBoy2.Visible = false;
                tbDerinlik1.Visible = false;
                tbDerinlik2.Visible = false;

                tbYukseklik1.Visible = false;
                tbYukseklik2.Visible = true;
                tbYaricap1.Visible = true;
                tbYaricap2.Visible = true;
                label1.Text = "Küre";
                label2.Text = "Silindir";





            }
            if (comboBox1.SelectedIndex == 11)
            {


                tbX1.Visible = true;
                tbX2.Visible = true;
                tbY1.Visible = true;
                tbY2.Visible = true;
                tbZ1.Visible = true;
                tbZ2.Visible = true;
                tbEn1.Visible = true;
                tbEn2.Visible = false;
                tbBoy1.Visible = false;
                tbBoy2.Visible = false;
                tbDerinlik1.Visible = true;
                tbDerinlik2.Visible = false;

                tbYukseklik1.Visible = false;
                tbYukseklik2.Visible = false;
                tbYaricap1.Visible = false;
                tbYaricap2.Visible = true;
                label1.Text = "Yüzey";
                label2.Text = "Küre";





            }
            if (comboBox1.SelectedIndex == 12)
            {

                tbX1.Visible = true;
                tbX2.Visible = true;
                tbY1.Visible = true;
                tbY2.Visible = true;
                tbZ1.Visible = true;
                tbZ2.Visible = true;
                tbEn1.Visible = true;
                tbEn2.Visible = true;
                tbBoy1.Visible = false;
                tbBoy2.Visible = true;
                tbDerinlik1.Visible = true;
                tbDerinlik2.Visible = true;

                tbYukseklik1.Visible = false;
                tbYukseklik2.Visible = false;
                tbYaricap1.Visible = false;
                tbYaricap2.Visible = false;
                label1.Text = "Yüzey";
                label2.Text = "Dikdörtgen Prizma";





            }
            if (comboBox1.SelectedIndex == 13)
            {

                tbX1.Visible = true;
                tbX2.Visible = true;
                tbY1.Visible = true;
                tbY2.Visible = true;
                tbZ1.Visible = true;
                tbZ2.Visible = true;
                tbEn1.Visible = true;
                tbEn2.Visible = true;
                tbBoy1.Visible = false;
                tbBoy2.Visible = false;
                tbDerinlik1.Visible = true;
                tbDerinlik2.Visible = false;

                tbYukseklik1.Visible = false;
                tbYukseklik2.Visible = true;
                tbYaricap1.Visible = false;
                tbYaricap2.Visible = true;
                label1.Text = "Yüzey";
                label2.Text = "Silindir";





            }
            if (comboBox1.SelectedIndex == 14)
            {

                tbX1.Visible = true;
                tbX2.Visible = true;
                tbY1.Visible = true;
                tbY2.Visible = true;
                tbZ1.Visible = true;
                tbZ2.Visible = true;
                tbEn1.Visible = false;
                tbEn2.Visible = true;
                tbBoy1.Visible = false;
                tbBoy2.Visible = true;
                tbDerinlik1.Visible = false;
                tbDerinlik2.Visible = true;
                tbYaricap1.Visible = true;
                tbYaricap2.Visible = false;
                tbYukseklik1.Visible = false;
                tbYukseklik2.Visible = false;

                label1.Text = "Küre";
                label2.Text = "Dikdörtgen Prizma";





            }
            if (comboBox1.SelectedIndex == 15)
            {

                tbX1.Visible = true;
                tbX2.Visible = true;
                tbY1.Visible = true;
                tbY2.Visible = true;
                tbZ1.Visible = true;
                tbZ2.Visible = true;
                tbEn1.Visible = true;
                tbEn2.Visible = true;
                tbBoy1.Visible = true;
                tbBoy2.Visible = true;
                tbDerinlik1.Visible = true;
                tbDerinlik2.Visible = true;
                tbYaricap1.Visible = false;
                tbYaricap2.Visible = false;
                tbYukseklik1.Visible = false;
                tbYukseklik2.Visible = false;
                label1.Text = "1. Dikdörtgen Prizma";
                label2.Text = "2. Dikdörtgen Prizma";





            }

        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (e.KeyCode == Keys.Right)
                {
                    n1.X += 20;
                    panel1.Refresh();
                    n1.ciz(panel1);
                    d1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaDikdörtgenCarp(n1, d1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Left)
                {
                    n1.X -= 20;
                    panel1.Refresh();
                    n1.ciz(panel1);
                    d1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaDikdörtgenCarp(n1, d1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }

                }
                else if (e.KeyCode == Keys.Up)
                {
                    n1.Y -= 20;
                    panel1.Refresh();
                    n1.ciz(panel1);
                    d1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaDikdörtgenCarp(n1, d1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }

                }
                else if (e.KeyCode == Keys.Down)
                {
                    n1.Y += 20;
                    panel1.Refresh();
                    n1.ciz(panel1);
                    d1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaDikdörtgenCarp(n1, d1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.D)
                {
                    d1.NOKTA.X += 20;
                    panel1.Refresh();

                    n1.ciz(panel1);
                    d1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaDikdörtgenCarp(n1, d1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.A)
                {
                    d1.NOKTA.X -= 20;
                    panel1.Refresh();
                    n1.ciz(panel1);
                    d1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaDikdörtgenCarp(n1, d1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    d1.NOKTA.Y -= 20;
                    panel1.Refresh();
                    n1.ciz(panel1);
                    d1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaDikdörtgenCarp(n1, d1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.S)
                {
                    d1.NOKTA.Y += 20;
                    panel1.Refresh();
                    n1.ciz(panel1);
                    d1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaDikdörtgenCarp(n1, d1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (e.KeyCode == Keys.Right)
                {
                    n1.X += 20;
                    panel1.Refresh();
                    n1.ciz(panel1);
                    c1.ciz(panel1);
                    if (CarpismaDenetimi.noktaCemberCarpismasi(n1, c1))
                    {
                        label3.Text = "cisimler çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "cisimler çarpýþmýyor.";
                    }

                }
                else if (e.KeyCode == Keys.Left)
                {
                    n1.X -= 20;
                    panel1.Refresh();
                    n1.ciz(panel1);
                    c1.ciz(panel1);
                    if (CarpismaDenetimi.noktaCemberCarpismasi(n1, c1))
                    {
                        label3.Text = "cisimler çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "cisimler çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    n1.Y -= 20;
                    panel1.Refresh();
                    n1.ciz(panel1);
                    c1.ciz(panel1);
                    if (CarpismaDenetimi.noktaCemberCarpismasi(n1, c1))
                    {
                        label3.Text = "cisimler çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "cisimler çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    n1.Y += 20;
                    panel1.Refresh();
                    n1.ciz(panel1);

                    c1.ciz(panel1);
                    if (CarpismaDenetimi.noktaCemberCarpismasi(n1, c1))
                    {
                        label3.Text = "cisimler çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "cisimler çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.D)
                {
                    c1.NOKTA.X += 20;
                    panel1.Refresh();
                    n1.ciz(panel1);
                    c1.ciz(panel1);
                    if (CarpismaDenetimi.noktaCemberCarpismasi(n1, c1))
                    {
                        label3.Text = "cisimler çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "cisimler çarpýþmýyor.";
                    }

                }
                else if (e.KeyCode == Keys.A)
                {
                    c1.NOKTA.X
                        -= 20;
                    panel1.Refresh();
                    n1.ciz(panel1);
                    c1.ciz(panel1);
                    if (CarpismaDenetimi.noktaCemberCarpismasi(n1, c1))
                    {
                        label3.Text = "cisimler çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "cisimler çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    c1.NOKTA.Y -= 20;
                    panel1.Refresh();
                    n1.ciz(panel1);
                    c1.ciz(panel1);
                    if (CarpismaDenetimi.noktaCemberCarpismasi(n1, c1))
                    {
                        label3.Text = "cisimler çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "cisimler çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.S)
                {
                    c1.NOKTA.Y += 20;
                    panel1.Refresh();
                    n1.ciz(panel1);
                    c1.ciz(panel1);
                    if (CarpismaDenetimi.noktaCemberCarpismasi(n1, c1))
                    {
                        label3.Text = "cisimler çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "cisimler çarpýþmýyor.";
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (e.KeyCode == Keys.Right)
                {
                    d1.NOKTA.X += 20;
                    panel1.Refresh();
                    d1.ciz(panel1);
                    d2.ciz(panel1);
                    if (CarpismaDenetimi.dikdortgenCarp(d1, d2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }

                }
                else if ((e.KeyCode == Keys.Left))
                {
                    d1.NOKTA.X -= 20;
                    panel1.Refresh();
                    d1.ciz(panel1);
                    d2.ciz(panel1);
                    if (CarpismaDenetimi.dikdortgenCarp(d1, d2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    d1.NOKTA.Y += 20;
                    panel1.Refresh();
                    d1.ciz(panel1);
                    d2.ciz(panel1);
                    if (CarpismaDenetimi.dikdortgenCarp(d1, d2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    d1.NOKTA.Y -= 20;
                    panel1.Refresh();
                    d1.ciz(panel1);
                    d2.ciz(panel1);
                    if (CarpismaDenetimi.dikdortgenCarp(d1, d2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.D)
                {
                    d2.NOKTA.X += 20;
                    panel1.Refresh();
                    d1.ciz(panel1);
                    d2.ciz(panel1);
                    if (CarpismaDenetimi.dikdortgenCarp(d1, d2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.A)
                {
                    d2.NOKTA.X -= 20;
                    panel1.Refresh();
                    d1.ciz(panel1);
                    d2.ciz(panel1);
                    if (CarpismaDenetimi.dikdortgenCarp(d1, d2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    d2.NOKTA.Y -= 20;
                    panel1.Refresh();
                    d1.ciz(panel1);
                    d2.ciz(panel1);
                    if (CarpismaDenetimi.dikdortgenCarp(d1, d2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.S)
                {
                    d2.NOKTA.Y += 20;
                    panel1.Refresh();
                    d1.ciz(panel1);
                    d2.ciz(panel1);
                    if (CarpismaDenetimi.dikdortgenCarp(d1, d2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                if (e.KeyCode == Keys.Right)
                {
                    d1.NOKTA.X += 20;
                    panel1.Refresh();
                    d1.ciz(panel1);
                    c1.ciz(panel1);
                    if (CarpismaDenetimi.DikdörtgenCemberCarpismasi(d1, c1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }

                }
                else if (e.KeyCode == Keys.Left)
                {
                    d1.NOKTA.X -= 20;
                    panel1.Refresh();
                    d1.ciz(panel1);
                    c1.ciz(panel1);
                    if (CarpismaDenetimi.DikdörtgenCemberCarpismasi(d1, c1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    d1.NOKTA.Y -= 20;
                    panel1.Refresh(); d1.ciz(panel1); c1.ciz(panel1);
                    if (CarpismaDenetimi.DikdörtgenCemberCarpismasi(d1, c1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    d1.NOKTA.Y += 20;
                    panel1.Refresh();
                    d1.ciz(panel1); c1.ciz(panel1);
                    if (CarpismaDenetimi.DikdörtgenCemberCarpismasi(d1, c1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.D)
                {
                    c1.NOKTA.X += 20;
                    panel1.Refresh();
                    d1.ciz(panel1);
                    c1.ciz(panel1);
                    if (CarpismaDenetimi.DikdörtgenCemberCarpismasi(d1, c1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.A)
                {
                    c1.NOKTA.X -= 20;
                    panel1.Refresh();
                    d1.ciz(panel1);
                    c1.ciz(panel1);
                    if (CarpismaDenetimi.DikdörtgenCemberCarpismasi(d1, c1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    c1.NOKTA.Y -= 20;
                    panel1.Refresh(); d1.ciz(panel1);
                    c1.ciz(panel1);
                    if (CarpismaDenetimi.DikdörtgenCemberCarpismasi(d1, c1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.S)
                {
                    c1.NOKTA.Y += 20;
                    panel1.Refresh(); d1.ciz(panel1); c1.ciz(panel1);
                    if (CarpismaDenetimi.DikdörtgenCemberCarpismasi(d1, c1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                if (e.KeyCode == Keys.Right)
                {
                    c1.NOKTA.X += 20;
                    panel1.Refresh();
                    c1.ciz(panel1); c2.ciz(panel1);
                    if (CarpismaDenetimi.circleCarp(c1, c2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }

                }
                else if (e.KeyCode == Keys.Left)
                {
                    c1.NOKTA.X -= 20;
                    panel1.Refresh();
                    c1.ciz(panel1); c2.ciz(panel1);
                    if (CarpismaDenetimi.circleCarp(c1, c2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    c1.NOKTA.Y -= 20;
                    panel1.Refresh();
                    c1.ciz(panel1);
                    c2.ciz(panel1);
                    if (CarpismaDenetimi.circleCarp(c1, c2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    c1.NOKTA.Y += 20;
                    panel1.Refresh();
                    c1.ciz(panel1);
                    c2.ciz(panel1);
                    if (CarpismaDenetimi.circleCarp(c1, c2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.D)
                {
                    c2.NOKTA.X += 20;
                    panel1.Refresh();
                    c1.ciz(panel1);
                    c2.ciz(panel1);
                    if (CarpismaDenetimi.circleCarp(c1, c2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.A)
                {
                    c2.NOKTA.X -= 20;
                    panel1.Refresh();
                    c1.ciz(panel1);
                    c2.ciz(panel1);
                    if (CarpismaDenetimi.circleCarp(c1, c2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    c2.NOKTA.Y -= 20;
                    panel1.Refresh();
                    c1.ciz(panel1);
                    c2.ciz(panel1);
                    if (CarpismaDenetimi.circleCarp(c1, c2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.S)
                {
                    c2.NOKTA.Y += 20;
                    panel1.Refresh();
                    c1.ciz(panel1);
                    c2.ciz(panel1);
                    if (CarpismaDenetimi.circleCarp(c1, c2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 5) //nokta küre
            {
                if (e.KeyCode == Keys.Right)
                {
                    n3d1.X += 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaKureCarp(n3d1, k1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }

                }
                else if (e.KeyCode == Keys.Left)
                {
                    n3d1.X -= 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaKureCarp(n3d1, k1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    n3d1.Y -= 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaKureCarp(n3d1, k1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    n3d1.Y += 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaKureCarp(n3d1, k1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.D)
                {
                    k1.NOKTA.X += 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaKureCarp(n3d1, k1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.A)
                {
                    k1.NOKTA.X -= 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaKureCarp(n3d1, k1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    k1.NOKTA.Y -= 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaKureCarp(n3d1, k1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.S)
                {
                    k1.NOKTA.Y += 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaKureCarp(n3d1, k1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 6) //nokta prizma
            {
                if (e.KeyCode == Keys.Right)
                {
                    n3d1.X += 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); prizma1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaDikdörtgenPrizmaCarp(n3d1, prizma1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }

                }
                else if (e.KeyCode == Keys.Left)
                {
                    n3d1.X -= 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); prizma1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaDikdörtgenPrizmaCarp(n3d1, prizma1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    n3d1.Y -= 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); prizma1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaDikdörtgenPrizmaCarp(n3d1, prizma1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    n3d1.Y += 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); prizma1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaDikdörtgenPrizmaCarp(n3d1, prizma1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.D)
                {
                    prizma1.NOKTA.X += 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); prizma1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaDikdörtgenPrizmaCarp(n3d1, prizma1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.A)
                {
                    prizma1.NOKTA.X -= 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); prizma1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaDikdörtgenPrizmaCarp(n3d1, prizma1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    prizma1.NOKTA.Y -= 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); prizma1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaDikdörtgenPrizmaCarp(n3d1, prizma1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.S)
                {
                    prizma1.NOKTA.Y += 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); prizma1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaDikdörtgenPrizmaCarp(n3d1, prizma1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 7) //nokta SÝLÝNDÝR
            {
                if (e.KeyCode == Keys.Right)
                {
                    n3d1.X += 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); silindir1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaSilindirCarp(n3d1, silindir1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }

                }
                else if (e.KeyCode == Keys.Left)
                {
                    n3d1.X -= 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); silindir1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaSilindirCarp(n3d1, silindir1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    n3d1.Y -= 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); silindir1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaSilindirCarp(n3d1, silindir1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    n3d1.Y += 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); silindir1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaSilindirCarp(n3d1, silindir1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.D)
                {
                    silindir1.NOKTA.X += 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); silindir1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaSilindirCarp(n3d1, silindir1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.A)
                {
                    silindir1.NOKTA.X -= 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); silindir1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaSilindirCarp(n3d1, silindir1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    silindir1.NOKTA.Y -= 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); silindir1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaSilindirCarp(n3d1, silindir1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.S)
                {
                    silindir1.NOKTA.Y += 20;
                    panel1.Refresh();
                    n3d1.ciz(panel1); silindir1.ciz(panel1);
                    if (CarpismaDenetimi.NoktaSilindirCarp(n3d1, silindir1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 8) //SÝLÝNDÝR SÝLÝNDÝR
            {
                if (e.KeyCode == Keys.Right)
                {
                    silindir2.NOKTA.X += 20;
                    panel1.Refresh();
                    silindir2.ciz(panel1); silindir1.ciz(panel1);
                    if (CarpismaDenetimi.SilindirCarp(silindir1, silindir2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }

                }
                else if (e.KeyCode == Keys.Left)
                {
                    silindir2.NOKTA.X -= 20;
                    panel1.Refresh();
                    silindir2.ciz(panel1); silindir1.ciz(panel1);
                    if (CarpismaDenetimi.SilindirCarp(silindir1, silindir2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    silindir2.NOKTA.Y -= 20;
                    panel1.Refresh();
                    silindir2.ciz(panel1); silindir1.ciz(panel1);
                    if (CarpismaDenetimi.SilindirCarp(silindir1, silindir2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    silindir2.NOKTA.Y += 20;
                    panel1.Refresh();
                    silindir2.ciz(panel1); silindir1.ciz(panel1);
                    if (CarpismaDenetimi.SilindirCarp(silindir1, silindir2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.D)
                {
                    silindir1.NOKTA.X += 20;
                    panel1.Refresh();
                    silindir2.ciz(panel1); silindir1.ciz(panel1);
                    if (CarpismaDenetimi.SilindirCarp(silindir1, silindir2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.A)
                {
                    silindir1.NOKTA.X -= 20;
                    panel1.Refresh();
                    silindir2.ciz(panel1); silindir1.ciz(panel1);
                    if (CarpismaDenetimi.SilindirCarp(silindir1, silindir2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    silindir1.NOKTA.Y -= 20;
                    panel1.Refresh();
                    silindir2.ciz(panel1); silindir1.ciz(panel1);
                    if (CarpismaDenetimi.SilindirCarp(silindir1, silindir2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.S)
                {
                    silindir1.NOKTA.Y += 20;
                    panel1.Refresh();
                    silindir2.ciz(panel1); silindir1.ciz(panel1);
                    if (CarpismaDenetimi.SilindirCarp(silindir1, silindir2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 9) //kure kure
            {
                if (e.KeyCode == Keys.Right)
                {
                    k2.NOKTA.X += 20;
                    panel1.Refresh();
                    k2.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.KureCarp(k1, k2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }

                }
                else if (e.KeyCode == Keys.Left)
                {
                    k2.NOKTA.X -= 20;
                    panel1.Refresh();
                    k2.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.KureCarp(k1, k2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    k2.NOKTA.Y -= 20;
                    panel1.Refresh();
                    k2.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.KureCarp(k1, k2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    k2.NOKTA.Y += 20;
                    panel1.Refresh();
                    k2.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.KureCarp(k1, k2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.D)
                {
                    k1.NOKTA.X += 20;
                    panel1.Refresh();
                    k2.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.KureCarp(k1, k2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.A)
                {
                    k1.NOKTA.X -= 20;
                    panel1.Refresh();
                    k2.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.KureCarp(k1, k2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    k1.NOKTA.Y -= 20;
                    panel1.Refresh();
                    k2.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.KureCarp(k1, k2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.S)
                {
                    k1.NOKTA.Y += 20;
                    panel1.Refresh();
                    k2.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.KureCarp(k1, k2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 10) //silindir kure
            {
                if (e.KeyCode == Keys.Right)
                {
                    k1.NOKTA.X += 20;
                    panel1.Refresh();
                    silindir1.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.SilindirKureCarp(silindir1, k1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }

                }
                else if (e.KeyCode == Keys.Left)
                {
                    k1.NOKTA.X -= 20;
                    panel1.Refresh();
                    silindir1.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.SilindirKureCarp(silindir1, k1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    k1.NOKTA.Y -= 20;
                    panel1.Refresh();
                    silindir1.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.SilindirKureCarp(silindir1, k1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    k1.NOKTA.Y += 20;
                    panel1.Refresh();
                    silindir1.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.SilindirKureCarp(silindir1, k1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.D)
                {
                    silindir1.NOKTA.X += 20;
                    panel1.Refresh();
                    silindir1.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.SilindirKureCarp(silindir1, k1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.A)
                {
                    silindir1.NOKTA.X -= 20;
                    panel1.Refresh();
                    silindir1.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.SilindirKureCarp(silindir1, k1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    silindir1.NOKTA.Y -= 20;
                    panel1.Refresh();
                    silindir1.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.SilindirKureCarp(silindir1, k1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.S)
                {
                    silindir1.NOKTA.Y += 20;
                    panel1.Refresh();
                    silindir1.ciz(panel1); k1.ciz(panel1);
                    if (CarpismaDenetimi.SilindirKureCarp(silindir1, k1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 11) //yuzey kure
            {
                if (e.KeyCode == Keys.Right)
                {
                    k1.NOKTA.X += 20;
                    panel1.Refresh();
                    k1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeyKureCarp(k1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }

                }
                else if (e.KeyCode == Keys.Left)
                {
                    k1.NOKTA.X -= 20;
                    panel1.Refresh();
                    k1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeyKureCarp(k1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    k1.NOKTA.Y -= 20;
                    panel1.Refresh();
                    k1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeyKureCarp(k1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    k1.NOKTA.Y += 20;
                    panel1.Refresh();
                    k1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeyKureCarp(k1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.D)
                {
                    y1.NOKTA.X += 20;
                    panel1.Refresh();
                    k1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeyKureCarp(k1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.A)
                {
                    y1.NOKTA.X -= 20;
                    panel1.Refresh();
                    k1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeyKureCarp(k1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    y1.NOKTA.Y -= 20;
                    panel1.Refresh();
                    k1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeyKureCarp(k1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.S)
                {
                    y1.NOKTA.Y += 20;
                    panel1.Refresh();
                    k1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeyKureCarp(k1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 12) //yuzey prizma
            {
                if (e.KeyCode == Keys.Right)
                {
                    prizma1.NOKTA.X += 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeyPrizmaCarp(prizma1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }

                }
                else if (e.KeyCode == Keys.Left)
                {
                    prizma1.NOKTA.X -= 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeyPrizmaCarp(prizma1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    prizma1.NOKTA.Y -= 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeyPrizmaCarp(prizma1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    prizma1.NOKTA.Y += 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeyPrizmaCarp(prizma1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.D)
                {
                    y1.NOKTA.X += 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeyPrizmaCarp(prizma1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.A)
                {
                    y1.NOKTA.X -= 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeyPrizmaCarp(prizma1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    y1.NOKTA.Y -= 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeyPrizmaCarp(prizma1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.S)
                {
                    y1.NOKTA.Y += 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeyPrizmaCarp(prizma1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 13) //yuzey silindir
            {
                if (e.KeyCode == Keys.Right)
                {
                    silindir1.NOKTA.X += 20;
                    panel1.Refresh();
                    silindir1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeySilindirCarp(silindir1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }

                }
                else if (e.KeyCode == Keys.Left)
                {
                    silindir1.NOKTA.X -= 20;
                    panel1.Refresh();
                    silindir1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeySilindirCarp(silindir1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    silindir1.NOKTA.Y -= 20;
                    panel1.Refresh();
                    silindir1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeySilindirCarp(silindir1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    silindir1.NOKTA.Y += 20;
                    panel1.Refresh();
                    silindir1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeySilindirCarp(silindir1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.D)
                {
                    y1.NOKTA.X += 20;
                    panel1.Refresh();
                    silindir1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeySilindirCarp(silindir1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.A)
                {
                    y1.NOKTA.X -= 20;
                    panel1.Refresh();
                    silindir1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeySilindirCarp(silindir1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    y1.NOKTA.Y -= 20;
                    panel1.Refresh();
                    silindir1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeySilindirCarp(silindir1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.S)
                {
                    y1.NOKTA.Y += 20;
                    panel1.Refresh();
                    silindir1.ciz(panel1);
                    y1.ciz(panel1);
                    if (CarpismaDenetimi.YuzeySilindirCarp(silindir1, y1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 14) //kure prizma
            {
                if (e.KeyCode == Keys.Right)
                {
                    prizma1.NOKTA.X += 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    k1.ciz(panel1);
                    if (CarpismaDenetimi.KurePrizmaCarp(k1, prizma1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }

                }
                else if (e.KeyCode == Keys.Left)
                {
                    prizma1.NOKTA.X -= 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    k1.ciz(panel1);
                    if (CarpismaDenetimi.KurePrizmaCarp(k1, prizma1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    prizma1.NOKTA.Y -= 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    k1.ciz(panel1);
                    if (CarpismaDenetimi.KurePrizmaCarp(k1, prizma1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    prizma1.NOKTA.Y += 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    k1.ciz(panel1);
                    if (CarpismaDenetimi.KurePrizmaCarp(k1, prizma1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.D)
                {
                    k1.NOKTA.X += 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    k1.ciz(panel1);
                    if (CarpismaDenetimi.KurePrizmaCarp(k1, prizma1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.A)
                {
                    k1.NOKTA.X -= 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    k1.ciz(panel1);
                    if (CarpismaDenetimi.KurePrizmaCarp(k1, prizma1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    k1.NOKTA.Y -= 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    k1.ciz(panel1);
                    if (CarpismaDenetimi.KurePrizmaCarp(k1, prizma1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.S)
                {
                    k1.NOKTA.Y += 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    k1.ciz(panel1);
                    if (CarpismaDenetimi.KurePrizmaCarp(k1, prizma1))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 15) //kure prizma
            {
                if (e.KeyCode == Keys.Right)
                {
                    prizma1.NOKTA.X += 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    prizma2.ciz(panel1);
                    if (CarpismaDenetimi.PrizmaCarp(prizma1, prizma2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }

                }
                else if (e.KeyCode == Keys.Left)
                {
                    prizma1.NOKTA.X -= 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    prizma2.ciz(panel1);
                    if (CarpismaDenetimi.PrizmaCarp(prizma1, prizma2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    prizma1.NOKTA.Y -= 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    prizma2.ciz(panel1);
                    if (CarpismaDenetimi.PrizmaCarp(prizma1, prizma2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    prizma1.NOKTA.Y += 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    prizma2.ciz(panel1);
                    if (CarpismaDenetimi.PrizmaCarp(prizma1, prizma2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.D)
                {
                    prizma2.NOKTA.X += 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    prizma2.ciz(panel1);
                    if (CarpismaDenetimi.PrizmaCarp(prizma1, prizma2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.A)
                {
                    prizma2.NOKTA.X -= 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    prizma2.ciz(panel1);
                    if (CarpismaDenetimi.PrizmaCarp(prizma1, prizma2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    prizma2.NOKTA.Y -= 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    prizma2.ciz(panel1);
                    if (CarpismaDenetimi.PrizmaCarp(prizma1, prizma2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
                else if (e.KeyCode == Keys.S)
                {
                    prizma2.NOKTA.Y += 20;
                    panel1.Refresh();
                    prizma1.ciz(panel1);
                    prizma2.ciz(panel1);
                    if (CarpismaDenetimi.PrizmaCarp(prizma1, prizma2))
                    {
                        label3.Text = "Cisimler Çarpýþýyor.";
                    }
                    else
                    {
                        label3.Text = "Cisimler Çarpýþmýyor.";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 5)
            {
                k1.NOKTA.Z += 20; // z ekseninde 20 birim ilerlet.
                panel1.Refresh();
                k1.ciz(panel1);
                n3d1.ciz(panel1);
                if (CarpismaDenetimi.NoktaKureCarp(n3d1, k1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                prizma1.NOKTA.Z += 20;
                panel1.Refresh();
                n3d1.ciz(panel1); prizma1.ciz(panel1);
                if (CarpismaDenetimi.NoktaDikdörtgenPrizmaCarp(n3d1, prizma1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if(comboBox1.SelectedIndex ==7)
            {
                silindir1.NOKTA.Z += 20;
                panel1.Refresh();
                n3d1.ciz(panel1); silindir1.ciz(panel1);
                if (CarpismaDenetimi.NoktaSilindirCarp(n3d1, silindir1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if(comboBox1.SelectedIndex ==8)
            {
                silindir1.NOKTA.Z += 20;
                panel1.Refresh();
                silindir2.ciz(panel1); silindir1.ciz(panel1);
                if (CarpismaDenetimi.SilindirCarp(silindir1, silindir2))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if(comboBox1.SelectedIndex ==9)
            {
                k1.NOKTA.Z += 20;
                panel1.Refresh();
                k2.ciz(panel1); k1.ciz(panel1);
                if (CarpismaDenetimi.KureCarp(k1, k2))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if(comboBox1.SelectedIndex==10)
            {
                k1.NOKTA.Z += 20;
                panel1.Refresh();
                silindir1.ciz(panel1); k1.ciz(panel1);
                if (CarpismaDenetimi.SilindirKureCarp(silindir1, k1))
                {
                   label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if(comboBox1.SelectedIndex ==11)
            {
                y1.NOKTA.Z += 20;
                panel1.Refresh();
                k1.ciz(panel1);
                y1.ciz(panel1);
                if (CarpismaDenetimi.YuzeyKureCarp(k1, y1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if(comboBox1.SelectedIndex ==12)
            {
                y1.NOKTA.Z += 20;
                panel1.Refresh();
                prizma1.ciz(panel1);
                y1.ciz(panel1);
                if (CarpismaDenetimi.YuzeyPrizmaCarp(prizma1, y1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if(comboBox1.SelectedIndex ==13)
            {
                y1.NOKTA.Z += 20;
                panel1.Refresh();
                silindir1.ciz(panel1);
                y1.ciz(panel1);
                if (CarpismaDenetimi.YuzeySilindirCarp(silindir1, y1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if(comboBox1.SelectedIndex ==14)
            {
                k1.NOKTA.Z += 20;
                panel1.Refresh();
                prizma1.ciz(panel1);
                k1.ciz(panel1);
                if (CarpismaDenetimi.KurePrizmaCarp(k1, prizma1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if(comboBox1.SelectedIndex==15)
            {
                prizma1.NOKTA.Z += 20;
                panel1.Refresh();
                prizma1.ciz(panel1);
                prizma2.ciz(panel1);
                if (CarpismaDenetimi.PrizmaCarp(prizma1, prizma2))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 5)
            {
                k1.NOKTA.Z -= 20; // z ekseninde 20 birim ilerlet.
                panel1.Refresh();
                k1.ciz(panel1);
                n3d1.ciz(panel1);
                if (CarpismaDenetimi.NoktaKureCarp(n3d1, k1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                   label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if(comboBox1.SelectedIndex ==6)
            {
                prizma1.NOKTA.Z -= 20;
                panel1.Refresh();
                n3d1.ciz(panel1); prizma1.ciz(panel1);
                if (CarpismaDenetimi.NoktaDikdörtgenPrizmaCarp(n3d1, prizma1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                silindir1.NOKTA.Z -= 20;
                panel1.Refresh();
                n3d1.ciz(panel1); silindir1.ciz(panel1);
                if (CarpismaDenetimi.NoktaSilindirCarp(n3d1, silindir1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                silindir1.NOKTA.Z -= 20;
                panel1.Refresh();
                silindir2.ciz(panel1); silindir1.ciz(panel1);
                if (CarpismaDenetimi.SilindirCarp(silindir1, silindir2))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                k1.NOKTA.Z -= 20;
                panel1.Refresh();
                k2.ciz(panel1); k1.ciz(panel1);
                if (CarpismaDenetimi.KureCarp(k1, k2))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                k1.NOKTA.Z -= 20;
                panel1.Refresh();
                silindir1.ciz(panel1); k1.ciz(panel1);
                if (CarpismaDenetimi.SilindirKureCarp(silindir1, k1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 11)
            {
                y1.NOKTA.Z -= 20;
                panel1.Refresh();
                k1.ciz(panel1);
                y1.ciz(panel1);
                if (CarpismaDenetimi.YuzeyKureCarp(k1, y1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 12)
            {
                y1.NOKTA.Z -= 20;
                panel1.Refresh();
                prizma1.ciz(panel1);
                y1.ciz(panel1);
                if (CarpismaDenetimi.YuzeyPrizmaCarp(prizma1, y1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 13)
            {
                y1.NOKTA.Z -= 20;
                panel1.Refresh();
                silindir1.ciz(panel1);
                y1.ciz(panel1);
                if (CarpismaDenetimi.YuzeySilindirCarp(silindir1, y1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 14)
            {
                k1.NOKTA.Z -= 20;
                panel1.Refresh();
                prizma1.ciz(panel1);
                k1.ciz(panel1);
                if (CarpismaDenetimi.KurePrizmaCarp(k1, prizma1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 15)
            {
                prizma1.NOKTA.Z -= 20;
                panel1.Refresh();
                prizma1.ciz(panel1);
                prizma2.ciz(panel1);
                if (CarpismaDenetimi.PrizmaCarp(prizma1, prizma2))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 5)
            {
                n3d1.Z += 20; // z ekseninde 20 birim ilerlet.
                panel1.Refresh();
                k1.ciz(panel1);
                n3d1.ciz(panel1);
                if (CarpismaDenetimi.NoktaKureCarp(n3d1, k1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                n3d1.Z += 20;
                panel1.Refresh();
                n3d1.ciz(panel1); prizma1.ciz(panel1);
                if (CarpismaDenetimi.NoktaDikdörtgenPrizmaCarp(n3d1, prizma1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                n3d1.Z += 20;
                panel1.Refresh();
                n3d1.ciz(panel1); silindir1.ciz(panel1);
                if (CarpismaDenetimi.NoktaSilindirCarp(n3d1, silindir1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                silindir2.NOKTA.Z += 20;
                panel1.Refresh();
                silindir2.ciz(panel1); silindir1.ciz(panel1);
                if (CarpismaDenetimi.SilindirCarp(silindir1, silindir2))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                k2.NOKTA.Z += 20;
                panel1.Refresh();
                k2.ciz(panel1); k1.ciz(panel1);
                if (CarpismaDenetimi.KureCarp(k1, k2))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                silindir1.NOKTA.Z += 20;
                panel1.Refresh();
                silindir1.ciz(panel1); k1.ciz(panel1);
                if (CarpismaDenetimi.SilindirKureCarp(silindir1, k1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                   label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 11)
            {
                k1.NOKTA.Z += 20;
                panel1.Refresh();
                k1.ciz(panel1);
                y1.ciz(panel1);
                if (CarpismaDenetimi.YuzeyKureCarp(k1, y1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 12)
            {
                prizma1.NOKTA.Z += 20;
                panel1.Refresh();
                prizma1.ciz(panel1);
                y1.ciz(panel1);
                if (CarpismaDenetimi.YuzeyPrizmaCarp(prizma1, y1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 13)
            {
                silindir1.NOKTA.Z += 20;
                panel1.Refresh();
                silindir1.ciz(panel1);
                y1.ciz(panel1);
                if (CarpismaDenetimi.YuzeySilindirCarp(silindir1, y1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 14)
            {
                prizma1.NOKTA.Z += 20;
                panel1.Refresh();
                prizma1.ciz(panel1);
                k1.ciz(panel1);
                if (CarpismaDenetimi.KurePrizmaCarp(k1, prizma1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 15)
            {
                prizma2.NOKTA.Z += 20;
                panel1.Refresh();
                prizma1.ciz(panel1);
                prizma2.ciz(panel1);
                if (CarpismaDenetimi.PrizmaCarp(prizma1, prizma2))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 5)
            {
                n3d1.Z -= 20; // z ekseninde 20 birim ilerlet.
                panel1.Refresh();
                k1.ciz(panel1);
                n3d1.ciz(panel1);
                if (CarpismaDenetimi.NoktaKureCarp(n3d1, k1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                n3d1.Z -= 20;
                panel1.Refresh();
                n3d1.ciz(panel1); prizma1.ciz(panel1);
                if (CarpismaDenetimi.NoktaDikdörtgenPrizmaCarp(n3d1, prizma1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                n3d1.Z -= 20;
                panel1.Refresh();
                n3d1.ciz(panel1); silindir1.ciz(panel1);
                if (CarpismaDenetimi.NoktaSilindirCarp(n3d1, silindir1))
                {
                   label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 8) 
            {
                silindir2.NOKTA.Z -= 20;
                panel1.Refresh();
                silindir2.ciz(panel1); silindir1.ciz(panel1);
                if (CarpismaDenetimi.SilindirCarp(silindir1, silindir2))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                k2.NOKTA.Z -= 20;
                panel1.Refresh();
                k2.ciz(panel1); k1.ciz(panel1);
                if (CarpismaDenetimi.KureCarp(k1, k2))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                silindir1.NOKTA.Z -= 20;
                panel1.Refresh();
                silindir1.ciz(panel1); k1.ciz(panel1);
                if (CarpismaDenetimi.SilindirKureCarp(silindir1, k1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 11)
            {
                k1.NOKTA.Z -= 20;
                panel1.Refresh();
                k1.ciz(panel1);
                y1.ciz(panel1);
                if (CarpismaDenetimi.YuzeyKureCarp(k1, y1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 12)
            {
                prizma1.NOKTA.Z -= 20;
                panel1.Refresh();
                prizma1.ciz(panel1);
                y1.ciz(panel1);
                if (CarpismaDenetimi.YuzeyPrizmaCarp(prizma1, y1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 13)
            {
                silindir1.NOKTA.Z -= 20;
                panel1.Refresh();
                silindir1.ciz(panel1);
                y1.ciz(panel1);
                if (CarpismaDenetimi.YuzeySilindirCarp(silindir1, y1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 14)
            {
                prizma1.NOKTA.Z -= 20;
                panel1.Refresh();
                prizma1.ciz(panel1);
                k1.ciz(panel1);
                if (CarpismaDenetimi.KurePrizmaCarp(k1, prizma1))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
            else if (comboBox1.SelectedIndex == 15)
            {
                prizma2.NOKTA.Z -= 20;
                panel1.Refresh();
                prizma1.ciz(panel1);
                prizma2.ciz(panel1);
                if (CarpismaDenetimi.PrizmaCarp(prizma1, prizma2))
                {
                    label3.Text = "Cisimler Çarpýþýyor.";
                }
                else
                {
                    label3.Text = "Cisimler Çarpýþmýyor.";
                }
            }
        }
    }
}
