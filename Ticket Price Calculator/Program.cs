// See https://aka.ms/new-console-template for more information

decimal price, discountedPrice;
int age;

price = 10.00m;
discountedPrice = 7.00m;

Console.WriteLine("Enter your age: ");

age = Convert.ToInt32(Console.ReadLine());

while (age < 0)
{
    Console.WriteLine("The number you have entered is a negative number");
    Console.WriteLine("Enter your right age: ");
    age = Convert.ToInt32(Console.ReadLine());
}

if (age >= 65 || age <= 12)
{
    Console.WriteLine("Price of ticket is GH₵ " + discountedPrice);
}else
{
    Console.WriteLine("Price of ticket is GH₵ " + price);
}