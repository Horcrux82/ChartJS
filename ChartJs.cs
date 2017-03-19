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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJSLib
{
	
	 /// <summary>Enumeration for ChartType
	 /// Each enum is a different type of chart. Used in constructor of ChartJs.
	 /// Consequently, ChartJs is the parent of all the different chart classes
	 /// and this is how a chart is defined and created.</summary>
    public enum ChartType
    {
        bar,
        radar,
        line,
		horizontalBar,
		pie,
		doughnut,
		bubble
    }

	 /// <summary> Enumeration for the Animation
	 /// Each enum is a different type of animation. These are all the possible animations
	 /// possible on a ChartJS graph, taken from the ChartJS <summary/>
    public enum Animation
    {
        linear, easeInQuad, easeOutQuad, easeInOutQuad, easeInCubic, easeOutCubic, easeInOutCubic, easeInQuart, easeOutQuart, easeInOutQuart, easeInQuint, easeOutQuint, easeInOutQuint, easeInSine, easeOutSine, easeInOutSine, easeInExpo, easeOutExpo, easeInOutExpo, easeInCirc, easeOutCirc, easeInOutCirc, easeInElastic, easeOutElastic, easeInOutElastic, easeInBack, easeOutBack, easeInOutBack, easeInBounce, easeOutBounce, easeInOutBounce
    }

	 ///<summary><c>ChartJs</c>class contains all the features that are common between all Charts
	 ///All charts contain a Dataset , an Animation, an X- Axis and a Y-Axis etc..
	 ///It is the parent of all the Charts in this program.</summary>

    public abstract class ChartJs
    {
		const string Outfile = @"/Users/iskandarchacra/Desktop/Bdeir_Project/js/main.js";
		//const string Outfile = @"C:\Users\mb97\Desktop\Trash\js\main.js";

		/// <summary>A list of Datasets. Since each chart has its own dataset, 
		/// a List of Datasets allows the user to have more than one chart
		/// in the same graph</summary>
		List<Dataset> dataSetList;
        string jsTemplate, updatedTemp;
        Animation animation = Animation.easeOutQuart;

		///<summary> Every graph has an x and a y axis
		/// They are of type Scale</summary>
		Scale xAxis, yAxis;


	    /// <summary>The following fields are only for PieChart 
		/// They determine properties that only affect Pie charts and Doughnut charts</summary>
        double _CutoutPercentage;
		double _Circumference = 2 * Math.PI;
		double _Rotation = 0.5 * Math.PI;
		string _AnimateRotate = "false";
		string _AnimateScale = "false";


		 /// <summary>Constructor for <c>ChartJs </c>
		 /// Creates a chart with default settings 
		 /// depending on the ChartType given to it.
		 /// Initiates a few of the fields and initiates others to default value</summary>
		 /// <param name="type">Used to indicate the type of graph being generated</param>
        public ChartJs(ChartType type)
        {
			jsTemplate = ChartJS.Properties.Resources.jsTemplate;
			dataSetList = new List<Dataset>();
			xAxis = new xAxes(AxesType.linear);
			yAxis = new yAxes(AxesType.linear);

            updatedTemp = jsTemplate.Replace("{type}", type.ToString());
        }
  		

		/// <summary>
		/// Adds a dataset to the dataSetList variable.
		/// </summary>
		/// <param name="d">Dataset to be added to the list of datasets</param>
		public void addDataset(Dataset d)
		{
			dataSetList.Add(d);
		}
		/// <summary>
		/// Adds a list of datasets to the dataset list.
		/// Uses the function <c>addDataset</c> in order 
		/// add more than one dataset at a time 
		/// </summary>
		/// <param name="datasets">A list of Dataset</param>
   		public void addDatasets(List<Dataset> datasets)
		{
			datasets.ForEach(p =>
			{
				addDataset(p);
			});
		}
		/// <summary>
		/// Setter that sets the animation of the Chart
		/// </summary>
		/// <param name="animation">Enum Animation used to determine the animation being used</param>
        internal void setAnimation(Animation animation)
        {
            this.animation = animation;
        }

		/// <summary>
		/// Setter that sets the x axis
		/// </summary>
		/// <param name="x">Scale x used to determine the x axis of the chart</param>
		public void setXAxis(Scale x)
		{
			xAxis = x;
		}
		/// <summary>
		/// Sets the Y A-xis.
		/// </summary>
		/// <param name="y">The y axis.</param>
		public void setYAxes(Scale y)
		{
			yAxis = y;
		}
		#region OPTIONS METHODS
		/// <summary>
		/// Used in Pie and Doughnut Charts.
		/// Cuts out percentage from the chart
		/// </summary>
		/// <param name="amount">Amount being cut out </param>
		public virtual void cutoutPercentage(double amount) { this._CutoutPercentage = 0; }
		/// <summary>
		/// Used in Pie and Doughnut Charts.
		/// Determines the circumference of the chart
		/// </summary>
		/// <param name="x">Size of the circumference</param>
		public virtual void circumference(double x) { this._Circumference = 2 * Math.PI; }
		/// <summary>
		/// Used in Pie and Doughnut Charts
		/// Determines the degrees the chart is rotated
		/// </summary>
		/// <param name="x">The amount of rotation</param>
		public virtual void rotation(double x) { this._Rotation = -0.5 * Math.PI; }
		/// <summary>
		/// Animates the rotate.
		/// </summary>
		/// <param name="b">If set to <c>true</c> the rotation is animated.</param>
		public virtual void animateRotate(bool b) { this._AnimateRotate = "false"; }
		/// <summary>
		/// Animates the scale.
		/// </summary>
		/// <param name="b">If set to <c>true</c> b.</param>
		public virtual void animateScale(bool b) { this._AnimateScale = "false"; }
		/// <summary>
		/// Sets the cutout percentage.
		/// </summary>
		/// <param name="x">Amount being cut out.</param>
		public void setCutoutPercentage(double x) { this._CutoutPercentage = x; }
		/// <summary>
		/// Sets the circumference.
		/// </summary>
		/// <param name="x">How large the circumference is.</param>
		public void setCircumference(double x) { this._Circumference = x; }
		/// <summary>
		/// Sets the rotation.
		/// </summary>
		/// <param name="x">The amount rotated</param>
		public void setRotation(double x) { this._Rotation = x; }
		/// <summary>
		/// Sets the rotation animation
		/// </summary>
		/// <param name="b">The animation rotation</param>
		public void setAnimateRotate(string b) { this._AnimateRotate = b; }
		/// <summary>
		/// Sets the animate scale.
		/// </summary>
		/// <param name="b">The blue component.</param>
		public void setAnimateScale(string b) { this._AnimateScale = b; }
		#endregion

		/// <summary>
		/// Create an instance of Chart.
		/// This method overrwrites the JS template and the result is a graph.
		/// After doing all modifications to the graph, this function must be called
		/// to give a result.
		/// </summary>
		public void create()
		{
			updatedTemp = updatedTemp.Replace("{animation}", animation.ToString());
			updatedTemp = updatedTemp.Replace("{cutoutPercentage}", _CutoutPercentage.ToString());
			updatedTemp = updatedTemp.Replace("{animateRotate}", _AnimateRotate);
			updatedTemp = updatedTemp.Replace("{animateScale}", _AnimateScale);
			updatedTemp = updatedTemp.Replace("{circumference}", _Circumference.ToString());
			updatedTemp = updatedTemp.Replace("{rotation}", _Rotation.ToString());
			updatedTemp = updatedTemp.Replace("{labels}", dataSetList[0].labels);
			for (int i = 0; i < dataSetList.Count(); i++)
			{
				updatedTemp = updatedTemp.Replace("{dataset}", dataSetList[i].product);
			}
			updatedTemp = updatedTemp.Replace("{dataset}", "");
			updatedTemp = updatedTemp.Replace("{xAxes}", xAxis.xProduct);
			updatedTemp = updatedTemp.Replace("{yAxes}", yAxis.yProduct);
			File.WriteAllText(Outfile, updatedTemp);
        }

    }
}
