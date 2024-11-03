using Microsoft.VisualBasic.Logging;

namespace Calculator;

partial class CalculatorForm
{
    private System.Windows.Forms.Button buttonOne;
    private System.Windows.Forms.Button buttonTwo;
    private System.Windows.Forms.Button buttonThree;
    private System.Windows.Forms.Button buttonFour;
    private System.Windows.Forms.Button buttonFive;
    private System.Windows.Forms.Button buttonSix;
    private System.Windows.Forms.Button buttonSeven;
    private System.Windows.Forms.Button buttonEight;
    private System.Windows.Forms.Button buttonNine;
    private System.Windows.Forms.Button buttonZero;
    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.Button buttonSubstract;
    private System.Windows.Forms.Button buttonMultiply;
    private System.Windows.Forms.Button buttonDivide;
    private System.Windows.Forms.Button buttonModulus;
    private System.Windows.Forms.Button buttonNegative;
    private System.Windows.Forms.Button buttonComma;
    private System.Windows.Forms.Button buttonEquals;
    private System.Windows.Forms.Button buttonRemoveLast;
    private System.Windows.Forms.Button buttonClear;
    private System.Windows.Forms.TextBox calculatorDisplay;

    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(307, 309);
        this.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
        this.Text = "Calculator";

        CreateButton(ref buttonEquals, "=", 154, 257, 75, 50, "Segoe UI Semilight", 16, 118, 185, 237);
        CreateButton(ref buttonOne, "1", 2, 206, 75, 50, "Segoe UI Semilight", 16, 59, 59, 59);
        CreateButton(ref buttonTwo, "2", 78, 206, 75, 50, "Segoe UI Semilight", 16, 59, 59, 59);
        CreateButton(ref buttonThree, "3", 154, 206, 75, 50, "Segoe UI Semilight", 16, 59, 59, 59);
        CreateButton(ref buttonFour, "4", 2, 155, 75, 50, "Segoe UI Semilight", 16, 59, 59, 59);
        CreateButton(ref buttonFive, "5", 78, 155, 75, 50, "Segoe UI Semilight", 16, 59, 59, 59);
        CreateButton(ref buttonSix, "6", 154, 155, 75, 50, "Segoe UI Semilight", 16, 59, 59, 59);
        CreateButton(ref buttonSeven, "7", 2, 104, 75, 50, "Segoe UI Semilight", 16, 59, 59, 59);
        CreateButton(ref buttonEight, "8", 78, 104, 75, 50, "Segoe UI Semilight", 16, 59, 59, 59);
        CreateButton(ref buttonNine, "9", 154, 104, 75, 50, "Segoe UI Semilight", 16, 59, 59, 59);
        CreateButton(ref buttonZero, "0", 78, 257, 75, 50, "Segoe UI Semilight", 16, 59, 59, 59);
        CreateButton(ref buttonAdd, "+", 230, 257, 75, 50, "Segoe UI Semilight", 16, 40, 40, 40);
        CreateButton(ref buttonSubstract, "-", 230, 206, 75, 50, "Segoe UI Semilight", 16, 40, 40, 40);
        CreateButton(ref buttonMultiply, "*", 230, 155, 75, 50, "Segoe UI Semilight", 16, 40, 40, 40);
        CreateButton(ref buttonDivide, "/", 230, 104, 75, 50, "Segoe UI Semilight", 16, 40, 40, 40);
        CreateButton(ref buttonModulus, "%", 230, 53, 75, 50, "Segoe UI Semilight", 16, 40, 40, 40);
        CreateButton(ref buttonNegative, "(-)", 154, 53, 75, 50, "Segoe UI Semilight", 16, 40, 40, 40);
        CreateButton(ref buttonComma, ",", 2, 257, 75, 50, "Segoe UI Semilight", 16, 40, 40, 40);
        CreateButton(ref buttonRemoveLast, "<-", 78, 53, 75, 50, "Segoe UI Semilight", 16, 40, 40, 40);
        CreateButton(ref buttonClear, "C", 2, 53, 75, 50, "Segoe UI Semilight", 16, 40, 40, 40);

        this.calculatorDisplay = new System.Windows.Forms.TextBox();
        this.calculatorDisplay.Location = new System.Drawing.Point(3, 4);
        this.calculatorDisplay.Size = new System.Drawing.Size(301, 100); // Only adjusts width
        this.calculatorDisplay.BackColor = System.Drawing.Color.FromArgb(59, 59, 59);
        this.calculatorDisplay.ForeColor = System.Drawing.Color.White;
        this.calculatorDisplay.Font = new Font("Segoe UI Semilight", 26);
        this.calculatorDisplay.TextAlign = HorizontalAlignment.Right;
        this.calculatorDisplay.ReadOnly = true;
        this.calculatorDisplay.BorderStyle = BorderStyle.None;
        this.Controls.Add(this.calculatorDisplay);
    }

    public void CreateButton(ref Button button, String buttonLabel, int locationX, int locationY, int sizeX, int sizeY, string fontName, int fontSize, int backColorRed, int backColorGreen, int backColorBlue)
    {
        button = new System.Windows.Forms.Button();
        button.Text = buttonLabel;
        button.Location = new System.Drawing.Point(locationX, locationY);
        button.Size = new System.Drawing.Size(sizeX, sizeY);
        button.Font = new System.Drawing.Font(fontName, fontSize);
        button.BackColor = System.Drawing.Color.FromArgb(backColorRed, backColorGreen, backColorBlue);
        button.ForeColor = System.Drawing.Color.White;
        button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Controls.Add(button);
    }

    #endregion
} // 328 -> 109
