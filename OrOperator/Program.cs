
int math, biology, chemistry;

Console.WriteLine("Enter math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter biology reult:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("You have been accepted!");
}
else
{
    Console.WriteLine("You have not been accepted.");
}