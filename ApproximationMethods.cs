using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Jace;

namespace MathProject
{
    public static class Approximation
    {
        //Fields
        #region fields
        //...
        #endregion

        //Properties
        #region property
        //...
        #endregion

        //Methods
        #region public methods
        /// <summary>
        /// Euler's method of approximation of an equation with the given values
        /// </summary>
        /// <param name="equation">f(x,y)</param>
        /// <param name="x0">Initial x</param>
        /// <param name="y0">Initial y</param>
        /// <param name="h">Step size</param>
        /// <param name="endPoint">Step end</param>
        /// <returns>List of results for x, y</returns>
        public static List<KeyValuePair<double, double>> EulerMethod(string equation, double x0, double y0, double h, double endPoint)
        {
            var finalResults = new List<KeyValuePair<double, double>>();
            double newX = x0;
            double newY = y0;
            while (newX <= endPoint + h)
            {
                finalResults.Add(new KeyValuePair<double, double>(newX, newY));
                newY += h * CalcEngine(equation, newX, newY);
                newX += h;
            }
            
            return finalResults;
        }
        /// <summary>
        /// Euler method to be used with a list of h values
        /// </summary>
        /// <param name="equation"></param>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        /// <param name="hList"></param>
        /// <param name="endPoint"></param>
        /// <returns>Returns a DataTable to be used in a gridView</returns>
        public static DataTable EulerMethod(string equation, double x0, double y0, List<double> hList, double endPoint)
        {
            hList.Sort(); //Sort so we begin with the smallest h
            var eulerTable = new DataTable();
            eulerTable.Columns.Add("x");
            double fillX = x0;
            while (fillX <= endPoint + hList[0])
            {
                eulerTable.Rows.Add(fillX);
                fillX += hList[0];
            }
            int eulerTableRowCount = eulerTable.Rows.Count;
            foreach (var h in hList)
            {
                eulerTable.Columns.Add(h.ToString());
                var eulerList = EulerMethod(equation, x0, y0, h, endPoint);
                foreach (var result in eulerList)
                {
                    for (int row = 0; row < eulerTableRowCount; row++)
                    {
                        if(Convert.ToDouble(eulerTable.Rows[row]["x"]).ToString("#.000") == result.Key.ToString("#.000"))
                        {
                            eulerTable.Rows[row][h.ToString()] = result.Value;
                        }
                    }
                }
            }

            return eulerTable;
        }

        /// <summary>
        /// Euler's Improved method of approximation of an equation with the given values
        /// </summary>
        /// <param name="equation">String with equation</param>
        /// <param name="x0">Initial x value</param>
        /// <param name="y0">Initial y value</param>
        /// <param name="h">Initial h value</param>
        /// <param name="endPoint">The value where we stop</param>
        /// <returns>Returns list with aproximations</returns>
        public static List<KeyValuePair<double, double>> ImprovedEulerMethod(string equation, double x0, double y0, double h, double endPoint)
        {
            var finalResults = new List<KeyValuePair<double, double>>();
            double newX = x0;
            double newY = y0;
            double resultEuler;


            while (newX <= endPoint + h)
            {
                finalResults.Add(new KeyValuePair<double, double>(newX, newY));
                resultEuler = CalcEngine(equation, newX, newY);
                newX += h;
                newY += h / 2 * (resultEuler + CalcEngine(equation, newX, newY + h * resultEuler));
            }

            return finalResults;
        }
        /// <summary>
        /// Improved Euler method for a list of h values
        /// </summary>
        /// <param name="equation"></param>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        /// <param name="hList"></param>
        /// <param name="endPoint"></param>
        /// <returns>Returns a DataTable to be used in a gridView</returns>
        public static DataTable ImprovedEulerMethod(string equation, double x0, double y0, List<double> hList, double endPoint)
        {
            hList.Sort(); //Sort so we begin with the smallest h
            var eulerTable = new DataTable();
            eulerTable.Columns.Add("x");
            double fillX = x0;
            while (fillX <= endPoint + hList[0])
            {
                eulerTable.Rows.Add(fillX);
                fillX += hList[0];
            }

            int eulerTableRowCount = eulerTable.Rows.Count;
            foreach (var h in hList)
            {
                eulerTable.Columns.Add(h.ToString());
                var eulerList = ImprovedEulerMethod(equation, x0, y0, h, endPoint);
                foreach (var result in eulerList)
                {
                    for (int row = 0; row < eulerTableRowCount; row++)
                    {
                        if (Convert.ToDouble(eulerTable.Rows[row]["x"]).ToString("#.000") == result.Key.ToString("#.000"))
                        {
                            eulerTable.Rows[row][h.ToString()] = result.Value;
                        }
                    }
                }
            }

            return eulerTable;
        }

