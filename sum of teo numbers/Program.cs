int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

int magic = int.Parse(Console.ReadLine());
int count = 0;
bool isFound = false;

for (int x = start; x <= end; x++)
{
    for (int y = start ; y <= end; y++)
    { 
        count++;
    int result = x + y;
        if (result == magic)
        {
            Console.WriteLine($"Combination N:{count} ({x} + {y} = {magic})");
            isFound = true;
            break;
        }
    }
    if(isFound)
    {
        break;
    }

}
if (!isFound)
{
    Console.WriteLine($"{count} combinations - neither equals {magic}");
}

