namespace WindowsFormsApp1
{
    partial class Calc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SummBox = new System.Windows.Forms.TextBox();
            this.LeastBox = new System.Windows.Forms.TextBox();
            this.GoneCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(139, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Summ:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(65, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "LeastMultiple:";
            // 
            // SummBox
            // 
            this.SummBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SummBox.Location = new System.Drawing.Point(244, 47);
            this.SummBox.Name = "SummBox";
            this.SummBox.Size = new System.Drawing.Size(94, 29);
            this.SummBox.TabIndex = 2;
            // 
            // LeastBox
            // 
            this.LeastBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeastBox.Location = new System.Drawing.Point(244, 108);
            this.LeastBox.Name = "LeastBox";
            this.LeastBox.Size = new System.Drawing.Size(94, 29);
            this.LeastBox.TabIndex = 3;
            // 
            // GoneCalc
            // 
            this.GoneCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoneCalc.Location = new System.Drawing.Point(144, 198);
            this.GoneCalc.Name = "GoneCalc";
            this.GoneCalc.Size = new System.Drawing.Size(128, 66);
            this.GoneCalc.TabIndex = 4;
            this.GoneCalc.Text = "Count";
            this.GoneCalc.UseVisualStyleBackColor = true;
            this.GoneCalc.Click += new System.EventHandler(this.GoneCalc_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 325);
            this.Controls.Add(this.GoneCalc);
            this.Controls.Add(this.LeastBox);
            this.Controls.Add(this.SummBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(427, 364);
            this.MinimumSize = new System.Drawing.Size(427, 364);
            this.Name = "Calc";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SummBox;
        private System.Windows.Forms.TextBox LeastBox;
        private System.Windows.Forms.Button GoneCalc;
    }
}