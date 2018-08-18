namespace NAVY_Fractals
{
    partial class MainForm
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
            this.picFractal = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.comboFractals = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numIterations = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picFractal)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIterations)).BeginInit();
            this.SuspendLayout();
            // 
            // picFractal
            // 
            this.picFractal.Location = new System.Drawing.Point(12, 117);
            this.picFractal.Name = "picFractal";
            this.picFractal.Size = new System.Drawing.Size(891, 536);
            this.picFractal.TabIndex = 0;
            this.picFractal.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDraw);
            this.groupBox1.Controls.Add(this.comboFractals);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numIterations);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(137, 59);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 3;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // comboFractals
            // 
            this.comboFractals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFractals.FormattingEnabled = true;
            this.comboFractals.Location = new System.Drawing.Point(9, 59);
            this.comboFractals.Name = "comboFractals";
            this.comboFractals.Size = new System.Drawing.Size(121, 21);
            this.comboFractals.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iterations";
            // 
            // numIterations
            // 
            this.numIterations.Location = new System.Drawing.Point(9, 32);
            this.numIterations.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numIterations.Name = "numIterations";
            this.numIterations.Size = new System.Drawing.Size(120, 20);
            this.numIterations.TabIndex = 0;
            this.numIterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numIterations.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 665);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picFractal);
            this.Name = "MainForm";
            this.Text = "NAVY - Fractals";
            ((System.ComponentModel.ISupportInitialize)(this.picFractal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIterations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFractal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.ComboBox comboFractals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numIterations;
    }
}

