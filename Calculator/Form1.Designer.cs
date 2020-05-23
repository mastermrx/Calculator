namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtdisplay = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnce = new System.Windows.Forms.Button();
            this.btncle = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnp = new System.Windows.Forms.Button();
            this.btnBs = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnm = new System.Windows.Forms.Button();
            this.btn35 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btndv = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.button18btnsum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnPM = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtdisplay
            // 
            this.txtdisplay.BackColor = System.Drawing.Color.Silver;
            this.txtdisplay.Font = new System.Drawing.Font("DS-Digital", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisplay.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtdisplay.Location = new System.Drawing.Point(32, 134);
            this.txtdisplay.Multiline = true;
            this.txtdisplay.Name = "txtdisplay";
            this.txtdisplay.Size = new System.Drawing.Size(412, 76);
            this.txtdisplay.TabIndex = 0;
            this.txtdisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Silver;
            this.btn1.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(32, 538);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(73, 67);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnce
            // 
            this.btnce.BackColor = System.Drawing.Color.Silver;
            this.btnce.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnce.Location = new System.Drawing.Point(32, 275);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(73, 67);
            this.btnce.TabIndex = 2;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = false;
            this.btnce.Click += new System.EventHandler(this.btnce_Click);
            // 
            // btncle
            // 
            this.btncle.BackColor = System.Drawing.Color.Silver;
            this.btncle.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncle.Location = new System.Drawing.Point(141, 275);
            this.btncle.Name = "btncle";
            this.btncle.Size = new System.Drawing.Size(73, 67);
            this.btncle.TabIndex = 3;
            this.btncle.Text = "C";
            this.btncle.UseVisualStyleBackColor = false;
            this.btncle.Click += new System.EventHandler(this.btncle_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Silver;
            this.btn9.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(256, 362);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(73, 67);
            this.btn9.TabIndex = 4;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Silver;
            this.btn8.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(141, 362);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(73, 67);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Silver;
            this.btn7.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(32, 362);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(73, 67);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnp
            // 
            this.btnp.BackColor = System.Drawing.Color.Silver;
            this.btnp.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnp.Location = new System.Drawing.Point(371, 622);
            this.btnp.Name = "btnp";
            this.btnp.Size = new System.Drawing.Size(73, 67);
            this.btnp.TabIndex = 7;
            this.btnp.Text = "+";
            this.btnp.UseVisualStyleBackColor = false;
            this.btnp.Click += new System.EventHandler(this.Operational_Funtion);
            // 
            // btnBs
            // 
            this.btnBs.BackColor = System.Drawing.Color.Silver;
            this.btnBs.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBs.Location = new System.Drawing.Point(256, 275);
            this.btnBs.Name = "btnBs";
            this.btnBs.Size = new System.Drawing.Size(73, 67);
            this.btnBs.TabIndex = 8;
            this.btnBs.Text = "<";
            this.btnBs.UseVisualStyleBackColor = false;
            this.btnBs.Click += new System.EventHandler(this.btnBs_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Silver;
            this.btn4.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(32, 448);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(73, 67);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Silver;
            this.btn0.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(32, 622);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(73, 67);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnm
            // 
            this.btnm.BackColor = System.Drawing.Color.Silver;
            this.btnm.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnm.Location = new System.Drawing.Point(371, 538);
            this.btnm.Name = "btnm";
            this.btnm.Size = new System.Drawing.Size(73, 67);
            this.btnm.TabIndex = 14;
            this.btnm.Text = "-";
            this.btnm.UseVisualStyleBackColor = false;
            this.btnm.Click += new System.EventHandler(this.Operational_Funtion);
            // 
            // btn35
            // 
            this.btn35.BackColor = System.Drawing.Color.Silver;
            this.btn35.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn35.Location = new System.Drawing.Point(141, 448);
            this.btn35.Name = "btn35";
            this.btn35.Size = new System.Drawing.Size(73, 67);
            this.btn35.TabIndex = 13;
            this.btn35.Text = "5";
            this.btn35.UseVisualStyleBackColor = false;
            this.btn35.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Silver;
            this.btn6.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(256, 448);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(73, 67);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnmulti
            // 
            this.btnmulti.BackColor = System.Drawing.Color.Silver;
            this.btnmulti.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmulti.Location = new System.Drawing.Point(371, 362);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(73, 67);
            this.btnmulti.TabIndex = 17;
            this.btnmulti.Text = "*";
            this.btnmulti.UseVisualStyleBackColor = false;
            this.btnmulti.Click += new System.EventHandler(this.Operational_Funtion);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Silver;
            this.btn2.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(141, 538);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(73, 67);
            this.btn2.TabIndex = 16;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Silver;
            this.btn3.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(256, 538);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(73, 67);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.NumericValue);
            // 
            // btndv
            // 
            this.btndv.BackColor = System.Drawing.Color.Silver;
            this.btndv.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndv.Location = new System.Drawing.Point(371, 448);
            this.btndv.Name = "btndv";
            this.btndv.Size = new System.Drawing.Size(73, 67);
            this.btndv.TabIndex = 20;
            this.btndv.Text = "/";
            this.btndv.UseVisualStyleBackColor = false;
            this.btndv.Click += new System.EventHandler(this.Operational_Funtion);
            // 
            // btnpoint
            // 
            this.btnpoint.BackColor = System.Drawing.Color.Silver;
            this.btnpoint.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpoint.Location = new System.Drawing.Point(141, 622);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(73, 67);
            this.btnpoint.TabIndex = 19;
            this.btnpoint.Text = ".";
            this.btnpoint.UseVisualStyleBackColor = false;
            this.btnpoint.Click += new System.EventHandler(this.NumericValue);
            // 
            // button18btnsum
            // 
            this.button18btnsum.BackColor = System.Drawing.Color.Silver;
            this.button18btnsum.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18btnsum.Location = new System.Drawing.Point(256, 622);
            this.button18btnsum.Name = "button18btnsum";
            this.button18btnsum.Size = new System.Drawing.Size(73, 67);
            this.button18btnsum.TabIndex = 18;
            this.button18btnsum.Text = "=";
            this.button18btnsum.UseVisualStyleBackColor = false;
            this.button18btnsum.Click += new System.EventHandler(this.button18btnsum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 40);
            this.label1.TabIndex = 21;
            this.label1.Text = "CALCULATOR";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("DS-Digital", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(607, 382);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 47);
            this.lbl2.TabIndex = 22;
            // 
            // btnPM
            // 
            this.btnPM.BackColor = System.Drawing.Color.Silver;
            this.btnPM.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPM.Location = new System.Drawing.Point(371, 275);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(73, 67);
            this.btnPM.TabIndex = 23;
            this.btnPM.Text = "±";
            this.btnPM.UseVisualStyleBackColor = false;
            this.btnPM.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(477, 28);
            this.menuStrip2.TabIndex = 26;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripMenuItem.Image")));
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.closeToolStripMenuItem.Text = "Close ";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.aboutToolStripMenuItem.Text = "About ";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(477, 714);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndv);
            this.Controls.Add(this.btnpoint);
            this.Controls.Add(this.button18btnsum);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnm);
            this.Controls.Add(this.btn35);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnBs);
            this.Controls.Add(this.btnp);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btncle);
            this.Controls.Add(this.btnce);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtdisplay);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULATOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.NumericValue);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdisplay;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnce;
        private System.Windows.Forms.Button btncle;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnp;
        private System.Windows.Forms.Button btnBs;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnm;
        private System.Windows.Forms.Button btn35;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btndv;
        private System.Windows.Forms.Button btnpoint;
        private System.Windows.Forms.Button button18btnsum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

