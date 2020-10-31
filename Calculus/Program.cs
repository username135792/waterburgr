using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;
using System.Threading;

namespace Calculus
{
    class CalculusInput
    {
        static void Main(string[] args)
        {
            double OutputNumber = 0;
            string InputSpace = File.ReadAllText(@"C:\Users\MSI\Desktop\input.txt");
            string InputNoSpace = Regex.Replace(InputSpace, @"\s", "");
            string[] ValueArray = InputNoSpace.Split('-', '+', '/', '*');
            double FirstNumber = double.Parse(ValueArray[0]);
            double SecondNumber = double.Parse(ValueArray[1]);
            if (InputNoSpace.Contains('+'))
            {
                OutputNumber = Plus(FirstNumber, SecondNumber);
                
            }
            else
            {
                if (InputNoSpace.Contains('-'))
                {
                    OutputNumber = Minus(FirstNumber, SecondNumber);
                    
                }
                else
                {
                    if (InputNoSpace.Contains('/'))
                    {
                        OutputNumber = Divide(FirstNumber, SecondNumber);
                        
                    }
                    else
                    {
                        if (InputNoSpace.Contains('*'))
                        {
                            OutputNumber = Multiply(FirstNumber, SecondNumber);
                            
                        }
                        else
                        {
                            Console.WriteLine("Ошибка. Ваш пример не содержит знака");
                            Thread.Sleep(5000);
                            Environment.Exit(0);
                        }
                    }
                }
            }
            string OutputText = Convert.ToString(OutputNumber);
            string folder = @"C:\Users\MSI\Desktop\Output.txt"; 
            File.WriteAllText(folder, OutputText);
            Console.WriteLine("Программа посчитала");
        }
        
        static double Plus(double FirstNumber, double SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }
        static double Minus(double FirstNumber, double SecondNumber)
        {
            return FirstNumber - SecondNumber;
        }
        static double Divide(double FirstNumber, double SecondNumber)
        {
            return FirstNumber / SecondNumber;
        }
        static double Multiply(double FirstNumber, double SecondNumber)
        {
            return FirstNumber * SecondNumber;
        }
    }
}