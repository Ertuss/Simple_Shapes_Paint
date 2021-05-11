using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace NDP_ProjeOdevi
{
    public partial class Form1 : Form
    {
        // İlgili panelin içinde seçilen nesnenin etrafını boyamak
        // için nesnein panel içindeki koordinatını aşşağıdaki değişkenlere
        // panelde click işlemi tetiklendiğinde atanır.
        static int renkSecimX, renkSecimY;
        static int sekilSecimX, sekilSecimY;
        static int islemSecimX, islemSecimY;
        static int kayitSecimX, kayitSecimY;

        // Çizimi ve çizimde kullanılacak rengin ayarlanması için gereken
        // başlangıç noktasını tutan Point değeri,
        // Graphics nesnesi ve Color türünde istenenRenk değişkeninin tanımlanması.
        static Point baslangicNoktasi = new Point();
        static Point secimPoint = new Point();
        public static Graphics g;
        static Color istenenRenk = new Color();

        // Varsayılan olarak dortgen seçili gelir.
        enum sekilSecim { ucgen, dortgen, altigen, cember };
        static sekilSecim _sekilSecim = sekilSecim.dortgen;

        // clickAktif panele tıklandığında true olur.
        static bool clickAktif = false;

        // İlgili seçim taramalarının ve dosya işlemlerinin yapılması için
        // gereken logic işlemlerde işimize yarayacak aktifleme işlemleri.
        static bool sekilAktif = true;
        static bool renkAktif = true;
        static bool secimIslemAktif = false;
        static bool trashIslemAktif = false;
        static bool dosyaIslemAktif = false;

        // Şekillerimizi arka planda sakladığımız sekiller listesi.
        List<Sekil> sekiller = new List<Sekil>();
        Dortgen dortgen = new Dortgen();
        Cember cember = new Cember();
        Ucgen ucgen = new Ucgen();
        Altigen altigen = new Altigen();

        public Form1()
        {
            InitializeComponent();
            // Başlangıçta renk ve şekil varsayılan olarak seçili gelir.
            // Bunu için gereken atamalar.
            renkSecimX = colorRed.Location.X;
            renkSecimY = colorRed.Location.Y;
            sekilSecimX = kareSekil.Location.X;
            sekilSecimY = kareSekil.Location.Y;

            // Varsayılan olarak belirlenen renk kırmızıdır.
            // Çizimde kullanılan istenen renk değişkenine kırmızı rengi atanır.
            istenenRenk = Color.Red;
        }

        // ilgili panellerin içinde seçili alanın değişmesi için 
        // boyalı alanın koordinatlarını değiştiren fonksiyonlar
        void seciliRenkDegistir(int x, int y)
        {
            kayitPaneli.Refresh();
            islemPaneli.Refresh();
            renkSecimX = x;
            renkSecimY = y;
            renkPaneli.Refresh();
        }
        void seciliSekilDegistir(int x, int y)
        {
            sekilSecimX = x;
            sekilSecimY = y;
            sekilPaneli.Refresh();
        }
        void seciliIslemDegistir(int x, int y)
        {
            islemSecimX = x;
            islemSecimY = y;
            islemPaneli.Refresh();
        }
        void seciliKayitDegistir(int x, int y)
        {
            kayitSecimX = x;
            kayitSecimY = y;
            kayitPaneli.Refresh();
        }

        private void ucgenSekil_Click(object sender, EventArgs e)
        {
            // Panellerin aktif bilgilerini tutar.
            // İlgili olanları aktfileştirirken diğerlerini kapar.
            sekilAktif = true;
            _sekilSecim = sekilSecim.ucgen;
            secimIslemAktif = false;
            trashIslemAktif = false;
            dosyaIslemAktif = false;

            // diğer panelleri yeniler
            kayitPaneli.Refresh();
            islemPaneli.Refresh();

            // Seçilen kısmın değişmesi için çağırdığımız fonksiyon.
            seciliSekilDegistir(ucgenSekil.Location.X, ucgenSekil.Location.Y);
        }
        private void kareSekil_Click(object sender, EventArgs e)
        {
            // Panellerin aktif bilgilerini tutar.
            // İlgili olanları aktfileştirirken diğerlerini kapar.
            sekilAktif = true;
            _sekilSecim = sekilSecim.dortgen;
            secimIslemAktif = false;
            trashIslemAktif = false;
            dosyaIslemAktif = false;

            // diğer panelleri yeniler
            kayitPaneli.Refresh();
            islemPaneli.Refresh();

            // Seçilen kısmın değişmesi için çağırdığımız fonksiyon.
            seciliSekilDegistir(kareSekil.Location.X, kareSekil.Location.Y);
        }
        private void cemberSekil_Click(object sender, EventArgs e)
        {
            // Panellerin aktif bilgilerini tutar.
            // İlgili olanları aktfileştirirken diğerlerini kapar.
            sekilAktif = true;
            _sekilSecim = sekilSecim.cember;
            secimIslemAktif = false;
            trashIslemAktif = false;
            dosyaIslemAktif = false;

            // diğer panelleri yeniler
            kayitPaneli.Refresh();
            islemPaneli.Refresh();

            // Seçilen kısmın değişmesi için çağırdığımız fonksiyon.
            seciliSekilDegistir(cemberSekil.Location.X, cemberSekil.Location.Y);
        }
        private void altıgenSekil_Click(object sender, EventArgs e)
        {
            // Panellerin aktif bilgilerini tutar.
            // İlgili olanları aktfileştirirken diğerlerini kapar.
            sekilAktif = true;
            _sekilSecim = sekilSecim.altigen;
            secimIslemAktif = false;
            trashIslemAktif = false;
            dosyaIslemAktif = false;

            // diğer panelleri yeniler
            kayitPaneli.Refresh();
            islemPaneli.Refresh();

            // Seçilen kısmın değişmesi için çağırdığımız fonksiyon.
            seciliSekilDegistir(altıgenSekil.Location.X, altıgenSekil.Location.Y);
        }


        private void colorRed_Click(object sender, EventArgs e)
        {
            if (secimIslemAktif == true)
            {
                foreach (var sekil in sekiller)
                {
                    if (sekil.aktif)
                    {
                        sekil.fircaRenk = Color.Red;
                        sekil.aktif = false;
                    }
                    cizimPaneli.Invalidate();
                }
            }
            
            renkAktif = true;
            secimIslemAktif = false;
            trashIslemAktif = false;
            dosyaIslemAktif = false;

            seciliRenkDegistir(colorRed.Location.X, colorRed.Location.Y);
            istenenRenk = Color.Red;
        }
        private void colorBlue_Click(object sender, EventArgs e)
        {
            if (secimIslemAktif == true)
            {
                foreach (var sekil in sekiller)
                {
                    if (sekil.aktif == true)
                    {
                        sekil.fircaRenk = Color.Blue;
                        sekil.aktif = false;
                    }
                    cizimPaneli.Invalidate();
                }
            }
            renkAktif = true;
            secimIslemAktif = false;
            trashIslemAktif = false;
            dosyaIslemAktif = false;


            seciliRenkDegistir(colorBlue.Location.X, colorBlue.Location.Y);
            istenenRenk = Color.Blue;
        }
        private void colorGreen_Click(object sender, EventArgs e)
        {
            if (secimIslemAktif == true)
            {
                foreach (var sekil in sekiller)
                {
                    if (sekil.aktif == true)
                    {
                        sekil.fircaRenk = Color.Green;
                        sekil.aktif = false;
                    }
                    cizimPaneli.Invalidate();
                }
            }
            renkAktif = true;
            secimIslemAktif = false;
            trashIslemAktif = false;
            dosyaIslemAktif = false;

            seciliRenkDegistir(colorGreen.Location.X, colorGreen.Location.Y);
            istenenRenk = Color.Green;
        }
        private void colorOrange_Click(object sender, EventArgs e)
        {
            if (secimIslemAktif == true)
            {
                foreach (var sekil in sekiller)
                {
                    if (sekil.aktif == true)
                    {
                        sekil.fircaRenk = Color.Orange;
                        sekil.aktif = false;
                    }
                    cizimPaneli.Invalidate();
                }
            }
            renkAktif = true;
            secimIslemAktif = false;
            trashIslemAktif = false;
            dosyaIslemAktif = false;

            seciliRenkDegistir(colorOrange.Location.X, colorOrange.Location.Y);
            istenenRenk = Color.Orange;
        }
        private void colorBlack_Click(object sender, EventArgs e)
        {
            if (secimIslemAktif == true)
            {
                foreach (var sekil in sekiller)
                {
                    if (sekil.aktif == true)
                    {
                        sekil.fircaRenk = Color.Black;
                        sekil.aktif = false;
                    }
                    cizimPaneli.Invalidate();
                }
            }
            renkAktif = true;
            secimIslemAktif = false;
            trashIslemAktif = false;
            dosyaIslemAktif = false;

            seciliRenkDegistir(colorBlack.Location.X, colorBlack.Location.Y);
            istenenRenk = Color.Black;
        }
        private void colorYellow_Click(object sender, EventArgs e)
        {
            if (secimIslemAktif == true)
            {
                foreach (var sekil in sekiller)
                {
                    if (sekil.aktif == true)
                    {
                        sekil.fircaRenk = Color.Yellow;
                        sekil.aktif = false;
                    }
                    cizimPaneli.Invalidate();
                }
            }
            renkAktif = true;
            secimIslemAktif = false;
            trashIslemAktif = false;
            dosyaIslemAktif = false;

            seciliRenkDegistir(colorYellow.Location.X, colorYellow.Location.Y);
            istenenRenk = Color.Yellow;
        }
        private void colorPurple_Click(object sender, EventArgs e)
        {
            if (secimIslemAktif == true)
            {
                foreach (var sekil in sekiller)
                {
                    if (sekil.aktif == true)
                    {
                        sekil.fircaRenk = Color.Purple;
                        sekil.aktif = false;
                    }
                    cizimPaneli.Invalidate();
                }
            }
            renkAktif = true;
            secimIslemAktif = false;
            trashIslemAktif = false;
            dosyaIslemAktif = false;

            seciliRenkDegistir(colorPurple.Location.X, colorPurple.Location.Y);
            istenenRenk = Color.Purple;
        }
        private void colorBordo_Click(object sender, EventArgs e)
        {
            if (secimIslemAktif == true)
            {
                foreach (var sekil in sekiller)
                {
                    if (sekil.aktif == true)
                    {
                        sekil.fircaRenk = Color.DarkRed;
                        sekil.aktif = false;
                    }
                    cizimPaneli.Invalidate();
                }
            }
            renkAktif = true;
            secimIslemAktif = false;
            trashIslemAktif = false;
            dosyaIslemAktif = false;

            seciliRenkDegistir(colorBordo.Location.X, colorBordo.Location.Y);
            istenenRenk = Color.DarkRed;
        }
        private void colorWhite_Click(object sender, EventArgs e)
        {
            if (secimIslemAktif == true)
            {
                foreach (var sekil in sekiller)
                {
                    if (sekil.aktif == true)
                    {
                        sekil.fircaRenk = Color.White;
                        sekil.aktif = false;
                    }
                    cizimPaneli.Invalidate();
                }
            }
            renkAktif = true;
            secimIslemAktif = false;
            trashIslemAktif = false;
            dosyaIslemAktif = false;

            seciliRenkDegistir(colorWhite.Location.X, colorWhite.Location.Y);
            istenenRenk = Color.White;
        }

        private void pointerIcon_Click(object sender, EventArgs e)
        {
            sekilAktif = false;
            renkAktif = false;
            secimIslemAktif = true;
            dosyaIslemAktif = false;

            kayitPaneli.Refresh();
            sekilPaneli.Refresh();
            renkPaneli.Refresh();

            seciliIslemDegistir(pointerIcon.Location.X, pointerIcon.Location.Y);
        }
        private void trashIcon_Click(object sender, EventArgs e)
        {
            trashIslemAktif = true;
            // Silme tuşuna basıldığında seçili şekil varsa şekli sekiller den çıkarır.
            if (secimIslemAktif == true && trashIslemAktif == true)
            {
                foreach (var sekil in sekiller)
                {
                    if (sekil.aktif == true)
                    {
                        sekiller.Remove(sekil);
                        break;
                    }
                }
                cizimPaneli.Invalidate();
            }
            if (secimIslemAktif)
            {
                sekilAktif = false;
                renkAktif = false;
                secimIslemAktif = true;
                dosyaIslemAktif = false;

                kayitPaneli.Refresh();
                sekilPaneli.Refresh();
                renkPaneli.Refresh();

                seciliIslemDegistir(trashIcon.Location.X, trashIcon.Location.Y);
            }
            else
            {
                MessageBox.Show("Lütfen önce silinecek şekli seçiniz.");
            }
        }
        

        private void islemPaneli_Paint(object sender, PaintEventArgs e)
        {
            // İşlem panelindeki butonlara tıklandığında yapılan çizim işlemi
            if (secimIslemAktif || trashIslemAktif)
            {
                Color transparanRenk = Transparanlastir(127, Color.Purple);
                Brush brush = new SolidBrush(transparanRenk);
                e.Graphics.FillRectangle(brush, islemSecimX - 5, islemSecimY - 5, 70, 72);
                brush.Dispose();
            }
        }
        private void renkPaneli_Paint(object sender, PaintEventArgs e)
        {
            // Renk aktif se yani herhangi bir renk seçili ise seçilen kısmı boyar.
            if (renkAktif)
            {
                Color transparanRenk = Transparanlastir(127, Color.Purple);
                Brush brush = new SolidBrush(transparanRenk);
                e.Graphics.FillRectangle(brush, renkSecimX - 5, renkSecimY - 5, 40, 40);
                brush.Dispose();
            }
        }
        private void sekilPaneli_Paint(object sender, PaintEventArgs e)
        {
            // sekilAktif se yani panelde herhangi bir şekil seçili ise seçilenin
            // etrafını boyar.
            if (sekilAktif)
            {
                Color transparanRenk = Transparanlastir(144, Color.Purple);
                Brush brush = new SolidBrush(transparanRenk);
                e.Graphics.FillRectangle(brush, sekilSecimX - 5, sekilSecimY - 5, 70, 70);
                brush.Dispose();
            }
        }
        private void kayıtPaneli_Paint(object sender, PaintEventArgs e)
        {
            // dosyaIslemAktif aktifse seçilen kısmı boyar.
            if (dosyaIslemAktif)
            {
                Color transparanRenk = Transparanlastir(144, Color.Purple);
                Brush brush = new SolidBrush(transparanRenk);
                e.Graphics.FillRectangle(brush, kayitSecimX - 5, kayitSecimY - 5, 70, 70);
                brush.Dispose();
            }
        }
        
        

        private void dosyaKaydet_Click(object sender, EventArgs e)
        {
            dosyaIslemAktif = true;
            sekilAktif = false;
            secimIslemAktif = false;
            trashIslemAktif = false;

            sekilPaneli.Refresh();
            renkPaneli.Refresh();
            islemPaneli.Refresh();

            // Seçilen kısmın değişmesi için çağırdığımız fonksiyon.
            seciliKayitDegistir(saveFile.Location.X, saveFile.Location.Y);

            try
            {
                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "Metin Dosyası|*.txt";
                save.OverwritePrompt = true;
                save.CreatePrompt = true;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter Kayit = new StreamWriter(save.FileName);

                    // Gelen şeklin ozet fonksiyonu ile gelen string dosyaya kayıt etme formatıdır.
                    // gelen string de dosyaya yazılır.
                    foreach (var sekil in sekiller)
                    {
                        Kayit.WriteLine(sekil.DosyaKayitFormat());
                    }

                    Kayit.Close();
                    MessageBox.Show("Kayıt işlemi başarılı.", "Kayıt İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kayitPaneli.Refresh();
                }
                else
                {
                    dosyaIslemAktif = false;
                    kayitPaneli.Refresh();
                }
            }
            catch
            {
                //Dosyaya yazma işlemi tamamlanmassa hata mesajı ekrana veriliyor.
                MessageBox.Show("Kayıt İşleminiz Tamamlanamadı.", "Kayıt İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dosyadanOku_Click(object sender, EventArgs e)
        {
            dosyaIslemAktif = true;
            sekilAktif = false;
            secimIslemAktif = false;
            trashIslemAktif = false;

            sekilPaneli.Refresh();
            renkPaneli.Refresh();
            islemPaneli.Refresh();

            seciliKayitDegistir(openFile.Location.X, openFile.Location.Y);

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Metin Dosyası|*.txt";


            if (open.ShowDialog() == DialogResult.OK)
            {
                string satir;
                string[] bilgiler;

                g = cizimPaneli.CreateGraphics();
                StreamReader Oku = new StreamReader(open.FileName);

                while ((satir = Oku.ReadLine()) != null)
                {
                    bilgiler = satir.Split('/');
                    Color color = Color.FromArgb(Convert.ToInt32(bilgiler[5]));

                    //Alınan şekil bilgisine göre nesneyi oluşturur ve sekiller listesine ekler.
                    switch (bilgiler[0])
                    {
                        case "Kare":
                            dortgen = new Dortgen(color, (float)(Convert.ToDouble(bilgiler[1])), (float)(Convert.ToDouble(bilgiler[2])), (float)(Convert.ToDouble(bilgiler[3])), (float)(Convert.ToDouble(bilgiler[4])));
                            sekiller.Add(dortgen);
                            break;
                        case "Cember":
                            cember = new Cember(color, (float)(Convert.ToDouble(bilgiler[1])), (float)(Convert.ToDouble(bilgiler[2])), (float)(Convert.ToDouble(bilgiler[3])), (float)(Convert.ToDouble(bilgiler[4])));
                            sekiller.Add(cember);
                            break;
                        case "Ucgen":
                            ucgen = new Ucgen(color, (float)(Convert.ToDouble(bilgiler[1])), (float)(Convert.ToDouble(bilgiler[2])), (float)(Convert.ToDouble(bilgiler[3])), (float)(Convert.ToDouble(bilgiler[4])));
                            sekiller.Add(ucgen);
                            break;
                        case "Altigen":
                            altigen = new Altigen(color, (float)(Convert.ToDouble(bilgiler[1])), (float)(Convert.ToDouble(bilgiler[2])), (float)(Convert.ToDouble(bilgiler[3])), (float)(Convert.ToDouble(bilgiler[4])));
                            sekiller.Add(altigen);
                            break;
                        default:
                            break;
                    }
                }
                Oku.Close();

                dosyaIslemAktif = false;
                cizimPaneli.Invalidate();
            }
            else
            {
                dosyaIslemAktif = false;
            }

            kayitPaneli.Refresh();
        }

        private void cizimPaneli_MouseMove(object sender, MouseEventArgs e)
        {
            // Mouseun bulunduğu konumun bilgisi Point mouseTakipP değişkeninde tutulur.
            Point mouseTakipP = new Point();
            mouseTakipP = e.Location;

            //float x = Math.Min(baslangicNoktasi.X, p.X);
            //float y = Math.Min(baslangicNoktasi.Y, p.Y);

            // x ve y değeri panele ilk tıklandığındaki konumun x ve y değeridir.
            float x = baslangicNoktasi.X;
            float y = baslangicNoktasi.Y;
            // yukseklik ve genislik değeri panele ilk tıklandığındaki konumudan mouse ın bulunduğu
            // konumun fark değerinin mutlak değeridir.
            float yukseklik = Math.Abs(baslangicNoktasi.Y - mouseTakipP.Y);
            float genislik = Math.Abs(baslangicNoktasi.X - mouseTakipP.X);

            // Panelin sınırlarında sorun olduğu için biraz eksiltme işlemi yaptım.
            int sagSinir = cizimPaneli.Right - 15;
            int solSinir = cizimPaneli.Left - 10;
            int ustSinir = cizimPaneli.Top - 15;
            int altSinir = cizimPaneli.Bottom - 15;
            
            // genişlik ve yükseklik değerini eşitleyerek sadece düzgün çokkenar çizimini sağlıyorum.
            if (genislik < yukseklik)
                genislik = yukseklik;
            else
                yukseklik = genislik;

            g = cizimPaneli.CreateGraphics();
            // Eğer şekil seçimi ve clickAktifi true ysa
            if (clickAktif && sekilAktif)
            { 
                switch (_sekilSecim)
                {
                    case sekilSecim.ucgen:

                        float hipotenus = (float)Math.Sqrt((genislik * genislik) + (yukseklik * yukseklik));

                        // Şekil çizerken panel dışına taşmasını engelleyen koşul
                        if (baslangicNoktasi.X - genislik > solSinir &&
                            baslangicNoktasi.X + genislik < sagSinir &&
                            baslangicNoktasi.Y - hipotenus + 30 > ustSinir &&
                            baslangicNoktasi.Y + yukseklik < altSinir)
                        {
                            cizimPaneli.Refresh();
                            ucgen = new Ucgen(istenenRenk, x, y, genislik, yukseklik);
                            ucgen.Ciz(g);
                        }

                        break;

                    case sekilSecim.dortgen:

                        // Şekil çizerken panel dışına taşmasını engelleyen koşul
                        if (baslangicNoktasi.X + genislik < sagSinir &&
                            baslangicNoktasi.Y + yukseklik < altSinir)
                        {
                            cizimPaneli.Refresh();
                            dortgen = new Dortgen(istenenRenk, x, y, genislik, yukseklik);
                            dortgen.Ciz(g);
                        }

                        break;

                    case sekilSecim.altigen:

                        // Şekil çizerken panel dışına taşmasını engelleyen koşul
                        if (baslangicNoktasi.X - (2 * genislik) > solSinir &&
                            baslangicNoktasi.X + (2 * genislik) < sagSinir &&
                            baslangicNoktasi.Y - (2 * yukseklik) > ustSinir &&
                            baslangicNoktasi.Y + (2 * yukseklik) < altSinir)
                        {
                            cizimPaneli.Refresh();
                            altigen = new Altigen(istenenRenk, x, y, genislik * 4, yukseklik * 4);
                            altigen.Ciz(g);
                        }

                        break;

                    case sekilSecim.cember:

                        // Şekil çizerken panel dışına taşmasını engelleyen koşul
                        if (baslangicNoktasi.X + genislik < sagSinir &&
                            baslangicNoktasi.Y + yukseklik < altSinir)
                        {
                            cizimPaneli.Refresh();
                            cember = new Cember(istenenRenk, x, y, genislik, yukseklik);
                            cember.Ciz(g);
                        }

                        break;
                }
            }

        }
        private void cizimPaneli_MouseDown(object sender, MouseEventArgs e)
        {
            // Seçim işlemi aktif ise secimPoint lokasyonu mouseun tıklandığı andaki lokasyonudur.
            if (secimIslemAktif == true)
            {
                secimPoint = e.Location;
            }
            clickAktif = true;
            baslangicNoktasi = e.Location;
        }
        private void cizimPaneli_MouseUp(object sender, MouseEventArgs e)
        {
            clickAktif = false;

            // Panelden mouse tık kalktığında şekil seçili ise şeklin tipine göre
            // oluşan şekil şekiller listesine basılır.
            if (_sekilSecim == sekilSecim.dortgen && sekilAktif)
            {
                sekiller.Add(dortgen);
            }
            else if (_sekilSecim == sekilSecim.cember && sekilAktif)
            {
                sekiller.Add(cember);
            }
            else if (_sekilSecim == sekilSecim.ucgen && sekilAktif)
            {
                sekiller.Add(ucgen);
            }
            else if (_sekilSecim == sekilSecim.altigen && sekilAktif)
            {
                sekiller.Add(altigen);
            }
            cizimPaneli.Invalidate();
        }
        private void cizimPaneli_Paint(object sender, PaintEventArgs e)
        {
            // Şekil seçme butonu aktifse
            if (secimIslemAktif == true)
            {
                // Şekiller kadar döner
                foreach (var sekil in sekiller)
                {
                    Color transparanSiyah = Transparanlastir(127, Color.Black);
                    Brush myBrush = new SolidBrush(transparanSiyah);

                    // Öncelikle daha önceden aktifleşmiş şekkillerin önüne geçmek için
                    // başta gelen bütün şekillerin aktif değeri kapanır.
                    sekil.aktif = false;

                    // IsInPolygon şekli tarar ve tıkladığımız nokta s 
                    // koordinatı şeklin içindeyse içeriye girer ve etrafını boyar.
                    if (PolygonunIcindemi(sekil.SekilPoints(), secimPoint))
                    {
                        if (sekil.GetType() == typeof(Ucgen))
                        {
                            e.Graphics.FillRectangle(myBrush, sekil.X - sekil.genislik - 5, sekil.Y - sekil.yukseklik - 5, (sekil.genislik * 2) + 10, (sekil.yukseklik * 2) + 10);
                        }
                        if (sekil.GetType() == typeof(Altigen))
                        {
                            e.Graphics.FillRectangle(myBrush, sekil.X - (sekil.genislik / 2) - 5, sekil.Y - (sekil.yukseklik / 2) - 5, sekil.genislik + 10, sekil.yukseklik + 10);
                        }
                        if (sekil.GetType() == typeof(Dortgen))
                        {
                            e.Graphics.FillRectangle(myBrush, sekil.X - 10, sekil.Y - 10, sekil.genislik + 20, sekil.yukseklik + 20);
                        }
                        if (sekil.GetType() == typeof(Cember))
                        {
                            e.Graphics.FillRectangle(myBrush, sekil.X - 10, sekil.Y - 10, sekil.genislik + 20, sekil.yukseklik + 20);
                        }

                        // Şeklin etrafını boyadıktan sonra aktif ini true yapar.
                        sekil.aktif = true;
                    }
                }
            }

            // sekiller içindeki şekilleri ekrana çizer.
            foreach (var sekil in sekiller)
            {
                sekil.Ciz(g);
            }

        }

        static Color Transparanlastir(int A, Color color)
        {
            return Color.FromArgb(A, color.R, color.G, color.B);
        }
        public static bool PolygonunIcindemi(PointF[] polygon, PointF testPoint)
        {
            bool result = false;
            int j = polygon.Count() - 1;

            for (int i = 0; i < polygon.Count(); i++)
            {
                if (polygon[i].Y < testPoint.Y && polygon[j].Y >= testPoint.Y || polygon[j].Y < testPoint.Y && polygon[i].Y >= testPoint.Y)
                {
                    if (polygon[i].X + (testPoint.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) * (polygon[j].X - polygon[i].X) < testPoint.X)
                    {
                        result = !result;
                    }
                }
                j = i;
            }
            return result;
        }
    }
}



