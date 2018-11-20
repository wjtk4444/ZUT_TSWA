using System;
using CalculatorLogic;

namespace CalculatorGUI
{
    partial class FormMainWindow
    {
        private void radioButtonHex_CheckedChanged(object sender, EventArgs e)
        {
            calculator.inputMode = InputMode.HEX;
            updadeKeyboardLayout();
        }

        private void radioButtonDec_CheckedChanged(object sender, EventArgs e)
        {
            calculator.inputMode = InputMode.DEC;
            updadeKeyboardLayout();
        }

        private void radioButtonOct_CheckedChanged(object sender, EventArgs e)
        {
            calculator.inputMode = InputMode.OCT;
            updadeKeyboardLayout();
        }

        private void radioButtonBin_CheckedChanged(object sender, EventArgs e)
        {
            calculator.inputMode = InputMode.BIN;
            updadeKeyboardLayout();
        }

        void updadeKeyboardLayout()
        {
            // 0 and 1 is always enabled
            button2.Enabled = calculator.inputMode > InputMode.BIN;
            button3.Enabled = calculator.inputMode > InputMode.BIN;
            button4.Enabled = calculator.inputMode > InputMode.BIN;
            button5.Enabled = calculator.inputMode > InputMode.BIN;
            button6.Enabled = calculator.inputMode > InputMode.BIN;
            button7.Enabled = calculator.inputMode > InputMode.BIN;
            button8.Enabled = calculator.inputMode > InputMode.OCT;
            button9.Enabled = calculator.inputMode > InputMode.OCT;
            buttonA.Enabled = calculator.inputMode > InputMode.DEC;
            buttonB.Enabled = calculator.inputMode > InputMode.DEC;
            buttonC.Enabled = calculator.inputMode > InputMode.DEC;
            buttonD.Enabled = calculator.inputMode > InputMode.DEC;
            buttonE.Enabled = calculator.inputMode > InputMode.DEC;
            buttonF.Enabled = calculator.inputMode > InputMode.DEC;
        }
    }
}
