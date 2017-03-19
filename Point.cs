/*
 *Author: Iskandar Chacra
 *Since; 2016-10-10
 *Version: 1.0
 *This project was inspired and supervised by Mr. Mahmoud Bdeir 
 *Instructor, Department of Computer Science
 *American University of Beirut
 */

namespace ChartJSLib
{
    public class Point
    {
        private float value;
        private string label;

        public Point(float value = 0, string label = "default label")
        {
            this.value = value;
            this.label = label;
        }
        public void setValue(float value)
        {
            this.value = value;
        }
        public void setLabel(string label)
        {
            this.label = label;
        }
        public float getValue()
        {
            return value;
        }
        public string getLabel()
        {
            return label;
        }
    }

}
