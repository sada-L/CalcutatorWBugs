using System;
using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CalcutatorWBugs;

public partial class MainWindow : Window
{
    private string Num;
    private string Temp;
    private string Oper;
    private bool IsExp;
    
    public MainWindow()
    {
        InitializeComponent();

        Width = 291;
        MaxWidth = 291;
        Height = 400;
        
        ButtonDelete.Click += ButtonDeleteOnClick;
        ButtonDivide.Click += ButtonDivideOnClick;
        ButtonMult.Click += ButtonMultOnClick;
        ButtonMinus.Click += ButtonMinusOnClick;
        ButtonPlus.Click += ButtonPlusOnClick;
        ButtonSqrt.Click += ButtonSqrtOnClick;
        ButtonZero.Click += ButtonZeroOnClick;
        ButtonOne.Click += ButtonOneOnClick;
        ButtonTwo.Click += ButtonTwoOnClick;
        ButtonThree.Click += ButtonThreeOnClick;
        ButtonFour.Click += ButtonFourOnClick;
        ButtonFive.Click += ButtonFiveOnClick;
        ButtonSix.Click += ButtonSixOnClick;
        ButtonSeven.Click += ButtonSevenOnClick;
        ButtonEight.Click += ButtonEightOnClick;
        ButtonNine.Click += ButtonNineOnClick;
        ButtonEqual.Click += ButtonEqualOnClick;
        ButtonComma.Click += ButtonCommaOnClick;
        ButtonExpansion.Click += ButtonExpansionOnClick;
        ButtonBackspace.Click += ButtonBackspaceOnClick;
        ButtonDegrees.Click += ButtonDegreesOnClick;
        ButtonReciproc.Click += ButtonReciprocOnClick;
        ButtonLn.Click += ButtonLnOnClick;
        ButtonPi.Click += PiOnClick;
        ButtonCos.Click += CosOnClick;
        ButtonTan.Click += TanOnClick;
        ButtonSin.Click += SinOnClick;
        ButtonLog.Click += LogOnClick;
        Button10PowX.Click += Button10PowXOnClick;
        ButtonSqrt3.Click += Sqrt3OnClick;
        ButtonSqrtYx.Click += SqrtYxOnClick;
        ButtonPow3.Click += Pow3OnClick;
        ButtonFactorial.Click += FactorialOnClick;
        ButtonPercent.Click += PercentOnClick;
    }
    
