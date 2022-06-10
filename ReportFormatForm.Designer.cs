namespace Reservation_App
{
    partial class ReportFormatForm
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
            this.radio_T_D_G = new System.Windows.Forms.RadioButton();
            this.radio_D_G_T = new System.Windows.Forms.RadioButton();
            this.radio_T_G_D = new System.Windows.Forms.RadioButton();
            this.radio_D_T_G = new System.Windows.Forms.RadioButton();
            this.radio_G_T_D = new System.Windows.Forms.RadioButton();
            this.radio_G_D_T = new System.Windows.Forms.RadioButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_T_D_G);
            this.groupBox1.Controls.Add(this.radio_D_G_T);
            this.groupBox1.Controls.Add(this.radio_T_G_D);
            this.groupBox1.Controls.Add(this.radio_D_T_G);
            this.groupBox1.Controls.Add(this.radio_G_T_D);
            this.groupBox1.Controls.Add(this.radio_G_D_T);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 310);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raporlama formatını seçiniz :";
            // 
            // radio_T_D_G
            // 
            this.radio_T_D_G.AutoSize = true;
            this.radio_T_D_G.Font = new System.Drawing.Font("Microsoft PhagsPa", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_T_D_G.ForeColor = System.Drawing.Color.Black;
            this.radio_T_D_G.Location = new System.Drawing.Point(343, 226);
            this.radio_T_D_G.Name = "radio_T_D_G";
            this.radio_T_D_G.Size = new System.Drawing.Size(135, 67);
            this.radio_T_D_G.TabIndex = 18;
            this.radio_T_D_G.TabStop = true;
            this.radio_T_D_G.Text = "Toplam ücret\r\nDetay Bilgiler\r\nGenel Bilgiler";
            this.radio_T_D_G.UseVisualStyleBackColor = true;
            this.radio_T_D_G.CheckedChanged += new System.EventHandler(this.radio_T_D_G_CheckedChanged);
            // 
            // radio_D_G_T
            // 
            this.radio_D_G_T.AutoSize = true;
            this.radio_D_G_T.Font = new System.Drawing.Font("Microsoft PhagsPa", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_D_G_T.ForeColor = System.Drawing.Color.Black;
            this.radio_D_G_T.Location = new System.Drawing.Point(343, 149);
            this.radio_D_G_T.Name = "radio_D_G_T";
            this.radio_D_G_T.Size = new System.Drawing.Size(135, 67);
            this.radio_D_G_T.TabIndex = 17;
            this.radio_D_G_T.TabStop = true;
            this.radio_D_G_T.Text = "Detay Bilgiler\r\nGenel Bilgiler\r\nToplam ücret";
            this.radio_D_G_T.UseVisualStyleBackColor = true;
            this.radio_D_G_T.CheckedChanged += new System.EventHandler(this.radio_D_G_T_CheckedChanged);
            // 
            // radio_T_G_D
            // 
            this.radio_T_G_D.AutoSize = true;
            this.radio_T_G_D.Font = new System.Drawing.Font("Microsoft PhagsPa", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_T_G_D.ForeColor = System.Drawing.Color.Black;
            this.radio_T_G_D.Location = new System.Drawing.Point(175, 226);
            this.radio_T_G_D.Name = "radio_T_G_D";
            this.radio_T_G_D.Size = new System.Drawing.Size(135, 67);
            this.radio_T_G_D.TabIndex = 16;
            this.radio_T_G_D.TabStop = true;
            this.radio_T_G_D.Text = "Toplam ücret\r\nGenel Bilgiler\r\nDetay Bilgiler";
            this.radio_T_G_D.UseVisualStyleBackColor = true;
            this.radio_T_G_D.CheckedChanged += new System.EventHandler(this.radio_T_G_D_CheckedChanged);
            // 
            // radio_D_T_G
            // 
            this.radio_D_T_G.AutoSize = true;
            this.radio_D_T_G.Font = new System.Drawing.Font("Microsoft PhagsPa", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_D_T_G.ForeColor = System.Drawing.Color.Black;
            this.radio_D_T_G.Location = new System.Drawing.Point(175, 144);
            this.radio_D_T_G.Name = "radio_D_T_G";
            this.radio_D_T_G.Size = new System.Drawing.Size(135, 67);
            this.radio_D_T_G.TabIndex = 15;
            this.radio_D_T_G.TabStop = true;
            this.radio_D_T_G.Text = "Detay Bilgiler\r\nToplam ücret\r\nGenel Bilgiler";
            this.radio_D_T_G.UseVisualStyleBackColor = true;
            this.radio_D_T_G.CheckedChanged += new System.EventHandler(this.radio_D_T_G_CheckedChanged);
            // 
            // radio_G_T_D
            // 
            this.radio_G_T_D.AutoSize = true;
            this.radio_G_T_D.Font = new System.Drawing.Font("Microsoft PhagsPa", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_G_T_D.ForeColor = System.Drawing.Color.Black;
            this.radio_G_T_D.Location = new System.Drawing.Point(343, 67);
            this.radio_G_T_D.Name = "radio_G_T_D";
            this.radio_G_T_D.Size = new System.Drawing.Size(135, 67);
            this.radio_G_T_D.TabIndex = 14;
            this.radio_G_T_D.TabStop = true;
            this.radio_G_T_D.Text = "Genel Bilgiler\r\nToplam ücret\r\nDetay Bilgiler";
            this.radio_G_T_D.UseVisualStyleBackColor = true;
            this.radio_G_T_D.CheckedChanged += new System.EventHandler(this.radio_G_T_D_CheckedChanged);
            // 
            // radio_G_D_T
            // 
            this.radio_G_D_T.AutoSize = true;
            this.radio_G_D_T.Font = new System.Drawing.Font("Microsoft PhagsPa", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_G_D_T.ForeColor = System.Drawing.Color.Black;
            this.radio_G_D_T.Location = new System.Drawing.Point(175, 67);
            this.radio_G_D_T.Name = "radio_G_D_T";
            this.radio_G_D_T.Size = new System.Drawing.Size(135, 67);
            this.radio_G_D_T.TabIndex = 13;
            this.radio_G_D_T.TabStop = true;
            this.radio_G_D_T.Text = "Genel Bilgiler\r\nDetay Bilgiler\r\nToplam ücret";
            this.radio_G_D_T.UseVisualStyleBackColor = true;
            this.radio_G_D_T.CheckedChanged += new System.EventHandler(this.radio_G_D_T_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrint.Location = new System.Drawing.Point(289, 343);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(104, 30);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Yazdır";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ReportFormatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(690, 412);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportFormatForm";
            this.Text = "ReportFormatForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_T_D_G;
        private System.Windows.Forms.RadioButton radio_D_G_T;
        private System.Windows.Forms.RadioButton radio_T_G_D;
        private System.Windows.Forms.RadioButton radio_D_T_G;
        private System.Windows.Forms.RadioButton radio_G_T_D;
        private System.Windows.Forms.RadioButton radio_G_D_T;
        private System.Windows.Forms.Button btnPrint;
    }
}