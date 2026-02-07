namespace odev2deneme3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            ghhh = new Label();
            button1 = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            tbBoy1 = new MaskedTextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            tbEn1 = new MaskedTextBox();
            label8 = new Label();
            tbX2 = new MaskedTextBox();
            label7 = new Label();
            tbDerinlik2 = new MaskedTextBox();
            label6 = new Label();
            tbBoy2 = new MaskedTextBox();
            label5 = new Label();
            tbEn2 = new MaskedTextBox();
            label4 = new Label();
            tbYaricap1 = new MaskedTextBox();
            tbY2 = new MaskedTextBox();
            tbYukseklik1 = new MaskedTextBox();
            tbZ2 = new MaskedTextBox();
            tbZ1 = new MaskedTextBox();
            tbYukseklik2 = new MaskedTextBox();
            tbY1 = new MaskedTextBox();
            tbYaricap2 = new MaskedTextBox();
            tbX1 = new MaskedTextBox();
            tbDerinlik1 = new MaskedTextBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            label13 = new Label();
            label14 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            richTextBox2 = new RichTextBox();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "a)\tNokta, Dörtgen çarpışma denetimi", "b)\tNokta, çember çarpışma denetimi", "c)\tDikdörtgen, dikdörtgen çarpışma denetimi", "d)\tDikdörtgen, çember çarpışma denetimi", "e)\tÇember, çember çarpışma denetimi", "f)\tNokta, Küre çarpışma denetimi", "g)\tNokta, dikdörtgen prizma çarpışma denetimi", "h)\tNokta, Silindir çarpışma denetimi", "i)\tSilindir, silindir çarpışma denetimi", "j)\tKüre, küre çarpışma denetimi", "k)\tKüre silindir çarpışma denetimi", "l)\tYüzey, küre çarpışma denetimi", "m)\tYüzey, dikdörtgen prizma çarpışma denetimi", "n)\tYüzey silindir çarpışma denetimi", "o)\tKüre, dikdörtgen prizma çarpışma denetimi", "p)\tDikdörtgen prizma, dikdörtgen prizma çarpışma denetimi" });
            comboBox1.Location = new Point(136, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(305, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.KeyDown += comboBox1_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 39);
            label1.Name = "label1";
            label1.Size = new Size(67, 16);
            label1.TabIndex = 1;
            label1.Text = "1. Cisim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(305, 37);
            label2.Name = "label2";
            label2.Size = new Size(67, 16);
            label2.TabIndex = 2;
            label2.Text = "2. Cisim";
            // 
            // ghhh
            // 
            ghhh.AutoSize = true;
            ghhh.BackColor = SystemColors.ControlDarkDark;
            ghhh.Location = new Point(248, 578);
            ghhh.Name = "ghhh";
            ghhh.Size = new Size(0, 20);
            ghhh.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(230, 319);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "BAŞLAT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Info;
            panel1.ForeColor = Color.Red;
            panel1.Location = new Point(564, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(903, 683);
            panel1.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left;
            panel3.BackColor = Color.RosyBrown;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(tbBoy1);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(tbEn1);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(tbX2);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(tbDerinlik2);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(tbBoy2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(tbEn2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(tbYaricap1);
            panel3.Controls.Add(tbY2);
            panel3.Controls.Add(tbYukseklik1);
            panel3.Controls.Add(tbZ2);
            panel3.Controls.Add(tbZ1);
            panel3.Controls.Add(tbYukseklik2);
            panel3.Controls.Add(tbY1);
            panel3.Controls.Add(tbYaricap2);
            panel3.Controls.Add(tbX1);
            panel3.Controls.Add(tbDerinlik1);
            panel3.Location = new Point(4, 203);
            panel3.Name = "panel3";
            panel3.Size = new Size(554, 372);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Location = new Point(233, 350);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 47;
            label3.Text = "Sonuç";
            // 
            // tbBoy1
            // 
            tbBoy1.Location = new Point(136, 90);
            tbBoy1.Mask = "00000";
            tbBoy1.Name = "tbBoy1";
            tbBoy1.Size = new Size(125, 27);
            tbBoy1.TabIndex = 32;
            tbBoy1.ValidatingType = typeof(int);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.Location = new Point(27, 13);
            label12.Name = "label12";
            label12.Size = new Size(53, 18);
            label12.TabIndex = 46;
            label12.Text = "Seçim";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(27, 295);
            label11.Name = "label11";
            label11.Size = new Size(35, 18);
            label11.TabIndex = 44;
            label11.Text = "ÇAP";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(27, 262);
            label10.Name = "label10";
            label10.Size = new Size(89, 18);
            label10.TabIndex = 43;
            label10.Text = "YÜKSEKLİK";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(27, 229);
            label9.Name = "label9";
            label9.Size = new Size(17, 18);
            label9.TabIndex = 42;
            label9.Text = "Z";
            // 
            // tbEn1
            // 
            tbEn1.Location = new Point(136, 57);
            tbEn1.Mask = "00000";
            tbEn1.Name = "tbEn1";
            tbEn1.Size = new Size(125, 27);
            tbEn1.TabIndex = 0;
            tbEn1.ValidatingType = typeof(int);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(27, 196);
            label8.Name = "label8";
            label8.Size = new Size(17, 18);
            label8.TabIndex = 41;
            label8.Text = "Y";
            // 
            // tbX2
            // 
            tbX2.Location = new Point(305, 156);
            tbX2.Mask = "00000";
            tbX2.Name = "tbX2";
            tbX2.Size = new Size(125, 27);
            tbX2.TabIndex = 22;
            tbX2.ValidatingType = typeof(int);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(27, 163);
            label7.Name = "label7";
            label7.Size = new Size(17, 18);
            label7.TabIndex = 40;
            label7.Text = "X";
            // 
            // tbDerinlik2
            // 
            tbDerinlik2.Location = new Point(305, 123);
            tbDerinlik2.Mask = "00000";
            tbDerinlik2.Name = "tbDerinlik2";
            tbDerinlik2.Size = new Size(125, 27);
            tbDerinlik2.TabIndex = 23;
            tbDerinlik2.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(27, 126);
            label6.Name = "label6";
            label6.Size = new Size(80, 18);
            label6.TabIndex = 39;
            label6.Text = "DERİNLİK";
            // 
            // tbBoy2
            // 
            tbBoy2.Location = new Point(305, 90);
            tbBoy2.Mask = "00000";
            tbBoy2.Name = "tbBoy2";
            tbBoy2.Size = new Size(125, 27);
            tbBoy2.TabIndex = 24;
            tbBoy2.ValidatingType = typeof(int);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(27, 93);
            label5.Name = "label5";
            label5.Size = new Size(35, 18);
            label5.TabIndex = 38;
            label5.Text = "BOY";
            // 
            // tbEn2
            // 
            tbEn2.Location = new Point(305, 57);
            tbEn2.Mask = "00000";
            tbEn2.Name = "tbEn2";
            tbEn2.Size = new Size(125, 27);
            tbEn2.TabIndex = 25;
            tbEn2.ValidatingType = typeof(int);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(27, 64);
            label4.Name = "label4";
            label4.Size = new Size(26, 18);
            label4.TabIndex = 37;
            label4.Text = "EN";
            // 
            // tbYaricap1
            // 
            tbYaricap1.Location = new Point(136, 288);
            tbYaricap1.Mask = "00000";
            tbYaricap1.Name = "tbYaricap1";
            tbYaricap1.Size = new Size(125, 27);
            tbYaricap1.TabIndex = 26;
            tbYaricap1.ValidatingType = typeof(int);
            // 
            // tbY2
            // 
            tbY2.Location = new Point(305, 189);
            tbY2.Mask = "00000";
            tbY2.Name = "tbY2";
            tbY2.Size = new Size(125, 27);
            tbY2.TabIndex = 36;
            tbY2.ValidatingType = typeof(int);
            // 
            // tbYukseklik1
            // 
            tbYukseklik1.Location = new Point(136, 255);
            tbYukseklik1.Mask = "00000";
            tbYukseklik1.Name = "tbYukseklik1";
            tbYukseklik1.Size = new Size(125, 27);
            tbYukseklik1.TabIndex = 27;
            tbYukseklik1.ValidatingType = typeof(int);
            // 
            // tbZ2
            // 
            tbZ2.Location = new Point(305, 222);
            tbZ2.Mask = "00000";
            tbZ2.Name = "tbZ2";
            tbZ2.Size = new Size(125, 27);
            tbZ2.TabIndex = 35;
            tbZ2.ValidatingType = typeof(int);
            // 
            // tbZ1
            // 
            tbZ1.Location = new Point(136, 222);
            tbZ1.Mask = "00000";
            tbZ1.Name = "tbZ1";
            tbZ1.Size = new Size(125, 27);
            tbZ1.TabIndex = 28;
            tbZ1.ValidatingType = typeof(int);
            // 
            // tbYukseklik2
            // 
            tbYukseklik2.Location = new Point(305, 255);
            tbYukseklik2.Mask = "00000";
            tbYukseklik2.Name = "tbYukseklik2";
            tbYukseklik2.Size = new Size(125, 27);
            tbYukseklik2.TabIndex = 34;
            tbYukseklik2.ValidatingType = typeof(int);
            // 
            // tbY1
            // 
            tbY1.Location = new Point(136, 189);
            tbY1.Mask = "00000";
            tbY1.Name = "tbY1";
            tbY1.Size = new Size(125, 27);
            tbY1.TabIndex = 29;
            tbY1.ValidatingType = typeof(int);
            // 
            // tbYaricap2
            // 
            tbYaricap2.Location = new Point(305, 288);
            tbYaricap2.Mask = "00000";
            tbYaricap2.Name = "tbYaricap2";
            tbYaricap2.Size = new Size(125, 27);
            tbYaricap2.TabIndex = 33;
            tbYaricap2.ValidatingType = typeof(int);
            // 
            // tbX1
            // 
            tbX1.Location = new Point(136, 156);
            tbX1.Mask = "00000";
            tbX1.Name = "tbX1";
            tbX1.Size = new Size(125, 27);
            tbX1.TabIndex = 30;
            tbX1.ValidatingType = typeof(int);
            // 
            // tbDerinlik1
            // 
            tbDerinlik1.Location = new Point(136, 123);
            tbDerinlik1.Mask = "00000";
            tbDerinlik1.Name = "tbDerinlik1";
            tbDerinlik1.Size = new Size(125, 27);
            tbDerinlik1.TabIndex = 31;
            tbDerinlik1.ValidatingType = typeof(int);
            // 
            // button5
            // 
            button5.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button5.Location = new Point(305, 74);
            button5.Name = "button5";
            button5.Size = new Size(94, 30);
            button5.TabIndex = 3;
            button5.Text = "Z' yi azalt";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button4.Location = new Point(305, 38);
            button4.Name = "button4";
            button4.Size = new Size(94, 30);
            button4.TabIndex = 2;
            button4.Text = "Z' yi arttır";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.Location = new Point(140, 74);
            button3.Name = "button3";
            button3.Size = new Size(94, 30);
            button3.TabIndex = 1;
            button3.Text = "Z' yi azalt";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(140, 38);
            button2.Name = "button2";
            button2.Size = new Size(94, 30);
            button2.TabIndex = 0;
            button2.Text = "Z' yi arttır";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(13, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(526, 104);
            richTextBox1.TabIndex = 45;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(100, 17);
            label13.Name = "label13";
            label13.Size = new Size(161, 18);
            label13.TabIndex = 0;
            label13.Text = "1. Cisim Z Ekseni";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label14.Location = new Point(305, 17);
            label14.Name = "label14";
            label14.Size = new Size(161, 18);
            label14.TabIndex = 1;
            label14.Text = "2. Cisim Z Ekseni";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(4, 578);
            panel2.Name = "panel2";
            panel2.Size = new Size(551, 105);
            panel2.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Desktop;
            panel4.Controls.Add(richTextBox2);
            panel4.Controls.Add(richTextBox1);
            panel4.Location = new Point(4, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(554, 205);
            panel4.TabIndex = 0;
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            richTextBox2.Location = new Point(13, 115);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(526, 87);
            richTextBox2.TabIndex = 46;
            richTextBox2.Text = "NOT: GİRİLEN X,Y,Z KOORDİNATLARI DÜZLEMDE BEŞER BİRİM SOLDA, ÜSTTE VE DERİNDE OLAN KOORDİNATLARDIR.\n\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1467, 684);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(ghhh);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Cisim Çarpışma Denetimi";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label ghhh;
        private Button button1;
        private Panel panel1;
        private MaskedTextBox tbEn1;
        private MaskedTextBox tbX2;
        private MaskedTextBox tbDerinlik2;
        private MaskedTextBox tbBoy2;
        private MaskedTextBox tbEn2;
        private MaskedTextBox tbYaricap1;
        private MaskedTextBox tbYukseklik1;
        private MaskedTextBox tbZ1;
        private MaskedTextBox tbY1;
        private MaskedTextBox tbX1;
        private MaskedTextBox tbDerinlik1;
        private MaskedTextBox tbBoy1;
        private MaskedTextBox tbYaricap2;
        private MaskedTextBox tbYukseklik2;
        private MaskedTextBox tbZ2;
        private MaskedTextBox tbY2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private RichTextBox richTextBox1;
        private Label label12;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button4;
        private Label label14;
        private Label label13;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label3;
        private RichTextBox richTextBox2;
    }
}
