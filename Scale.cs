/*
 *Author: Iskandar Chacra
 *Since; 2016-10-10
 *Version: 1.0
 *This project was inspired and supervised by Mr. Mahmoud Bdeir 
 *Instructor, Department of Computer Science
 *American University of Beirut
 */

using System;
namespace ChartJSLib
{
	public enum axisType
	{
		category, linear, logarithmic, time, radialLinear

	}

	/*
	 * CLASS SCALE

	 */

	/// <summary>
	/// Scale.
	///This class is parent of the Y axis and the X axis.
	/// Since X axis and Y axis have the same fields, they inherit these fields
	///from parent class Scale
	/// X axis class implements createX() function
	/// Y axis class implements createY() function
	/// </summary>
	public abstract class Scale
	{
		public string axisDisplay = "true";
		public string gridColor = "'rgba(0, 0, 0, 0.1)'";
		public int gridBorderDash;
		public int gridLineWidth = 1;
		public string gridDrawBorder = "true";
		public string gridDrawOnChart = "true";
		public string gridDrawTicks = "true";
		public int gridTickMarkLength = 10;
		public int gridZeroLineWidth = 1;
		public string gridZeroLineColor = "'rgba(0, 0, 0, 0.25)'";
		public string labelDisplay = "false";
		public string labelString;
		public string labelFontColor = "#666";
		public string labelFontFamily = "'Helvetica Neue', 'Helvetica', 'Arial', sans-serif";
		public int labelFontSize = 12;
		public string labelFontStyle = "normal";
		public string ticksAutoSkip = "true";
		public int ticksAutoSkipPadding = 0;
		public string ticksDisplay = "true";
		public string ticksFontColor = "#666";
		public string ticksFontFamily = "'Helvetica Neue', 'Helvetica', 'Arial', sans-serif";
		public int ticksFontSize = 12;
		public string ticksFontStyle = "normal";
		public int ticksLabelOffset = 0;
		public int ticksMaxRotation = 90;
		public int ticksMinRotation = 0;
		public string ticksMirror = "false";
		public int ticksPadding = 10;
		public string ticksReverse = "false";

		public string scaleType;
		public string position;
		public string stacked = "false";

		public string xProduct, yProduct = "";

