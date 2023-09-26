//Task 1

int num1 = 70;
int num2 = 36;
int num3 = 25;

int sum = 0;

if (num1 > 0 && num2 > 0 && num3 > 0)
{
    if (num1 % 5 == 0)
    {
        sum += num1;
    }
    if (num2 % 5 == 0)
    {
        sum += num2;
    }
    if (num3 % 5 == 0)
    {
        sum += num3;
    } 
    Console.WriteLine("Sum of numbers that are divisible by 5 is: " + sum);
}
else
{
    Console.WriteLine("One or More Number is Negative");
}

//Task 2

int num = 278;
int sum1 = 0;

sum1 = num % 10 + num / 10 % 10 + num / 100; //278 = 8 + 7 + 2 = 17 (corresponding to the number 278)

Console.WriteLine("Sum of digits of the number is: " + sum1);