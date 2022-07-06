
namespace Yemekane_Otomasyon_deneme2
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnizinler = new System.Windows.Forms.Button();
            this.btndurum = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(185, 5);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(1);
            this.button1.Size = new System.Drawing.Size(90, 90);
            this.button1.TabIndex = 1;
            this.button1.Text = "Üyeler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnizinler
            // 
            this.btnizinler.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnizinler.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnizinler.FlatAppearance.BorderSize = 2;
            this.btnizinler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnizinler.Location = new System.Drawing.Point(95, 5);
            this.btnizinler.Name = "btnizinler";
            this.btnizinler.Padding = new System.Windows.Forms.Padding(1);
            this.btnizinler.Size = new System.Drawing.Size(90, 90);
            this.btnizinler.TabIndex = 2;
            this.btnizinler.Text = "İzinler";
            this.btnizinler.UseVisualStyleBackColor = true;
            this.btnizinler.Click += new System.EventHandler(this.button2_Click);
            // 
            // btndurum
            // 
            this.btndurum.Dock = System.Windows.Forms.DockStyle.Left;
            this.btndurum.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btndurum.FlatAppearance.BorderSize = 2;
            this.btndurum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndurum.Location = new System.Drawing.Point(5, 5);
            this.btndurum.Name = "btndurum";
            this.btndurum.Padding = new System.Windows.Forms.Padding(1);
            this.btndurum.Size = new System.Drawing.Size(90, 90);
            this.btndurum.TabIndex = 3;
            this.btndurum.Text = "Durum";
            this.btndurum.UseVisualStyleBackColor = true;
            this.btndurum.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(7, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "İşlemler";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnizinler);
            this.panel1.Controls.Add(this.btndurum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(782, 100);
            this.panel1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hakkımızda";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnizinler;
        private System.Windows.Forms.Button btndurum;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
    }
}

