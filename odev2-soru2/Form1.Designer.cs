
namespace odev2_soru2
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.createMatA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearMatA = new System.Windows.Forms.Button();
            this.clearMatB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createMatB = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ArowNum = new System.Windows.Forms.NumericUpDown();
            this.AcolumnNum = new System.Windows.Forms.NumericUpDown();
            this.BcolumnNum = new System.Windows.Forms.NumericUpDown();
            this.BrowNum = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.matSum = new System.Windows.Forms.Button();
            this.matMult = new System.Windows.Forms.Button();
            this.clearResult = new System.Windows.Forms.Button();
            this.matTrac = new System.Windows.Forms.Button();
            this.matTrans = new System.Windows.Forms.Button();
            this.matRev = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveRich = new System.Windows.Forms.Button();
            this.readRich = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ArowNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcolumnNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BcolumnNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowNum)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(459, 346);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // createMatA
            // 
            this.createMatA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.createMatA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createMatA.Location = new System.Drawing.Point(1161, 25);
            this.createMatA.Name = "createMatA";
            this.createMatA.Size = new System.Drawing.Size(75, 23);
            this.createMatA.TabIndex = 1;
            this.createMatA.Text = "Create A";
            this.createMatA.UseVisualStyleBackColor = false;
            this.createMatA.Click += new System.EventHandler(this.createMatA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(992, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matrix A Row";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(992, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Matrix A Column";
            // 
            // clearMatA
            // 
            this.clearMatA.BackColor = System.Drawing.Color.Salmon;
            this.clearMatA.Location = new System.Drawing.Point(1162, 56);
            this.clearMatA.Name = "clearMatA";
            this.clearMatA.Size = new System.Drawing.Size(75, 23);
            this.clearMatA.TabIndex = 6;
            this.clearMatA.Text = "Clear A";
            this.clearMatA.UseVisualStyleBackColor = false;
            this.clearMatA.Click += new System.EventHandler(this.clearMatA_Click);
            // 
            // clearMatB
            // 
            this.clearMatB.BackColor = System.Drawing.Color.Salmon;
            this.clearMatB.Location = new System.Drawing.Point(1162, 144);
            this.clearMatB.Name = "clearMatB";
            this.clearMatB.Size = new System.Drawing.Size(75, 23);
            this.clearMatB.TabIndex = 13;
            this.clearMatB.Text = "Clear B";
            this.clearMatB.UseVisualStyleBackColor = false;
            this.clearMatB.Click += new System.EventHandler(this.clearMatB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(992, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Matrix B Column";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(992, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Matrix B Row";
            // 
            // createMatB
            // 
            this.createMatB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.createMatB.Location = new System.Drawing.Point(1162, 115);
            this.createMatB.Name = "createMatB";
            this.createMatB.Size = new System.Drawing.Size(75, 23);
            this.createMatB.TabIndex = 8;
            this.createMatB.Text = "Create B";
            this.createMatB.UseVisualStyleBackColor = false;
            this.createMatB.Click += new System.EventHandler(this.createMatB_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(489, 25);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(459, 346);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // ArowNum
            // 
            this.ArowNum.Location = new System.Drawing.Point(1095, 28);
            this.ArowNum.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.ArowNum.Name = "ArowNum";
            this.ArowNum.Size = new System.Drawing.Size(50, 20);
            this.ArowNum.TabIndex = 14;
            // 
            // AcolumnNum
            // 
            this.AcolumnNum.Location = new System.Drawing.Point(1096, 54);
            this.AcolumnNum.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.AcolumnNum.Name = "AcolumnNum";
            this.AcolumnNum.Size = new System.Drawing.Size(50, 20);
            this.AcolumnNum.TabIndex = 15;
            // 
            // BcolumnNum
            // 
            this.BcolumnNum.Location = new System.Drawing.Point(1094, 144);
            this.BcolumnNum.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.BcolumnNum.Name = "BcolumnNum";
            this.BcolumnNum.Size = new System.Drawing.Size(50, 20);
            this.BcolumnNum.TabIndex = 17;
            // 
            // BrowNum
            // 
            this.BrowNum.Location = new System.Drawing.Point(1093, 118);
            this.BrowNum.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.BrowNum.Name = "BrowNum";
            this.BrowNum.Size = new System.Drawing.Size(50, 20);
            this.BrowNum.TabIndex = 16;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(489, 390);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(459, 346);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GrayText;
            this.label6.ForeColor = System.Drawing.Color.LawnGreen;
            this.label6.Location = new System.Drawing.Point(486, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Matrix B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(12, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Matrix A";
            // 
            // matSum
            // 
            this.matSum.BackColor = System.Drawing.Color.LightSkyBlue;
            this.matSum.Location = new System.Drawing.Point(15, 390);
            this.matSum.Name = "matSum";
            this.matSum.Size = new System.Drawing.Size(172, 52);
            this.matSum.TabIndex = 21;
            this.matSum.Text = "Matrix[A] + Matrix[B]";
            this.matSum.UseVisualStyleBackColor = false;
            this.matSum.Click += new System.EventHandler(this.matSum_Click);
            // 
            // matMult
            // 
            this.matMult.BackColor = System.Drawing.Color.LightSkyBlue;
            this.matMult.Location = new System.Drawing.Point(193, 390);
            this.matMult.Name = "matMult";
            this.matMult.Size = new System.Drawing.Size(172, 52);
            this.matMult.TabIndex = 22;
            this.matMult.Text = "Matrix[A] x Matrix[B]";
            this.matMult.UseVisualStyleBackColor = false;
            this.matMult.Click += new System.EventHandler(this.matMult_Click);
            // 
            // clearResult
            // 
            this.clearResult.BackColor = System.Drawing.Color.Salmon;
            this.clearResult.Location = new System.Drawing.Point(193, 506);
            this.clearResult.Name = "clearResult";
            this.clearResult.Size = new System.Drawing.Size(172, 52);
            this.clearResult.TabIndex = 24;
            this.clearResult.Text = "Clear Result";
            this.clearResult.UseVisualStyleBackColor = false;
            this.clearResult.Click += new System.EventHandler(this.clearResult_Click);
            // 
            // matTrac
            // 
            this.matTrac.BackColor = System.Drawing.Color.Gold;
            this.matTrac.Location = new System.Drawing.Point(193, 448);
            this.matTrac.Name = "matTrac";
            this.matTrac.Size = new System.Drawing.Size(172, 52);
            this.matTrac.TabIndex = 25;
            this.matTrac.Text = "Trace of Matrix";
            this.matTrac.UseVisualStyleBackColor = false;
            this.matTrac.Click += new System.EventHandler(this.matTrac_Click);
            // 
            // matTrans
            // 
            this.matTrans.BackColor = System.Drawing.Color.Gold;
            this.matTrans.Location = new System.Drawing.Point(15, 506);
            this.matTrans.Name = "matTrans";
            this.matTrans.Size = new System.Drawing.Size(172, 52);
            this.matTrans.TabIndex = 26;
            this.matTrans.Text = "Transpose of the Matrix";
            this.matTrans.UseVisualStyleBackColor = false;
            this.matTrans.Click += new System.EventHandler(this.matTrans_Click);
            // 
            // matRev
            // 
            this.matRev.BackColor = System.Drawing.Color.Gold;
            this.matRev.Location = new System.Drawing.Point(15, 448);
            this.matRev.Name = "matRev";
            this.matRev.Size = new System.Drawing.Size(172, 52);
            this.matRev.TabIndex = 27;
            this.matRev.Text = "Inverse of Matrix";
            this.matRev.UseVisualStyleBackColor = false;
            this.matRev.Click += new System.EventHandler(this.matRev_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(955, 186);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(382, 546);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = "";
            // 
            // saveRich
            // 
            this.saveRich.BackColor = System.Drawing.Color.Gold;
            this.saveRich.Location = new System.Drawing.Point(12, 680);
            this.saveRich.Name = "saveRich";
            this.saveRich.Size = new System.Drawing.Size(172, 52);
            this.saveRich.TabIndex = 30;
            this.saveRich.Text = "Save";
            this.saveRich.UseVisualStyleBackColor = false;
            this.saveRich.Click += new System.EventHandler(this.saveRich_Click);
            // 
            // readRich
            // 
            this.readRich.BackColor = System.Drawing.Color.Gold;
            this.readRich.Location = new System.Drawing.Point(190, 680);
            this.readRich.Name = "readRich";
            this.readRich.Size = new System.Drawing.Size(172, 52);
            this.readRich.TabIndex = 29;
            this.readRich.Text = "Read";
            this.readRich.UseVisualStyleBackColor = false;
            this.readRich.Click += new System.EventHandler(this.readRich_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1080, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Max Value = 9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1349, 744);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.saveRich);
            this.Controls.Add(this.readRich);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.matRev);
            this.Controls.Add(this.matTrans);
            this.Controls.Add(this.matTrac);
            this.Controls.Add(this.clearResult);
            this.Controls.Add(this.matMult);
            this.Controls.Add(this.matSum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.BcolumnNum);
            this.Controls.Add(this.BrowNum);
            this.Controls.Add(this.AcolumnNum);
            this.Controls.Add(this.ArowNum);
            this.Controls.Add(this.clearMatB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createMatB);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.clearMatA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createMatA);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Matrix Calculator";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArowNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcolumnNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BcolumnNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button createMatA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearMatA;
        private System.Windows.Forms.Button clearMatB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createMatB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.NumericUpDown ArowNum;
        private System.Windows.Forms.NumericUpDown AcolumnNum;
        private System.Windows.Forms.NumericUpDown BcolumnNum;
        private System.Windows.Forms.NumericUpDown BrowNum;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button matSum;
        private System.Windows.Forms.Button matMult;
        private System.Windows.Forms.Button clearResult;
        private System.Windows.Forms.Button matTrac;
        private System.Windows.Forms.Button matTrans;
        private System.Windows.Forms.Button matRev;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button saveRich;
        private System.Windows.Forms.Button readRich;
        private System.Windows.Forms.Label label8;
    }
}

