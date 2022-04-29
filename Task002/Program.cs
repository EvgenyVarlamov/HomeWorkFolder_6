/* Задача 40: Напишите программу, которая принимает на вход 
три числа и проверяет, может ли существовать треугольник со 
сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника 
меньше суммы двух других сторон.
*/

int triangleSideA = InputSizeOfSide();
int triangleSideB = InputSizeOfSide();
int triangleSideC = InputSizeOfSide();

CheckSizesOfTriangle(triangleSideA, triangleSideB, triangleSideC);

void CheckSizesOfTriangle(int sideA, int sideB, int sideC)
{
    if(sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
    {
        Console.WriteLine("Такой треугольник может существовать");
    }
    else Console.WriteLine("Такой треугольник не может существовать");
}

int InputSizeOfSide()
{
  Console.WriteLine("Введите сторону треугольника:");
  int triangleSide = Convert.ToInt32(Console.ReadLine());
  return triangleSide;
}