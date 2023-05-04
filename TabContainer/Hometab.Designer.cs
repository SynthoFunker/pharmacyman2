using System.Drawing.Drawing2D;
using System.Drawing;

namespace pharmacyp.TabContainer
{
    partial class Hometab
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem2 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem3 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem4 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.QuantityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(122)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.61881F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.38119F));
            this.tableLayoutPanel1.Controls.Add(this.QuantityChart, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 233);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.31804F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 276);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // QuantityChart
            // 
            this.QuantityChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.Name = "ChartArea1";
            this.QuantityChart.ChartAreas.Add(chartArea1);
            this.QuantityChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legendItem1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            legendItem1.Name = "باش";
            legendItem1.SeparatorColor = System.Drawing.SystemColors.InfoText;
            legendItem1.SeparatorType = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickLine;
            legendItem2.BackSecondaryColor = System.Drawing.Color.WhiteSmoke;
            legendItem2.Color = System.Drawing.Color.Yellow;
            legendItem2.Name = "مامناوەند";
            legendItem2.SeparatorType = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickLine;
            legendItem3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            legendItem3.Name = "کەم";
            legendItem3.SeparatorType = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickLine;
            legendItem4.Color = System.Drawing.Color.Red;
            legendItem4.Name = "تەواوبوو";
            legend1.CustomItems.Add(legendItem1);
            legend1.CustomItems.Add(legendItem2);
            legend1.CustomItems.Add(legendItem3);
            legend1.CustomItems.Add(legendItem4);
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend1.Font = new System.Drawing.Font("UniQAIDAR_A7MED", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TextWrapThreshold = 35;
            legend1.Title = "ڕێژە / عدد";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Near;
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            legend1.TitleFont = new System.Drawing.Font("UniQAIDAR_A7MED", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)), true);
            legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickLine;
            this.QuantityChart.Legends.Add(legend1);
            this.QuantityChart.Location = new System.Drawing.Point(3, 3);
            this.QuantityChart.Name = "QuantityChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Quantity";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YValuesPerPoint = 2;
            this.QuantityChart.Series.Add(series1);
            this.QuantityChart.Size = new System.Drawing.Size(402, 270);
            this.QuantityChart.TabIndex = 2;
            this.QuantityChart.Text = "chart1";
            // 
            // Hometab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Hometab";
            this.Size = new System.Drawing.Size(808, 509);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart QuantityChart;
    }
}
