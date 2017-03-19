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

namespace ChartJSLib
{
	public class Dataset
	{
		Boolean sort, bubble = false;
		string backGroundColor = "";
		string hoverBackColor = "";
		string hoverBordColor = "";
		string hoverBordWidth = "";
		public string label;
		public string labels;
		string borderWidth;
		string values = "";
		string _Fill = "false";
		double _LineTension;
		string _BorderColor = "";
		string _PointBorderColor = "";
		string _PointBackgroundColor = "";
		string _PointBorderWidth = "";
		string _PointHoverBackgroundColor = "";
		string _PointHoverBorderColor = "";
		string _PointHoverBorderWidth = "";
		string _ShowLine = "true";
		List<Point> pointList;
		List<BubblePoint> bubblePointList;
		public string product = "";
		Boolean bPointBorderColor, bBackgroundColor, bHoverBackColor, bHoverBordColor, bShowLine,
		bBorderColor, bPointBackgroundColor, bPointHoverBackgroundColor, bPointHoverBorderColor;
		private static Random rnd;
		private static readonly object syncLock = new object();
		
		public Dataset(String dataLabel)
		{
			this.label = dataLabel;
			pointList = new List<Point>();
			bubblePointList = new List<BubblePoint>();
			rnd = new Random(DateTime.Now.Millisecond);
		}
		public void create()
		{
			#region COLORS
			if (bPointBorderColor)
			{
				_PointBorderColor = generateRandomColors(_PointBorderColor);
			}
			if (bBackgroundColor)
			{
				if (!bubble)
					backGroundColor = generateRandomColors(backGroundColor);
				else
					backGroundColor = generateRandomBubbleColors(backGroundColor);
			}
			if (bHoverBackColor)
			{
				if (!bubble)
					hoverBackColor = generateRandomColors(hoverBackColor);
				else
					hoverBackColor = generateRandomBubbleColors(hoverBackColor);
			}
			if (bHoverBordColor)
			{
				if (!bubble)
					hoverBordColor = generateRandomColors(hoverBordColor);
				else
					hoverBordColor = generateRandomBubbleColors(hoverBordColor);
			}
			if (bBorderColor)
			{
				if (!bubble)
				{
					
					int x1 = getRandomNumber();
					int y1 = getRandomNumber();
					int z1 = getRandomNumber();
					_BorderColor = "'rgba(" + x1 + ", " + y1 + ", " + z1 + ", " + "0.5)'";
				}
				else
					_BorderColor = generateRandomBubbleColors(_BorderColor);
			}
			if (bPointBackgroundColor)
			{
				_PointBackgroundColor = generateRandomColors(_PointBackgroundColor);
			}
			if (bPointHoverBackgroundColor)
			{
				_PointHoverBackgroundColor = generateRandomColors(_PointHoverBackgroundColor);
			}
			if (bPointHoverBorderColor)
			{
				_PointHoverBorderColor = generateRandomColors(_PointHoverBorderColor);
			}
			if (bShowLine)
			{
				_ShowLine = "true";
			}
			#endregion
			//if (sort)
			//{
			//	pointList.Sort();
			//}
			if (!bubble)
			{
				labels = "\"";
				labels += string.Join("\",\"", pointList.Select(x => x.getLabel()));
				labels += "\"";
				values = string.Join(",", pointList.Select(x => x.getValue()));
			}
			else 
			{ 
				labels = "";
				for (int i = 0; i < bubblePointList.Count() ; i++)
				{
					values += "{\n\tx: " + bubblePointList[i].getX() + ", y: " + bubblePointList[i].getY() + ", r: " + bubblePointList[i].getR() + "\n},\n";	
				}
			}

			product = "{\nlabel: ['" + label + "'],\nfill: " + _Fill + ",\nlineTension: " + _LineTension + ",\nbackgroundColor: [" + backGroundColor
				+ "],\nborderColor: [" + _BorderColor + "],\nborderWidth: [" + borderWidth + "],\npointBorderColor:[" + _PointBorderColor + "],\npointBackgroundColor:["
				+ _PointBackgroundColor + "],\npointBorderWidth:[" + _PointBorderWidth + "],\npointHoverBackgroundColor:[" + _PointHoverBackgroundColor + "],\npointHoverBorderColor:[\n" +
				_PointHoverBorderColor + "],\npointHoverBorderWidth:[" + _PointHoverBorderWidth + "],\nshowLine:" + _ShowLine + ",\nhoverBackgroundColor:[" + hoverBackColor + "],\nhoverBorderColor:[" +
				hoverBordColor + "],\nhoverBorderWidth:[" + hoverBordWidth + "],\ndata:[" + values + "]},{dataset}\n";
		}
		public void setFill(string s)
		{
			this._Fill = s;
		}
		public void setLineTension(double n)
		{
			this._LineTension = n;
		}
		public void setPointBorderColor(Boolean b)
		{
			bPointBorderColor = b;
		}
		public void setPointBackgroundColor(Boolean b)
		{
			bPointBackgroundColor = b;
		}
		public void setPointBorderWidth(int x)
		{
			_PointBorderWidth = "";
			for (int i = 0; i < pointList.Count - 1; i++)
			{
				_PointBorderWidth += x + ", ";
			}
			_PointBorderWidth += x;

		}
		public void setPointHoverBackgroundColor(Boolean b)
		{
			bPointHoverBackgroundColor = b;
		}
		public void setPointHoverBorderColor(Boolean b)
		{
			bPointHoverBorderColor = b;
		}
		public void setPointHoverBorderWidth(int n)
		{
			this._PointHoverBorderWidth = "";
			for (int i = 0; i < pointList.Count - 1; i++)
			{
				_PointHoverBorderWidth += n + ", ";
			}
			_PointHoverBorderWidth += n;
		}
		public void setShowLine(Boolean show)
		{
			bShowLine = show;
		}
		public void setHoverBackColor(Boolean b)
		{
			bHoverBackColor = b;
		}
		public void setHoverBordColor(Boolean b)
		{
			bHoverBordColor = b;
		}
		public void setBorderWidth(int bordWidth)
		{
			borderWidth = "";
			for (int i = 0; i < pointList.Count - 1; i++)
			{
				borderWidth += bordWidth + ", ";
			}
			borderWidth += bordWidth;
		}
		public void setHoverBorderWidth(int hoverWidth)
		{
			hoverBordWidth = "";
			for (int i = 0; i < pointList.Count - 1; i++)
			{
				hoverBordWidth += hoverWidth + ", ";
			}
			hoverBordWidth += hoverWidth;
		}

