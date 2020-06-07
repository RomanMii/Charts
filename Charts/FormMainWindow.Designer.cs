namespace Charts
{
    partial class FormMainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.flowLayoutPanelControls = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trygonometrycznaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wielomianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(3, 3);
            this.chart.Name = "chart";
            this.tableLayoutPanel1.SetRowSpan(this.chart, 2);
            this.chart.Size = new System.Drawing.Size(531, 366);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.Controls.Add(this.chart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelControls, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(702, 372);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.ContextMenuStrip = this.contextMenuStrip1;
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.Location = new System.Drawing.Point(540, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(159, 24);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "add function";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // flowLayoutPanelControls
            // 
            this.flowLayoutPanelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelControls.Location = new System.Drawing.Point(540, 33);
            this.flowLayoutPanelControls.Name = "flowLayoutPanelControls";
            this.flowLayoutPanelControls.Size = new System.Drawing.Size(159, 336);
            this.flowLayoutPanelControls.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trygonometrycznaToolStripMenuItem,
            this.wielomianToolStripMenuItem,
            this.liniowaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
            // 
            // trygonometrycznaToolStripMenuItem
            // 
            this.trygonometrycznaToolStripMenuItem.Name = "trygonometrycznaToolStripMenuItem";
            this.trygonometrycznaToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.trygonometrycznaToolStripMenuItem.Text = "trygonometryczna";
            this.trygonometrycznaToolStripMenuItem.Click += new System.EventHandler(this.trygonometrycznaToolStripMenuItem_Click);
            // 
            // wielomianToolStripMenuItem
            // 
            this.wielomianToolStripMenuItem.Name = "wielomianToolStripMenuItem";
            this.wielomianToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.wielomianToolStripMenuItem.Text = "wielomian";
            // 
            // liniowaToolStripMenuItem
            // 
            this.liniowaToolStripMenuItem.Name = "liniowaToolStripMenuItem";
            this.liniowaToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.liniowaToolStripMenuItem.Text = "liniowa";
            this.liniowaToolStripMenuItem.Click += new System.EventHandler(this.liniowaToolStripMenuItem_Click);
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 372);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormMainWindow";
            this.Text = "grAphs";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelControls;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trygonometrycznaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wielomianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liniowaToolStripMenuItem;
    }
}

