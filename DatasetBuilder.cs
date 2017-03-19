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

namespace ChartJSLib
{
	
	public class DatasetBuilder
	{
		static Dataset dataSet;

		public static DatasetBuilder createDataset(String dataLabel)
		{
			dataSet = new Dataset(dataLabel);
			return new DatasetBuilder();
		}

		public DatasetBuilder setFill(string s)
		{
			dataSet.setFill(s);
			return this;
		}
		public DatasetBuilder setLineTension(double n)
		{
			dataSet.setLineTension(n);
			return this;
		}
		public DatasetBuilder setPointBorderColor(Boolean b)
		{
			dataSet.setPointBorderColor(b);
			return this;
		}
		public DatasetBuilder setPointBackgroundColor(Boolean b)
		{
			dataSet.setPointBackgroundColor(b);
			return this;
		}
		public DatasetBuilder setPointBorderWidth(int x)
		{
			dataSet.setPointBorderWidth(x);
			return this;
		}
		public DatasetBuilder setPointHoverBackgroundColor(Boolean b)
		{
			dataSet.setPointHoverBackgroundColor(b);
			return this;
		}
		public DatasetBuilder setPointHoverBorderColor(Boolean b)
		{
			dataSet.setPointHoverBorderColor(b);
			return this;
		}
		public DatasetBuilder setPointHoverBorderWidth(int n)
		{
			dataSet.setPointHoverBorderWidth(n);
			return this;
		}
		public DatasetBuilder setShowLine(Boolean show)
		{
			dataSet.setShowLine(show);
			return this;
		}
		public DatasetBuilder setHoverBackColor(Boolean b)
		{
			dataSet.setHoverBackColor(b);
			return this;
		}
		public DatasetBuilder setHoverBordColor(Boolean b)
		{
			dataSet.setHoverBordColor(b);
			return this;
		}
		public DatasetBuilder setBorderWidth(int bordWidth)
		{
			dataSet.setBorderWidth(bordWidth);
			return this;
		}
		public DatasetBuilder setHoverBorderWidth(int hoverWidth)
		{
			dataSet.setHoverBorderWidth(hoverWidth);
			return this;
		}

		public DatasetBuilder setBackGroundColor(Boolean b)
		{
			dataSet.setBackGroundColor(b);
			return this;
		}
		public DatasetBuilder addBubblePoint(BubblePoint p)
		{
			dataSet.addBubblePoint(p);
			return this;
		}
		public DatasetBuilder isBubble(Boolean b)
		{
			dataSet.isBubble(b);
			return this;
		}
		public DatasetBuilder addPoint(Point p)
		{
			dataSet.addPoint(p);
			return this;
		}
		public DatasetBuilder addPoint(int value, string label)
		{
			dataSet.addPoint(new Point(value, label));
			return this;
		}
		public DatasetBuilder addPoints(string csvPoints)
		{
			dataSet.addPoints(csvPoints);
			return this;
		}
		public DatasetBuilder addPoints(List<Point> points)
		{
			dataSet.addPoints(points);
			return this;
		}
		public DatasetBuilder setBorderColor(Boolean b)
		{
			dataSet.setBorderColor(b);
			return this;
		}
		//public DatasetBuilder sortPoints(Boolean b)
		//{
		//	dataSet.sortPoints(b);
		//	return this;
		//}
		public Dataset Build()
		{
			dataSet.create();
			return dataSet;
		}
	}
}
