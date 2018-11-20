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
            radioButtonDec.Checked = calculator.inputMode == InputMode.DEC; // always true; rises radioButtonDec.CheckChanged event (which calls updateKeyboardLayout())
            radioButtonQWord.Checked = calculator.inputLength == InputLength.QWORD; // always true; rises radioButtonQWord.CheckChanged event (which calls updateBitDisplay())
        }
    }
}
