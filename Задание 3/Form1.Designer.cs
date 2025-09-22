namespace Задание_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonCalculate = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(12, 106);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(125, 27);
            textBoxA.TabIndex = 0;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(143, 106);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(125, 27);
            textBoxB.TabIndex = 1;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(274, 106);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(125, 27);
            textBoxC.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 3;
            label1.Text = "Сторона A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 82);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 4;
            label2.Text = "Сторона B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 82);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 5;
            label3.Text = "Сторона C";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(274, 176);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(94, 29);
            buttonCalculate.TabIndex = 6;
            buttonCalculate.Text = "Рассчитать";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(405, 106);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(75, 20);
            labelResult.TabIndex = 7;
            labelResult.Text = "Результат";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(782, 253);
            Controls.Add(labelResult);
            Controls.Add(buttonCalculate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Name = "Form1";
            Text = "Задание 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonCalculate;
        private Label labelResult;
    }
}
