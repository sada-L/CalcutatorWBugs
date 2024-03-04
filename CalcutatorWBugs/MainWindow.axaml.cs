using System;
using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CalcutatorWBugs;

public partial class MainWindow : Window
{
    private string _num;
    private string _temp;
    private string _oper;
    private bool _isExp;
    
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
        ButtonPow2.Click += Pow2OnClick;
    }
    
    private void ButtonDeleteOnClick(object? sender, RoutedEventArgs e)
    {
        _num = " ";
        _temp = " ";
        _oper = null;
        TextBoxOutInPut.Text = null;
    }          // CE
    private void ButtonExpansionOnClick(object? sender, RoutedEventArgs e)
    {
        if (!_isExp) {
            _isExp = true; 
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
            _isExp = false; 
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
        if (_oper == null) {
            _num = _num.Remove(_num.Length - 1);
            TextBoxOutInPut.Text = _num;
        }
        else {
            _temp = _temp.Remove(_temp.Length - 1);
            TextBoxOutInPut.Text = _temp;
        }
    }       // <
    private void ButtonEqualOnClick(object? sender, RoutedEventArgs e)
    {
        _num = Convert.ToString(Calculate(_oper));
        TextBoxOutInPut.Text = _num;
        _temp = " ";
    }           // =
    
    private void ButtonCommaOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnNumberButton(",");
    }           // ,
    private void ButtonNineOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnNumberButton(9);
    }            // 9
    private void ButtonEightOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnNumberButton(8);
    }           // 8
    private void ButtonSevenOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnNumberButton(7);
    }           // 7
    private void ButtonSixOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnNumberButton(6);
    }             // 6
    private void ButtonFiveOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnNumberButton(5);
    }            // 5
    private void ButtonFourOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnNumberButton(4);
    }            // 4
    private void ButtonThreeOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnNumberButton(3);
    }           // 3
    private void ButtonTwoOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnNumberButton(2);
    }             // 2
    private void ButtonOneOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnNumberButton(1);
    }             // 1
    private void ButtonZeroOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnNumberButton(0);
    }            // 0
    private void PiOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnNumberButton(Math.PI);
    }                    // Pi
    private void ClickOnNumberButton(object buttonNumber)
    {
        if (_oper == null) {
            _num += buttonNumber.ToString();
            TextBoxOutInPut.Text = _num;
        }
        else {
            _temp += buttonNumber.ToString();
            TextBoxOutInPut.Text = _temp;
        }
    }                        // event butt num
    
    private void FactorialOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnFunctionButton("fact");
        
    }             // fact
    private void Pow3OnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnFunctionButton("p3");
        
    }                  // P3
    private void SqrtYxOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnFunctionButton("sqrtyx");
        
    }                // sqrtYX
    private void Sqrt3OnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnFunctionButton("sqrt3");
        
    }                 // sqrt3
    private void Button10PowXOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnFunctionButton("10px");
        
    }          // 10PX
    private void LogOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnFunctionButton("log");
        
    }                   // Log
    private void SinOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnFunctionButton("sin");
        
    }                   // Sin
    private void TanOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnFunctionButton("tan");
        
    }                   // Tan
    private void CosOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnFunctionButton("cos");
        
    }                   // Cos
    private void ButtonSqrtOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnFunctionButton("sqrt");
        
    }            // Sqrt
    private void ButtonPlusOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnFunctionButton("plus");
        
    }            // +
    private void ButtonMinusOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnFunctionButton("minus");
        
    }           // - 
    private void ButtonMultOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnFunctionButton("mult");
        
    }            // *
    private void ButtonDivideOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnFunctionButton("divide");
        
    }          // / 
    private void ButtonLnOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnFunctionButton("ln");
        
    }              // Ln
    private void ButtonReciprocOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnFunctionButton("recip");
        
    }        // 1/x
    private void ButtonDegreesOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnFunctionButton("degrees");
        
    }         // X^Y
    private void PercentOnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnFunctionButton("percent");
        
    }               // %
    private void Pow2OnClick(object? sender, RoutedEventArgs e)
    {
        ClickOnFunctionButton("p2");
        
    }                  // p2
    private void ClickOnFunctionButton(string operation)
    {
        _oper = operation;
        TextBoxOutInPut.Text = "0";
    }                         // event butt fun calk
    
    private double Factorial(double n) => n == 1 ? 1 : n * Factorial(n - 1);        // fact
    private double Calculate(string s) => s switch
    {
        "plus" => Convert.ToDouble(_num) + Convert.ToDouble(_temp),
        "minus" => Convert.ToDouble(_num) - Convert.ToDouble(_temp),
        "mult" => Convert.ToDouble(_num) * Convert.ToDouble(_temp),
        "divide" => Convert.ToDouble(_num) / Convert.ToDouble(_temp),
        "sqrt" => Math.Sqrt( Convert.ToDouble(_num)),
        "ln" => Math.Log(Convert.ToDouble(_num),10),
        "recip" => 1/Convert.ToDouble(_num),
        "fact" => Factorial(Convert.ToDouble(_num)),
        "p3" => Math.Pow( Convert.ToDouble(_num), 3),
        "sqrtyx" => Math.Pow( Convert.ToDouble(_num), 1/Convert.ToDouble(_temp)),
        "sqrt3" => Math.Pow( Convert.ToDouble(_num), 1/3),
        "10px" => Math.Pow( 10, Convert.ToDouble(_num)),
        "log" => Math.Log( Convert.ToDouble(_num), Convert.ToDouble(_temp)),
        "sin" => Math.Sin( Convert.ToDouble(_num)),
        "tan" => Math.Tan( Convert.ToDouble(_num)),
        "cos" => Math.Cos( Convert.ToDouble(_num)),
        "degrees" => Math.Pow( Convert.ToDouble(_num), Convert.ToDouble(_temp)),
        "percent" => Convert.ToDouble(_num)/100,
        "p2" => Math.Pow( Convert.ToDouble(_num), 2)
    };                                        //Вычисление 
}