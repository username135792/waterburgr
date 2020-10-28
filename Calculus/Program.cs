using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace Calculus
{
    class CalculusInput
    {
        static void Main(string[] args)
        {
            string InputSpace = System.IO.File.ReadAllText(@"C:\Users\MSI\Desktop\input.txt");
            string InputNoSpace = Regex.Replace(InputSpace, @"\s", "");
            string[] ValueArray = InputNoSpace.Split('-', '+', '/', '*');
            double FirstNumber = double.Parse(ValueArray[0]);
            double SecondNumber = double.Parse(ValueArray[1]);
            if (InputNoSpace.Contains('+'))
            {
                double Output = Plus();
            }
            else
            {
                if (InputNoSpace.Contains('-'))
                {
                    double Output = Minus();
                }
                else
                {
                    if (InputNoSpace.Contains('/'))
                    {
                        double Output = Divide();
                    }
                    else
                    {
                        if (InputNoSpace.Contains('*'))
                        {
                            double Output = Multiply();
                        }
                    }
                }
            }
            //C: \Users\MSI\Desktop
            //создать пустой файл
            System.IO.File.Create(@"C:\Users\MSI\Desktop");

            //создать (если нет) либо открыть если есть и записать текст (путем замены если что то      было   записано)
            System.IO.File.WriteAllText("D:\\TestFile.txt", "текст");

            //создает новый  если такого нет , либо открывает имеющийся и пишет путем добавления 
            System.IO.File.AppendAllText("D:\\TestFile.txt", "текст");

            //получить доступ к  существующему либо создать новый
            StreamWriter file = new StreamWriter("D:\\TestFile.txt");
            //записать в него
            file.Write("текст");
            //закрыть для сохранения данных
            file.Close();
        }

        static double Plus()
        {
            return double(FirstNumber) + double(SecondNumber)
        }
        static double Minus()
        {
            return double(FirstNumber) - double(SecondNumber)
        }
        static double Divide()
        {
            return double(FirstNumber) / double(SecondNumber)
        }
        static double Multiply()
        {
            return double(FirstNumber) * double(SecondNumber)
        }
    }
}