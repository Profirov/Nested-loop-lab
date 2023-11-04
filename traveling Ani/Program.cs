string input = Console.ReadLine();
double budget;

while (input != "End")
{ 
 budget = double.Parse(Console.ReadLine());

    double money = 0;
    while (money < budget)
    {
        money += double.Parse(Console.ReadLine());
    }



    Console.WriteLine($"Going to {input}!");

    input = Console.ReadLine();
}