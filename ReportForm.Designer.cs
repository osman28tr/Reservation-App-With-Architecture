namespace Reservation_App
{
    partial class ReportForm
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
            this.btn_HtmlRapor = new System.Windows.Forms.Button();
            this.btn_XmlRapor = new System.Windows.Forms.Button();
            this.btn_JsonRapor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Accommodation = new System.Windows.Forms.Button();
            this.btn_Transportation = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_HtmlRapor
            // 
            this.btn_HtmlRapor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_HtmlRapor.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_HtmlRapor.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.btn_HtmlRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HtmlRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_HtmlRapor.Location = new System.Drawing.Point(409, 104);
            this.btn_HtmlRapor.Name = "btn_HtmlRapor";
            this.btn_HtmlRapor.Size = new System.Drawing.Size(99, 46);
            this.btn_HtmlRapor.TabIndex = 7;
            this.btn_HtmlRapor.Text = "HTML";
            this.btn_HtmlRapor.UseVisualStyleBackColor = false;
            this.btn_HtmlRapor.Click += new System.EventHandler(this.btn_HtmlRapor_Click);
            // 
            // btn_XmlRapor
            // 
            this.btn_XmlRapor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_XmlRapor.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_XmlRapor.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.btn_XmlRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XmlRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_XmlRapor.Location = new System.Drawing.Point(287, 104);
            this.btn_XmlRapor.Name = "btn_XmlRapor";
            this.btn_XmlRapor.Size = new System.Drawing.Size(99, 46);
            this.btn_XmlRapor.TabIndex = 6;
            this.btn_XmlRapor.Text = "XML";
            this.btn_XmlRapor.UseVisualStyleBackColor = false;
            this.btn_XmlRapor.Click += new System.EventHandler(this.btn_XmlRapor_Click);
            // 
            // btn_JsonRapor
            // 
            this.btn_JsonRapor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_JsonRapor.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_JsonRapor.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.btn_JsonRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_JsonRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_JsonRapor.Location = new System.Drawing.Point(166, 104);
            this.btn_JsonRapor.Name = "btn_JsonRapor";
            this.btn_JsonRapor.Size = new System.Drawing.Size(99, 46);
            this.btn_JsonRapor.TabIndex = 5;
            this.btn_JsonRapor.Text = "JSON";
            this.btn_JsonRapor.UseVisualStyleBackColor = false;
            this.btn_JsonRapor.Click += new System.EventHandler(this.btn_JsonRapor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_XmlRapor);
            this.groupBox1.Controls.Add(this.btn_HtmlRapor);
            this.groupBox1.Controls.Add(this.btn_JsonRapor);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 177);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raporlama Türünü Seçiniz :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Accommodation);
            this.groupBox2.Controls.Add(this.btn_Transportation);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(0, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 172);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İptal Et";
            // 
            // btn_Accommodation
            // 
            this.btn_Accommodation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Accommodation.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Accommodation.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.btn_Accommodation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Accommodation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Accommodation.Location = new System.Drawing.Point(340, 65);
            this.btn_Accommodation.Name = "btn_Accommodation";
            this.btn_Accommodation.Size = new System.Drawing.Size(135, 60);
            this.btn_Accommodation.TabIndex = 6;
            this.btn_Accommodation.Text = "-";
            this.btn_Accommodation.UseVisualStyleBackColor = false;
            this.btn_Accommodation.Click += new System.EventHandler(this.btn_Accommodation_Click);
            // 
            // btn_Transportation
            // 
            this.btn_Transportation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Transportation.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Transportation.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.btn_Transportation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Transportation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Transportation.Location = new System.Drawing.Point(166, 65);
            this.btn_Transportation.Name = "btn_Transportation";
            this.btn_Transportation.Size = new System.Drawing.Size(136, 60);
            this.btn_Transportation.TabIndex = 5;
            this.btn_Transportation.Text = "-";
            this.btn_Transportation.UseVisualStyleBackColor = false;
            this.btn_Transportation.Click += new System.EventHandler(this.btn_Transportation_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(330, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Accommodation_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(628, 354);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_HtmlRapor;
        private System.Windows.Forms.Button btn_XmlRapor;
        private System.Windows.Forms.Button btn_JsonRapor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Accommodation;
        private System.Windows.Forms.Button btn_Transportation;
        private System.Windows.Forms.Button button1;
    }
}