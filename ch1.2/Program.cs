using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 後端作業1

{

    internal class Program
    {
        static void Main(string[] args)
        {
            //1-1寫一程式，輸入a,b,c,d，計算((𝑎+𝑏))/ ((𝑐−𝑑))×2。
            //Console.WriteLine("輸入a");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入b");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入c");
            //double c = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入d");
            //double d = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入的值為:");
            //Console.WriteLine("a=" + a);
            //Console.WriteLine("b=" + b);
            //Console.WriteLine("c=" + c);
            //Console.WriteLine("d=" + d);
            //double z = ((a + b) / (c - d)) * 2;
            //Console.WriteLine("z=(a + b) / (c - d) * 2");
            //Console.WriteLine("計算結果 z =" + z);
            //Console.ReadKey();

            //1-2此組方程式的解如下：
            //x = ((𝑐1𝑏2−𝑐2𝑏1))/ ((𝑎1𝑏2−𝑎2𝑏1))  ，  y = ((𝑐1𝑎2−𝑐2𝑎1))/ ((𝑏1𝑎2−𝑎1𝑏2))
            //Console.WriteLine("輸入a1");
            //double a1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入b1");
            //double b1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入c1");
            //double c1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入a2");
            //double a2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入b2");
            //double b2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入c2");
            //double c2 = Convert.ToDouble(Console.ReadLine());
            //double x = (c1 * b2 - c2 * b1) / (a1 * b2 - a2 * b1);
            //Console.WriteLine("a1x+b1y=c1");
            //Console.WriteLine($"x = {x}");
            //double y = (c1 * a2 - c2 * a1) / (b1 * a2 - a1 * b2);
            //Console.WriteLine("a2x+b2y=c2");
            //Console.WriteLine($"y = {y}");
            //Console.ReadKey();

            //1-3輸入a和b，求： y = (𝑎2 +𝑏2)/ (𝑎2−𝑏2)---->Math.Pow(a, 2)是平方
            //Console.WriteLine("輸入a");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入b");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("問題假設 y = (a2 + b2)/ (a2 - b2) = ");
            //// 計算 a^2 和 b^2
            //Console.WriteLine("a2="+ Math.Pow(a, 2));
            //Console.WriteLine("b2=" + Math.Pow(b, 2));
            //double a2 = Math.Pow(a, 2);
            //double b2 = Math.Pow(b, 2);
            //// 計算分子分母
            //double c = a2 + b2;
            //double d = a2 - b2;
            //Console.WriteLine("a2 + b2 = " + c);
            //Console.WriteLine("a2 - b2 = " + d);
            //// 計算 y
            //double y = c/d;
            //// 輸出結果
            //Console.WriteLine($"y = {y}");
            //Console.ReadKey();
            //($"y = {y}")是甚麼意思---->$插值字串 {y}變數 y  假設 y 值是 5，那麼 ($"y = {y}") 會生成字串 "y = 5"

            //1-4輸入a和b，求y= √(𝑎2+𝑏2)---->Math.Sqrt(a * a)是√
            //Console.WriteLine("輸入a");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入b");
            //double b = Convert.ToDouble(Console.ReadLine());
            //double y = Math.Sqrt(a * a + b * b);
            //Console.WriteLine($"√(a2+b2)={y}");
            //Console.ReadKey();

            //1-5輸入a、b和c，求：y = a - (b + c)(3a - c)
            //Console.WriteLine("輸入a");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入b");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入c");
            //double c = Convert.ToDouble(Console.ReadLine());
            //double y = a - (b + c) * (3 * a - c);
            //Console.WriteLine("y = a - (b + c) * (3 * a - c) = " + y);
            //Console.ReadKey();

            //1 - 6請隨意輸入正負數，取絕對值輸出--->Math.Abs(number)絕對值
            //Console.WriteLine("輸入正負數，取絕對值");
            //double b = Convert.ToDouble(Console.ReadLine());
            //// 計算絕對值
            //double a = Math.Abs(b);
            //// 輸出結果
            //Console.WriteLine("絕對值為: " + a);
            //Console.ReadKey();


            //1 - 7輸入的西元年份轉換成民國年份後輸出
            //Console.WriteLine("西元年份轉換成民國年份");
            //Console.WriteLine("請輸入想轉換的西元年份？");
            //int y = Convert.ToInt16(Console.ReadLine());
            //int z = y - 1911;
            //Console.WriteLine("西元" + y +"年 = 民國" + z+"年");
            //Console.ReadKey();

            // 1-8請輸入身高體重，輸出BMI 
            // BMI＝體重(公斤)÷身高(公尺)÷身高(公尺)--->ToString轉換為字串類型
            //Console.WriteLine("過輕:低於 18.5");
            //Console.WriteLine("正常範圍：18.5 - 24.9");
            //Console.WriteLine("超重25 - 29.9");
            //Console.WriteLine("肥胖：30 及以上");
            //Console.WriteLine("輸入身高(公尺)");
            //double height = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入體重(公斤)");
            //double weight = Convert.ToDouble(Console.ReadLine());
            //double bmi = weight / (height * height);
            //Console.WriteLine("BMI＝體重÷身高÷身高 ="+bmi.ToString("F2"));
            //Console.ReadKey();

            //2-1輸入x和y，如果x>=y，則列印x，否則列印y
            //Console.WriteLine("輸入x");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入y");
            //double y = Convert.ToDouble(Console.ReadLine());
            //if (x >= y)
            //{
            //    Console.WriteLine($"{x}較大");
            //}
            //else
            //{
            //    Console.WriteLine($"{y}較大");
            //}
            //Console.ReadKey();

            //2-2輸入x和y，如果x和y都是正數，令z = 1，如兩者均為負數，令z = -1，否則令z = 0
            //---->& 和
            //Console.WriteLine("輸入x");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入y");
            //double y = Convert.ToDouble(Console.ReadLine());
            //double z;
            //if (x > 0 & y > 0)
            //{
            //    z = 1;
            //}
            //else if (x < 0 & y < 0)
            //{
            //    z = -1;
            //}
            //else
            //{
            //    z = 0;
            //}
            //Console.WriteLine($"z 的值是: {z}");
            //Console.ReadKey();

            //2 - 3輸入x、y、u、v，如果(x + y) > (u + v)，則令z = x + y，否則令z = u + v
            //Console.WriteLine("輸入x");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入y");
            //double y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入u");
            //double u = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入v");
            //double v = Convert.ToDouble(Console.ReadLine());
            //double z;
            //if ((x + y) > (u + v))
            //{
            //    z = x + y;
            //}
            //else
            //{
            //    z = u + v;
            //}
            //Console.WriteLine($"z值{z}");
            //Console.ReadKey();

            //2-4輸入x、y、u、v，如果((𝑥+𝑦))/((𝑢+𝑣))>=2，令z=x+y，否則令z=u+v。
            //Console.WriteLine("輸入x");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入y");
            //double y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入u");
            //double u = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入v");
            //double v = Convert.ToDouble(Console.ReadLine());
            //double z;
            //if (((x + y) / (u + v)) >= 2)
            //{
            //    z = x + y;
            //}
            //else
            //{
            //    z = u + v;
            //}
            //Console.WriteLine($"z值{z}");
            //Console.ReadKey();

            //2-5輸入x和y，如果x >= y，令z = x2，否則令z = y2
            //Console.WriteLine("輸入x");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入y");
            //double y = Convert.ToDouble(Console.ReadLine());
            //double z;
            //if (x >= y)
            //{
            //    z = x * x;
            //}
            //else
            //{
            //    z = y * y;
            //}
            //Console.WriteLine($"z值{z}");
            //Console.ReadKey();

            //2-6流程圖
            Console.WriteLine("讀入income");
            double income = Convert.ToDouble(Console.ReadLine());
            double rate = 0;
            double difference = 0;

            if (income > 4090000)
            {
                rate = 0.4;
                difference = 721100;
            }
            else if (income > 2180000)
            {
                rate = 0.3;
                difference = 312100;
            }
            else if (income > 1090000)
            {
                rate = 0.21;
                difference = 115900;
            }
            else if (income > 410000)
            {
                rate = 0.13;
                difference = 28700;
            }
            else
            {
                rate = 0.06;
                difference = 0;
            }
            double tax = (income * rate) - difference;
            Console.WriteLine($"tax={tax}");
            Console.ReadKey();


            //2-7流程圖
            Console.WriteLine("輸入x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("輸入y");
            double y = Convert.ToDouble(Console.ReadLine());
            if (x > 0)
            {
                if (y > 0) { Console.WriteLine("1st quadrant\n"); }
                else if (y == 0) { Console.WriteLine("x-axis\n"); }
                else { Console.WriteLine("4th quadrant\n"); }
            }
            else if (x == 0)
            {
                if (y == 0) { Console.WriteLine("origin\n"); }
                else { Console.WriteLine("y-axis\n"); }
            }
            else
            {
                if (y > 0) { Console.WriteLine("2nd quadrant\n"); }
                else if (y == 0) { Console.WriteLine("x-axis\n"); }
                else { Console.WriteLine("3th quadrant\n"); }
            }
            Console.ReadKey();

            //補充1
            //Console.WriteLine("請輸入答對題數");
            //double a =Convert.ToDouble(Console.ReadLine());
            //double z = 0;
            //if (a >= 0 && a <= 10)
            //{
            //    z = a * 6; // 0~10 題，每題 6 分
            //}
            //else if (a >= 11 && a <= 20)
            //{
            //    z = 60 + a * 2; // 前10題 6分，之後的2分
            //}
            //else if (a >= 21 && a <= 40)
            //{
            //    z = 80 + a * 1; // 前10題 6分，接著10題 2分，之後的1分
            //}
            //else if (a > 40)
            //{
            //    z = 100; // 超過40題一律100分
            //}
            //Console.WriteLine($"得分: {z}");
            //Console.ReadKey();

            //補充2請輸入身高體重，輸出BMI並顯示這樣的BMI是正常還是過輕、過重。
            //BMI＝體重(公斤)÷身高(公尺)÷身高(公尺)--->ToString轉換為字串類型
            //else if 部分應正確處理條件判斷，而 else 不應該帶有條件，應該改為 else if。
            //Console.WriteLine("輸入身高(公尺)");
            //double height = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入體重(公斤)");
            //double weight = Convert.ToDouble(Console.ReadLine());
            //double bmi = weight / (height * height);
            //Console.WriteLine("BMI＝體重÷身高÷身高 =" + bmi.ToString("F2"));
            //if (bmi < 18.5)
            //{
            //    Console.WriteLine("過輕:低於 18.5");
            //}
            //else if (bmi >=18.5 & bmi<= 24.9)
            //{
            //    Console.WriteLine("正常範圍：18.5 - 24.9");
            //}
            //else if(bmi >= 25 & bmi<=29.9)
            //{
            //    Console.WriteLine("超重25 - 29.9");
            //}
            //else if(bmi >= 30) 
            //{
            //    Console.WriteLine("肥胖：30 及以上");
            //}
            //Console.ReadKey();

            //補充3請隨意輸入三個數，請由大到小依序印出。
            //-->放入陣列 numbers。Array.Sort()陣列排序小到大。Array.Reverse()陣列反轉大到小。foreach 迴圈
            //num 是一個變數從 numbers 陣列中依次取出每個數字（num）
            //Console.WriteLine("輸入x");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入y");
            //double y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("輸入z");
            //double z = Convert.ToDouble(Console.ReadLine());
            //double[] numbers = {x, y, z};
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //Console.WriteLine("大到小");
            //foreach (double num in numbers)
            //{
            //Console.WriteLine(num);
            //}
            //Console.ReadKey();

            //補充4企業發放的獎金根據利潤提成
            //a 這個變數名稱通常用來表示“利潤”
            //Console.WriteLine("輸入當月利潤(萬)");
            //double a =Convert.ToDouble(Console.ReadLine());
            //double c =0;//c這個變數名稱通常用來表示“獎金”
            //if (a <= 10)
            //{
            //    c =a * 0.1;
            //}
            //else if(a<=20)
            //{
            //    c = 10 * 0.1 + (a-10)*0.075;
            //}
            //else if (a <=40)
            //{
            //    c = 10 * 0.1 + 10 * 0.075 + (a-20)*0.05;
            //}
            //else if (a <=60)
            //{
            //    c = 10 * 0.1 + 10 * 0.075 + 20 * 0.05 + (a-40)*0.01;
            //}
            //else if (a <=100) 
            //{
            //    c = 10 * 0.1 + 10 * 0.075 + 20 * 0.05 + 40 * 0.01 + (a-60)*0.015;
            //}
            //else if (a > 100)
            //{
            //    c = 10 * 0.1 + 10 * 0.075 + 20 * 0.05 + 20 * 0.01 + 20* 0.015 + (a-100) * 0.01;
            //}
            //Console.WriteLine($"發放獎金為:{c}萬元");
            //Console.ReadKey();


            //增加一題,使用switch改寫：輸入一個學生的分數，輸出該成績級別
            //Console.WriteLine("請輸入學生分數0 到 100");
            //double score = Convert.ToDouble(Console.ReadLine());
            //switch (score / 10)
            //{
            //    case 10://100分
            //    case 9:
            //        Console.WriteLine("成績級別A");
            //        break;
            //    case 8:
            //        Console.WriteLine("成績級別B");
            //        break;
            //    case 7:
            //        Console.WriteLine("成績級別C");
            //        break;
            //    case 6:
            //        Console.WriteLine("成績級別D");
            //        break;
            //    default:
            //        Console.WriteLine("成績級別F");
            //        break;
            //}
            //Console.ReadKey();
        }
    }
}