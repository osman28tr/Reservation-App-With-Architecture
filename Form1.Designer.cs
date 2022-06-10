namespace Reservation_App
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
            this.btn_Report = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPhoneNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.returndate = new System.Windows.Forms.DateTimePicker();
            this.DepartureDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textWhereTo = new System.Windows.Forms.TextBox();
            this.textWhereFrom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radio_Otobus_Otel = new System.Windows.Forms.RadioButton();
            this.radio_Otobus_Cadir = new System.Windows.Forms.RadioButton();
            this.radio_Ucak_Otel = new System.Windows.Forms.RadioButton();
            this.radio_Ucak_Cadir = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Report
            // 
            this.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Report.Location = new System.Drawing.Point(414, 459);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(138, 42);
            this.btn_Report.TabIndex = 1;
            this.btn_Report.Text = "Raporla";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.button2_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(199, 29);
            this.textName.Margin = new System.Windows.Forms.Padding(6);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(241, 29);
            this.textName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adres";
            // 
            // textAdress
            // 
            this.textAdress.Location = new System.Drawing.Point(199, 79);
            this.textAdress.Margin = new System.Windows.Forms.Padding(6);
            this.textAdress.Name = "textAdress";
            this.textAdress.Size = new System.Drawing.Size(241, 29);
            this.textAdress.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon Numarası";
            // 
            // textPhoneNum
            // 
            this.textPhoneNum.Location = new System.Drawing.Point(199, 127);
            this.textPhoneNum.Margin = new System.Windows.Forms.Padding(6);
            this.textPhoneNum.Name = "textPhoneNum";
            this.textPhoneNum.Size = new System.Drawing.Size(241, 29);
            this.textPhoneNum.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kimlik Numarası";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(199, 173);
            this.textID.Margin = new System.Windows.Forms.Padding(6);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(241, 29);
            this.textID.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.textID);
            this.groupBox1.Controls.Add(this.textAdress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textPhoneNum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 231);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kimlik bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.returndate);
            this.groupBox2.Controls.Add(this.DepartureDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textWhereTo);
            this.groupBox2.Controls.Add(this.textWhereFrom);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(493, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 231);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seyehat Bilgileri";
            // 
            // returndate
            // 
            this.returndate.Location = new System.Drawing.Point(199, 171);
            this.returndate.Name = "returndate";
            this.returndate.Size = new System.Drawing.Size(249, 29);
            this.returndate.TabIndex = 11;
            // 
            // DepartureDate
            // 
            this.DepartureDate.Location = new System.Drawing.Point(199, 122);
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.Size = new System.Drawing.Size(249, 29);
            this.DepartureDate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nereye";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dönüş Tarihi";
            // 
            // textWhereTo
            // 
            this.textWhereTo.Location = new System.Drawing.Point(199, 29);
            this.textWhereTo.Margin = new System.Windows.Forms.Padding(6);
            this.textWhereTo.Name = "textWhereTo";
            this.textWhereTo.Size = new System.Drawing.Size(241, 29);
            this.textWhereTo.TabIndex = 2;
            // 
            // textWhereFrom
            // 
            this.textWhereFrom.Location = new System.Drawing.Point(199, 79);
            this.textWhereFrom.Margin = new System.Windows.Forms.Padding(6);
            this.textWhereFrom.Name = "textWhereFrom";
            this.textWhereFrom.Size = new System.Drawing.Size(241, 29);
            this.textWhereFrom.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Gidiş tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nereden";
            // 
            // radio_Otobus_Otel
            // 
            this.radio_Otobus_Otel.AutoSize = true;
            this.radio_Otobus_Otel.Location = new System.Drawing.Point(271, 277);
            this.radio_Otobus_Otel.Name = "radio_Otobus_Otel";
            this.radio_Otobus_Otel.Size = new System.Drawing.Size(200, 52);
            this.radio_Otobus_Otel.TabIndex = 12;
            this.radio_Otobus_Otel.TabStop = true;
            this.radio_Otobus_Otel.Text = "Ulaşım yolu : Otobüs\r\nKonaklama : Otel";
            this.radio_Otobus_Otel.UseVisualStyleBackColor = true;
            this.radio_Otobus_Otel.CheckedChanged += new System.EventHandler(this.radio_Otobus_Otel_CheckedChanged);
            // 
            // radio_Otobus_Cadir
            // 
            this.radio_Otobus_Cadir.AutoSize = true;
            this.radio_Otobus_Cadir.Location = new System.Drawing.Point(499, 277);
            this.radio_Otobus_Cadir.Name = "radio_Otobus_Cadir";
            this.radio_Otobus_Cadir.Size = new System.Drawing.Size(200, 52);
            this.radio_Otobus_Cadir.TabIndex = 13;
            this.radio_Otobus_Cadir.TabStop = true;
            this.radio_Otobus_Cadir.Text = "Ulaşım yolu : Otobüs\r\nKonaklama : Çadır";
            this.radio_Otobus_Cadir.UseVisualStyleBackColor = true;
            this.radio_Otobus_Cadir.CheckedChanged += new System.EventHandler(this.radio_Otobus_Cadir_CheckedChanged);
            // 
            // radio_Ucak_Otel
            // 
            this.radio_Ucak_Otel.AutoSize = true;
            this.radio_Ucak_Otel.Location = new System.Drawing.Point(499, 349);
            this.radio_Ucak_Otel.Name = "radio_Ucak_Otel";
            this.radio_Ucak_Otel.Size = new System.Drawing.Size(181, 52);
            this.radio_Ucak_Otel.TabIndex = 14;
            this.radio_Ucak_Otel.TabStop = true;
            this.radio_Ucak_Otel.Text = "Ulaşım yolu : Uçak\r\nKonaklama : Otel";
            this.radio_Ucak_Otel.UseVisualStyleBackColor = true;
            this.radio_Ucak_Otel.CheckedChanged += new System.EventHandler(this.radio_Ucak_Otel_CheckedChanged);
            // 
            // radio_Ucak_Cadir
            // 
            this.radio_Ucak_Cadir.AutoSize = true;
            this.radio_Ucak_Cadir.Location = new System.Drawing.Point(271, 349);
            this.radio_Ucak_Cadir.Name = "radio_Ucak_Cadir";
            this.radio_Ucak_Cadir.Size = new System.Drawing.Size(181, 52);
            this.radio_Ucak_Cadir.TabIndex = 15;
            this.radio_Ucak_Cadir.TabStop = true;
            this.radio_Ucak_Cadir.Text = "Ulaşım yolu : Uçak\r\nKonaklama : Çadır";
            this.radio_Ucak_Cadir.UseVisualStyleBackColor = true;
            this.radio_Ucak_Cadir.CheckedChanged += new System.EventHandler(this.radio_Ucak_Cadir_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(976, 516);
            this.Controls.Add(this.radio_Ucak_Cadir);
            this.Controls.Add(this.radio_Ucak_Otel);
            this.Controls.Add(this.radio_Otobus_Cadir);
            this.Controls.Add(this.radio_Otobus_Otel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Report);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPhoneNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textWhereTo;
        private System.Windows.Forms.TextBox textWhereFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker returndate;
        private System.Windows.Forms.DateTimePicker DepartureDate;
        private System.Windows.Forms.RadioButton radio_Otobus_Otel;
        private System.Windows.Forms.RadioButton radio_Otobus_Cadir;
        private System.Windows.Forms.RadioButton radio_Ucak_Otel;
        private System.Windows.Forms.RadioButton radio_Ucak_Cadir;
    }
}

