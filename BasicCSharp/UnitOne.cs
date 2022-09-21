#pragma warning disable CS0219
using Xunit;

namespace BasicCSharp;

public class UnitOne
{
    /// <summary>
    /// To Test This Method: do the following
    /// make sure you're in your BasicCSharp folder in your terminal
    /// type 'dotnet test --filter DisplayName=BasicCSharp.UnitOne.CreateInteger' (without quotes)
    /// </summary>
    [Fact]
    public void CreateInteger()
    {
        //Integer data type is used to hold integer values from -2147483648 to 2147483647. As you can see, it can hold quite a bit! Integers are 32 bit in size and is one of those data types you'll use very often.

        //Here we declare an integer variable named num here. 
        int num;
        
        //C# is a strongly typed language which means whenever we create a variable, we need to let the compiler(the piece of software that translates our C# code to something machines can understand and execute) know that we plan on assigning an Integer type to this variable. This step is called "declaration"
        
        
        //now we assign a value 6 to the variable "num"
        num = 6;
        //This step is called initialization. We are providing the data to the variable.
        //notice during initialization we do not repeat the data type of the variable. Saying which data type the variable will hold is only necessary during declaration step and in fact let compiler know to create a new variable! If you do another int num = 6 right here, the compiler will try to create a new integer variable named num, and realize that it already has the variable named num and "complain" (throw a compilation error)


        //your turn: Declare an integer variable named "foo" and assign 26 to the foo variable
        //hint: don't forget the semicolon!
        //write your code here

        int foo = 26;

        //now make sure you're in your BasicCSharp folder in your terminal and type 'dotnet test --filter DisplayName=BasicCSharp.UnitOne.CreateInteger' to see if your test passes or not


        //Do not touch the following code!!
        Assert.Equal(typeof(int), foo.GetType());
        Assert.Equal(26, foo);
    }

    /// <summary>
    /// To test this method, do the following:
    /// make sure you're in your BasicCSharp folder in your terminal
    /// type 'dotnet test --filter DisplayName=BasicCSharp.UnitOne.CreateIntegerTwo' (without quotes)
    /// </summary>
    [Fact]
    public void CreateIntegerTwo()
    {
        //In the previous test, we declared our variable first and then initialize it in a separate line. In fact, those can be done in one line as such
        int num = 6;

        //Now your turn, create an integer variable named foo and assign the value -20 to it.

        int foo = -20;

        //Now ensure you're in your BasicCSharp folder in your terminal and type 'dotnet test --filter DisplayName=BasicCSharp.UnitOne.CreateIntegerTwo' to see if your test passes or not

        //Do not touch the following code!!
        Assert.Equal(typeof(int), foo.GetType());
        Assert.Equal(-20, foo);
    }

    /// <summary>
    /// To test this method, do the following:
    /// make sure you're in your BasicCSharp folder in your terminal
    /// type 'dotnet test --filter DisplayName=BasicCSharp.UnitOne.ChangeValueOfAVariable' (without quotes)
    /// </summary>
    [Fact]
    public void ChangeValueOfAVariable()
    {
        /*
        Variables are called variables because... well they can change values! Here we are going to change the value of an already declared and initialized variable.
        */

        int num = 0;
        //here we change the value of this integer variable num from 0 to 123
        num = 123; //now num holds the integer value 123 instead of 0.

        //now your turn: change the value of the variable num to something other than 123
        //Do not modify the previous lines!

        num = 2435;


        //To test that this passes, ensure you're in your BasicCSharp folder in your terminal and type 'dotnet test --filter DisplayName=BasicCSharp.UnitOne.ChangeValueOfAVariable' to see if your test passes or not

        //Do not touch the following code!!
        Assert.Equal(typeof(int), num.GetType());
        Assert.NotEqual(123, num);
    }


    /// <summary>
    /// To test this method, do the following:
    /// make sure you're in your BasicCSharp folder in your terminal
    /// type 'dotnet test --filter DisplayName=BasicCSharp.UnitOne.CreateDouble' (without quotes)
    /// </summary>
    [Fact]
    public void CreateDouble()
    {
        //double type is handy for any decimal values we encounter. Double occupies 64 bit of space in memory and can hold values from -1.7976931348623157E+308 to 1.7976931348623157E+308, as well have values that can represent negative and positive infinity.
        //Declaring double variable is as simple as any others
        double foo = 3.14159265358979323846;

        //your turn: create a double variable named "bar" and assign the value 2.7182818284590 to it


        double bar = 2.7182818284590;


        //Do not touch the following code!!
        Assert.Equal(typeof(double), bar.GetType());
        Assert.Equal(2.7182818284590, bar);
    }


    /// <summary>
    /// To test this method, do the following:
    /// make sure you're in your BasicCSharp folder in your terminal
    /// type 'dotnet test --filter DisplayName=BasicCSharp.UnitOne.CreateBooleans' (without quotes)
    /// </summary>
    [Fact]
    public void CreateBooleans()
    {
        //booleans hold either a true or a false value, and is very handy for comparing whether two are the same or not (and way more)
        //booleans are declared as following:
        bool foo = true;
        
        //Create a boolean variable named "isTrue" with the value true
        //and another variable named isFalse with the value false

        bool isTrue = true;
        bool isFalse = false;

        //Do not touch the following code!!
        Assert.Equal(typeof(bool), isTrue.GetType());
        Assert.Equal(typeof(bool), isFalse.GetType());
        Assert.True(isTrue);
        Assert.False(isFalse);
    }


    /// <summary>
    /// To test this method, do the following:
    /// make sure you're in your BasicCSharp folder in your terminal
    /// type 'dotnet test --filter DisplayName=BasicCSharp.UnitOne.CreateString' (without quotes)
    /// </summary>
    [Fact]
    public void CreateString()
    {
        //String is a data type that holds multiple characters.
        //We can easily create strings by using double quotes ("") around a collection of characters.
        string foo = "bar";

        //try it yourself- create a string variable named "bar" and assign the value "foo"
        /**
            A quick warning, even though they may look very similar, C# interprets single quotes as Char, a data type that represents a single character, such as 'b'. You'll get an error if you try to do the following
            string foo = 'bar';
        */

        string bar = "foo";


        //Do not touch the following code!!
        Assert.Equal(typeof(string), bar.GetType());
        Assert.Equal("foo", bar);
    }
}


