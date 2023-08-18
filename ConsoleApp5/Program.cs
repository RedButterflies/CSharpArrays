

//arrays
string[] animals= { "zebra","elephant","lion","tiger","monkey","hippo","wolf","dinosaur" };
Console.WriteLine("Here are all of the zoo animals: ");
for (int i=0;i<animals.Length;i++)
{
    Console.WriteLine("Animal "+i+ ": " + animals[i]);
}
Console.WriteLine();
foreach(string animal in animals)
{
    Console.WriteLine("Animal: " + animal);
}
Console.WriteLine();

int[] numbers = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine("10th member of the numbers array: "+numbers[9]);
Console.WriteLine("9th member of the numbers array: "+numbers[8]);


float[] floaters = new float[] { 1.1f,1.2f,1.3f};
for(int i=0;i<floaters.Length;i++)
{
    Console.WriteLine("Floater nr "+Convert.ToInt16(i+1)+": " + floaters[i]);
}

char[] characters = new char[5];

Console.WriteLine();
//sorting arrays
Array.Sort(animals);
Console.WriteLine("Sorted animals: ");
foreach ( string animal in animals)
{
    Console.WriteLine(animal);
}

Console.WriteLine();
Console.WriteLine("Sorted numbers: ");
Array.Sort(numbers);
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
Console.WriteLine();

