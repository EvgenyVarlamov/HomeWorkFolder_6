/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) */
// !!! В условии задачи ошибка, правильная точка пересечиния => (-0,5; -0,5) !!!

double coefficientK1 = InputValueForCoordinateCalculation();
double incrementB1 = InputValueForCoordinateCalculation();
double coefficientK2 = InputValueForCoordinateCalculation();
double incrementB2 = InputValueForCoordinateCalculation();

Console.WriteLine(GetGeometricCoordinate(coefficientK1, coefficientK2, incrementB1, incrementB2));

// Метод/функция вычисления точки персечения двух прямых, если они не парраллельны и не совпадают
string GetGeometricCoordinate(double coefK1, double coefK2, double incrB1, double incrB2)
{
    if(coefK1 == coefK2 && incrB1 != incrB2)
    {
        return "Прямые параллельны";
    }
    else if(coefK1 == coefK2)
    {
        return "Прямые параллельны и совпадают";
    }
    else
    {
        double abscissaPoint = Math.Round((incrB2 - incrB1)/(coefK1 - coefK2), 1);
        double ordinataPoint = Math.Round(abscissaPoint * coefK1 + incrB1, 1);
        return "Точка пересечения имеет координаты (" + abscissaPoint + "; " + ordinataPoint + ")";
    }
}

double InputValueForCoordinateCalculation()       // Метод/функция ввода коээфициента/приращения функции
{
  Console.WriteLine("Введите значение коээфициента/приращения функции");
  double value = Convert.ToDouble(Console.ReadLine());
  return value;
}