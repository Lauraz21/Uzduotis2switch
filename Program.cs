Console.WriteLine("Pasirinkite viena figura: " +
    "\n-Kvadratas - 1 \n-Trikampis - 2  \n-Apskritimas - 3 \n-Staciakampis - 4");
int figure = Convert.ToInt32(Console.ReadLine());

switch (figure)
{
    case 1:
        Console.WriteLine("Jus pasirinkote kvadrata. " +
        "Iveskite krastines ilgi:");
        int userSquareNumber = Convert.ToInt32(Console.ReadLine());
        int sum = userSquareNumber * userSquareNumber;
        Console.WriteLine("Kvadrato plotas: " + sum + " cm");
        break;
    case 2:
        Console.WriteLine("Jus pasirinkote trikampi.Iveskite aukstines ir pagrindo ilgi: ");
        int userTriangleNumber = Convert.ToInt32(Console.ReadLine());
        int userTriangleNumber2 = Convert.ToInt32(Console.ReadLine());
        float sum2 = 0.5f * userTriangleNumber * userTriangleNumber2;
        Console.WriteLine("Trikampio plotas: " + sum2 + " cm");
        break;
    case 3:
        Console.WriteLine("Jus pasirinkote apskritima. Iveskite spindulio ilgi: ");
        int userCircleNumber = Convert.ToInt32(Console.ReadLine());
        float sum3 = 3.14f * userCircleNumber * userCircleNumber;
        Console.WriteLine("Apskritimo plotas: " + sum3 + " cm");
        break;
    case 4:
        Console.WriteLine("Jus pasirinkote staciakampi. Iveskite dvieju krastiniu ilgius:");
        int userRectangleNumber = Convert.ToInt32(Console.ReadLine());
        int userRectangleNumber2 = Convert.ToInt32(Console.ReadLine());
        int sum4 = userRectangleNumber * userRectangleNumber2;
        Console.WriteLine("Staciakampio plotas: " + sum4 + " cm");
        break;
}
