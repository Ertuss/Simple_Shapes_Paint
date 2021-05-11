namespace NDP_ProjeOdevi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.renkPaneli = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.colorWhite = new System.Windows.Forms.PictureBox();
            this.colorBordo = new System.Windows.Forms.PictureBox();
            this.colorPurple = new System.Windows.Forms.PictureBox();
            this.colorYellow = new System.Windows.Forms.PictureBox();
            this.colorBlack = new System.Windows.Forms.PictureBox();
            this.colorOrange = new System.Windows.Forms.PictureBox();
            this.colorGreen = new System.Windows.Forms.PictureBox();
            this.colorBlue = new System.Windows.Forms.PictureBox();
            this.colorRed = new System.Windows.Forms.PictureBox();
            this.islemPaneli = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.trashIcon = new System.Windows.Forms.PictureBox();
            this.pointerIcon = new System.Windows.Forms.PictureBox();
            this.kayitPaneli = new System.Windows.Forms.Panel();
            this.saveFile = new System.Windows.Forms.PictureBox();
            this.openFile = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cizimPaneli = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.kareSekil = new System.Windows.Forms.PictureBox();
            this.cemberSekil = new System.Windows.Forms.PictureBox();
            this.ucgenSekil = new System.Windows.Forms.PictureBox();
            this.altıgenSekil = new System.Windows.Forms.PictureBox();
            this.sekilPaneli = new System.Windows.Forms.Panel();
            this.renkPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBordo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPurple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRed)).BeginInit();
            this.islemPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trashIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointerIcon)).BeginInit();
            this.kayitPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kareSekil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cemberSekil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucgenSekil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altıgenSekil)).BeginInit();
            this.sekilPaneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // renkPaneli
            // 
            this.renkPaneli.BackColor = System.Drawing.Color.LightSteelBlue;
            this.renkPaneli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.renkPaneli.Controls.Add(this.label1);
            this.renkPaneli.Controls.Add(this.colorWhite);
            this.renkPaneli.Controls.Add(this.colorBordo);
            this.renkPaneli.Controls.Add(this.colorPurple);
            this.renkPaneli.Controls.Add(this.colorYellow);
            this.renkPaneli.Controls.Add(this.colorBlack);
            this.renkPaneli.Controls.Add(this.colorOrange);
            this.renkPaneli.Controls.Add(this.colorGreen);
            this.renkPaneli.Controls.Add(this.colorBlue);
            this.renkPaneli.Controls.Add(this.colorRed);
            this.renkPaneli.Location = new System.Drawing.Point(697, 196);
            this.renkPaneli.Margin = new System.Windows.Forms.Padding(2);
            this.renkPaneli.Name = "renkPaneli";
            this.renkPaneli.Size = new System.Drawing.Size(157, 165);
            this.renkPaneli.TabIndex = 9;
            this.renkPaneli.Paint += new System.Windows.Forms.PaintEventHandler(this.renkPaneli_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Renk Seçimi :";
            // 
            // colorWhite
            // 
            this.colorWhite.BackColor = System.Drawing.Color.White;
            this.colorWhite.Location = new System.Drawing.Point(105, 120);
            this.colorWhite.Margin = new System.Windows.Forms.Padding(2);
            this.colorWhite.Name = "colorWhite";
            this.colorWhite.Size = new System.Drawing.Size(30, 30);
            this.colorWhite.TabIndex = 17;
            this.colorWhite.TabStop = false;
            this.colorWhite.Click += new System.EventHandler(this.colorWhite_Click);
            // 
            // colorBordo
            // 
            this.colorBordo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorBordo.Location = new System.Drawing.Point(62, 120);
            this.colorBordo.Margin = new System.Windows.Forms.Padding(2);
            this.colorBordo.Name = "colorBordo";
            this.colorBordo.Size = new System.Drawing.Size(30, 30);
            this.colorBordo.TabIndex = 16;
            this.colorBordo.TabStop = false;
            this.colorBordo.Click += new System.EventHandler(this.colorBordo_Click);
            // 
            // colorPurple
            // 
            this.colorPurple.BackColor = System.Drawing.Color.Purple;
            this.colorPurple.Location = new System.Drawing.Point(19, 120);
            this.colorPurple.Margin = new System.Windows.Forms.Padding(2);
            this.colorPurple.Name = "colorPurple";
            this.colorPurple.Size = new System.Drawing.Size(30, 30);
            this.colorPurple.TabIndex = 15;
            this.colorPurple.TabStop = false;
            this.colorPurple.Click += new System.EventHandler(this.colorPurple_Click);
            // 
            // colorYellow
            // 
            this.colorYellow.BackColor = System.Drawing.Color.Yellow;
            this.colorYellow.Location = new System.Drawing.Point(105, 75);
            this.colorYellow.Margin = new System.Windows.Forms.Padding(2);
            this.colorYellow.Name = "colorYellow";
            this.colorYellow.Size = new System.Drawing.Size(30, 30);
            this.colorYellow.TabIndex = 14;
            this.colorYellow.TabStop = false;
            this.colorYellow.Click += new System.EventHandler(this.colorYellow_Click);
            // 
            // colorBlack
            // 
            this.colorBlack.BackColor = System.Drawing.Color.Black;
            this.colorBlack.Location = new System.Drawing.Point(62, 75);
            this.colorBlack.Margin = new System.Windows.Forms.Padding(2);
            this.colorBlack.Name = "colorBlack";
            this.colorBlack.Size = new System.Drawing.Size(30, 30);
            this.colorBlack.TabIndex = 13;
            this.colorBlack.TabStop = false;
            this.colorBlack.Click += new System.EventHandler(this.colorBlack_Click);
            // 
            // colorOrange
            // 
            this.colorOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colorOrange.Location = new System.Drawing.Point(19, 75);
            this.colorOrange.Margin = new System.Windows.Forms.Padding(2);
            this.colorOrange.Name = "colorOrange";
            this.colorOrange.Size = new System.Drawing.Size(30, 30);
            this.colorOrange.TabIndex = 12;
            this.colorOrange.TabStop = false;
            this.colorOrange.Click += new System.EventHandler(this.colorOrange_Click);
            // 
            // colorGreen
            // 
            this.colorGreen.BackColor = System.Drawing.Color.Green;
            this.colorGreen.Location = new System.Drawing.Point(105, 30);
            this.colorGreen.Margin = new System.Windows.Forms.Padding(2);
            this.colorGreen.Name = "colorGreen";
            this.colorGreen.Size = new System.Drawing.Size(30, 30);
            this.colorGreen.TabIndex = 11;
            this.colorGreen.TabStop = false;
            this.colorGreen.Click += new System.EventHandler(this.colorGreen_Click);
            // 
            // colorBlue
            // 
            this.colorBlue.BackColor = System.Drawing.Color.Blue;
            this.colorBlue.Location = new System.Drawing.Point(62, 30);
            this.colorBlue.Margin = new System.Windows.Forms.Padding(2);
            this.colorBlue.Name = "colorBlue";
            this.colorBlue.Size = new System.Drawing.Size(30, 30);
            this.colorBlue.TabIndex = 10;
            this.colorBlue.TabStop = false;
            this.colorBlue.Click += new System.EventHandler(this.colorBlue_Click);
            // 
            // colorRed
            // 
            this.colorRed.BackColor = System.Drawing.Color.Red;
            this.colorRed.Location = new System.Drawing.Point(19, 30);
            this.colorRed.Margin = new System.Windows.Forms.Padding(2);
            this.colorRed.Name = "colorRed";
            this.colorRed.Size = new System.Drawing.Size(30, 30);
            this.colorRed.TabIndex = 0;
            this.colorRed.TabStop = false;
            this.colorRed.Click += new System.EventHandler(this.colorRed_Click);
            // 
            // islemPaneli
            // 
            this.islemPaneli.BackColor = System.Drawing.Color.White;
            this.islemPaneli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.islemPaneli.Controls.Add(this.label5);
            this.islemPaneli.Controls.Add(this.trashIcon);
            this.islemPaneli.Controls.Add(this.pointerIcon);
            this.islemPaneli.Location = new System.Drawing.Point(697, 365);
            this.islemPaneli.Margin = new System.Windows.Forms.Padding(2);
            this.islemPaneli.Name = "islemPaneli";
            this.islemPaneli.Size = new System.Drawing.Size(157, 104);
            this.islemPaneli.TabIndex = 11;
            this.islemPaneli.Paint += new System.Windows.Forms.PaintEventHandler(this.islemPaneli_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Şekil İşlemleri :";
            // 
            // trashIcon
            // 
            this.trashIcon.Image = ((System.Drawing.Image)(resources.GetObject("trashIcon.Image")));
            this.trashIcon.Location = new System.Drawing.Point(82, 30);
            this.trashIcon.Margin = new System.Windows.Forms.Padding(2);
            this.trashIcon.Name = "trashIcon";
            this.trashIcon.Size = new System.Drawing.Size(59, 63);
            this.trashIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trashIcon.TabIndex = 12;
            this.trashIcon.TabStop = false;
            this.trashIcon.Click += new System.EventHandler(this.trashIcon_Click);
            // 
            // pointerIcon
            // 
            this.pointerIcon.Image = ((System.Drawing.Image)(resources.GetObject("pointerIcon.Image")));
            this.pointerIcon.Location = new System.Drawing.Point(10, 30);
            this.pointerIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pointerIcon.Name = "pointerIcon";
            this.pointerIcon.Size = new System.Drawing.Size(60, 63);
            this.pointerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pointerIcon.TabIndex = 11;
            this.pointerIcon.TabStop = false;
            this.pointerIcon.Click += new System.EventHandler(this.pointerIcon_Click);
            // 
            // kayitPaneli
            // 
            this.kayitPaneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kayitPaneli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kayitPaneli.Controls.Add(this.saveFile);
            this.kayitPaneli.Controls.Add(this.openFile);
            this.kayitPaneli.Controls.Add(this.label4);
            this.kayitPaneli.Location = new System.Drawing.Point(697, 473);
            this.kayitPaneli.Margin = new System.Windows.Forms.Padding(2);
            this.kayitPaneli.Name = "kayitPaneli";
            this.kayitPaneli.Size = new System.Drawing.Size(157, 103);
            this.kayitPaneli.TabIndex = 12;
            this.kayitPaneli.Paint += new System.Windows.Forms.PaintEventHandler(this.kayıtPaneli_Paint);
            // 
            // saveFile
            // 
            this.saveFile.Image = ((System.Drawing.Image)(resources.GetObject("saveFile.Image")));
            this.saveFile.Location = new System.Drawing.Point(82, 31);
            this.saveFile.Margin = new System.Windows.Forms.Padding(2);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(60, 60);
            this.saveFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saveFile.TabIndex = 12;
            this.saveFile.TabStop = false;
            this.saveFile.Click += new System.EventHandler(this.dosyaKaydet_Click);
            // 
            // openFile
            // 
            this.openFile.Image = ((System.Drawing.Image)(resources.GetObject("openFile.Image")));
            this.openFile.Location = new System.Drawing.Point(10, 31);
            this.openFile.Margin = new System.Windows.Forms.Padding(2);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(60, 60);
            this.openFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openFile.TabIndex = 11;
            this.openFile.TabStop = false;
            this.openFile.Click += new System.EventHandler(this.dosyadanOku_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dosya İşlemleri :";
            // 
            // cizimPaneli
            // 
            this.cizimPaneli.BackColor = System.Drawing.Color.MintCream;
            this.cizimPaneli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cizimPaneli.BackgroundImage")));
            this.cizimPaneli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cizimPaneli.Location = new System.Drawing.Point(10, 11);
            this.cizimPaneli.Margin = new System.Windows.Forms.Padding(2);
            this.cizimPaneli.Name = "cizimPaneli";
            this.cizimPaneli.Size = new System.Drawing.Size(683, 565);
            this.cizimPaneli.TabIndex = 13;
            this.cizimPaneli.Paint += new System.Windows.Forms.PaintEventHandler(this.cizimPaneli_Paint);
            this.cizimPaneli.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cizimPaneli_MouseDown);
            this.cizimPaneli.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cizimPaneli_MouseMove);
            this.cizimPaneli.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cizimPaneli_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şekil Seçimi";
            // 
            // kareSekil
            // 
            this.kareSekil.Image = ((System.Drawing.Image)(resources.GetObject("kareSekil.Image")));
            this.kareSekil.Location = new System.Drawing.Point(13, 37);
            this.kareSekil.Margin = new System.Windows.Forms.Padding(2);
            this.kareSekil.Name = "kareSekil";
            this.kareSekil.Size = new System.Drawing.Size(60, 60);
            this.kareSekil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kareSekil.TabIndex = 10;
            this.kareSekil.TabStop = false;
            this.kareSekil.Click += new System.EventHandler(this.kareSekil_Click);
            // 
            // cemberSekil
            // 
            this.cemberSekil.Image = ((System.Drawing.Image)(resources.GetObject("cemberSekil.Image")));
            this.cemberSekil.Location = new System.Drawing.Point(85, 37);
            this.cemberSekil.Margin = new System.Windows.Forms.Padding(2);
            this.cemberSekil.Name = "cemberSekil";
            this.cemberSekil.Size = new System.Drawing.Size(60, 60);
            this.cemberSekil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cemberSekil.TabIndex = 11;
            this.cemberSekil.TabStop = false;
            this.cemberSekil.Click += new System.EventHandler(this.cemberSekil_Click);
            // 
            // ucgenSekil
            // 
            this.ucgenSekil.Image = ((System.Drawing.Image)(resources.GetObject("ucgenSekil.Image")));
            this.ucgenSekil.Location = new System.Drawing.Point(13, 110);
            this.ucgenSekil.Margin = new System.Windows.Forms.Padding(2);
            this.ucgenSekil.Name = "ucgenSekil";
            this.ucgenSekil.Size = new System.Drawing.Size(60, 60);
            this.ucgenSekil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucgenSekil.TabIndex = 12;
            this.ucgenSekil.TabStop = false;
            this.ucgenSekil.Click += new System.EventHandler(this.ucgenSekil_Click);
            // 
            // altıgenSekil
            // 
            this.altıgenSekil.Image = ((System.Drawing.Image)(resources.GetObject("altıgenSekil.Image")));
            this.altıgenSekil.Location = new System.Drawing.Point(85, 110);
            this.altıgenSekil.Margin = new System.Windows.Forms.Padding(2);
            this.altıgenSekil.Name = "altıgenSekil";
            this.altıgenSekil.Size = new System.Drawing.Size(60, 60);
            this.altıgenSekil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.altıgenSekil.TabIndex = 13;
            this.altıgenSekil.TabStop = false;
            this.altıgenSekil.Click += new System.EventHandler(this.altıgenSekil_Click);
            // 
            // sekilPaneli
            // 
            this.sekilPaneli.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.sekilPaneli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sekilPaneli.Controls.Add(this.label2);
            this.sekilPaneli.Controls.Add(this.cemberSekil);
            this.sekilPaneli.Controls.Add(this.ucgenSekil);
            this.sekilPaneli.Controls.Add(this.altıgenSekil);
            this.sekilPaneli.Controls.Add(this.kareSekil);
            this.sekilPaneli.Location = new System.Drawing.Point(697, 10);
            this.sekilPaneli.Margin = new System.Windows.Forms.Padding(2);
            this.sekilPaneli.Name = "sekilPaneli";
            this.sekilPaneli.Size = new System.Drawing.Size(157, 182);
            this.sekilPaneli.TabIndex = 10;
            this.sekilPaneli.Paint += new System.Windows.Forms.PaintEventHandler(this.sekilPaneli_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(862, 580);
            this.Controls.Add(this.cizimPaneli);
            this.Controls.Add(this.kayitPaneli);
            this.Controls.Add(this.islemPaneli);
            this.Controls.Add(this.renkPaneli);
            this.Controls.Add(this.sekilPaneli);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.renkPaneli.ResumeLayout(false);
            this.renkPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBordo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPurple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRed)).EndInit();
            this.islemPaneli.ResumeLayout(false);
            this.islemPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trashIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointerIcon)).EndInit();
            this.kayitPaneli.ResumeLayout(false);
            this.kayitPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kareSekil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cemberSekil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucgenSekil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altıgenSekil)).EndInit();
            this.sekilPaneli.ResumeLayout(false);
            this.sekilPaneli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel renkPaneli;
        private System.Windows.Forms.Panel islemPaneli;
        private System.Windows.Forms.Panel kayitPaneli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel cizimPaneli;
        private System.Windows.Forms.PictureBox trashIcon;
        private System.Windows.Forms.PictureBox pointerIcon;
        private System.Windows.Forms.PictureBox saveFile;
        private System.Windows.Forms.PictureBox openFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox kareSekil;
        private System.Windows.Forms.PictureBox cemberSekil;
        private System.Windows.Forms.PictureBox ucgenSekil;
        private System.Windows.Forms.PictureBox altıgenSekil;
        private System.Windows.Forms.Panel sekilPaneli;
        private System.Windows.Forms.PictureBox colorWhite;
        private System.Windows.Forms.PictureBox colorBordo;
        private System.Windows.Forms.PictureBox colorPurple;
        private System.Windows.Forms.PictureBox colorYellow;
        private System.Windows.Forms.PictureBox colorBlack;
        private System.Windows.Forms.PictureBox colorOrange;
        private System.Windows.Forms.PictureBox colorGreen;
        private System.Windows.Forms.PictureBox colorBlue;
        private System.Windows.Forms.PictureBox colorRed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}

