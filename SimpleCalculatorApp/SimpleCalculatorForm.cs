using System;
using System.Windows.Forms;

namespace SimpleCalculatorApp
{
    public partial class SimpleCalculatorForm : Form
    {
        private float firstNumber, result;
        private bool isDecimal;
        private bool hasDecimal;
        static char operation;
        private bool isFirstTime;

        public SimpleCalculatorForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            labelDisplay.Text = "0";
            firstNumber = 0;
            result = 0;
            isDecimal = false;
            hasDecimal = false;
            operation = '\0';
            isFirstTime = true;
        }

        private void UpdateDisplay(int numberEntered)
        {
            if (isDecimal)
            {
                if (!hasDecimal)
                {
                    labelDisplay.Text = labelDisplay.Text + ".";
                    hasDecimal = true;
                }

                isDecimal = false;
            }
            else
            {
                if (labelDisplay.Text.Equals("0") && labelDisplay.Text != null)
                {
                    labelDisplay.Text = "";
                    labelDisplay.Text = numberEntered.ToString();
                }
                else if (labelDisplay.Text.Equals("-0"))
                {
                    labelDisplay.Text = "-" + numberEntered.ToString();
                }
                else
                {
                    labelDisplay.Text += numberEntered.ToString();
                }
            }
        }

        private void UpdateResult()
        {
            try
            {
                firstNumber = float.Parse(labelDisplay.Text);
                result = HelperCalculation.GetFinalResult(result, firstNumber, operation);

                labelDisplay.Text = "";
                hasDecimal = false;

            }
            catch (Exception)
            {
                // if the input is invalid, do nothing
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void ButtonDecimal_Click(object sender, EventArgs e)
        {
            isDecimal = true;
            UpdateDisplay(0);
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            float finalResult = 0;
            try
            {
                if (!labelDisplay.Text.Equals("0") && labelDisplay.Text != null && labelDisplay.Text != ".")
                {
                    finalResult = HelperCalculation.GetFinalResult(result, float.Parse(labelDisplay.Text), operation);
                }

                hasDecimal = false;
                result = 0;
                isFirstTime = true;
            }
            catch (Exception)
            {
                // if the input is invalid, do nothing
            }

            labelDisplay.Text = finalResult.ToString();
        }

        private void OperationUpdate(string bottonOperator)
        {
            if (isFirstTime)
            {
                operation = bottonOperator.ToCharArray()[0];
                result = float.Parse(labelDisplay.Text);
                labelDisplay.Text = "";
                isFirstTime = false;
                hasDecimal = false;
            }
            else
            {
                UpdateResult();
                operation = bottonOperator.ToCharArray()[0];
            }
        }

        private void ButtonPlusMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if (float.Parse(labelDisplay.Text) < 0)
                {
                    labelDisplay.Text = labelDisplay.Text.Remove(0, 1);
                }
                else
                {
                    labelDisplay.Text = "-" + labelDisplay.Text;
                }
            }
            catch (Exception)
            {
                // if the input is invalid, do nothing
            }
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            OperationUpdate(button.Text);

        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            OperationUpdate(button.Text);
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            OperationUpdate(button.Text);

        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            OperationUpdate(button.Text);
        }

        private void ButtonZero_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            UpdateDisplay(int.Parse(button.Text));
        }
        private void ButtonOne_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            UpdateDisplay(int.Parse(button.Text));
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            UpdateDisplay(int.Parse(button.Text));
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            UpdateDisplay(int.Parse(button.Text));
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            UpdateDisplay(int.Parse(button.Text));
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            UpdateDisplay(int.Parse(button.Text));
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            UpdateDisplay(int.Parse(button.Text));
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            UpdateDisplay(int.Parse(button.Text));
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            UpdateDisplay(int.Parse(button.Text));
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            UpdateDisplay(int.Parse(button.Text));
        }

    }
}