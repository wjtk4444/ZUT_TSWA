namespace CalculatorGUI
{
    partial class FormMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.panelKeyboard = new System.Windows.Forms.Panel();
            this.panelInputType = new System.Windows.Forms.Panel();
            this.panelInputLength = new System.Windows.Forms.Panel();
            this.radioButtonHex = new System.Windows.Forms.RadioButton();
            this.radioButtonDec = new System.Windows.Forms.RadioButton();
            this.radioButtonOct = new System.Windows.Forms.RadioButton();
            this.radioButtonBin = new System.Windows.Forms.RadioButton();
            this.radioButtonByte = new System.Windows.Forms.RadioButton();
            this.radioButtonWord = new System.Windows.Forms.RadioButton();
            this.radioButtonDWord = new System.Windows.Forms.RadioButton();
            this.radioButtonQWord = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonClearEntry = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSign = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonEvaluate = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonAnd = new System.Windows.Forms.Button();
            this.buttonXor = new System.Windows.Forms.Button();
            this.buttonRsh = new System.Windows.Forms.Button();
            this.buttonRoR = new System.Windows.Forms.Button();
            this.buttonMoD = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.buttonNot = new System.Windows.Forms.Button();
            this.buttonOr = new System.Windows.Forms.Button();
            this.buttonLsh = new System.Windows.Forms.Button();
            this.buttonRoL = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelKeyboard.SuspendLayout();
            this.panelInputType.SuspendLayout();
            this.panelInputLength.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelInputLength);
            this.panelMain.Controls.Add(this.panelInputType);
            this.panelMain.Controls.Add(this.panelKeyboard);
            this.panelMain.Controls.Add(this.textBoxResult);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(584, 442);
            this.panelMain.TabIndex = 1;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(12, 12);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxResult.Size = new System.Drawing.Size(560, 32);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.Text = "0";
            // 
            // panelKeyboard
            // 
            this.panelKeyboard.Controls.Add(this.buttonNot);
            this.panelKeyboard.Controls.Add(this.buttonOr);
            this.panelKeyboard.Controls.Add(this.buttonLsh);
            this.panelKeyboard.Controls.Add(this.buttonRoL);
            this.panelKeyboard.Controls.Add(this.button37);
            this.panelKeyboard.Controls.Add(this.buttonAnd);
            this.panelKeyboard.Controls.Add(this.buttonXor);
            this.panelKeyboard.Controls.Add(this.buttonRsh);
            this.panelKeyboard.Controls.Add(this.buttonRoR);
            this.panelKeyboard.Controls.Add(this.buttonMoD);
            this.panelKeyboard.Controls.Add(this.button31);
            this.panelKeyboard.Controls.Add(this.buttonF);
            this.panelKeyboard.Controls.Add(this.buttonD);
            this.panelKeyboard.Controls.Add(this.buttonE);
            this.panelKeyboard.Controls.Add(this.buttonEvaluate);
            this.panelKeyboard.Controls.Add(this.button0);
            this.panelKeyboard.Controls.Add(this.buttonAdd);
            this.panelKeyboard.Controls.Add(this.buttonC);
            this.panelKeyboard.Controls.Add(this.buttonA);
            this.panelKeyboard.Controls.Add(this.buttonB);
            this.panelKeyboard.Controls.Add(this.buttonDiv);
            this.panelKeyboard.Controls.Add(this.buttonMul);
            this.panelKeyboard.Controls.Add(this.button8);
            this.panelKeyboard.Controls.Add(this.buttonSub);
            this.panelKeyboard.Controls.Add(this.button2);
            this.panelKeyboard.Controls.Add(this.button4);
            this.panelKeyboard.Controls.Add(this.button6);
            this.panelKeyboard.Controls.Add(this.button9);
            this.panelKeyboard.Controls.Add(this.buttonSign);
            this.panelKeyboard.Controls.Add(this.buttonClear);
            this.panelKeyboard.Controls.Add(this.button7);
            this.panelKeyboard.Controls.Add(this.button5);
            this.panelKeyboard.Controls.Add(this.buttonClearEntry);
            this.panelKeyboard.Controls.Add(this.button3);
            this.panelKeyboard.Controls.Add(this.buttonBackspace);
            this.panelKeyboard.Controls.Add(this.button1);
            this.panelKeyboard.Location = new System.Drawing.Point(154, 143);
            this.panelKeyboard.Name = "panelKeyboard";
            this.panelKeyboard.Size = new System.Drawing.Size(418, 287);
            this.panelKeyboard.TabIndex = 1;
            // 
            // panelInputType
            // 
            this.panelInputType.Controls.Add(this.radioButtonBin);
            this.panelInputType.Controls.Add(this.radioButtonOct);
            this.panelInputType.Controls.Add(this.radioButtonDec);
            this.panelInputType.Controls.Add(this.radioButtonHex);
            this.panelInputType.Location = new System.Drawing.Point(12, 143);
            this.panelInputType.Name = "panelInputType";
            this.panelInputType.Size = new System.Drawing.Size(136, 145);
            this.panelInputType.TabIndex = 2;
            // 
            // panelInputLength
            // 
            this.panelInputLength.Controls.Add(this.radioButtonByte);
            this.panelInputLength.Controls.Add(this.radioButtonQWord);
            this.panelInputLength.Controls.Add(this.radioButtonWord);
            this.panelInputLength.Controls.Add(this.radioButtonDWord);
            this.panelInputLength.Location = new System.Drawing.Point(12, 294);
            this.panelInputLength.Name = "panelInputLength";
            this.panelInputLength.Size = new System.Drawing.Size(136, 136);
            this.panelInputLength.TabIndex = 3;
            // 
            // radioButtonHex
            // 
            this.radioButtonHex.AutoSize = true;
            this.radioButtonHex.Location = new System.Drawing.Point(25, 12);
            this.radioButtonHex.Name = "radioButtonHex";
            this.radioButtonHex.Size = new System.Drawing.Size(44, 17);
            this.radioButtonHex.TabIndex = 0;
            this.radioButtonHex.TabStop = true;
            this.radioButtonHex.Text = "Hex";
            this.radioButtonHex.UseVisualStyleBackColor = true;
            // 
            // radioButtonDec
            // 
            this.radioButtonDec.AutoSize = true;
            this.radioButtonDec.Location = new System.Drawing.Point(25, 35);
            this.radioButtonDec.Name = "radioButtonDec";
            this.radioButtonDec.Size = new System.Drawing.Size(45, 17);
            this.radioButtonDec.TabIndex = 1;
            this.radioButtonDec.TabStop = true;
            this.radioButtonDec.Text = "Dec";
            this.radioButtonDec.UseVisualStyleBackColor = true;
            // 
            // radioButtonOct
            // 
            this.radioButtonOct.AutoSize = true;
            this.radioButtonOct.Location = new System.Drawing.Point(25, 58);
            this.radioButtonOct.Name = "radioButtonOct";
            this.radioButtonOct.Size = new System.Drawing.Size(42, 17);
            this.radioButtonOct.TabIndex = 2;
            this.radioButtonOct.TabStop = true;
            this.radioButtonOct.Text = "Oct";
            this.radioButtonOct.UseVisualStyleBackColor = true;
            // 
            // radioButtonBin
            // 
            this.radioButtonBin.AutoSize = true;
            this.radioButtonBin.Location = new System.Drawing.Point(25, 81);
            this.radioButtonBin.Name = "radioButtonBin";
            this.radioButtonBin.Size = new System.Drawing.Size(40, 17);
            this.radioButtonBin.TabIndex = 3;
            this.radioButtonBin.TabStop = true;
            this.radioButtonBin.Text = "Bin";
            this.radioButtonBin.UseVisualStyleBackColor = true;
            // 
            // radioButtonByte
            // 
            this.radioButtonByte.AutoSize = true;
            this.radioButtonByte.Location = new System.Drawing.Point(25, 95);
            this.radioButtonByte.Name = "radioButtonByte";
            this.radioButtonByte.Size = new System.Drawing.Size(53, 17);
            this.radioButtonByte.TabIndex = 7;
            this.radioButtonByte.TabStop = true;
            this.radioButtonByte.Text = "BYTE";
            this.radioButtonByte.UseVisualStyleBackColor = true;
            // 
            // radioButtonWord
            // 
            this.radioButtonWord.AutoSize = true;
            this.radioButtonWord.Location = new System.Drawing.Point(25, 72);
            this.radioButtonWord.Name = "radioButtonWord";
            this.radioButtonWord.Size = new System.Drawing.Size(60, 17);
            this.radioButtonWord.TabIndex = 6;
            this.radioButtonWord.TabStop = true;
            this.radioButtonWord.Text = "WORD";
            this.radioButtonWord.UseVisualStyleBackColor = true;
            // 
            // radioButtonDWord
            // 
            this.radioButtonDWord.AutoSize = true;
            this.radioButtonDWord.Location = new System.Drawing.Point(25, 49);
            this.radioButtonDWord.Name = "radioButtonDWord";
            this.radioButtonDWord.Size = new System.Drawing.Size(68, 17);
            this.radioButtonDWord.TabIndex = 5;
            this.radioButtonDWord.TabStop = true;
            this.radioButtonDWord.Text = "DWORD";
            this.radioButtonDWord.UseVisualStyleBackColor = true;
            // 
            // radioButtonQWord
            // 
            this.radioButtonQWord.AutoSize = true;
            this.radioButtonQWord.Location = new System.Drawing.Point(25, 26);
            this.radioButtonQWord.Name = "radioButtonQWord";
            this.radioButtonQWord.Size = new System.Drawing.Size(68, 17);
            this.radioButtonQWord.TabIndex = 4;
            this.radioButtonQWord.TabStop = true;
            this.radioButtonQWord.Text = "QWORD";
            this.radioButtonQWord.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Location = new System.Drawing.Point(178, 78);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(38, 32);
            this.buttonBackspace.TabIndex = 1;
            this.buttonBackspace.Text = "<-";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(266, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonClearEntry
            // 
            this.buttonClearEntry.Location = new System.Drawing.Point(222, 78);
            this.buttonClearEntry.Name = "buttonClearEntry";
            this.buttonClearEntry.Size = new System.Drawing.Size(38, 32);
            this.buttonClearEntry.TabIndex = 3;
            this.buttonClearEntry.Text = "CE";
            this.buttonClearEntry.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(222, 154);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 32);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(178, 116);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(38, 32);
            this.button7.TabIndex = 5;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(266, 78);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(38, 32);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(310, 78);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(38, 32);
            this.buttonSign.TabIndex = 7;
            this.buttonSign.Text = "±";
            this.buttonSign.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(266, 116);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(38, 32);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(266, 154);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(38, 32);
            this.button6.TabIndex = 9;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(178, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 32);
            this.button4.TabIndex = 10;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(310, 192);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(38, 32);
            this.buttonSub.TabIndex = 12;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(222, 116);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(38, 32);
            this.button8.TabIndex = 13;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(310, 154);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(38, 32);
            this.buttonMul.TabIndex = 14;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(310, 116);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(38, 32);
            this.buttonDiv.TabIndex = 15;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(134, 78);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(38, 32);
            this.buttonB.TabIndex = 16;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(134, 40);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(38, 32);
            this.buttonA.TabIndex = 17;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(134, 116);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(38, 32);
            this.buttonC.TabIndex = 18;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(310, 228);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(38, 32);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(178, 228);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(82, 32);
            this.button0.TabIndex = 20;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            // 
            // buttonEvaluate
            // 
            this.buttonEvaluate.Location = new System.Drawing.Point(354, 190);
            this.buttonEvaluate.Name = "buttonEvaluate";
            this.buttonEvaluate.Size = new System.Drawing.Size(38, 70);
            this.buttonEvaluate.TabIndex = 21;
            this.buttonEvaluate.Text = "=";
            this.buttonEvaluate.UseVisualStyleBackColor = true;
            // 
            // buttonF
            // 
            this.buttonF.Location = new System.Drawing.Point(134, 228);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(38, 32);
            this.buttonF.TabIndex = 24;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = true;
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(134, 154);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(38, 32);
            this.buttonD.TabIndex = 23;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(134, 192);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(38, 32);
            this.buttonE.TabIndex = 22;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            // 
            // buttonAnd
            // 
            this.buttonAnd.Location = new System.Drawing.Point(90, 228);
            this.buttonAnd.Name = "buttonAnd";
            this.buttonAnd.Size = new System.Drawing.Size(38, 32);
            this.buttonAnd.TabIndex = 30;
            this.buttonAnd.Text = "And";
            this.buttonAnd.UseVisualStyleBackColor = true;
            // 
            // buttonXor
            // 
            this.buttonXor.Location = new System.Drawing.Point(90, 154);
            this.buttonXor.Name = "buttonXor";
            this.buttonXor.Size = new System.Drawing.Size(38, 32);
            this.buttonXor.TabIndex = 29;
            this.buttonXor.Text = "Xor";
            this.buttonXor.UseVisualStyleBackColor = true;
            // 
            // buttonRsh
            // 
            this.buttonRsh.Location = new System.Drawing.Point(90, 192);
            this.buttonRsh.Name = "buttonRsh";
            this.buttonRsh.Size = new System.Drawing.Size(38, 32);
            this.buttonRsh.TabIndex = 28;
            this.buttonRsh.Text = "Rsh";
            this.buttonRsh.UseVisualStyleBackColor = true;
            // 
            // buttonRoR
            // 
            this.buttonRoR.Location = new System.Drawing.Point(90, 116);
            this.buttonRoR.Name = "buttonRoR";
            this.buttonRoR.Size = new System.Drawing.Size(38, 32);
            this.buttonRoR.TabIndex = 27;
            this.buttonRoR.Text = "RoR";
            this.buttonRoR.UseVisualStyleBackColor = true;
            // 
            // buttonMoD
            // 
            this.buttonMoD.Location = new System.Drawing.Point(90, 40);
            this.buttonMoD.Name = "buttonMoD";
            this.buttonMoD.Size = new System.Drawing.Size(38, 32);
            this.buttonMoD.TabIndex = 26;
            this.buttonMoD.Text = "MoD";
            this.buttonMoD.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(90, 78);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(38, 32);
            this.button31.TabIndex = 25;
            this.button31.Text = ")";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // buttonNot
            // 
            this.buttonNot.Location = new System.Drawing.Point(46, 228);
            this.buttonNot.Name = "buttonNot";
            this.buttonNot.Size = new System.Drawing.Size(38, 32);
            this.buttonNot.TabIndex = 36;
            this.buttonNot.Text = "Not";
            this.buttonNot.UseVisualStyleBackColor = true;
            // 
            // buttonOr
            // 
            this.buttonOr.Location = new System.Drawing.Point(46, 154);
            this.buttonOr.Name = "buttonOr";
            this.buttonOr.Size = new System.Drawing.Size(38, 32);
            this.buttonOr.TabIndex = 35;
            this.buttonOr.Text = "Or";
            this.buttonOr.UseVisualStyleBackColor = true;
            // 
            // buttonLsh
            // 
            this.buttonLsh.Location = new System.Drawing.Point(46, 192);
            this.buttonLsh.Name = "buttonLsh";
            this.buttonLsh.Size = new System.Drawing.Size(38, 32);
            this.buttonLsh.TabIndex = 34;
            this.buttonLsh.Text = "Lsh";
            this.buttonLsh.UseVisualStyleBackColor = true;
            // 
            // buttonRoL
            // 
            this.buttonRoL.Location = new System.Drawing.Point(46, 116);
            this.buttonRoL.Name = "buttonRoL";
            this.buttonRoL.Size = new System.Drawing.Size(38, 32);
            this.buttonRoL.TabIndex = 33;
            this.buttonRoL.Text = "RoL";
            this.buttonRoL.UseVisualStyleBackColor = true;
            // 
            // button37
            // 
            this.button37.Location = new System.Drawing.Point(46, 78);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(38, 32);
            this.button37.TabIndex = 31;
            this.button37.Text = "(";
            this.button37.UseVisualStyleBackColor = true;
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 442);
            this.Controls.Add(this.panelMain);
            this.Name = "FormMainWindow";
            this.Text = "Calculator";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelKeyboard.ResumeLayout(false);
            this.panelInputType.ResumeLayout(false);
            this.panelInputType.PerformLayout();
            this.panelInputLength.ResumeLayout(false);
            this.panelInputLength.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Panel panelInputLength;
        private System.Windows.Forms.RadioButton radioButtonByte;
        private System.Windows.Forms.RadioButton radioButtonQWord;
        private System.Windows.Forms.RadioButton radioButtonWord;
        private System.Windows.Forms.RadioButton radioButtonDWord;
        private System.Windows.Forms.Panel panelInputType;
        private System.Windows.Forms.RadioButton radioButtonBin;
        private System.Windows.Forms.RadioButton radioButtonOct;
        private System.Windows.Forms.RadioButton radioButtonDec;
        private System.Windows.Forms.RadioButton radioButtonHex;
        private System.Windows.Forms.Panel panelKeyboard;
        private System.Windows.Forms.Button buttonNot;
        private System.Windows.Forms.Button buttonOr;
        private System.Windows.Forms.Button buttonLsh;
        private System.Windows.Forms.Button buttonRoL;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button buttonAnd;
        private System.Windows.Forms.Button buttonXor;
        private System.Windows.Forms.Button buttonRsh;
        private System.Windows.Forms.Button buttonRoR;
        private System.Windows.Forms.Button buttonMoD;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonEvaluate;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonClearEntry;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button button1;
    }
}

