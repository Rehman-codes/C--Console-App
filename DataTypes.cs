class DataTypes
{
    private int count = 10;
    private float small = 20.123456789018908908f; // float has 7 decimal digits of precision.     
    private double big =  20.123456789018908908;  // double has 15-16 decimal digits of precision.
    private char pass = 'c';
    private string name = "Abdur Rehman";
    private bool isProgrammer = true;

    public void printValues()
    {
        Console.WriteLine("Data types");
        Console.WriteLine("Integer: " + count);
        Console.WriteLine("Float: " + small);
        Console.WriteLine("Double: " + big);
        Console.WriteLine("Character: " + pass);
        Console.WriteLine("String: " + name);
        Console.WriteLine("Boolean: " + isProgrammer);
    }

}