using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace lab7
{

    class Program
    {
        static string calc2(string a, int len)
        {

            int b;
            int c;
            int d;
            int e;
            
            int l;
            
            
            b = a.IndexOf("sin");
            c = a.IndexOf("cos");
            d = a.IndexOf("tan");
            e = a.IndexOf("cot");

            //Console.WriteLine(d);
            //Console.WriteLine(e);
            //Console.WriteLine(b);
            //Console.WriteLine(lenstr);
            if (b!=-1)
            {
                string qq;
                
                int h;
                int j;
                h = a.IndexOf("(");
                j = a.LastIndexOf(")");
                
                l = a.Length;
                if (h == -1)
                {
                    h = c;
                }
                if (j == -1)
                {
                    j = len;
                }
                
                qq = calc2(a[(h+1)..(j )],l);
                a =a.Remove((h-3),(j+1));
                a = a.Insert((b), qq);
                c = -1;
                double x;
                string gv1 = ",";
                string vg1 = ".";
                a = a.Replace(gv1, vg1);
                a = new DataTable().Compute(a, "").ToString();
                double z = double.Parse(a);
                x = Math.Sin(z);
                x = Math.Round(x, 3);
                a = x.ToString();
                


            }
            b = a.IndexOf("sin");
            c = a.IndexOf("cos");
            d = a.IndexOf("tan");
            e = a.IndexOf("cot");

            if (c == -1 & d == -1 & e == -1)
            {
                
            }
            if (c != -1)
            {
                string qq;
                int h;
                int j;
                h = a.IndexOf("(");
                j = a.LastIndexOf(")");
                l = a.Length;
                if (h==-1)
                {
                    h = c;
                }
                if (j == -1)
                {
                    j = len;
                }
                qq = calc2(a[(h + 1)..(j)], l);
                a = a.Remove((h - 3), (j+1));
                a = a.Insert((c), qq);
                b = -1;
                double x;
                string gv1 = ",";
                string vg1 = ".";
                a = a.Replace(gv1, vg1);
                a = new DataTable().Compute(a, "").ToString();
                double z = double.Parse(a);
                x = Math.Cos(z);
                x = Math.Round(x, 3);
                a = x.ToString();
                

            }
            b = a.IndexOf("sin");
            c = a.IndexOf("cos");
            d = a.IndexOf("tan");
            e = a.IndexOf("cot");
            if (b == -1  & d == -1 & e == -1)
            {
                
            }
            if (d != -1)
            {
                string qq;
                int h;
                int j;
                h = a.IndexOf("(");
                j = a.LastIndexOf(")");
                l = a.Length;
                
                if (h == -1)
                {
                    h = c;
                }
                if (j == -1)
                {
                    j = len;
                }
                if (d != -1)
                {
                    qq = calc2(a[(h + 1)..(j)], l);
                    a = a.Remove((h - 3), (j + 1));
                    a = a.Insert((d), qq);
                }
                b = -1;
                c = -1;
                e = -1;
                b = a.IndexOf("sin");
                c = a.IndexOf("cos");
                d = a.IndexOf("tan");
                e = a.IndexOf("cot");
                double x;
                string gv1 = ",";
                string vg1 = ".";
                a = a.Replace(gv1, vg1);
                if (d == -1)
                {
                    a = new DataTable().Compute(a, "").ToString();
                    double z = double.Parse(a);
                    x = Math.Tan(z);
                    x = Math.Round(x, 3);
                    a = x.ToString();
                }

            }
            b = a.IndexOf("sin");
            c = a.IndexOf("cos");
            d = a.IndexOf("tan");
            e = a.IndexOf("cot");
            if (b == -1 & c == -1 & d == -1 & e == -1)
            {
                
            }
            if (e != -1)
            {
                string qq;
                int h;
                int j;
                h = a.IndexOf("(");
                j = a.LastIndexOf(")");
                l = a.Length;
                if (h == -1)
                {
                    h = c;
                }
                if (j == -1)
                {
                    j = len;
                }
                qq = calc2(a[(h + 1)..(j)], l);
                a = a.Remove((h - 3), (j + 1));
                a = a.Insert((e), qq);
                b = -1;
                c = -1;
                d = -1;
                double x;
                string gv1 = ",";
                string vg1 = ".";
                a = a.Replace(gv1, vg1);
                a = new DataTable().Compute(a, "").ToString();
                double z = double.Parse(a);
                x = 1 / Math.Tan(z);
                x = Math.Round(x, 3);
                a = x.ToString();
                


            }
            b = a.IndexOf("sin");
            c = a.IndexOf("cos");
            d = a.IndexOf("tan");
            e = a.IndexOf("cot");
            if (b == -1 & c == -1 & d == -1 & e == -1)
            {
                
            }

            string gv = ",";
            string vg = ".";
            a=a.Replace  (gv,vg);
            Console.WriteLine(a);
            a = new DataTable().Compute(a, "").ToString();
            
            return a;
        }
        static void calc1(string a)
        {
            Console.WriteLine( "result = " + new DataTable().Compute(a, "").ToString());
        }
        static void Main(string[] args)
        {
            string a;
            a=Console.ReadLine();
            
            
            a=calc2(a,a.Length);
            Console.WriteLine(a);
            a = a.Replace("pi", "3.145");
            a = a.Replace("e", "2.718");
            //calc1(a);

            
        }
    }
}
