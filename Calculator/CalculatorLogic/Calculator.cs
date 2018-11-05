using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLogic
{
    public class Calculator
    {
        public Calculator()
        {
            result = 0;
            inputMode = InputMode.DEC;
            inputLength = InputLength.QWORD;
        }

        public string displayValue
        {
            get
            {
                string retVal = "";
                switch(inputMode)
                {
                    case InputMode.BIN:
                        retVal = Convert.ToString(result, 2);
                        break;
                    case InputMode.OCT:
                        retVal = Convert.ToString(result, 8);
                        break;
                    case InputMode.DEC:
                        retVal = result.ToString();
                        break;
                    case InputMode.HEX:
                        retVal = Convert.ToString(result, 16);
                        break;
                }

                switch(inputLength)
                {
                    case InputLength.BYTE:
                        if (retVal.Length > 8) retVal = retVal.Substring(retVal.Length - 8, 8);
                        break;
                    case InputLength.WORD:
                        if (retVal.Length > 16) retVal = retVal.Substring(retVal.Length - 16, 16);
                        break;
                    case InputLength.DWORD:
                        if (retVal.Length > 32) retVal = retVal.Substring(retVal.Length - 32, 32);
                        break;
                }

                return retVal;
            }
        }
        public InputMode inputMode { get; set; }
        public InputLength inputLength { get; set; }
        public Int64 result;
    }
}
