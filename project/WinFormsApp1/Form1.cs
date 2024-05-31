using WinFormsControlLibrary1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            practice11.Left = (this.ClientSize.Width - practice11.Width) / 2;
            practice11.Top = (this.ClientSize.Height - practice11.Height) / 2;
        }

        private void Size(object sender, EventArgs e)
        {
            practice11.Left = (this.ClientSize.Width - practice11.Width) / 2;
            practice11.Top = (this.ClientSize.Height - practice11.Height) / 2;
        }
    }
}
