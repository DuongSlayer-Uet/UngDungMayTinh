using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace STMxBMP180
{
    public partial class graph : Form
    {
        private float node1val = 30;
        private float node2val = 40;
        private int xValue = 0;
        public graph()
        {
            InitializeComponent();
        }

        private void graph_Load(object sender, EventArgs e)
        {
            setupGraph();
        }
        private void setupGraph()
        {
            // node1 graph
            Series series1 = new Series("RealtimeLine");
            series1.ChartType = SeriesChartType.Line;
            series1.BorderWidth = 2;
            graph_node1.Series.Clear();
            graph_node1.Series.Add(series1);
            graph_node1.Legends.Clear();
            graph_node1.ChartAreas[0].AxisX.Title = "Time (s)";
            graph_node1.ChartAreas[0].AxisY.Title = "Temperature (°C)";

            // node2 graph
            Series series2 = new Series("RealtimeLine");
            series2.ChartType = SeriesChartType.Line;
            series2.BorderWidth = 2;
            graph_node2.Series.Clear();
            graph_node2.Series.Add(series2);
            graph_node2.Legends.Clear();
            graph_node2.ChartAreas[0].AxisX.Title = "Time (s)";
            graph_node2.ChartAreas[0].AxisY.Title = "Temperature (°C)";

            // Timer để thêm dữ liệu mỗi 1 giây
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1000 ms = 1 giây
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            var series1 = graph_node1.Series["RealtimeLine"];
            series1.Points.AddXY(xValue, node1val);
            // Nếu có >8 điểm, xóa point cũ đầu tiên
            if (series1.Points.Count > 8)
                series1.Points.RemoveAt(0);
            // Cập nhật trục X để scroll
            graph_node1.ChartAreas[0].AxisX.Minimum = series1.Points[0].XValue;
            graph_node1.ChartAreas[0].AxisX.Maximum = series1.Points[series1.Points.Count - 1].XValue;
            graph_node1.ChartAreas[0].AxisY.Minimum = 0;
            graph_node1.ChartAreas[0].AxisY.Maximum = node1val + 20;
            graph_node1.Invalidate(); // refresh chart

            // press
            var series2 = graph_node2.Series["RealtimeLine"];
            series2.Points.AddXY(xValue, node2val);
            // Nếu có >8 điểm, xóa point cũ đầu tiên
            if (series2.Points.Count > 8)
                series2.Points.RemoveAt(0);
            // Cập nhật trục X để scroll
            graph_node2.ChartAreas[0].AxisX.Minimum = series2.Points[0].XValue;
            graph_node2.ChartAreas[0].AxisX.Maximum = series2.Points[series2.Points.Count - 1].XValue;
            graph_node2.ChartAreas[0].AxisY.Minimum = 0;
            graph_node2.ChartAreas[0].AxisY.Maximum = node1val + 20;
            graph_node2.Invalidate(); // refresh chart
            xValue++;
        }
    }
}
