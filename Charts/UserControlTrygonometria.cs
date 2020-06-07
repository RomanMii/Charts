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
    public partial class UserControlTrygonometria : UserControl,IFunction
    {
        public UserControlTrygonometria()
        {
            InitializeComponent();
            comboBoxFunction.SelectedIndex = 0;
            groupBox1.Name = FunctionName;
        }

        public string FunctionName
        {
            get
            {
                return string.Format("f(x) = {0} {1} {2}x", numericUpDownA.Value, comboBoxFunction.Text,  numericUpDownB.Value);
            }
        }

        public event emptyFunction FunctonChanged;

        public double Value(double x)
        {
            double val = 0;
            switch(comboBoxFunction.Text)
            {
                case "sin":
                    val = (double)(numericUpDownA.Value) * Math.Sin((double)numericUpDownB.Value*x);
                    break;
                case "cos":
                    val = (double)(numericUpDownA.Value) * Math.Cos((double)numericUpDownB.Value*x);
                    break;
                case "tan":
                    val = (double)(numericUpDownA.Value) * Math.Tan((double)numericUpDownB.Value*x);
                    break;
            }
            return val;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            groupBox1.Text = FunctionName;
            if (FunctonChanged != null)
            {
                FunctonChanged();
            }
        }
    }
}
