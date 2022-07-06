namespace Yemekane_Otomasyon_deneme2
{
    partial class Üyepanel
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
            this.üyedatagrid = new System.Windows.Forms.DataGridView();
            this.pnldata = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbTC = new System.Windows.Forms.TextBox();
            this.tbadSoyad = new System.Windows.Forms.TextBox();
            this.tbbirim = new System.Windows.Forms.TextBox();
            this.tbGörev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnexcelıceaktar = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.üyedatagrid)).BeginInit();
            this.pnldata.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // üyedatagrid
            // 
            this.üyedatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.üyedatagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.üyedatagrid.Location = new System.Drawing.Point(0, 0);
            this.üyedatagrid.Name = "üyedatagrid";
            this.üyedatagrid.Size = new System.Drawing.Size(786, 173);
            this.üyedatagrid.TabIndex = 0;
            this.üyedatagrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.üyedatagrid_CellEnter);
            // 
            // pnldata
            // 
            this.pnldata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnldata.Controls.Add(this.üyedatagrid);
            this.pnldata.Location = new System.Drawing.Point(3, 248);
            this.pnldata.Name = "pnldata";
            this.pnldata.Size = new System.Drawing.Size(786, 173);
            this.pnldata.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnsil);
            this.panel1.Controls.Add(this.btnekle);
            this.panel1.Location = new System.Drawing.Point(594, 6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(190, 100);
            this.panel1.TabIndex = 5;
            // 
            // btnsil
            // 
            this.btnsil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnsil.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnsil.FlatAppearance.BorderSize = 2;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Location = new System.Drawing.Point(95, 5);
            this.btnsil.Name = "btnsil";
            this.btnsil.Padding = new System.Windows.Forms.Padding(1);
            this.btnsil.Size = new System.Drawing.Size(90, 90);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "Üye Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnekle.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnekle.FlatAppearance.BorderSize = 2;
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnekle.Location = new System.Drawing.Point(5, 5);
            this.btnekle.Name = "btnekle";
            this.btnekle.Padding = new System.Windows.Forms.Padding(1);
            this.btnekle.Size = new System.Drawing.Size(90, 90);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "Üye Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.pnldata);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Üye işlemleri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(320, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 67);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Ara";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(121, 16);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(141, 23);
            this.textBox6.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(10, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Aramak için Üye\r\nbilgileri girin:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.tbTC);
            this.groupBox1.Controls.Add(this.tbadSoyad);
            this.groupBox1.Controls.Add(this.tbbirim);
            this.groupBox1.Controls.Add(this.tbGörev);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 177);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veriler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(77, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ad/Soyad:";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(107, 16);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(150, 23);
            this.tbID.TabIndex = 13;
            // 
            // tbTC
            // 
            this.tbTC.Location = new System.Drawing.Point(107, 44);
            this.tbTC.Multiline = true;
            this.tbTC.Name = "tbTC";
            this.tbTC.Size = new System.Drawing.Size(150, 23);
            this.tbTC.TabIndex = 12;
            // 
            // tbadSoyad
            // 
            this.tbadSoyad.Location = new System.Drawing.Point(107, 75);
            this.tbadSoyad.Multiline = true;
            this.tbadSoyad.Name = "tbadSoyad";
            this.tbadSoyad.Size = new System.Drawing.Size(150, 23);
            this.tbadSoyad.TabIndex = 11;
            // 
            // tbbirim
            // 
            this.tbbirim.Location = new System.Drawing.Point(107, 106);
            this.tbbirim.Multiline = true;
            this.tbbirim.Name = "tbbirim";
            this.tbbirim.Size = new System.Drawing.Size(150, 23);
            this.tbbirim.TabIndex = 10;
            // 
            // tbGörev
            // 
            this.tbGörev.Location = new System.Drawing.Point(107, 137);
            this.tbGörev.Multiline = true;
            this.tbGörev.Name = "tbGörev";
            this.tbGörev.Size = new System.Drawing.Size(150, 23);
            this.tbGörev.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(53, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Görev:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(60, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCKimlik No:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Excel İşlemleri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(3, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 181);
            this.panel2.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 181);
            this.dataGridView1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnexcelıceaktar);
            this.panel3.Controls.Add(this.btnexcel);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(780, 110);
            this.panel3.TabIndex = 7;
            // 
            // btnexcelıceaktar
            // 
            this.btnexcelıceaktar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnexcelıceaktar.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnexcelıceaktar.FlatAppearance.BorderSize = 2;
            this.btnexcelıceaktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcelıceaktar.Location = new System.Drawing.Point(5, 55);
            this.btnexcelıceaktar.Name = "btnexcelıceaktar";
            this.btnexcelıceaktar.Padding = new System.Windows.Forms.Padding(1);
            this.btnexcelıceaktar.Size = new System.Drawing.Size(770, 50);
            this.btnexcelıceaktar.TabIndex = 2;
            this.btnexcelıceaktar.Text = "Excel\'i içe Aktar";
            this.btnexcelıceaktar.UseVisualStyleBackColor = true;
            // 
            // btnexcel
            // 
            this.btnexcel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnexcel.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnexcel.FlatAppearance.BorderSize = 2;
            this.btnexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcel.Location = new System.Drawing.Point(5, 5);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Padding = new System.Windows.Forms.Padding(1);
            this.btnexcel.Size = new System.Drawing.Size(770, 50);
            this.btnexcel.TabIndex = 3;
            this.btnexcel.Text = "Excel\'e Aktar";
            this.btnexcel.UseVisualStyleBackColor = true;
            // 
            // Üyepanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Üyepanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üyeler";
            this.Load += new System.EventHandler(this.Üyepanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.üyedatagrid)).EndInit();
            this.pnldata.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView üyedatagrid;
        private System.Windows.Forms.Panel pnldata;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnexcelıceaktar;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbGörev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbTC;
        private System.Windows.Forms.TextBox tbadSoyad;
        private System.Windows.Forms.TextBox tbbirim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}