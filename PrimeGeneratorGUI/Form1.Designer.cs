namespace PrimeGeneratorGUI
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
            this.startRangeLabel = new System.Windows.Forms.Label();
            this.endRangeLabel = new System.Windows.Forms.Label();
            this.startRange = new System.Windows.Forms.NumericUpDown();
            this.endRange = new System.Windows.Forms.NumericUpDown();
            this.calculateSequential = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.calculateParallel = new System.Windows.Forms.Button();
            this.stopWatchLabel = new System.Windows.Forms.Label();
            this.stopWatchTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endRange)).BeginInit();
            this.SuspendLayout();
            // 
            // startRangeLabel
            // 
            this.startRangeLabel.AutoSize = true;
            this.startRangeLabel.Location = new System.Drawing.Point(37, 28);
            this.startRangeLabel.Name = "startRangeLabel";
            this.startRangeLabel.Size = new System.Drawing.Size(118, 25);
            this.startRangeLabel.TabIndex = 0;
            this.startRangeLabel.Text = "Start range";
            // 
            // endRangeLabel
            // 
            this.endRangeLabel.AutoSize = true;
            this.endRangeLabel.Location = new System.Drawing.Point(323, 28);
            this.endRangeLabel.Name = "endRangeLabel";
            this.endRangeLabel.Size = new System.Drawing.Size(111, 25);
            this.endRangeLabel.TabIndex = 1;
            this.endRangeLabel.Text = "End range";
            // 
            // startRange
            // 
            this.startRange.Location = new System.Drawing.Point(42, 68);
            this.startRange.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.startRange.Name = "startRange";
            this.startRange.Size = new System.Drawing.Size(113, 31);
            this.startRange.TabIndex = 2;
            // 
            // endRange
            // 
            this.endRange.Location = new System.Drawing.Point(328, 68);
            this.endRange.Maximum = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.endRange.Name = "endRange";
            this.endRange.Size = new System.Drawing.Size(106, 31);
            this.endRange.TabIndex = 3;
            // 
            // calculateSequential
            // 
            this.calculateSequential.Location = new System.Drawing.Point(42, 401);
            this.calculateSequential.Name = "calculateSequential";
            this.calculateSequential.Size = new System.Drawing.Size(190, 85);
            this.calculateSequential.TabIndex = 4;
            this.calculateSequential.Text = "Calculate primes (sequential)";
            this.calculateSequential.UseVisualStyleBackColor = true;
            this.calculateSequential.Click += new System.EventHandler(this.CalculateSequential_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(42, 186);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(392, 179);
            this.listBox.TabIndex = 5;
            // 
            // calculateParallel
            // 
            this.calculateParallel.Location = new System.Drawing.Point(244, 401);
            this.calculateParallel.Name = "calculateParallel";
            this.calculateParallel.Size = new System.Drawing.Size(190, 85);
            this.calculateParallel.TabIndex = 6;
            this.calculateParallel.Text = "Calculate primes (parallel)";
            this.calculateParallel.UseVisualStyleBackColor = true;
            this.calculateParallel.Click += new System.EventHandler(this.CalculateParallel_Click);
            // 
            // stopWatchLabel
            // 
            this.stopWatchLabel.AutoSize = true;
            this.stopWatchLabel.Location = new System.Drawing.Point(160, 137);
            this.stopWatchLabel.Name = "stopWatchLabel";
            this.stopWatchLabel.Size = new System.Drawing.Size(118, 25);
            this.stopWatchLabel.TabIndex = 7;
            this.stopWatchLabel.Text = "Stopwatch:";
            // 
            // stopWatchTime
            // 
            this.stopWatchTime.AutoSize = true;
            this.stopWatchTime.Location = new System.Drawing.Point(284, 137);
            this.stopWatchTime.Name = "stopWatchTime";
            this.stopWatchTime.Size = new System.Drawing.Size(35, 25);
            this.stopWatchTime.TabIndex = 8;
            this.stopWatchTime.Text = "0s";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(473, 516);
            this.Controls.Add(this.stopWatchTime);
            this.Controls.Add(this.stopWatchLabel);
            this.Controls.Add(this.calculateParallel);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.calculateSequential);
            this.Controls.Add(this.endRange);
            this.Controls.Add(this.startRange);
            this.Controls.Add(this.endRangeLabel);
            this.Controls.Add(this.startRangeLabel);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.startRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label startRangeLabel;
        private System.Windows.Forms.Label endRangeLabel;
        private System.Windows.Forms.NumericUpDown startRange;
        private System.Windows.Forms.NumericUpDown endRange;
        private System.Windows.Forms.Button calculateSequential;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button calculateParallel;
        private System.Windows.Forms.Label stopWatchLabel;
        private System.Windows.Forms.Label stopWatchTime;
    }
}