    private void ButtonDeleteOnClick(object? sender, RoutedEventArgs e)
    {
        Num = " ";
        Temp = " ";
        Oper = null;
        TextBoxOutInPut.Text = null;
    }          // CE
    private void ButtonExpansionOnClick(object? sender, RoutedEventArgs e)
    {
        if (!IsExp) {
            IsExp = true; 
            ButtonExpansion.Content = "<";
            ButtonSqrt.IsVisible = true;
            ButtonPercent.IsVisible = true;
            ButtonLn.IsVisible = true;
            ButtonDegrees.IsVisible = true;
            ButtonReciproc.IsVisible = true;
            ButtonPi.IsVisible = true;
            ButtonTan.IsVisible = true;
            ButtonCos.IsVisible = true;
            ButtonSin.IsVisible = true;
            ButtonLog.IsVisible = true;
            Button10PowX.IsVisible = true;
            ButtonSqrt3.IsVisible = true;
            ButtonSqrtYx.IsVisible = true;
            ButtonPow3.IsVisible = true;
            ButtonPow2.IsVisible = true;
            ButtonFactorial.IsVisible = true;
            Width = 540;
            MaxWidth = 540;
        }
        else {
            IsExp = false; 
            ButtonExpansion.Content = ">";
            ButtonSqrt.IsVisible = false;
            ButtonPercent.IsVisible = false;
            ButtonLn.IsVisible = false;
            ButtonDegrees.IsVisible = false;
            ButtonReciproc.IsVisible = false;
            ButtonPi.IsVisible = false;
            ButtonTan.IsVisible = false;
            ButtonCos.IsVisible = false;
            ButtonSin.IsVisible = false;
            ButtonLog.IsVisible = false;
            Button10PowX.IsVisible = false;
            ButtonSqrt3.IsVisible = false;
            ButtonSqrtYx.IsVisible = false;
            ButtonPow3.IsVisible = false;
            ButtonPow2.IsVisible = false;
            ButtonFactorial.IsVisible = false;
            Width = 291;
            MaxWidth = 291;
        }
    }       // >
    private void ButtonBackspaceOnClick(object? sender, RoutedEventArgs e)
    {
        if (Oper == null) {
            Num = Num.Remove(Num.Length - 1);
            TextBoxOutInPut.Text = Num;
        }
        else {
            Temp = Temp.Remove(Temp.Length - 1);
            TextBoxOutInPut.Text = Temp;
        }
    }       // <
    private void ButtonCommaOnClick(object? sender, RoutedEventArgs e)
    {
        if (Oper == null) {
            Num += ",";
            TextBoxOutInPut.Text = Num;
        }
        else {
            Temp += ",";
            TextBoxOutInPut.Text = Temp;
        }
    }           // ,
    private void ButtonEqualOnClick(object? sender, RoutedEventArgs e)
    {
        Num = Convert.ToString(Calculate(Oper));
        TextBoxOutInPut.Text = Num;
    }           // =
    private void ButtonNineOnClick(object? sender, RoutedEventArgs e)
    {
        if (Oper == null) {
            Num += 9.ToString();
            TextBoxOutInPut.Text = Num;
        }
        else {
            Temp += 9.ToString();
            TextBoxOutInPut.Text = Temp;
        }
    }            // 9
    private void ButtonEightOnClick(object? sender, RoutedEventArgs e)
    {
        if (Oper == null) {
            Num += 8.ToString();
            TextBoxOutInPut.Text = Num;
        }
        else {
            Temp += 8.ToString();
            TextBoxOutInPut.Text = Temp;
        }
    }           // 8
    private void ButtonSevenOnClick(object? sender, RoutedEventArgs e)
    {
        if (Oper == null) {
            Num += 7.ToString();
            TextBoxOutInPut.Text = Num;
        }
        else {
            Temp += 7.ToString();
            TextBoxOutInPut.Text = Temp;
        }
    }           // 7
    private void ButtonSixOnClick(object? sender, RoutedEventArgs e)
    {
        if (Oper == null) {
            Num += 6.ToString();
            TextBoxOutInPut.Text = Num;
        }
        else {
            Temp += 6.ToString();
            TextBoxOutInPut.Text = Temp;
        }
    }             // 6
    private void ButtonFiveOnClick(object? sender, RoutedEventArgs e)
    {
        if (Oper == null) {
            Num += 5.ToString();
            TextBoxOutInPut.Text = Num;
        }
        else {
            Temp += 5.ToString();
            TextBoxOutInPut.Text = Temp;
        }
    }            // 5
    private void ButtonFourOnClick(object? sender, RoutedEventArgs e)
    {
        if (Oper == null) {
            Num += 4.ToString();
            TextBoxOutInPut.Text = Num;
        }
        else {
            Temp += 4.ToString();
            TextBoxOutInPut.Text = Temp;
        }
    }            // 4
    private void ButtonThreeOnClick(object? sender, RoutedEventArgs e)
    {
        if (Oper == null) {
            Num += 3.ToString();
            TextBoxOutInPut.Text = Num;
        }
        else {
            Temp += 3.ToString();
            TextBoxOutInPut.Text = Temp;
        }
    }           // 3
    private void ButtonTwoOnClick(object? sender, RoutedEventArgs e)
    {
        if (Oper == null) {
            Num += 2.ToString();
            TextBoxOutInPut.Text = Num;
        }
        else {
            Temp += 2.ToString();
            TextBoxOutInPut.Text = Temp;
        }
    }             // 2
    private void ButtonOneOnClick(object? sender, RoutedEventArgs e)
    {
        if (Oper == null) {
            Num += 1.ToString();
            TextBoxOutInPut.Text = Num;
        }
        else {
            Temp += 1.ToString();
            TextBoxOutInPut.Text = Temp;
        }
    }             // 1
    private void ButtonZeroOnClick(object? sender, RoutedEventArgs e)
    {
        if (Oper == null) {
            Num += 0.ToString();
            TextBoxOutInPut.Text = Num;
        }
        else {
            Temp += 0.ToString();
            TextBoxOutInPut.Text = Temp;
        }
    }            // 0
    private void PiOnClick(object? sender, RoutedEventArgs e)
    {
        if (Oper == null)
        {
            Num += Math.PI.ToString();
            TextBoxOutInPut.Text = Num;
        }
        else {
            Temp += Math.PI.ToString();
            TextBoxOutInPut.Text = Temp;
        }
    }                    // Pi
    
