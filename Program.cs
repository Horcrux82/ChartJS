/*
 *Author: Iskandar Chacra
 *Since; 2016-10-10
 *Version: 1.0
 *This project was inspired and supervised by Mr. Mahmoud Bdeir 
 *Instructor, Department of Computer Science
 *American University of Beirut
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ChartJSLib
{

	public class Program
	{
		static void Main(string[] args)
		{
			Point p1 = new Point(2, "Obama");
			Point p2 = new Point(1, "Lincoln");
			Point p3 = new Point(3, "Bush");
			Point p11 = new Point(10, "Clinton");
			Point p22 = new Point(5, "Trump");
			Point p33 = new Point(9, "Sanders");
			#region TESTING BARCHART
			Dataset barDataset1 = DatasetBuilder.createDataset("2015 elections").addPoint(p1).addPoint(p2).addPoint(p3)
				.setPointHoverBorderWidth(10)
				.setPointHoverBorderColor(true)
				.setPointBorderColor(true)
				.setPointBackgroundColor(true)
				.setPointBorderWidth(10)
				.setPointHoverBackgroundColor(true)
				.setShowLine(true)
				.setBackGroundColor(true)
				.setBorderColor(true)
				.setFill("true").Build();
			Dataset barDataset2 = DatasetBuilder.createDataset("2016 elections").addPoint(p11).addPoint(p22).addPoint(p33)
				.setPointHoverBorderWidth(10)
				.setPointHoverBorderColor(true)
				.setPointBorderColor(true)
				.setPointBackgroundColor(true)
				.setPointBorderWidth(10)
				.setPointHoverBackgroundColor(true)
				.setShowLine(true)
				.setBackGroundColor(true)
				.setBorderColor(true)
				.setFill("true").Build();
			#endregion
			#region TESTING LINE/RADAR CHART
			Dataset lineRadarDataset1 = DatasetBuilder.createDataset("2015 elections").addPoint(p1).addPoint(p2).addPoint(p3)
				.setLineTension(0.1)
				.setBackGroundColor(true)
				.setPointHoverBorderColor(true)
				.setBorderColor(true)
				.setPointHoverBorderWidth(5)
				.setPointBorderColor(true)
				.setPointBackgroundColor(true)
				.setPointBorderWidth(10)
				.setPointHoverBackgroundColor(true)
				.setShowLine(true)
				.setBorderColor(true)
				.setFill("true").Build();
			Dataset lineRadarDataset2 = DatasetBuilder.createDataset("2016 elections").addPoint(p11).addPoint(p22).addPoint(p33)
				.setLineTension(0.1)
				.setPointHoverBorderColor(true)
				.setBorderColor(true)
				.setBackGroundColor(true)
				.setPointHoverBorderWidth(5)
				.setPointBorderColor(true)
				.setPointBackgroundColor(true)
				.setPointBorderWidth(10)
				.setPointHoverBackgroundColor(true)
				.setShowLine(true)
				.setBorderColor(true)
				.setFill("true").Build();
			#endregion
			#region TESTING PIE/DOUGHNUT CHART
			Dataset PieDoughnutDataset1 = DatasetBuilder.createDataset("").addPoint(p11).addPoint(p22).addPoint(p33)
														.setBackGroundColor(true)
														.setBorderColor(true)
														.setBorderWidth(5)
														.setHoverBackColor(true)
														.setHoverBordColor(true)
														.setHoverBorderWidth(8)
														.Build();

			Dataset PieDoughnutDataset2 = DatasetBuilder.createDataset("").addPoint(p11).addPoint(p22).addPoint(p33)
														.setBackGroundColor(true)
														.setBorderColor(true)
														.setBorderWidth(5)
														.setHoverBackColor(true)
														.setHoverBordColor(true)
														.setHoverBorderWidth(8).Build();

			#endregion
			#region TESTING BUBBLE GRAPH
			/*
			 * Bubblepoint graph
			 * Need to let the datasetbuilder know that we are building a bubble point graph. Using isBubble() function is necessary
			 */
			BubblePoint bp1 = new BubblePoint(1, 2, 20);
			BubblePoint bp2 = new BubblePoint(29, 20, 12);
			BubblePoint bp3 = new BubblePoint(20, 10, 15);
			Dataset bubbleDataset1 = DatasetBuilder.createDataset("2016 elections")
										.isBubble(true).addBubblePoint(bp1).addBubblePoint(bp2).addBubblePoint(bp3)
										.setBackGroundColor(true)
										.setHoverBackColor(true)
										.setBorderColor(true).Build();

			BubblePoint bp11 = new BubblePoint(10, 20, 20);
			BubblePoint bp22 = new BubblePoint(15, 25, 12);
			BubblePoint bp33 = new BubblePoint(18, 35, 15);
			Dataset bubbleDataset2 = DatasetBuilder.createDataset("2015 elections").isBubble(true).addBubblePoint(bp11).addBubblePoint(bp22).addBubblePoint(bp33)
										.setBackGroundColor(true)
										.setHoverBackColor(true)
										.setBorderColor(true).Build();
			#endregion
			#region BUILDING SCALES
			Scale xAxis = ScaleBuilder.createCategoryXAxes().setGridColor(true).setGridLineWidth(2)
									  .setGridBorderDash(2).setGridDrawTicks(true).setGridDrawBorder(true)
									  .setGridZeroLineColor(true).setLabelString("IM X AXIS").setLabelDisplay(true)
									  .setLabelFontSize(20).setLabelFontColor(true).setTicksDisplay(true)
									  .setTicksFontColor(true).setTicksReverse(false).BuildX();
			Scale yAxis = ScaleBuilder.createLinearYAxes().setGridColor(true).setGridLineWidth(4)
									  .setGridBorderDash(2).setGridDrawTicks(true).setGridDrawBorder(false)
									  .setGridZeroLineColor(true).setLabelString("IM Y AXIS").setLabelDisplay(true)
									  .setLabelFontStyle("italic").setLabelFontColor(true).setTicksDisplay(true)
									  .setTicksFontColor(true).setTicksReverse(false).BuildY();
			#endregion
			//ChartJs LineChart = ChartJsBuilder.createLineChart().setAnimation(Animation.easeInElastic).addDataset(lineRadarDataset2).addDataset(lineRadarDataset1).setXAxes(xAxis).setYAxes(yAxis).Build();
			//ChartJs RadarChart = ChartJsBuilder.createRadarChart().addDataset(lineRadarDataset1).setAnimation(Animation.easeInElastic).addDataset(lineRadarDataset2).setXAxes(xAxis).setYAxes(yAxis).Build();
			ChartJs BarChart = ChartJsBuilder.createBarChart().setAnimation(Animation.easeOutCubic).addDataset(barDataset1).addDataset(barDataset2).setXAxes(xAxis).setYAxes(yAxis).Build();
			//ChartJs PieChart = ChartJsBuilder.createPieChart().addDataset(PieDoughnutDataset1).addDataset(PieDoughnutDataset2).setXAxes(xAxis).setYAxes(yAxis).Build();
			//ChartJs DoughnutChart = ChartJsBuilder.createDoughnutChart().addDataset(PieDoughnutDataset1).addDataset(PieDoughnutDataset2).setXAxes(xAxis).setYAxes(yAxis).Build();
			//ChartJs BubbleChart = ChartJsBuilder.createBubbleChart().addDataset(bubbleDataset1).addDataset(bubbleDataset2).setXAxes(xAxis).setYAxes(yAxis).Build();
		}

	}
}
