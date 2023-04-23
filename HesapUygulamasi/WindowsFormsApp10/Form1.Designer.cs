
namespace WindowsFormsApp10
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Baslangic = new System.Windows.Forms.Label();
            this.Bitis = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MukemmelSayilar = new System.Windows.Forms.TabControl();
            this.TekSayilar = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Calistir = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.MukemmelSayilar.SuspendLayout();
            this.TekSayilar.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Calistir);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Bitis);
            this.groupBox1.Controls.Add(this.Baslangic);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Bilgileri";
            // 
            // Baslangic
            // 
            this.Baslangic.AutoSize = true;
            this.Baslangic.Location = new System.Drawing.Point(30, 47);
            this.Baslangic.Name = "Baslangic";
            this.Baslangic.Size = new System.Drawing.Size(69, 17);
            this.Baslangic.TabIndex = 0;
            this.Baslangic.Text = "Başlangıç";
            // 
            // Bitis
            // 
            this.Bitis.AutoSize = true;
            this.Bitis.Location = new System.Drawing.Point(238, 47);
            this.Bitis.Name = "Bitis";
            this.Bitis.Size = new System.Drawing.Size(34, 17);
            this.Bitis.TabIndex = 1;
            this.Bitis.Text = "Bitiş";
            this.Bitis.Click += new System.EventHandler(this.label2_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(725, 149);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MukemmelSayilar
            // 
            this.MukemmelSayilar.Controls.Add(this.TekSayilar);
            this.MukemmelSayilar.Controls.Add(this.tabPage2);
            this.MukemmelSayilar.Controls.Add(this.tabPage3);
            this.MukemmelSayilar.Controls.Add(this.tabPage4);
            this.MukemmelSayilar.Location = new System.Drawing.Point(12, 217);
            this.MukemmelSayilar.Name = "MukemmelSayilar";
            this.MukemmelSayilar.SelectedIndex = 0;
            this.MukemmelSayilar.Size = new System.Drawing.Size(764, 221);
            this.MukemmelSayilar.TabIndex = 3;
            // 
            // TekSayilar
            // 
            this.TekSayilar.Controls.Add(this.listView1);
            this.TekSayilar.Location = new System.Drawing.Point(4, 25);
            this.TekSayilar.Name = "TekSayilar";
            this.TekSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.TekSayilar.Size = new System.Drawing.Size(756, 192);
            this.TekSayilar.TabIndex = 0;
            this.TekSayilar.Text = "Tek Sayılar";
            this.TekSayilar.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 192);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Çift Sayılar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(756, 192);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Asal Sayılar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(756, 192);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mükemmel Sayılar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(278, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "10000";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Calistir
            // 
            this.Calistir.Location = new System.Drawing.Point(442, 47);
            this.Calistir.Name = "Calistir";
            this.Calistir.Size = new System.Drawing.Size(119, 22);
            this.Calistir.TabIndex = 4;
            this.Calistir.Text = "Çalıştır";
            this.Calistir.UseVisualStyleBackColor = true;
            this.Calistir.Click += new System.EventHandler(this.Calistir_Click);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(6, 15);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(724, 171);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(6, 15);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(735, 158);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // listView4
            // 
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(6, 15);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(728, 158);
            this.listView4.TabIndex = 0;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MukemmelSayilar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MukemmelSayilar.ResumeLayout(false);
            this.TekSayilar.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Bitis;
        private System.Windows.Forms.Label Baslangic;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabControl MukemmelSayilar;
        private System.Windows.Forms.TabPage TekSayilar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button Calistir;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
    }
}

