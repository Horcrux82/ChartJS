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
	/*
	 *This class extends the class ChartJS and
	 *is used to create two types of Bar Charts, 
	 *a horizontal Bar Chart and a vertical Bar Chart
	 *
	 *This will be used in the ChartJsBuilder class 
	 */
	public class BarChart: ChartJs
	{
		/*
		 *Constructor of Bar Chart, constructs Bar Chart from parent ChartJs
		 *@param enum ChartType 
		 */
		private BarChart(ChartType type) : base(type){}

		/*
		 * Method uses the BarChart with bar enum as parameter
		 * @return a columns bar chart (bars are vertical)
		 */
		public static BarChart createColumnsChart()
		{
			return new BarChart(ChartType.bar);
		}
		/*
		 * Method uses the BarChart with horizontalBar enum as parameter
		 * @return a horizontal bar chart
		 */
		public static BarChart createBarChart()
		{
			return new BarChart(ChartType.horizontalBar);
		}	
	}
}
