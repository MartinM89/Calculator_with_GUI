using System.Drawing.Design;
using System.Net;

namespace Calculator;

public partial class CalculatorForm : Form
{
    public CalculatorForm()
    {
        InitializeComponent();
        buttonOne.Click += ButtonOne_Click!;
        buttonTwo.Click += ButtonTwo_Click!;
        buttonThree.Click += ButtonThree_Click!;
        buttonFour.Click += ButtonFour_Click!;
        buttonFive.Click += ButtonFive_Click!;
        buttonSix.Click += ButtonSix_Click!;
        buttonSeven.Click += ButtonSeven_Click!;
        buttonEight.Click += ButtonEight_Click!;
        buttonNine.Click += ButtonNine_Click!;
        buttonZero.Click += ButtonZero_Click!;
        buttonAdd.Click += ButtonAdd_Click!;
        buttonSubstract.Click += ButtonSubstract_Click!;
        buttonMultiply.Click += ButtonMultiply_Click!;
        buttonDivide.Click += ButtonDivide_Click!;
        buttonModulus.Click += ButtonModulus_Click!;
        buttonComma.Click += ButtonComma_Click!;
        buttonEquals.Click += ButtonEquals_Click!;
        buttonRemoveLast.Click += ButtonRemoveLast_Click!;
        buttonClear.Click += ButtonClear_Click!;
        this.KeyPreview = true;
        this.KeyDown += new KeyEventHandler(CalculatorForm_KeyDown!);
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (keyData.Equals(Keys.Tab))
        {
            return true;
        }

        return base.ProcessCmdKey(ref msg, keyData);
    }

    private void CalculatorForm_KeyDown(object sender, KeyEventArgs e)
    {
        // e.SuppressKeyPress = true;

        switch (e.KeyCode)
        {
            case Keys.D1 or Keys.NumPad1:
                buttonOne.PerformClick();
                break;

            case Keys.D2 or Keys.NumPad2:
                buttonTwo.PerformClick();
                break;

            case Keys.D3 or Keys.NumPad3:
                buttonThree.PerformClick();
                break;

            case Keys.D4 or Keys.NumPad4:
                buttonFour.PerformClick();
                break;

            case Keys.D5 or Keys.NumPad5:
                buttonFive.PerformClick();
                break;

            case Keys.D6 or Keys.NumPad6:
                buttonSix.PerformClick();
                break;

            case Keys.D7 or Keys.NumPad7:
                if (e.Shift)
                {
                    buttonDivide.PerformClick();
                    return;
                }
                buttonSeven.PerformClick();
                break;

            case Keys.D8 or Keys.NumPad8:
                buttonEight.PerformClick();
                break;

            case Keys.D9 or Keys.NumPad9:
                buttonNine.PerformClick();
                break;

            case Keys.D0 or Keys.NumPad0:
                if (e.Shift)
                {
                    buttonEquals.PerformClick();
                    break;
                }
                buttonZero.PerformClick();
                break;

            case Keys.Add or Keys.Oemplus:
                buttonAdd.PerformClick();
                break;

            case Keys.Subtract or Keys.OemMinus:
                buttonSubstract.PerformClick();
                break;

            case Keys.Multiply:
                buttonMultiply.PerformClick();
                break;

            case Keys.Oem2: // Asterisk
                if (e.Shift)
                {
                    buttonMultiply.PerformClick();
                }
                break;

            case Keys.Divide:
                buttonDivide.PerformClick();
                break;

            case Keys.OemPeriod or Keys.Decimal or Keys.Oemcomma:
                buttonComma.PerformClick();
                break;

            case Keys.Back:
                buttonRemoveLast.PerformClick();
                break;

            case Keys.Enter:
                buttonEquals.PerformClick();
                break;

            default:
                break;
        }
    }

    private string currentInput = "";

    private void ButtonOne_Click(object sender, EventArgs e)
    {
        currentInput += "1";
        ShowInput();
    }
    private void ButtonTwo_Click(object sender, EventArgs e)
    {
        currentInput += "2";
        ShowInput();
    }
    private void ButtonThree_Click(object sender, EventArgs e)
    {
        currentInput += "3";
        ShowInput();
    }
    private void ButtonFour_Click(object sender, EventArgs e)
    {
        currentInput += "4";
        ShowInput();
    }
    private void ButtonFive_Click(object sender, EventArgs e)
    {
        currentInput += "5";
        ShowInput();
    }
    private void ButtonSix_Click(object sender, EventArgs e)
    {
        currentInput += "6";
        ShowInput();
    }
    private void ButtonSeven_Click(object sender, EventArgs e)
    {
        currentInput += "7";
        ShowInput();
    }
    private void ButtonEight_Click(object sender, EventArgs e)
    {
        currentInput += "8";
        ShowInput();
    }
    private void ButtonNine_Click(object sender, EventArgs e)
    {
        currentInput += "9";
        ShowInput();
    }
    private void ButtonZero_Click(object sender, EventArgs e)
    {
        currentInput += "0";
        ShowInput();
    }
    private void ButtonAdd_Click(object sender, EventArgs e)
    {
        currentInput += "+";
        ShowInput();
    }
    private void ButtonSubstract_Click(object sender, EventArgs e)
    {
        currentInput += "-";
        ShowInput();
    }
    private void ButtonMultiply_Click(object sender, EventArgs e)
    {
        currentInput += "*";
        ShowInput();
    }
    private void ButtonDivide_Click(object sender, EventArgs e)
    {
        currentInput += "/";
        ShowInput();
    }
    private void ButtonModulus_Click(object sender, EventArgs e)
    {
        currentInput += "%";
        ShowInput();
    }
    private void ButtonComma_Click(object sender, EventArgs e)
    {
        currentInput += ",";
        ShowInput();
    }
    private void ButtonEquals_Click(object sender, EventArgs e)
    {
        string result = CalculatorLogic.StringToCalculate(currentInput);
        string mathQuestion = ShowInput();
        calculatorDisplay.Text = mathQuestion + "=" + result;
        currentInput = "";
    }
    private void ButtonRemoveLast_Click(object sender, EventArgs e)
    {
        int currentInputLength = currentInput.Length - 1;

        if (!currentInputLength.Equals(-1))
        {
            string newCurrentInput = currentInput.Substring(0, currentInputLength);
            currentInput = newCurrentInput;
            ShowInput();
        }
    }
    private void ButtonClear_Click(object sender, EventArgs e)
    {
        currentInput = "";
        calculatorDisplay.Text = currentInput;
    }

    private string ShowInput()
    {
        return calculatorDisplay.Text = currentInput;
    }
}
