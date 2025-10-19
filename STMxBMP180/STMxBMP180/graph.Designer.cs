
namespace STMxBMP180
{
    partial class graph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graph_node1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graph_node2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NODE1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graph_node1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_node2)).BeginInit();
            this.SuspendLayout();
            // 
            // graph_node1
            // 
            chartArea1.Name = "ChartArea1";
            this.graph_node1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graph_node1.Legends.Add(legend1);
            this.graph_node1.Location = new System.Drawing.Point(12, 109);
            this.graph_node1.Name = "graph_node1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graph_node1.Series.Add(series1);
            this.graph_node1.Size = new System.Drawing.Size(384, 327);
            this.graph_node1.TabIndex = 0;
            this.graph_node1.Text = "chart1";
            // 
            // graph_node2
            // 
            chartArea2.Name = "ChartArea1";
            this.graph_node2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graph_node2.Legends.Add(legend2);
            this.graph_node2.Location = new System.Drawing.Point(423, 109);
            this.graph_node2.Name = "graph_node2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.graph_node2.Series.Add(series2);
            this.graph_node2.Size = new System.Drawing.Size(369, 338);
            this.graph_node2.TabIndex = 1;
            this.graph_node2.Text = "chart2";
            // 
            // NODE1
            // 
            this.NODE1.AutoSize = true;
            this.NODE1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NODE1.Location = new System.Drawing.Point(159, 66);
            this.NODE1.Name = "NODE1";
            this.NODE1.Size = new System.Drawing.Size(80, 25);
            this.NODE1.TabIndex = 2;
            this.NODE1.Text = "NODE1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(570, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "NODE2";
            // 
            // graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NODE1);
            this.Controls.Add(this.graph_node2);
            this.Controls.Add(this.graph_node1);
            this.Name = "graph";
            this.Text = "graph";
            this.Load += new System.EventHandler(this.graph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graph_node1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_node2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graph_node1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph_node2;
        private System.Windows.Forms.Label NODE1;
        private System.Windows.Forms.Label label1;
    }
}