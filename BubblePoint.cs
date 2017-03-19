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
	/* 
	 * This class is an object of type bubble point. A bubble point 
	 * is a specific type of point used in a bubble graph.
	 *
	 * Bubble points differ from the basic Point because it 
	 * it takes x , y , and r values in order to be plotted.
	 * 
	 * */
	public class BubblePoint
	{
		
		private float x, y, r;

		/*
		 * Constructor for Bubble Point
		 * Creates a bubble point given an x-axis value, a y-axis value
		 * and a radius to determine size of circle
		 * @param float x, float y, and float r. r has default value 15 
		 * */
		public BubblePoint(float x = 0, float y = 0, float r = 15)
		{
			this.x = x;
			this.y = y;
			this.r = r;
		}

		/*
		 * Setter for global variable x
		 * Sets the x-axis value of the bubble point to given value
		 * @param float x 
		 * */
		public void setX(float x)
		{
			this.x = x;
		}
		/*
		 * Setter for global variable y
		 * Sets the y-axis value of the bubble point to given value
		 * @param float y
		 * */
		public void setY(float y)
		{
			this.y = y;
		}
		/*
		 * Setter for global variable r
		 * Sets the radius value of the bubble point to given value
		 * @param float r
		 * */
		public void setR(float r)
		{
			this.r = r;
		}
		/*
		 * Getter for x
		 * @return float value of x-axis
		 * */
		public float getX()
		{
			return x;
		}
		/*
		 * Getter for y
		 * @return float value of y-axis
		 * */
		public float getY()
		{
			return y;
		}
		/*
		 * Getter for r
		 * @return float value of radius
		 * */
		public float getR()
		{
			return r;
		}
	}
}
