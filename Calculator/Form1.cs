using System.Globalization;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private string operation = "";
        private string point = "";
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxShowResult.Text = "";
        }

        private void buttonDeleteSymbol_Click(object sender, EventArgs e)
        {
            if (textBoxShowResult.Text.Length > 0)
            {
                textBoxShowResult.Text = textBoxShowResult.Text.Substring(0, textBoxShowResult.Text.Length - 1);
            }
        }

        private void buttonNegativePositive_Click(object sender, EventArgs e)
        {
            if (textBoxShowResult.Text.Length > 0)
            {
                double number = double.Parse(textBoxShowResult.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                number = -number;
                textBoxShowResult.Text = number.ToString();
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (textBoxShowResult.Text.Length > 0)
            {
                textBoxShowResult.Text += "+";
                operation = "+";
                point = "";
            }
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (textBoxShowResult.Text.Length == 0)
            {
                textBoxShowResult.Text += "-";
                point = "";
            }
            else if (textBoxShowResult.Text == "-")
            {
                point = "";
            }
            else
            {
                firstNumber = double.Parse(textBoxShowResult.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                textBoxShowResult.Text += "-";
                operation = "-";
                point = "";
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (textBoxShowResult.Text.Length > 0)
            {
                firstNumber = double.Parse(textBoxShowResult.Text);
                textBoxShowResult.Text += "*";
                operation = "*";
                point = "";
            }
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (textBoxShowResult.Text.Length > 0)
            {
                firstNumber = double.Parse(textBoxShowResult.Text);
                textBoxShowResult.Text += "/";
                operation = "/";
                point = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (result == 0.0 && operation == "" && point != "." && textBoxShowResult.Text.ToString() == "")
            {
                textBoxShowResult.Text = "1";
            }
            else if (operation == "" && result != 0.0 && point == "")
            {
                textBoxShowResult.Text = "";
                textBoxShowResult.Text = "1";
            }
            else
            {
                textBoxShowResult.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (result == 0.0 && operation == "" && point != "." && textBoxShowResult.Text.ToString() == "")
            {
                textBoxShowResult.Text = "2";
            }
            else if (operation == "" && result != 0.0 && point == "")
            {
                textBoxShowResult.Text = "";
                textBoxShowResult.Text = "2";
            }
            else
            {
                textBoxShowResult.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (result == 0.0 && operation == "" && point != "." && textBoxShowResult.Text.ToString() == "")
            {
                textBoxShowResult.Text = "3";
            }
            else if (operation == "" && result != 0.0 && point == "")
            {
                textBoxShowResult.Text = "";
                textBoxShowResult.Text = "3";
            }
            else
            {
                textBoxShowResult.Text += "3";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (result == 0.0 && operation == "" && point != "." && textBoxShowResult.Text.ToString() == "")
            {
                textBoxShowResult.Text = "4";
            }
            else if (operation == "" && result != 0.0 && point == "")
            {
                textBoxShowResult.Text = "";
                textBoxShowResult.Text = "4";
            }
            else
            {
                textBoxShowResult.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (result == 0.0 && operation == "" && point != "." && textBoxShowResult.Text.ToString() == "")
            {
                textBoxShowResult.Text = "5";
            }
            else if (operation == "" && result != 0.0 && point == "")
            {
                textBoxShowResult.Text = "";
                textBoxShowResult.Text = "5";
            }
            else
            {
                textBoxShowResult.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (result == 0.0 && operation == "" && point != "." && textBoxShowResult.Text.ToString() == "")
            {
                textBoxShowResult.Text = "6";
            }
            else if (operation == "" && result != 0.0 && point == "")
            {
                textBoxShowResult.Text = "";
                textBoxShowResult.Text = "6";
            }
            else
            {
                textBoxShowResult.Text += "6";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (result == 0.0 && operation == "" && point != "." && textBoxShowResult.Text.ToString() == "")
            {
                textBoxShowResult.Text = "7";
            }
            else if (operation == "" && result != 0.0 && point == "")
            {
                textBoxShowResult.Text = "";
                textBoxShowResult.Text = "7";
            }
            else
            {
                textBoxShowResult.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (result == 0.0 && operation == "" && point != "." && textBoxShowResult.Text.ToString() == "")
            {
                textBoxShowResult.Text = "8";
            }
            else if (operation == "" && result != 0.0 && point == "")
            {
                textBoxShowResult.Text = "";
                textBoxShowResult.Text = "8";
            }
            else
            {
                textBoxShowResult.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (result == 0.0 && operation == "" && point != "." && textBoxShowResult.Text.ToString() == "")
            {
                textBoxShowResult.Text = "9";
            }
            else if (operation == "" && result != 0.0 && point == "")
            {
                textBoxShowResult.Text = "";
                textBoxShowResult.Text = "9";
            }
            else
            {
                textBoxShowResult.Text += "9";
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (result == 0.0 && operation == "" && point != "." && textBoxShowResult.Text.ToString() == "")
            {
                textBoxShowResult.Text = "0";
            }
            else if (operation == "" && result != 0.0 && point == "")
            {
                textBoxShowResult.Text = "";
                textBoxShowResult.Text = "0";
            }
            else
            {
                textBoxShowResult.Text += "0";
            }
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            point = ".";
            textBoxShowResult.Text += ".";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (textBoxShowResult.Text.Length > 0 && operation != "")
            {
                if (textBoxShowResult.Text[0] == '-')
                {
                    string[] numbers = textBoxShowResult.Text.Substring(1).Split(operation);
                    if (numbers.Length == 2)
                    {
                        firstNumber = -double.Parse(numbers[0].Replace(',', '.'), CultureInfo.InvariantCulture);
                        secondNumber = double.Parse(numbers[1].Replace(',', '.'), CultureInfo.InvariantCulture);
                        switch (operation)
                        {
                            case "+":
                                result = firstNumber + secondNumber;
                                point = "";
                                break;
                            case "-":
                                result = firstNumber - secondNumber;
                                point = "";
                                break;
                            case "*":
                                result = firstNumber * secondNumber;
                                point = "";
                                break;
                            case "/":
                                result = firstNumber / secondNumber;
                                point = "";
                                break;
                            default:
                                result = 0.0;
                                break;
                        }
                        textBoxShowResult.Text = result.ToString();
                        operation = "";
                    }
                }
                else
                {
                    string[] numbers = textBoxShowResult.Text.Split(operation);
                    if (numbers.Length == 2)
                    {
                        firstNumber = double.Parse(numbers[0].Replace(',', '.'), CultureInfo.InvariantCulture);
                        secondNumber = double.Parse(numbers[1].Replace(',', '.'), CultureInfo.InvariantCulture);
                        switch (operation)
                        {
                            case "+":
                                result = firstNumber + secondNumber;
                                point = "";
                                break;
                            case "-":
                                result = firstNumber - secondNumber;
                                point = "";
                                break;
                            case "*":
                                result = firstNumber * secondNumber;
                                point = "";
                                break;
                            case "/":
                                result = firstNumber / secondNumber;
                                point = "";
                                break;
                            default:
                                result = 0.0;
                                break;
                        }
                        textBoxShowResult.Text = result.ToString();
                        operation = "";
                    }
                }
            }
        }
    }
}