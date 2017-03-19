/*
 *Author: Iskandar Chacra
 *Since; 2016-10-10
 *Version: 1.0
 *This project was inspired and supervised by Mr. Mahmoud Bdeir 
 *Instructor, Department of Computer Science
 *American University of Beirut
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJSLib
{
	public class ChartJsBuilder
	{
  
		static ChartJs chart;

        public static ChartJsBuilder createBarChart()
		{
			chart = BarChart.createColumnsChart();
			return new ChartJsBuilder();
		}
		public static ChartJsBuilder createHorizontalBarChart()
		{
			chart = BarChart.createBarChart();
			return new ChartJsBuilder();
		}
		public static ChartJsBuilder createLineChart()
		{
			chart = new LineChart();
			return new ChartJsBuilder();
		}
		public static ChartJsBuilder createRadarChart()
		{
			chart = new RadarChart();
			return new ChartJsBuilder();
		}
		public static ChartJsBuilder createPieChart()
		{
			chart = PieChart.createPieChart();
			return new ChartJsBuilder();
		}
		public static ChartJsBuilder createDoughnutChart()
		{
			chart = PieChart.createDoughnutChart();
			return new ChartJsBuilder();
		}
		public static ChartJsBuilder createBubbleChart()
		{
			chart = new BubbleChart();
			return new ChartJsBuilder();
		}
		public ChartJsBuilder addDataset(Dataset d)
		{
			chart.addDataset(d);
			return this;
		}
		public ChartJsBuilder addDatasets(List<Dataset> datasets)
		{
			chart.addDatasets(datasets);
			return this;
		}
        public ChartJsBuilder setAnimation(Animation animation)
        {
            chart.setAnimation(animation);
            return this;
        }
		#region PIE/DOUGHNUT 
		public ChartJsBuilder animateScale(bool b)
		{
			chart.animateScale(b);
			return this;
		}
		public ChartJsBuilder animateRotate(bool b)
		{
			chart.animateRotate(b);
			return this;
		}
		public ChartJsBuilder circumference(double x)
		{
			chart.circumference(x);
			return this;
		}
		public ChartJsBuilder cutoutPercentage(double x)
		{
			chart.cutoutPercentage(x);
			return this;
		}
		public ChartJsBuilder rotation(double x)
		{
			chart.rotation(x);
			return this;
		}
		#endregion
		public ChartJsBuilder setXAxes(Scale x)
		{
			chart.setXAxes(x);
			return this;
		}
		public ChartJsBuilder setYAxes(Scale y)
		{
			chart.setYAxes(y);
			return this;
		}
		public ChartJs Build()
		{
			chart.create();
			return chart;
		}
	}
}
