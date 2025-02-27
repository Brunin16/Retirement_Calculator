namespace Tab_retirement_calculator
{
    partial class Calculator
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
            this.enterButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.workedYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.yearResponse = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.approximateValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(177, 284);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 11;
            this.enterButton.Text = "Calcular";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 100);
            this.label3.TabIndex = 10;
            this.label3.Text = "                    Bem Vindo\r\n       Para calcular quanto tempo\r\nresta ate sua a" +
    "posentadoria e seu valor\r\n         insira suas informações\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Anos trabalhados";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // workedYear
            // 
            this.workedYear.Location = new System.Drawing.Point(190, 170);
            this.workedYear.Name = "workedYear";
            this.workedYear.Size = new System.Drawing.Size(62, 20);
            this.workedYear.TabIndex = 8;
            this.workedYear.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Idade atual";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(190, 138);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(62, 20);
            this.year.TabIndex = 6;
            this.year.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // yearResponse
            // 
            this.yearResponse.AutoSize = true;
            this.yearResponse.Location = new System.Drawing.Point(94, 259);
            this.yearResponse.Name = "yearResponse";
            this.yearResponse.Size = new System.Drawing.Size(0, 13);
            this.yearResponse.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Salario medio";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // approximateValue
            // 
            this.approximateValue.Location = new System.Drawing.Point(190, 209);
            this.approximateValue.Name = "approximateValue";
            this.approximateValue.Size = new System.Drawing.Size(62, 20);
            this.approximateValue.TabIndex = 13;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 328);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.approximateValue);
            this.Controls.Add(this.yearResponse);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.workedYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.year);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox workedYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Label yearResponse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox approximateValue;
    }
}