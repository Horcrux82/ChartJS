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
	public class PieChart : ChartJs
	{

		double _CutoutPercentage;
		double _Circumference;
		double _Rotation;
		string _AnimateRotate;
		string _AnimateScale;
		public PieChart( ChartType type) :base (type){
			if (type.ToString() == "doughnut") 
				base.setCutoutPercentage(50);
			else if(type.ToString() == "pie") 
				base.setCutoutPercentage(0);
		}
		public static PieChart createPieChart()
		{
			return new PieChart(ChartType.pie);
		}
		public static PieChart createDoughnutChart()
		{
			return new PieChart(ChartType.doughnut);
		}

		public override void animateRotate(bool b)
		{
			if (b == true)
				_AnimateRotate = "true";
			else
				_AnimateRotate = "false";
			base.setAnimateRotate(_AnimateRotate);
		}
		public override void animateScale(bool b)
		{
			if (b == true)
				_AnimateScale = "true";
			else
				_AnimateScale = "false";
			base.setAnimateScale(_AnimateScale);
		}
		public override void circumference(double x)
		{
			_Circumference = x;
			base.setCircumference(_Circumference);
		}
		public override void cutoutPercentage(double x)
		{
			_CutoutPercentage = x;
			base.setCutoutPercentage(_CutoutPercentage);
		}
		public override void rotation(double x)
		{
			_Rotation = x;
			base.setRotation(_Rotation);
		}
	}
}
