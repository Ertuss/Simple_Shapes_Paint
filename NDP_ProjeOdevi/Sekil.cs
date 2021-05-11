using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_ProjeOdevi
{

    abstract class Sekil
    {
        // Şeklin paneldeki x ve y koordinatları
        public float X;
        public float Y;

        // Şeklin genişlik ve yükseklil değerleri.
        public float genislik;
        public float yukseklik;

        public bool aktif;

        protected Pen kalem = new Pen(Color.Black);
        public Color fircaRenk;
        public SolidBrush firca;

        public Sekil() // Her şekil oluştuğunda aktif değeri ve fircaRenk değeri varsayılan olarak aşşağıdaki gibi atanır.
        {
            aktif = false;
            fircaRenk = Color.Red;
        }

        public virtual void Ciz(Graphics g) // Şekilleri panele çizerken kullandığımız fonksiyon.
        {

        }

        public string DosyaKayitFormat() // Şekilleri dosyaya kayıt ederken kullandığımız fonksiyon.
        {
            string tip = GetType().ToString();

            string[] tipParcalar = tip.Split('.');
            string sekilAdi = tipParcalar.Last().ToString();

            string ozet = String.Format("{0}/{1}/{2}/{3}/{4}/{5}", sekilAdi, X, Y, genislik, yukseklik, fircaRenk.ToArgb());
            return ozet;
        }

        public virtual PointF[] SekilPoints() // Şekillerin köşe noktalarını döndüren fonksiyon.
        {
            PointF[] koseNoktalari = new PointF[0];
            return koseNoktalari;
        }
    }

    class Ucgen : Sekil
    {
        public Ucgen()
        {
            X = 0;
            Y = 0;
            genislik = 0;
            yukseklik = 0;
        }

        public Ucgen(Color fircaRenk, float x, float y, float w, float h)
        {
            this.X = x;
            this.Y = y;
            this.genislik = w;
            this.yukseklik = h;
            this.fircaRenk = fircaRenk;
        }

        public override void Ciz(Graphics g)
        {
            firca = new SolidBrush(fircaRenk);
            kalem.Width = 5;
            g.DrawPolygon(kalem, SekilPoints());
            g.FillPolygon(firca, SekilPoints());
        }

        public override PointF[] SekilPoints()
        {
            PointF p1 = new PointF(X, Y - yukseklik);
            PointF p2 = new PointF(X + genislik, Y + yukseklik);
            PointF p3 = new PointF(X - genislik, Y + yukseklik);
            PointF[] koseNoktalari = new PointF[3];
            koseNoktalari[0] = p1;
            koseNoktalari[1] = p2;
            koseNoktalari[2] = p3;
            return koseNoktalari;
        }
    }

    class Dortgen : Sekil
    {
        public Dortgen()
        {
            X = 0;
            Y = 0;
            genislik = 0;
            yukseklik = 0;
        }

        public Dortgen(Color fircaRenk, float x, float y, float w, float h)
        {
            this.X = x;
            this.Y = y;
            this.genislik = w;
            this.yukseklik = h;
            this.fircaRenk = fircaRenk;
        }
        public override void Ciz(Graphics g)
        {
            firca = new SolidBrush(fircaRenk);
            kalem.Width = 5;
            g.DrawPolygon(kalem, SekilPoints());
            g.FillPolygon(firca, SekilPoints());
        }

        public override PointF[] SekilPoints()
        {
            PointF p1 = new PointF(X, Y);
            PointF p2 = new PointF(X + genislik, Y);
            PointF p3 = new PointF(X + genislik, Y + yukseklik);
            PointF p4 = new PointF(X, Y + yukseklik);
            PointF[] koseNoktalari = new PointF[4];
            koseNoktalari[0] = p1;
            koseNoktalari[1] = p2;
            koseNoktalari[2] = p3;
            koseNoktalari[3] = p4;
            return koseNoktalari;
        }
    }

    class Altigen : Sekil
    {
        public Altigen()
        {
            X = 0;
            Y = 0;
            genislik = 0;
            yukseklik = 0;
        }

        public Altigen(Color fircaRenk, float x, float y, float w, float h)
        {
            this.X = x;
            this.Y = y;
            this.genislik = w;
            this.yukseklik = h;
            this.fircaRenk = fircaRenk;
        }
        public override void Ciz(Graphics g)
        {
            firca = new SolidBrush(fircaRenk);

            kalem.Width = 5;
            g.DrawPolygon(kalem, SekilPoints());
            g.FillPolygon(firca, SekilPoints());
        }

        public override PointF[] SekilPoints()
        {
            PointF p1 = new PointF(X - (genislik / 2), Y);
            PointF p2 = new PointF(X - (genislik / 4), Y + (yukseklik / 2));
            PointF p3 = new PointF(X + (genislik / 4), Y + (yukseklik / 2));
            PointF p4 = new PointF(X + (genislik / 2), Y);
            PointF p5 = new PointF(X + (genislik / 4), Y - (yukseklik / 2));
            PointF p6 = new PointF(X - (genislik / 4), Y - (yukseklik / 2));

            PointF[] koseNoktalari = new PointF[6];

            koseNoktalari[0] = p1;
            koseNoktalari[1] = p2;
            koseNoktalari[2] = p3;
            koseNoktalari[3] = p4;
            koseNoktalari[4] = p5;
            koseNoktalari[5] = p6;
            return koseNoktalari;
        }
    }

    class Cember : Sekil
    {
        public Cember()
        {
            X = 0;
            Y = 0;
            genislik = 0;
            yukseklik = 0;
        }

        public Cember(Color fircaRenk, float x, float y, float w, float h)
        {
            this.X = x;
            this.Y = y;
            this.genislik = w;
            this.yukseklik = h;
            this.fircaRenk = fircaRenk;
        }

        public override void Ciz(Graphics g)
        {
            firca = new SolidBrush(fircaRenk);
            kalem.Width = 5;
            g.DrawEllipse(kalem, X, Y, genislik, yukseklik);
            g.FillEllipse(firca, X, Y, genislik, yukseklik);
        }

        public override PointF[] SekilPoints()
        {
            PointF p1 = new PointF(X, Y);
            PointF p2 = new PointF(X + genislik, Y);
            PointF p3 = new PointF(X + genislik, Y + yukseklik);
            PointF p4 = new PointF(X, Y + yukseklik);

            PointF[] koseNoktalari = new PointF[4];

            koseNoktalari[0] = p1;
            koseNoktalari[1] = p2;
            koseNoktalari[2] = p3;
            koseNoktalari[3] = p4;

            return koseNoktalari;
        }
    }
    
}
