//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ChartJSLib
//{
//    public class jsChart
//    {
//        const string FileDirectory = @"C:\Users\mb97\Desktop\Trash\template.txt";
//        const string Outfile = @"C:\Users\mb97\Desktop\Trash\js\main.js";

//        public enum ChartType
//        {
//            bar,
//            radar,
//            line
//        }
//        //use a generic list name it Points, this list should take as a data type of its elements your own class (label, value)

//        public void GenerateChart(ChartType type, string title, float[] dataPoints, string[] dataPointLabels, int borderWidth = 1, bool showLabels = false)
//        {
//            string jsTemplate = File.ReadAllText(FileDirectory);
//            string data = string.Join(", ", dataPoints);
//            string labels = string.Join(",", dataPointLabels.Select(x => string.Format("'{0}'", x)));
//            string width = borderWidth + "";
//            string colors = generateRandomColors(dataPoints.Length);
//            string s = jsTemplate.Replace("{type}", type.ToString()).Replace("{datasetlabel}", title).Replace("{datapoints}", data).Replace("{labels}", labels).Replace("{borderwidth}", width).Replace("{backgroundcolor}", colors);
//            File.WriteAllText(Outfile, s);
//        }

//        public void GenerateChart(ChartType type, string title, int borderWidth = 1, bool showLabels = false)
//        {
//            //todo not implemented
//            throw new NotImplementedException();

//            //todo implement the showLabels

//            //todo implement showing value on hover
//        }

//        public string generateRandomColors(int size)
//        {
//            string result = "";
//            Random rnd = new Random();
//            for (int i = 0; i < size; i++)
//            {
//                int x = rnd.Next(1, 256);
//                int y = rnd.Next(1, 256);
//                int z = rnd.Next(1, 256);
//                result += "'rgba(" + x + ", " + y + ", " + z + ", " + "0.5)',\n";
//            }
//            int x1 = rnd.Next(1, 256);
//            int y1 = rnd.Next(1, 256);
//            int z1 = rnd.Next(1, 256);
//            result += "'rgba(" + x1 + ", " + y1 + ", " + z1 + ", " + "0.2)'";
//            return result;
//        }
//    }
//}