    private void FactorialOnClick(object? sender, RoutedEventArgs e)
    {
        Oper = "fact";
        TextBoxOutInPut.Text = "0";
    }             // fact
    private void Pow3OnClick(object? sender, RoutedEventArgs e)
    {
        Oper = "p3";
        TextBoxOutInPut.Text = "0";
    }                  // P3
    private void SqrtYxOnClick(object? sender, RoutedEventArgs e)
    {
        Oper = "sqrtyx";
        TextBoxOutInPut.Text = "0";
    }                // sqrtYX
    private void Sqrt3OnClick(object? sender, RoutedEventArgs e)
    {
        Oper = "sqrt3";
        TextBoxOutInPut.Text = "0";
    }                 // sqrt3
    private void Button10PowXOnClick(object? sender, RoutedEventArgs e)
    {
        Oper = "10px";
        TextBoxOutInPut.Text = "0";
    }          // 10PX
    private void LogOnClick(object? sender, RoutedEventArgs e)
    {
        Oper = "log";
        TextBoxOutInPut.Text = "0";
    }                   // Log
    private void SinOnClick(object? sender, RoutedEventArgs e)
    {
        Oper = "sin";
        TextBoxOutInPut.Text = "0";
    }                   // Sin
    private void TanOnClick(object? sender, RoutedEventArgs e)
    {
        Oper = "tan";
        TextBoxOutInPut.Text = "0";
    }                   // Tan
    private void CosOnClick(object? sender, RoutedEventArgs e)
    {
        Oper = "cos";
        TextBoxOutInPut.Text = "0";
    }                   // Cos
    private void ButtonSqrtOnClick(object? sender, RoutedEventArgs e)
    {
        Oper = "sqrt";
        TextBoxOutInPut.Text = "0";
    }            // Sqrt
    private void ButtonPlusOnClick(object? sender, RoutedEventArgs e)
    {
        Oper = "plus";
        TextBoxOutInPut.Text = "0";
    }            // +
    private void ButtonMinusOnClick(object? sender, RoutedEventArgs e)
    {
        Oper = "minus";
        TextBoxOutInPut.Text = "0";
    }           // - 
    private void ButtonMultOnClick(object? sender, RoutedEventArgs e)
    {
        Oper = "mult";
        TextBoxOutInPut.Text = "0";
    }            // *
    private void ButtonDivideOnClick(object? sender, RoutedEventArgs e)
    {
        Oper = "divide";
        TextBoxOutInPut.Text = "0";
    }          // / 
    private void ButtonLnOnClick(object? sender, RoutedEventArgs e)
    {
        Oper = "ln";
        TextBoxOutInPut.Text = "0";
    }              // Ln
    private void ButtonReciprocOnClick(object? sender, RoutedEventArgs e)
    {
        Oper = "recip";
        TextBoxOutInPut.Text = "0";
    }        // 1/x
    private void ButtonDegreesOnClick(object? sender, RoutedEventArgs e)
    {
        Oper = "degrees";
        TextBoxOutInPut.Text = "0";
    }         // X^Y
    private void PercentOnClick(object? sender, RoutedEventArgs e)
    {
        Oper = "percent";
        TextBoxOutInPut.Text = "0";
    }               // %
    private double Factorial(double n) => n == 1 ? 1 : n * Factorial(n - 1);        // fact
    private double Calculate(string s)
    {
        double eql = 0;
        switch (s)
        {
            case "plus":
                eql = Convert.ToDouble(Num) + Convert.ToDouble(Temp);
                break;
            case "minus":
                eql = Convert.ToDouble(Num) - Convert.ToDouble(Temp);
                break;
            case "mult":
                eql = Convert.ToDouble(Num) * Convert.ToDouble(Temp);
                break;
            case "divide":
                eql = Convert.ToDouble(Num) / Convert.ToDouble(Temp);
                break;
            case "sqrt":
                eql = Math.Sqrt( Convert.ToDouble(Num));
                break;
            case "ln":
                eql = Math.Log(Convert.ToDouble(Num),10);
                break;
            case "recip":
                eql =  1/Convert.ToDouble(Num);
                break;
            case "fact":
                eql = Factorial(Convert.ToDouble(Num));
                break;
            case "p3":
                eql = Math.Pow( Convert.ToDouble(Num), 3);
                break;
            case "sqrtyx":
                eql = Math.Pow( Convert.ToDouble(Num), 1/Convert.ToDouble(Temp));
                break;
            case "sqrt3":
                eql = Math.Pow( Convert.ToDouble(Num), 1/3);
                break;
            case "10px":
                eql = Math.Pow( 10, Convert.ToDouble(Num));
                break;
            case "log":
                eql = Math.Log( Convert.ToDouble(Num), Convert.ToDouble(Temp));
                break;
            case "sin":
                eql = Math.Sin( Convert.ToDouble(Num));
                break;
            case "tan":
                eql = Math.Tan( Convert.ToDouble(Num));
                break;
            case "cos":
                eql = Math.Cos( Convert.ToDouble(Num));
                break;
            case "degrees":
                eql = Math.Pow( Convert.ToDouble(Num), Convert.ToDouble(Temp));
                break;
            case "percent":
                eql = Convert.ToDouble(Num)/100;
                break;
        }
        return eql;
    }                                           //Вычисление
}