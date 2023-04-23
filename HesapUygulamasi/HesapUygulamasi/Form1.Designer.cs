
namespace _200601035_Ödev1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.Bitiş = new System.Windows.Forms.Label();
            this.mtbBitis = new System.Windows.Forms.MaskedTextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.mtbBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvTekSayilar = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvCiftSayilar = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lvAsalSayilar = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lvMukemmelSayilar = new System.Windows.Forms.ListView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Controls.Add(this.Bitiş);
            this.groupBox1.Controls.Add(this.mtbBitis);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.mtbBaslangic);
            this.groupBox1.Location = new System.Drawing.Point(43, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Bilgileri";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(486, 44);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Bitiş
            // 
            this.Bitiş.AutoSize = true;
            this.Bitiş.Location = new System.Drawing.Point(286, 44);
            this.Bitiş.Name = "Bitiş";
            this.Bitiş.Size = new System.Drawing.Size(38, 17);
            this.Bitiş.TabIndex = 3;
            this.Bitiş.Text = "Bitiş:";
            // 
            // mtbBitis
            // 
            this.mtbBitis.Location = new System.Drawing.Point(330, 44);
            this.mtbBitis.Mask = "00000";
            this.mtbBitis.Name = "mtbBitis";
            this.mtbBitis.Size = new System.Drawing.Size(100, 22);
            this.mtbBitis.TabIndex = 2;
            this.mtbBitis.ValidatingType = typeof(int);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(45, 40);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(73, 17);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Başlangıç:";
            // 
            // mtbBaslangic
            // 
            this.mtbBaslangic.Location = new System.Drawing.Point(124, 41);
            this.mtbBaslangic.Mask = "00000";
            this.mtbBaslangic.Name = "mtbBaslangic";
            this.mtbBaslangic.Size = new System.Drawing.Size(100, 22);
            this.mtbBaslangic.TabIndex = 0;
            this.mtbBaslangic.ValidatingType = typeof(int);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(43, 139);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(689, 133);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvTekSayilar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(681, 104);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tek Sayılar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvTekSayilar
            // 
            this.lvTekSayilar.HideSelection = false;
            this.lvTekSayilar.Location = new System.Drawing.Point(3, 7);
            this.lvTekSayilar.Name = "lvTekSayilar";
            this.lvTekSayilar.Size = new System.Drawing.Size(672, 97);
            this.lvTekSayilar.TabIndex = 0;
            this.lvTekSayilar.UseCompatibleStateImageBehavior = false;
            this.lvTekSayilar.SelectedIndexChanged += new System.EventHandler(this.lvTekSayilar_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvCiftSayilar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(681, 104);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Çift Sayılar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvCiftSayilar
            // 
            this.lvCiftSayilar.HideSelection = false;
            this.lvCiftSayilar.Location = new System.Drawing.Point(3, 3);
            this.lvCiftSayilar.Name = "lvCiftSayilar";
            this.lvCiftSayilar.Size = new System.Drawing.Size(672, 97);
            this.lvCiftSayilar.TabIndex = 1;
            this.lvCiftSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvAsalSayilar);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(681, 104);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Asal Sayılar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lvAsalSayilar
            // 
            this.lvAsalSayilar.HideSelection = false;
            this.lvAsalSayilar.Location = new System.Drawing.Point(6, 3);
            this.lvAsalSayilar.Name = "lvAsalSayilar";
            this.lvAsalSayilar.Size = new System.Drawing.Size(672, 97);
            this.lvAsalSayilar.TabIndex = 2;
            this.lvAsalSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lvMukemmelSayilar);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(681, 104);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mükemmel Sayılar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lvMukemmelSayilar
            // 
            this.lvMukemmelSayilar.HideSelection = false;
            this.lvMukemmelSayilar.Location = new System.Drawing.Point(6, 4);
            this.lvMukemmelSayilar.Name = "lvMukemmelSayilar";
            this.lvMukemmelSayilar.Size = new System.Drawing.Size(672, 97);
            this.lvMukemmelSayilar.TabIndex = 3;
            this.lvMukemmelSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 322);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.MaskedTextBox mtbBaslangic;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvTekSayilar;
        private System.Windows.Forms.Label Bitiş;
        private System.Windows.Forms.MaskedTextBox mtbBitis;
        private System.Windows.Forms.ListView lvCiftSayilar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lvAsalSayilar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView lvMukemmelSayilar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

