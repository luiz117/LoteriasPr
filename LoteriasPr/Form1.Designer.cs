namespace LoteriasPr
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
            btnCalculate = new Button();
            nupMax = new NumericUpDown();
            nupSorteados = new NumericUpDown();
            label2 = new Label();
            nupApostados = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            txtResult = new TextBox();
            btnClearResult = new Button();
            ((System.ComponentModel.ISupportInitialize)nupMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupSorteados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupApostados).BeginInit();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(102, 99);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // nupMax
            // 
            nupMax.Location = new Point(102, 12);
            nupMax.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nupMax.Name = "nupMax";
            nupMax.Size = new Size(120, 23);
            nupMax.TabIndex = 1;
            nupMax.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // nupSorteados
            // 
            nupSorteados.Location = new Point(102, 41);
            nupSorteados.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupSorteados.Name = "nupSorteados";
            nupSorteados.Size = new Size(120, 23);
            nupSorteados.TabIndex = 2;
            nupSorteados.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 14);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 4;
            label2.Text = "Maior Número:";
            // 
            // nupApostados
            // 
            nupApostados.Location = new Point(102, 70);
            nupApostados.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupApostados.Name = "nupApostados";
            nupApostados.Size = new Size(120, 23);
            nupApostados.TabIndex = 6;
            nupApostados.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 43);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "Sorteados:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 72);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 8;
            label4.Text = "Apostados:";
            // 
            // txtResult
            // 
            txtResult.Enabled = false;
            txtResult.Location = new Point(12, 128);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(503, 79);
            txtResult.TabIndex = 9;
            // 
            // btnClearResult
            // 
            btnClearResult.Location = new Point(183, 99);
            btnClearResult.Name = "btnClearResult";
            btnClearResult.Size = new Size(75, 23);
            btnClearResult.TabIndex = 10;
            btnClearResult.Text = "Clear";
            btnClearResult.UseVisualStyleBackColor = true;
            btnClearResult.Click += btnClearResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 227);
            Controls.Add(btnClearResult);
            Controls.Add(txtResult);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nupApostados);
            Controls.Add(label2);
            Controls.Add(nupSorteados);
            Controls.Add(nupMax);
            Controls.Add(btnCalculate);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator Lottery";
            ((System.ComponentModel.ISupportInitialize)nupMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupSorteados).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupApostados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private NumericUpDown nupMax;
        private NumericUpDown nupSorteados;
        private Label label2;
        private NumericUpDown nupApostados;
        private Label label3;
        private Label label4;
        private TextBox txtResult;
        private Button btnClearResult;
    }
}
