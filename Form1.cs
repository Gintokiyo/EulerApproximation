using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void buttonCalcMain_Click(object sender, EventArgs e)
        {
            errorCheckDyDx.Invoke(new Action(() => errorCheckDyDx.Text = ""));

            string dxdy = fEquationMain.Text;
            double x0 = Convert.ToDouble(xValueMain.Text);
            double y0 = Convert.ToDouble(yValueMain.Text);
            var hList = new List<double>();
            string hString = hValueMain.Text;
            string h = "";
            foreach (var character in hString)
            {
                if (character == ';')
                {
                    hList.Add(Convert.ToDouble(h));
                    h = "";
                }
                if (character != ' ' && character != ';') h += character;
            }
            if (h != "") hList.Add(Convert.ToDouble(h)); //We add the last stragler value in case string didn't end in ;
            double endPoint = Convert.ToDouble(endPointValueMain.Text);

            var showResultEuler = Approximation.EulerMethod(dxdy, x0, y0, hList, endPoint);
            var showResultImprovEuler = Approximation.ImprovedEulerMethod(dxdy, x0, y0, hList, endPoint);
            var showResultRungeKutta = Approximation.RungeKuttaMethod(dxdy, x0, y0, hList, endPoint);

            dataGridListResultsEuler.DataSource = showResultEuler;
            dataGridListResultsImprovEuler.DataSource = showResultImprovEuler;
            dataGridListResultsRunge.DataSource = showResultRungeKutta;
            hList.Clear();
        }

        private void buttonClearMain_Click(object sender, EventArgs e)
        {
            fEquationMain.Clear();
            xValueMain.Clear();
            yValueMain.Clear();
            hValueMain.Clear();
            endPointValueMain.Clear();
        }
    }
}
