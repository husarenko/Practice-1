using System.ComponentModel;

namespace WinFormsControlLibrary1
{
    [ToolboxBitmap(@"E:\2024@II\Net\Practice1\Practice1\WinFormsControlLibrary1\Icon1.ico")]
    public partial class Practice1 : UserControl
    {
        //Зазначення мінімальних та максимальних значень для введення
        private double minValue = 0;
        private double maxValue = 100;

        public double MinValue
        {
            get { return minValue; }
            set { minValue = value; }
        }

        public double MaxValue
        {
            get { return maxValue; }
            set { maxValue = value; }
        }

        public Practice1()
        {
            InitializeComponent();
            Input.TextChanged += new EventHandler(this.textBox1_TextChanged);
        }

        //Зміна стану індикатора при певному значенні в Input полі
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(Input.Text, out double value))
            {
                if (value < MinValue || value > MaxValue)
                {
                    Indicator.Text = "Value out of range!";
                    Indicator.ForeColor = Color.Red;
                    Indicator.Visible = true;
                }
                else
                {
                    Indicator.Visible = false;
                }
            }
            else
            {
                Indicator.Text = "Invalid input!";
                Indicator.ForeColor = Color.Red;
                Indicator.Visible = true;
            }
        }
    }
}
