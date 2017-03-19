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

	public class xAxis : Scale
	{
		public xAxis(xAxis aType) :base()
		{
			xProduct = "";
			position = "bottom";
			scaleType = aType.ToString();
		}
		public override void createX()
		{
				xProduct = "xAxes: [{\ntype: \"" + scaleType + "\",\ndisplay: " + axesDisplay + ",\ngridLines:{\ncolor:[" + gridColor +
				"],\nborderDash:[" + gridBorderDash + "],\nlineWidth: " + gridLineWidth + ",\ndrawBorder: " + gridDrawBorder + ",\ndrawOnChartArea: "
				+ gridDrawOnChart + ",\ndrawTicks: " + gridDrawTicks + ",\ntickMarkLength: " + gridTickMarkLength + ",\nzeroLineWidth: " + gridZeroLineWidth + ",\nzeroLineColor: "
				+ gridZeroLineColor + ",\n},\nscaleLabel:{\ndisplay: " + labelDisplay + ",\nlabelString: \"" + labelString + "\",\nfontColor: \"" + labelFontColor + "\",\nfontFamily: \"" + labelFontFamily + "\",\nfontSize: " +
				+labelFontSize + ",\nfontStyle: \"" + labelFontStyle + "\",\n},\nticks:{\nautoSkip: " + ticksAutoSkip + ",\nautoSkipPadding: " +
				ticksAutoSkipPadding + ",\ndisplay: " + ticksDisplay + ",\nfontColor: \"" + ticksFontColor + "\",\nfontFamily: \"" + ticksFontFamily + "\",\nfontSize: " + ticksFontSize + ",\nfontStyle: \"" + ticksFontStyle +
				"\",\nlabelOffset: " + ticksLabelOffset + ",\nmaxRotation: " + ticksMaxRotation + ",\nminRotation: " + ticksMinRotation + ",\nmirror: " + ticksMirror + ",\npadding: " + ticksPadding + ",\nreverse: " +
				ticksReverse + ",\n},\nposition: \"" + position + "\",\n stacked: " + stacked +",\n}],\n";
			
		}
		public override void createY()
		{
		}
	}
}