		public void setBackGroundColor(Boolean b)
		{
			bBackgroundColor = b;
		}
		public void setBorderColor(Boolean b)
		{
			bBorderColor = b;
		}
		public void addPoint(int value, string label)
		{
			pointList.Add(new Point(value, label));
		}
		public void addPoint(Point p)
		{
			pointList.Add(p);
		}

		public void addPoints(List<Point> points)
		{
			points.ForEach(p =>
			{
				addPoint(p);
			});
		}
		public void addPoints(string csvPoints)
		{
			var points = csvPoints.Split(new char[] { ',' });
			for (int i = 0; i < points.Length; i++)
			{
				addPoint(new Point(float.Parse(points[i]), points[++i]));
			}
		}
		public void addBubblePoint(BubblePoint p)
		{
			bubblePointList.Add(p);
		}

		public void addBubblePoint(int x, int y, int r)
		{
			bubblePointList.Add(new BubblePoint(x, y, r));
		}

		public void isBubble(Boolean b)
		{
			bubble = b;
		}

		public string generateRandomColors(String s)
		{
			s = "";
			for (int i = 0; i < pointList.Count - 1; i++)
			{
				int x = getRandomNumber();
				int y = getRandomNumber();
				int z = getRandomNumber();
				s += "'rgba(" + x + ", " + y + ", " + z + ", " + "0.5)',\n";
			}
			int x1 = getRandomNumber();
			int y1 = getRandomNumber();
			int z1 = getRandomNumber();
			s += "'rgba(" + x1 + ", " + y1 + ", " + z1 + ", " + "0.5)'";
			return s;
		}

		public string generateRandomBubbleColors(String s)
		{
			s = "";
			int x = getRandomNumber();
			int y = getRandomNumber();
			int z = getRandomNumber();
			for (int i = 0; i < bubblePointList.Count - 1; i++)
			{
				
				s += "'rgba(" + x + ", " + y + ", " + z + ", " + "0.5)',\n";
			}

			s += "'rgba(" + x + ", " + y + ", " + z + ", " + "0.5)'";		
			return s;
		}

		public int getRandomNumber()
		{
			return IntUtil.Random(1, 256);
		}
		//public void sortPoints(Boolean sort)
		//{
		//	this.sort = sort;
		//}
	}
}
