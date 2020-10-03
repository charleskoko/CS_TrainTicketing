namespace CS_TrainTicketing
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

       
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_fahrkartenkosten = new System.Windows.Forms.Label();
            this.label_preis = new System.Windows.Forms.Label();
            this.button_bezahlen = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_ABC = new System.Windows.Forms.Button();
            this.button_BC = new System.Windows.Forms.Button();
            this.button_AB = new System.Windows.Forms.Button();
            this.button_A = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_eingezahlt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_abbrechen = new System.Windows.Forms.Button();
            this.button_50_euro = new System.Windows.Forms.Button();
            this.button_20_euro = new System.Windows.Forms.Button();
            this.button_10_euro = new System.Windows.Forms.Button();
            this.button_5_euro = new System.Windows.Forms.Button();
            this.button_2_euro = new System.Windows.Forms.Button();
            this.button_1_euro = new System.Windows.Forms.Button();
            this.button_50_cent = new System.Windows.Forms.Button();
            this.button_20_cent = new System.Windows.Forms.Button();
            this.button_10_cent = new System.Windows.Forms.Button();
            this.listBox_ausgaben = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(230, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-13, -10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticketautomat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_fahrkartenkosten);
            this.groupBox2.Controls.Add(this.label_preis);
            this.groupBox2.Controls.Add(this.button_bezahlen);
            this.groupBox2.Controls.Add(this.button_reset);
            this.groupBox2.Controls.Add(this.button_ABC);
            this.groupBox2.Controls.Add(this.button_BC);
            this.groupBox2.Controls.Add(this.button_AB);
            this.groupBox2.Controls.Add(this.button_A);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 279);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label_fahrkartenkosten
            // 
            this.label_fahrkartenkosten.AutoSize = true;
            this.label_fahrkartenkosten.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fahrkartenkosten.Location = new System.Drawing.Point(158, -7);
            this.label_fahrkartenkosten.Name = "label_fahrkartenkosten";
            this.label_fahrkartenkosten.Size = new System.Drawing.Size(79, 27);
            this.label_fahrkartenkosten.TabIndex = 9;
            this.label_fahrkartenkosten.Text = "0 Euro";
            // 
            // label_preis
            // 
            this.label_preis.AutoSize = true;
            this.label_preis.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_preis.Location = new System.Drawing.Point(-5, -7);
            this.label_preis.Name = "label_preis";
            this.label_preis.Size = new System.Drawing.Size(65, 27);
            this.label_preis.TabIndex = 8;
            this.label_preis.Text = "Preis";
            // 
            // button_bezahlen
            // 
            this.button_bezahlen.Location = new System.Drawing.Point(6, 191);
            this.button_bezahlen.Name = "button_bezahlen";
            this.button_bezahlen.Size = new System.Drawing.Size(163, 69);
            this.button_bezahlen.TabIndex = 7;
            this.button_bezahlen.Text = "Zur Bezahlung";
            this.button_bezahlen.UseVisualStyleBackColor = true;
            this.button_bezahlen.Click += new System.EventHandler(this.paymentClick);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(175, 191);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(163, 69);
            this.button_reset.TabIndex = 6;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.resetClick);
            // 
            // button_ABC
            // 
            this.button_ABC.Location = new System.Drawing.Point(175, 118);
            this.button_ABC.Name = "button_ABC";
            this.button_ABC.Size = new System.Drawing.Size(163, 69);
            this.button_ABC.TabIndex = 5;
            this.button_ABC.Text = "ABC (3.60 Euro)";
            this.button_ABC.UseVisualStyleBackColor = true;
            this.button_ABC.Click += new System.EventHandler(this.TicketClick);
            // 
            // button_BC
            // 
            this.button_BC.Location = new System.Drawing.Point(6, 118);
            this.button_BC.Name = "button_BC";
            this.button_BC.Size = new System.Drawing.Size(163, 69);
            this.button_BC.TabIndex = 4;
            this.button_BC.Text = "BC (3.30 Euro)";
            this.button_BC.UseVisualStyleBackColor = true;
            this.button_BC.Click += new System.EventHandler(this.TicketClick);
            // 
            // button_AB
            // 
            this.button_AB.Location = new System.Drawing.Point(175, 33);
            this.button_AB.Name = "button_AB";
            this.button_AB.Size = new System.Drawing.Size(163, 69);
            this.button_AB.TabIndex = 3;
            this.button_AB.Text = "AB (2.90 Euro)";
            this.button_AB.UseVisualStyleBackColor = true;
            this.button_AB.Click += new System.EventHandler(this.TicketClick);
            // 
            // button_A
            // 
            this.button_A.Location = new System.Drawing.Point(6, 33);
            this.button_A.Name = "button_A";
            this.button_A.Size = new System.Drawing.Size(163, 69);
            this.button_A.TabIndex = 2;
            this.button_A.Text = "A (2.00 Euro)";
            this.button_A.UseVisualStyleBackColor = true;
            this.button_A.Click += new System.EventHandler(this.TicketClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_eingezahlt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.button_abbrechen);
            this.groupBox3.Controls.Add(this.button_50_euro);
            this.groupBox3.Controls.Add(this.button_20_euro);
            this.groupBox3.Controls.Add(this.button_10_euro);
            this.groupBox3.Controls.Add(this.button_5_euro);
            this.groupBox3.Controls.Add(this.button_2_euro);
            this.groupBox3.Controls.Add(this.button_1_euro);
            this.groupBox3.Controls.Add(this.button_50_cent);
            this.groupBox3.Controls.Add(this.button_20_cent);
            this.groupBox3.Controls.Add(this.button_10_cent);
            this.groupBox3.Location = new System.Drawing.Point(444, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 346);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label_eingezahlt
            // 
            this.label_eingezahlt.AutoSize = true;
            this.label_eingezahlt.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_eingezahlt.Location = new System.Drawing.Point(4, 0);
            this.label_eingezahlt.Name = "label_eingezahlt";
            this.label_eingezahlt.Size = new System.Drawing.Size(79, 27);
            this.label_eingezahlt.TabIndex = 10;
            this.label_eingezahlt.Text = "0 Euro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "label2";
            // 
            // button_abbrechen
            // 
            this.button_abbrechen.Location = new System.Drawing.Point(253, 18);
            this.button_abbrechen.Name = "button_abbrechen";
            this.button_abbrechen.Size = new System.Drawing.Size(160, 86);
            this.button_abbrechen.TabIndex = 20;
            this.button_abbrechen.Text = "Abbrechen";
            this.button_abbrechen.UseVisualStyleBackColor = true;
            this.button_abbrechen.Click += new System.EventHandler(this.cancelClick);
            // 
            // button_50_euro
            // 
            this.button_50_euro.Location = new System.Drawing.Point(294, 258);
            this.button_50_euro.Name = "button_50_euro";
            this.button_50_euro.Size = new System.Drawing.Size(128, 69);
            this.button_50_euro.TabIndex = 19;
            this.button_50_euro.Text = "50 Euro";
            this.button_50_euro.UseVisualStyleBackColor = true;
            this.button_50_euro.Click += new System.EventHandler(this.checkOut);
            // 
            // button_20_euro
            // 
            this.button_20_euro.Location = new System.Drawing.Point(150, 258);
            this.button_20_euro.Name = "button_20_euro";
            this.button_20_euro.Size = new System.Drawing.Size(128, 69);
            this.button_20_euro.TabIndex = 18;
            this.button_20_euro.Text = "20 Euro";
            this.button_20_euro.UseVisualStyleBackColor = true;
            this.button_20_euro.Click += new System.EventHandler(this.checkOut);
            // 
            // button_10_euro
            // 
            this.button_10_euro.Location = new System.Drawing.Point(6, 258);
            this.button_10_euro.Name = "button_10_euro";
            this.button_10_euro.Size = new System.Drawing.Size(128, 69);
            this.button_10_euro.TabIndex = 17;
            this.button_10_euro.Text = "10 Euro";
            this.button_10_euro.UseVisualStyleBackColor = true;
            this.button_10_euro.Click += new System.EventHandler(this.checkOut);
            // 
            // button_5_euro
            // 
            this.button_5_euro.Location = new System.Drawing.Point(294, 185);
            this.button_5_euro.Name = "button_5_euro";
            this.button_5_euro.Size = new System.Drawing.Size(128, 69);
            this.button_5_euro.TabIndex = 16;
            this.button_5_euro.Text = "5 Euro";
            this.button_5_euro.UseVisualStyleBackColor = true;
            this.button_5_euro.Click += new System.EventHandler(this.checkOut);
            // 
            // button_2_euro
            // 
            this.button_2_euro.Location = new System.Drawing.Point(150, 185);
            this.button_2_euro.Name = "button_2_euro";
            this.button_2_euro.Size = new System.Drawing.Size(128, 69);
            this.button_2_euro.TabIndex = 15;
            this.button_2_euro.Text = "2 Euro";
            this.button_2_euro.UseVisualStyleBackColor = true;
            this.button_2_euro.Click += new System.EventHandler(this.checkOut);
            // 
            // button_1_euro
            // 
            this.button_1_euro.Location = new System.Drawing.Point(6, 185);
            this.button_1_euro.Name = "button_1_euro";
            this.button_1_euro.Size = new System.Drawing.Size(128, 69);
            this.button_1_euro.TabIndex = 14;
            this.button_1_euro.Text = "1 Euro";
            this.button_1_euro.UseVisualStyleBackColor = true;
            this.button_1_euro.Click += new System.EventHandler(this.checkOut);
            // 
            // button_50_cent
            // 
            this.button_50_cent.Location = new System.Drawing.Point(294, 110);
            this.button_50_cent.Name = "button_50_cent";
            this.button_50_cent.Size = new System.Drawing.Size(128, 69);
            this.button_50_cent.TabIndex = 13;
            this.button_50_cent.Text = "50 Cent";
            this.button_50_cent.UseVisualStyleBackColor = true;
            this.button_50_cent.Click += new System.EventHandler(this.checkOut);
            // 
            // button_20_cent
            // 
            this.button_20_cent.Location = new System.Drawing.Point(150, 110);
            this.button_20_cent.Name = "button_20_cent";
            this.button_20_cent.Size = new System.Drawing.Size(128, 69);
            this.button_20_cent.TabIndex = 12;
            this.button_20_cent.Text = "20 Cent";
            this.button_20_cent.UseVisualStyleBackColor = true;
            this.button_20_cent.Click += new System.EventHandler(this.checkOut);
            // 
            // button_10_cent
            // 
            this.button_10_cent.Location = new System.Drawing.Point(6, 110);
            this.button_10_cent.Name = "button_10_cent";
            this.button_10_cent.Size = new System.Drawing.Size(128, 69);
            this.button_10_cent.TabIndex = 11;
            this.button_10_cent.Text = "10 Cent";
            this.button_10_cent.UseVisualStyleBackColor = true;
            this.button_10_cent.Click += new System.EventHandler(this.checkOut);
            // 
            // listBox_ausgaben
            // 
            this.listBox_ausgaben.FormattingEnabled = true;
            this.listBox_ausgaben.Location = new System.Drawing.Point(12, 463);
            this.listBox_ausgaben.Name = "listBox_ausgaben";
            this.listBox_ausgaben.Size = new System.Drawing.Size(860, 95);
            this.listBox_ausgaben.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.listBox_ausgaben);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_bezahlen;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_ABC;
        private System.Windows.Forms.Button button_BC;
        private System.Windows.Forms.Button button_AB;
        private System.Windows.Forms.Button button_A;
        private System.Windows.Forms.Button button_50_euro;
        private System.Windows.Forms.Button button_20_euro;
        private System.Windows.Forms.Button button_10_euro;
        private System.Windows.Forms.Button button_5_euro;
        private System.Windows.Forms.Button button_2_euro;
        private System.Windows.Forms.Button button_1_euro;
        private System.Windows.Forms.Button button_50_cent;
        private System.Windows.Forms.Button button_20_cent;
        private System.Windows.Forms.Button button_10_cent;
        private System.Windows.Forms.Label label_fahrkartenkosten;
        private System.Windows.Forms.Label label_preis;
        private System.Windows.Forms.Label label_eingezahlt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_abbrechen;
        private System.Windows.Forms.ListBox listBox_ausgaben;
    }
}

