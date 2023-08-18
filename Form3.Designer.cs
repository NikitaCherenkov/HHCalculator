namespace HHCalculator
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAnvil = new System.Windows.Forms.TextBox();
            this.textBoxHammer = new System.Windows.Forms.TextBox();
            this.textBoxMat0 = new System.Windows.Forms.TextBox();
            this.textBoxMat1 = new System.Windows.Forms.TextBox();
            this.textBoxMat2 = new System.Windows.Forms.TextBox();
            this.textBoxMat3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наковальня";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кузнечный молот";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Материалы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Результат:";
            // 
            // textBoxAnvil
            // 
            this.textBoxAnvil.Location = new System.Drawing.Point(105, 12);
            this.textBoxAnvil.Name = "textBoxAnvil";
            this.textBoxAnvil.Size = new System.Drawing.Size(58, 20);
            this.textBoxAnvil.TabIndex = 4;
            // 
            // textBoxHammer
            // 
            this.textBoxHammer.Location = new System.Drawing.Point(105, 42);
            this.textBoxHammer.Name = "textBoxHammer";
            this.textBoxHammer.Size = new System.Drawing.Size(58, 20);
            this.textBoxHammer.TabIndex = 5;
            // 
            // textBoxMat0
            // 
            this.textBoxMat0.Location = new System.Drawing.Point(70, 72);
            this.textBoxMat0.Name = "textBoxMat0";
            this.textBoxMat0.Size = new System.Drawing.Size(58, 20);
            this.textBoxMat0.TabIndex = 6;
            // 
            // textBoxMat1
            // 
            this.textBoxMat1.Location = new System.Drawing.Point(135, 72);
            this.textBoxMat1.Name = "textBoxMat1";
            this.textBoxMat1.Size = new System.Drawing.Size(58, 20);
            this.textBoxMat1.TabIndex = 7;
            // 
            // textBoxMat2
            // 
            this.textBoxMat2.Location = new System.Drawing.Point(200, 72);
            this.textBoxMat2.Name = "textBoxMat2";
            this.textBoxMat2.Size = new System.Drawing.Size(58, 20);
            this.textBoxMat2.TabIndex = 8;
            // 
            // textBoxMat3
            // 
            this.textBoxMat3.Location = new System.Drawing.Point(265, 72);
            this.textBoxMat3.Name = "textBoxMat3";
            this.textBoxMat3.Size = new System.Drawing.Size(58, 20);
            this.textBoxMat3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(230, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 26);
            this.label5.TabIndex = 12;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(119, 100);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(97, 23);
            this.buttonCalc.TabIndex = 13;
            this.buttonCalc.Text = "Вычислить";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 131);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMat3);
            this.Controls.Add(this.textBoxMat2);
            this.Controls.Add(this.textBoxMat1);
            this.Controls.Add(this.textBoxMat0);
            this.Controls.Add(this.textBoxHammer);
            this.Controls.Add(this.textBoxAnvil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Shown += new System.EventHandler(this.Form3_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAnvil;
        private System.Windows.Forms.TextBox textBoxHammer;
        private System.Windows.Forms.TextBox textBoxMat0;
        private System.Windows.Forms.TextBox textBoxMat1;
        private System.Windows.Forms.TextBox textBoxMat2;
        private System.Windows.Forms.TextBox textBoxMat3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCalc;
    }
}