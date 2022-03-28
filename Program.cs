/*
 * Created by Maurice Marinus 
 * Date: 2022/03/27
 * Time: 22:15
 * 
 * 
 */
using System;
using System.Drawing;
using System.Windows;
using System.Linq;
using System.Collections.Generic;

namespace Demo0
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int radius = 38;
			Console.WriteLine("Radius: "+radius.ToString());
			List<Tuple<double, double>> pts = new List<Tuple<double, double>>();
			List<double> totals = new List<double>();
			for (double y = radius; y >= 0; y-=0.001) {
				double x = Math.Sqrt(radius*radius - y * y); 
				pts.Add(new Tuple<double, double>(x,y)); 
			}
			 
			for (int i = 1; i <=pts.Count-1 ; i++) {
				
				double x1 = (double)pts[i].Item1;
				double x2 = (double)pts[i-1].Item1;
				
				double y1 = (double)pts[i].Item2;
				double y2 = (double)pts[i-1].Item2;
				
	 			var distance = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
				 
				totals.Add(distance); 
			}
			
			Console.WriteLine("Distance");
			Console.WriteLine("=====================");
			double tot = totals.Sum();
			Console.WriteLine("0-90  degrees: " + tot.ToString());
			Console.WriteLine("0-360 degrees: " + (tot * 4).ToString());
			Console.WriteLine("Pi: (C/d): " + ((tot *4)/(radius*2)).ToString());
			
			Console.WriteLine("Reality. Diameter of 76 should return : ~244 and not "+(tot *4).ToString());
			Console.WriteLine("Proof: https://www.linkedin.com/pulse/who-makes-best-pi-world-maurice-marinus");
			Console.WriteLine("Fix your code");
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}