#pragma warning disable CS0219
using Xunit;

namespace BasicCSharp;

public class UnitTwo /*Let's do math!*/
{
    /**
        In this unit we'll go over different arithmetic and comparison operators.
        Before we begin, however, we've already explored one operator, assignment operator(=)
        This equal sign(=) is used to assign a value to a variable.
    */
    
    [Theory]
    [InlineData(2, 3)]
    [InlineData(-2, 4)]
    public void AdditionOperator(int a, int b)
    {
        //you can add two numbers with the addition operator (+).
        //3 + 5 //will return 8.

        //your turn: given two integers a and b (those have already been provided for you, just use them)
        //declare an integer variable named c and set the value of c as the sum of a and b.
        int c = a + b;

        //corollary: += and ++ are other related operators, look them up!


        Assert.Equal(a + b, c);
    }

    [Theory]
    [InlineData(2, 3)]
    [InlineData(-2, 4)]
    public void SubtractionOperator(int a, int b)
    {
        //you can subtract one number from another with the subtraction operator (-).
        //3 - 5 will return -2.

        //your turn: given two integers a and b (those have already been provided for you, just use them)
        //declare an integer variable named c and set the value of c as the result of a - b.
        int c = a - b;

        //corollary: -= and -- are other related operators, look them up!


        Assert.Equal(a - b, c);
    }

    [Theory]
    [InlineData(2, 3)]
    [InlineData(-2, 4)]
    public void MultiplicationOperator(int a, int b)
    {
        //Multiplication operator works the same way as addition and subtraction, just use the * symbol.

        //same exercise as above two, given two integers, declare a variable c that holds the value of a times b.

        int c = a * b;

        Assert.Equal(a * b, c);
    }

    [Theory]
    [InlineData(2.34, 3.14)]
    [InlineData(1.00, 4.324)]
    public void DivisionPartOne(double a, double b)
    {
        //Division operator(/) behaves a bit differently. It actually matters whether you're dividing an integer or a decimal number(such as double)! Here we'll start by dividing doubles because they behave the most similar to the division we know and love.

        //Declare a DOUBLE variable c that holds the value of a divide b.
        double c = a / b;

        Assert.Equal(a / b, c);
    }

    [Theory]
    [InlineData(4, 2)]
    [InlineData(3, 2)]
    public void DivisionPartTwo(int a, int b)
    {
        //When the program sees two integers on either side of the division operator, instead of performing a the "regular" division, it will perform something called "integer division". This is where the decimal points is dropped, or the result of the division is simply the quotient. For Example, 3 / 2 will evaluate to 1, instead of 1.5, because 3 divide 2 is quotient 1 with remainder 1. So it does pay to pay attention to your data types!

        //given two integers a and b, divide a by b (a / b) and assign the value to another integer variable c

        int c = a / b;

        Assert.Equal(a / b, c);
    }

    public void ModuloOperator(int a, int b)
    {
        //The modulo operator(%) does modulo arithmetic, which is concerned with the REMAINDER of the division rather than the quotient we've seen earlier. This operator is Highly useful when you're dealing with 
    }

}


