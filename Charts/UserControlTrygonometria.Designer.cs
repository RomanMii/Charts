namespace Charts
{
    partial class UserControlTrygonometria
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxFunction = new System.Windows.Forms.ComboBox();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxFunction);
            this.groupBox1.Controls.Add(this.numericUpDownA);
            this.groupBox1.Controls.Add(this.numericUpDownB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // comboBoxFunction
            // 
            this.comboBoxFunction.FormattingEnabled = true;
            this.comboBoxFunction.Items.AddRange(new object[] {
            "sin",
            "cos",
            "tan"});
            this.comboBoxFunction.Location = new System.Drawing.Point(41, 36);
            this.comboBoxFunction.Name = "comboBoxFunction";
            this.comboBoxFunction.Size = new System.Drawing.Size(99, 24);
            this.comboBoxFunction.TabIndex = 5;
            this.comboBoxFunction.TextChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(42, 66);
            this.numericUpDownA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(98, 22);
            this.numericUpDownA.TabIndex = 4;
            this.numericUpDownA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownA.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(42, 94);
            this.numericUpDownB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(98, 22);
            this.numericUpDownB.TabIndex = 3;
            this.numericUpDownB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownB.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "B =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "A =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "f(x)";
            // 
            // UserControlTrygonometria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlTrygonometria";
            this.Size = new System.Drawing.Size(175, 138);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxFunction;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
