//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int PointCoordinates(String point, String nameCoordinate){
    Console.Write($"Введите координату {nameCoordinate} точки {point}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int xa=PointCoordinates("A", "xa");
int ya=PointCoordinates("A", "ya");
int za=PointCoordinates("A", "za");

int xb=PointCoordinates("B", "xb");
int yb=PointCoordinates("B", "yb");
int zb=PointCoordinates("B", "zb");

double distanse = Math.Round(Math.Sqrt(Math.Pow((xa-xb),2)+Math.Pow((ya-yb),2)+Math.Pow((za-zb),2)),2);

Console.WriteLine($"Растояние между точками А и В = {distanse}");