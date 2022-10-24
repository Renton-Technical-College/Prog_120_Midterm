using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_120_Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Since you will have multiple menus I am giving you a basic menu to start with to keep things organized.
            // Your four seperate apps will be built in the method blocks below.

            // You still need to add the goto / labels, display the information, and change the cases here to make a starting menu.

            // Change this, it will start by selecting the calculator app.
            string placeholder = "1";

            switch(placeholder)
            {
                case "1":
                    Calculator();
                    break;
                case "2":
                    FinancialCalculator();
                    break;
                case "3":
                    GeometryCalculator();
                    break;
                case "4":
                    CartesianPlane();
                    break;
            }

        } // Main


        // ------- 
        public static void Calculator()
        {
            // Write calculator menu and code here
            Console.WriteLine("Calculator");
        } // Calculator

        public static void FinancialCalculator()
        {
            // Write Financial Calculator menu and code here

        } // FinancialCalculator

        public static void GeometryCalculator()
        {
            // Write Geometry Calcualator Menu and code here

        } // GeometryCalculator

        public static void CartesianPlane()
        {
            // Write Caresian Plane and code here
        } // CartesianPlane



    } // class

} // namespace
