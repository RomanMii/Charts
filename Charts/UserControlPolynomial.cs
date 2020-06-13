using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charts
{
    public partial class UserControlPolynomial : UserControl,IFunction
    {
        public UserControlPolynomial()
        {
            InitializeComponent();
            groupBox.Text = FunctionName;
            arr[0] = (double)numericUpDownA.Value;
            arr[1] = (double)numericUpDownB.Value;
        }

        public string FunctionName
        {
            get
            {
                string name = "f(x) = ";
                int revI = (int)numericUpDown1.Value;
                for (int i = 0; i < numericUpDown1.Value +1; ++i)
                {
                    name += (arr[i].ToString() + "*x^" + revI.ToString() + " + ");
                    revI--;
                }
                return name;
            }
        }

        public event emptyFunction FunctonChanged;
        double[] arr = new double[2];

        public double Value(double x)
        {
            double ans = 0;
            int revI = (int)numericUpDown1.Value;
            for(int i = 0; i < numericUpDown1.Value +1; ++i)
            {
                ans += Math.Pow((arr[i] * x),revI);
                revI--;
            }
            return ans;
        }

        public void refresh()
        {
            groupBox.Text = FunctionName;

            if (FunctonChanged != null)
            {
                FunctonChanged();
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            switch (num.Location.Y)
            {
                case 40:
                    arr[0] = (double)num.Value;
                    break;
                case 62:
                    arr[1] = (double)num.Value;
                    break;
                default:
                    int arrAdress = num.Location.Y / 22 - 1;
                    arr[arrAdress] = (double)num.Value;
                    break;
            }
            refresh();
        }

        int a = 22;
        decimal previousValue = 1;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            arr = new double[(int)numericUpDown1.Value + 1];
            refresh();
            if (numericUpDown1.Value > previousValue)
            {
                for (int i = 0; i < numericUpDown1.Value - previousValue; ++i)
                {
                    NumericUpDown num = new NumericUpDown();
                    num.Size = numericUpDownB.Size;
                    num.ValueChanged += numericUpDown_ValueChanged;
                    num.Location = new Point(numericUpDownB.Location.X, numericUpDownB.Location.Y + a);
                    groupBox.Controls.Add(num);
                    a += 22;
                }
            }
            else
            {
                for (int i = 0; i < previousValue - numericUpDown1.Value; ++i)
                {
                    groupBox.Controls.RemoveAt(groupBox.Controls.Count - 1);
                    a -= 22;
                }
            }
            previousValue = numericUpDown1.Value;
        }
    }
}
