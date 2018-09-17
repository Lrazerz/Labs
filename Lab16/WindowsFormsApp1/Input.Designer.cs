namespace WindowsFormsApp1
{
    partial class Input
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Numb1 = new System.Windows.Forms.TextBox();
            this.Numb2 = new System.Windows.Forms.TextBox();
            this.Numb3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SumCheckBox = new System.Windows.Forms.CheckBox();
            this.LeaseCheckBox = new System.Windows.Forms.CheckBox();
            this.errorProviderNumber1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNumber2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNumber3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumber2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumber3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(109, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(110, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number2";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(110, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number3";
            // 
            // Numb1
            // 
            this.Numb1.Location = new System.Drawing.Point(210, 61);
            this.Numb1.Name = "Numb1";
            this.Numb1.Size = new System.Drawing.Size(62, 20);
            this.Numb1.TabIndex = 3;
            this.Numb1.TextChanged += new System.EventHandler(this.Numb1_TextChanged);
            // 
            // Numb2
            // 
            this.Numb2.Location = new System.Drawing.Point(210, 98);
            this.Numb2.Name = "Numb2";
            this.Numb2.Size = new System.Drawing.Size(62, 20);
            this.Numb2.TabIndex = 4;
            this.Numb2.TextChanged += new System.EventHandler(this.Numb2_TextChanged);
            // 
            // Numb3
            // 
            this.Numb3.Location = new System.Drawing.Point(210, 136);
            this.Numb3.Name = "Numb3";
            this.Numb3.Size = new System.Drawing.Size(62, 20);
            this.Numb3.TabIndex = 5;
            this.Numb3.TextChanged += new System.EventHandler(this.Numb3_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(99, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Choose action";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SumCheckBox
            // 
            this.SumCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumCheckBox.Location = new System.Drawing.Point(113, 219);
            this.SumCheckBox.Name = "SumCheckBox";
            this.SumCheckBox.Size = new System.Drawing.Size(147, 29);
            this.SumCheckBox.TabIndex = 7;
            this.SumCheckBox.Text = "Sum";
            this.SumCheckBox.UseVisualStyleBackColor = true;
            this.SumCheckBox.CheckedChanged += new System.EventHandler(this.SumCheckBox_CheckedChanged);
            // 
            // LeaseCheckBox
            // 
            this.LeaseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeaseCheckBox.Location = new System.Drawing.Point(113, 254);
            this.LeaseCheckBox.Name = "LeaseCheckBox";
            this.LeaseCheckBox.Size = new System.Drawing.Size(170, 35);
            this.LeaseCheckBox.TabIndex = 8;
            this.LeaseCheckBox.Text = "LeastMultiple";
            this.LeaseCheckBox.UseVisualStyleBackColor = true;
            this.LeaseCheckBox.CheckedChanged += new System.EventHandler(this.LeaseCheckBox_CheckedChanged);
            // 
            // errorProviderNumber1
            // 
            this.errorProviderNumber1.ContainerControl = this;
            // 
            // errorProviderNumber2
            // 
            this.errorProviderNumber2.ContainerControl = this;
            // 
            // errorProviderNumber3
            // 
            this.errorProviderNumber3.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(137, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LeaseCheckBox);
            this.Controls.Add(this.SumCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Numb3);
            this.Controls.Add(this.Numb2);
            this.Controls.Add(this.Numb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(452, 415);
            this.MinimumSize = new System.Drawing.Size(452, 415);
            this.Name = "Input";
            this.Text = "Input";
            this.Load += new System.EventHandler(this.Input_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumber2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumber3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Numb1;
        private System.Windows.Forms.TextBox Numb2;
        private System.Windows.Forms.TextBox Numb3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox SumCheckBox;
        private System.Windows.Forms.CheckBox LeaseCheckBox;
        private System.Windows.Forms.ErrorProvider errorProviderNumber1;
        private System.Windows.Forms.ErrorProvider errorProviderNumber2;
        private System.Windows.Forms.ErrorProvider errorProviderNumber3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}