		/// <summary>
		/// Sets the axis display.
		/// </summary>
		/// <param name="b">If set to <c>true</c> the axis is displayed.</param>
		public void setAxisDisplay(bool b)
		{
			if (b)
				axisDisplay = "true";
			else
				axisDisplay = "false";
		}
		public void setGridColor(bool b)
		{
			if (b)
			{
				Random rnd = new Random();				
				int x1 = rnd.Next(1, 256);
				int y1 = rnd.Next(1, 256);
				int z1 = rnd.Next(1, 256);
				gridColor = "'rgba(" + x1 + ", " + y1 + ", " + z1 + ", " + "0.5)'";
			}
		}
		/// <summary>
		/// Sets the grid border dash.
		/// </summary>
		/// <param name="dash">The length and spacing of dashes.</param>
		public void setGridBorderDash(int dash)
		{
			gridBorderDash = dash;
		}
		/// <summary>
		/// Sets the width of the grid line.
		/// </summary>
		/// <param name="x">The width.</param>
		public void setGridLineWidth(int width)
		{
			gridLineWidth = width;
		}
		/// <summary>
		/// Sets the grid draw border.
		/// </summary>
		/// <param name="b">If set to <c>true</c> the grid border is shown</param>
		public void setGridDrawBorder(bool b)
		{
			if(b)
				gridDrawBorder = "true";
			else
				gridDrawBorder = "false";
		}
		/// <summary>
		/// Sets the grid draw on chart.
		/// </summary>
		/// <param name="b">If set to <c>true</c> draws grid on chart</param>
		public void setGridDrawOnChart(bool b)
		{
			if (b)
				gridDrawOnChart = "true";
			else
				gridDrawOnChart = "false";
		}
		/// <summary>
		/// Sets the grid draw ticks.
		/// </summary>
		/// <param name="b">If set to <c>true</c> ticks are drawn on grid</param>
		public void setGridDrawTicks(bool b)
		{
			if (b)
				gridDrawTicks = "true";
			else
				gridDrawTicks = "false";
		}
		/// <summary>
		/// Sets the length of the grid tick mark.
		/// </summary>
		/// <param name="length">The length of tick mark.</param>
		public void setGridTickMarkLength(int length)
		{
			gridTickMarkLength = length;
		}
		/// <summary>
		/// Sets the width of the grid zero line.
		/// </summary>
		/// <param name="x">Stroke width of the grid line for the first index</param>
		public void setGridZeroLineWidth(int x)
		{
			gridZeroLineWidth = x;
		}
		/// <summary>
		/// Sets the color of the grid zero line.
		/// </summary>
		/// <param name="b">If set to <c>true</c> gives zero line a random color.</param>
		public void setGridZeroLineColor(bool b)
		{
			if(b)	{
				Random rnd = new Random();
				int x1 = rnd.Next(1, 256);
				int y1 = rnd.Next(1, 256);
				int z1 = rnd.Next(1, 256);
				gridZeroLineColor = "'rgba(" + x1 + ", " + y1 + ", " + z1 + ", " + "0.5)'";
			}
		}
		/// <summary>
		/// Sets the label display.
		/// </summary>
		/// <param name="b">If set to <c>true</c> label is displayed.</param>
		public void setLabelDisplay(bool b)
		{
			if (b)
				labelDisplay = "true";
			else
				labelDisplay = "false";
		}
		/// <summary>
		/// Sets the size of the label font.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		public void setLabelFontSize(int x)
		{
			labelFontSize = x;
		}
		/// <summary>
		/// Sets the label custom name
		/// </summary>
		/// <param name="s">The label's custom name</param>
		public void setLabelString(string s)
		{
			labelString = s;
		}
		/// <summary>
		/// Sets the color of the label font.
		/// </summary>
		/// <param name="b">If set to <c>true</c> label is given a random color</param>
		public void setLabelFontColor(bool b)
		{	
			if(b)
			{
				Random rnd = new Random();
				int x1 = rnd.Next(1, 256);
				int y1 = rnd.Next(1, 256);
				int z1 = rnd.Next(1, 256);
				labelFontColor = "'rgba(" + x1 + ", " + y1 + ", " + z1 + ", " + "0.5)'";
			}
		}
		/// <summary>
		/// Sets the label font family.
		/// </summary>
		/// <param name="s">The font family of the label</param>
		public void setLabelFontFamily(String s)
		{
			labelFontFamily = s;
		}
		/// <summary>
		/// Sets the label font style.
		/// </summary>
		/// <param name="s">The font style chosen to be used</param>
		public void setLabelFontStyle(string s)
		{
			labelFontStyle = s;
		}
		/// <summary>
		/// Sets the ticks auto skip.
		/// </summary>
		/// <param name="b">If set to <c>true</c> ticks are skipped</param>
		public void setTicksAutoSkip(bool b)
		{
			if (b)
				ticksAutoSkip = "true";
			else
				ticksAutoSkip = "false";
		}
		/// <summary>
		/// Sets the ticks auto skip padding.
		/// </summary>
		/// <param name="x">Padding between the ticks on the horizontal axis</param>
		public void setTicksAutoSkipPadding(int x)
		{
			ticksAutoSkipPadding = x;
		}
		/// <summary>
		/// Sets the ticks display.
		/// </summary>
		/// <param name="b">If set to <c>true</c> ticks are displayed.</param>
		public void setTicksDisplay(bool b)
		{
			if (b)
				ticksDisplay = "true";
			else
				ticksDisplay = "false";
		}
		/// <summary>
		/// Sets the color of the ticks.
		/// </summary>
		/// <param name="b">If set to <c>true</c> ticks are given a random color</param>
		public void setTicksFontColor(bool b)
		{
			if(b){
				Random rnd = new Random();
				int x1 = rnd.Next(1, 256);
				int y1 = rnd.Next(1, 256);
				int z1 = rnd.Next(1, 256);
				ticksFontColor = "'rgba(" + x1 + ", " + y1 + ", " + z1 + ", " + "0.5)'";
			}
		}
		/// <summary>
		/// Sets the ticks font family.
		/// </summary>
		/// <param name="s">The font family for ticks</param>
		public void setTicksFontFamily(string s)
		{
			ticksFontFamily = s;
		}
		/// <summary>
		/// Distance in pixels to offset the label from the centre point of the tick (in the y direction for the x axis, and the x direction for the y axis). 
		/// Note: this can cause labels at the edges to be cropped by the edge of the canvas
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		public void setTicksLabelOffset(int x)
		{
			ticksLabelOffset = x;
		}
		/// <summary>
		/// Maximum rotation for tick labels when rotating to condense labels. Note: Rotation doesn't occur until necessary. 
		/// Note: Only applicable to horizontal scales.
		/// </summary>
		/// <param name="x">Max rotations.</param>
		public void setTicksMaxRotation(int x)
		{
			ticksMaxRotation = x;
		}
		/// <summary>
		/// Minimum rotation for tick labels. Note: Only applicable to horizontal scales.
		/// </summary>
		/// <param name="x">Min rotations</param>
		public void setTicksMinRotation(int x)
		{
			ticksMinRotation = x;
		}
		/// <summary>
		/// Flips tick labels around axis, displaying the labels inside the chart instead of outside. 
		/// Note: Only applicable to vertical scales.
		/// </summary>
		/// <param name="b">If set to <c>true</c> displays labels inside chart.</param>
		public void setTicksMirror(bool b)
		{
			if (b)
				ticksMirror = "true";
			else
				ticksMirror = "false";
		}
		/// <summary>
		/// Padding between the tick label and the axis. Note: Only applicable to horizontal scales.
		/// </summary>
		/// <param name="x">Amount of padding</param>
		public void setTicksPadding(int x)
		{
			ticksPadding = x;
		}
		/// <summary>
		/// Reverses order of tick labels.
		/// </summary>
		/// <param name="b">If set to <c>true</c> reverses the order of tick labels.</param>
		public void setTicksReverse(bool b)
		{
			if (b)
				ticksReverse = "true";
			else
				ticksReverse = "false";
		}
		/// <summary>
		/// Sets the position of the axis
		/// </summary>
		/// <param name="s">Position of the scale. Possible values are 'top', 'left', 'bottom' and 'right'.</param>
		public void setaxisPosition(string s)
		{
			position = s;
		}
		/// <summary>
		/// Sets the stacked.
		/// </summary>
		/// <param name="b">If set to <c>true</c> bars are stacked on the axis</param>
		public void setStacked(bool b)
		{
			if (b)
				stacked = "true";
			else
				stacked = "false";
		}
		/// <summary>
		/// Creates the x - axis.
		/// Used by child class xAxis
		/// </summary>
		public abstract void createX();
		/// <summary>
		/// Creates the y-axis.
		/// Used by child class yAxis
		/// </summary>
		public abstract void createY();
	}
}
