using System.Windows.Forms;
using CalculatorLogic;

namespace CalculatorGUI
{
    public partial class FormMainWindow : Form
    {
        private Calculator calculator;

        public FormMainWindow()
        {
            InitializeComponent();

            calculator = new Calculator();

            // defaults
            textBoxResult.Text = calculator.displayValue;
            updateInputMethodAndLengthGUI();
        }
    }
}
