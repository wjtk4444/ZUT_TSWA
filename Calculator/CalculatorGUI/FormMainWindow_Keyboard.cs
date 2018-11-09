using System;
using System.Windows.Forms;
using CalculatorLogic;

namespace CalculatorGUI
{
    partial class FormMainWindow
    {
        private void radioButtonHex_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is RadioButton))
                return;

            calculator.inputMode = InputMode.HEX;
            updateInputMethodAndLengthGUI();
        }

        private void radioButtonDec_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is RadioButton))
                return;

            calculator.inputMode = InputMode.DEC;
            updateInputMethodAndLengthGUI();
        }

        private void radioButtonOct_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is RadioButton))
                return;

            calculator.inputMode = InputMode.OCT;
            updateInputMethodAndLengthGUI();
        }

        private void radioButtonBin_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is RadioButton))
                return;

            calculator.inputMode = InputMode.BIN;
            updateInputMethodAndLengthGUI();
        }

        void updateInputMethodAndLengthGUI()
        {
            radioButtonQWord.Checked = calculator.inputLength == InputLength.QWORD;
            radioButtonDWord.Checked = calculator.inputLength == InputLength.DWORD;
            radioButtonWord.Checked = calculator.inputLength == InputLength.WORD;
            radioButtonByte.Checked = calculator.inputLength == InputLength.BYTE;

            radioButtonHex.Checked = calculator.inputMode == InputMode.HEX;
            radioButtonDec.Checked = calculator.inputMode == InputMode.DEC;
            radioButtonOct.Checked = calculator.inputMode == InputMode.OCT;
            radioButtonBin.Checked = calculator.inputMode == InputMode.BIN;

            // enable all buttons
            foreach (Control c in panelKeyboard.Controls)
                if (c is Button)
                    c.Enabled = true;

            switch(calculator.inputMode)
            {
                case InputMode.BIN:
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;

                    // buttons [8,9]
                    button9.Enabled = false;
                    button8.Enabled = false;
                    
                    // block A-F
                    buttonA.Enabled = false;
                    buttonB.Enabled = false;
                    buttonC.Enabled = false;
                    buttonD.Enabled = false;
                    buttonE.Enabled = false;
                    buttonF.Enabled = false;
                    break;


                case InputMode.OCT:
                    // buttons [8,9]
                    button9.Enabled = false;
                    button8.Enabled = false;

                    // block A-F
                    buttonA.Enabled = false;
                    buttonB.Enabled = false;
                    buttonC.Enabled = false;
                    buttonD.Enabled = false;
                    buttonE.Enabled = false;
                    buttonF.Enabled = false;
                    break;

                case InputMode.DEC:
                    // block A-F
                    buttonA.Enabled = false;
                    buttonB.Enabled = false;
                    buttonC.Enabled = false;
                    buttonD.Enabled = false;
                    buttonE.Enabled = false;
                    buttonF.Enabled = false;
                    break;

                case InputMode.HEX:
                    // do nothing
                    break;
            }
        }
    }
}
