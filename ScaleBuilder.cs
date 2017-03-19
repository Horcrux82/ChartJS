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
	public class ScaleBuilder
	{
		static Scale scale;
		public static ScaleBuilder createLinearXAxes()
		{
			scale = new xAxes(AxesType.linear);
			return new ScaleBuilder();
		}
		public static ScaleBuilder createRadialLinearXAxes()
		{
			scale = new xAxes(AxesType.radialLinear);
			return new ScaleBuilder();
		}
		public static ScaleBuilder createLogarithmicXAxes()
		{
			scale = new xAxes(AxesType.logarithmic);
			return new ScaleBuilder();
		}
		public static ScaleBuilder createCategoryXAxes()
		{
			scale = new xAxes(AxesType.category);
			return new ScaleBuilder();
		}
		public static ScaleBuilder createTimeXAxes()
		{
			scale = new xAxes(AxesType.time);
			return new ScaleBuilder();
		}
		public static ScaleBuilder createLinearYAxes()
		{
			scale = new yAxes(AxesType.linear);
			return new ScaleBuilder();
		}
		public static ScaleBuilder createRadialLinearYAxes()
		{
			scale = new yAxes(AxesType.radialLinear);
			return new ScaleBuilder();
		}
		public static ScaleBuilder createLogarithmicYAxes()
		{
			scale = new yAxes(AxesType.logarithmic);
			return new ScaleBuilder();
		}
		public static ScaleBuilder createCategoryYAxes()
		{
			scale = new yAxes(AxesType.category);
			return new ScaleBuilder();
		}
		public static ScaleBuilder createTimeYAxes()
		{
			scale = new yAxes(AxesType.time);
			return new ScaleBuilder();
		}

		public ScaleBuilder setAxesDisplay(bool b)
		{
			scale.setAxesDisplay(b);
			return this;
		}

		public ScaleBuilder setGridColor(bool b)
		{
			scale.setGridColor(b);
			return this;
		}

		public ScaleBuilder setGridBorderDash(int x)
		{
			scale.setGridBorderDash(x);
			return this;
		}
		public ScaleBuilder setGridLineWidth(int x)
		{
			scale.setGridLineWidth(x);
			return this;
		}
		public ScaleBuilder setGridDrawBorder(bool b)
		{
			scale.setGridDrawBorder(b);
			return this;
		}

		public ScaleBuilder setGridDrawOnChart(bool b)
		{
			scale.setGridDrawOnChart(b);
			return this;
		}

		public ScaleBuilder setGridDrawTicks(bool b)
		{
			scale.setGridDrawTicks(b);
			return this;
		}

		public ScaleBuilder setGridTickMarkLength(int x)
		{
			scale.setGridTickMarkLength(x);
			return this;
		}

		public ScaleBuilder setGridZeroLineWidth(int x)
		{
			scale.setGridZeroLineWidth(x);
			return this;
		}

		public ScaleBuilder setGridZeroLineColor(bool b)
		{
			scale.setGridZeroLineColor(b);
			return this;
		}

		public ScaleBuilder setLabelDisplay(bool b)
		{
			scale.setLabelDisplay(b);
			return this;
		}

		public ScaleBuilder setLabelString(string s)
		{
			scale.setLabelString(s);
			return this;
		}

		public ScaleBuilder setLabelFontColor(bool b)
		{
			scale.setLabelFontColor(b);
			return this;
		}

		public ScaleBuilder setLabelFontFamily(String s)
		{
			scale.setLabelFontFamily(s);
			return this;
		}

		public ScaleBuilder setTicksAutoSkip(bool b)
		{
			scale.setTicksAutoSkip(b);
			return this;
		}

		public ScaleBuilder setTicksAutoSkipPadding(int x)
		{
			scale.setTicksAutoSkipPadding(x);
			return this;
		}

		public ScaleBuilder setTicksDisplay(bool b)
		{
			scale.setTicksDisplay(b);
			return this;
		}

		public ScaleBuilder setTicksFontColor(bool b)
		{
			scale.setTicksFontColor(b);
			return this;
		}

		public ScaleBuilder setTicksFontFamily(string s)
		{
			scale.setTicksFontFamily(s);
			return this;
		}
		public ScaleBuilder setTicksLabelOffset(int x)
		{
			scale.setTicksLabelOffset(x);
			return this;
		}
		public ScaleBuilder setTicksMaxRotation(int x)
		{
			scale.setTicksMaxRotation(x);
			return this;
		}

		public ScaleBuilder setTicksMinRotation(int x)
		{
			scale.setTicksMinRotation(x);
			return this;
		}

		public ScaleBuilder setTicksMirror(bool b)
		{
			scale.setTicksMirror(b);
			return this;
		}
		public ScaleBuilder setTicksPadding(int x)
		{
			scale.setTicksPadding(x);
			return this;
		}
		public ScaleBuilder setTicksReverse(bool b)
		{
			scale.setTicksReverse(b);
			return this;
		}

		public ScaleBuilder setAxesPosition(string s)
		{
			scale.setAxesPosition(s);
			return this;
		}

		public ScaleBuilder setStacked(bool b)
		{
			scale.setStacked(b);
			return this;
		}
		public ScaleBuilder setLabelFontSize(int x)
		{
			scale.setLabelFontSize(x);
			return this;
		}
		public ScaleBuilder setLabelFontStyle(String s)
		{
			scale.setLabelFontStyle(s);
			return this;
		}
		public Scale BuildX()
		{
			scale.createX();
			return scale;
		}

		public Scale BuildY()
		{
			scale.createY();
			return scale;
		}
	}
}