        /// <summary>
        /// Runge-Kutta's method of approximation of an equation with the given values
        /// </summary>
        /// <param name="equation">String with equation</param>
        /// <param name="x0">Initial x</param>
        /// <param name="y0">Initial y</param>
        /// <param name="h">Initial h</param>
        /// <param name="endPoint">End point</param>
        /// <returns>List with approximations</returns>
        public static List<KeyValuePair<double, double>> RungeKuttaMethod(string equation, double x0, double y0, double h, double endPoint)
        {
            var finalResults = new List<KeyValuePair<double, double>>();
            double newX = x0;
            double newY = y0;
            double resultK1, resultK2, resultK3, resultK4;

            while (newX <= endPoint + h)
            {
                finalResults.Add(new KeyValuePair<double, double>(newX, newY));
                resultK1 = CalcEngine(equation, newX, newY);
                resultK2 = CalcEngine(equation, newX + h / 2, newY + h / 2 * resultK1);
                resultK3 = CalcEngine(equation, newX + h / 2, newY + h / 2 * resultK2);
                resultK4 = CalcEngine(equation, newX + h, newY + h * resultK3);
                newY += h / 6 * (resultK1 + 2 * resultK2 + 2 * resultK3 + resultK4);
                newX += h;
            }

            return finalResults;
        }
        /// <summary>
        /// RungeKutta method to be used with a list of h values
        /// </summary>
        /// <param name="equation"></param>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        /// <param name="hList"></param>
        /// <param name="endPoint"></param>
        /// <returns>Returns a DataTable to be used in a gridView</returns>
        public static DataTable RungeKuttaMethod(string equation, double x0, double y0, List<double> hList, double endPoint)
        {
            hList.Sort(); //Sort so we begin with the smallest h
            var rungeTable = new DataTable();
            rungeTable.Columns.Add("x");
            double fillX = x0;
            while (fillX <= endPoint + hList[0])
            {
                rungeTable.Rows.Add(fillX);
                fillX += hList[0];
            }
            int eulerTableRowCount = rungeTable.Rows.Count;
            foreach (var h in hList)
            {
                rungeTable.Columns.Add(h.ToString());
                var eulerList = RungeKuttaMethod(equation, x0, y0, h, endPoint);
                foreach (var result in eulerList)
                {
                    for (int row = 0; row < eulerTableRowCount; row++)
                    {
                        if (Convert.ToDouble(rungeTable.Rows[row]["x"]).ToString("#.000") == result.Key.ToString("#.000"))
                        {
                            rungeTable.Rows[row][h.ToString()] = result.Value;
                        }
                    }
                }
            }

            return rungeTable;
        }
        #endregion

        #region private methods
        /// <summary>
        /// Calculation engine support method
        /// </summary>
        /// <param name="equation">String with equation</param>
        /// <param name="x">Current x</param>
        /// <param name="y">Current y</param>
        /// <returns>Returns single approximation for values</returns>
        private static double CalcEngine(string equation, double x, double y)
        {
            var myVar = new Dictionary<string, double>();
            myVar.Add("x", x);
            myVar.Add("y", y);

            CalculationEngine engine = new CalculationEngine();
            return engine.Calculate(equation, myVar);
        }
        #endregion
    }

}
