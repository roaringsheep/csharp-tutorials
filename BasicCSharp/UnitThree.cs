#pragma warning disable CS0219
using Xunit;

namespace BasicCSharp;
public class UnitThree
{
    [Fact]
    public void EqualityComparisonOperator()
    {
        /**
            Equality comparison operator (==) is used to check whether the left and the right side is the same or not
        */
        
    }
    /// <summary>
    /// To Test This Method: do the following
    /// make sure you're in your BasicCSharp folder in your terminal
    /// type 'dotnet test --filter DisplayName~BasicCSharp.UnitThree.ConditionalStatements' (without quotes)
    /// </summary>
    [Theory]
    [InlineData("morning")]
    [InlineData("evening")]
    public void ConditionalStatements(string timeOfTheDay)
    {
        /**
            statement is a piece of code that tells the computer to do *something*.
            Expression on the other hand is anything that evaluates to a value.
            true is an expression, so is 3, and "hello".
            bool amBoolean = true; is a statement because we're telling the computer to create a variable that will hold a boolean value and assign the value true to the variable.

            Conditional Statements (or If/Else statements) are statements that can act different ways based on given conditions
            it always starts with a required if statement that states the condition to be evaluated to either true or false.
            if the condition evaluates to true, computer executes the code inside if block (the code inside curly brackets that appear after if)
            if the condition evaluates to false, computer does not executes the if block. If there is an optional else statement, the computer will execute code in the else block.
            Let's see it in action
        */

        bool hadCoffee = true;
        string message;

        if(hadCoffee == true)
        {
            message = "Now you're ready for the day!";
        }
        else
        {
            message = "Why haven't you had one yet? Here you go";
        }

        //A few things to note here: we first declare hadCoffee boolean variable and initialize it to true.
        //then an if/else statement follows, that compares whether hadCoffee is equal to true or not. Notice how we are using == operator here, it is an equality comparison operator where the computer will compare whether the left hand value and the right hand value is in fact the same. To do the opposite, use the inequality operator, which is !=. We can also compare numbers using < (left strictly less than right), > (left strictly greater than right), <= (left less than or equal to right), and >= (left greater than or equal to right).
        //this conditional statement will dynamically (on the go) set the value of string variable message, based on hadCoffee variable. if hadCoffee is true, the message will be "Now you're ready for the day!" and if hadCoffee is not true (so false), the message will hold the value of "Why haven't you had one yet? Here you go"
        //This behavior will be far more dynamic once we start asking users for their input. Then we'll be able to dynamically alter our responses based on user inputs! 


        //Your Turn: complete a conditional statement that will display a different greeting of the day depending on time of the day:
        //If timeOfTheDay is "morning", the greeting should be "Good Morning"
        //if timeOfTheDay is anything else, the testMessage should be "Hello"
        //**Don't worry about not seeing the timeOfTheDay variable. It'll work, I promise!**
        string greeting;
        if(timeOfTheDay == "morning") //this here is equivalent to if(hasPet == true) because hasPet is either true or false.
        {
            //your code here

            greeting = "Good Morning";

            //Testing Code
            //do not touch this line!
            Assert.Equal("Good Morning", greeting);
        }
        else
        {
            //else condition code here
            greeting = "Hello";



            //do not touch this line!
            Assert.Equal("Hello", greeting);
        }
    }


    /// <summary>
    /// To Test This Method: do the following
    /// make sure you're in your BasicCSharp folder in your terminal
    /// type 'dotnet test --filter DisplayName~BasicCSharp.UnitThree.WhileLoop' (without quotes)
    /// </summary>
    [Theory]
    [InlineData(10)]
    [InlineData(30)]
    public void WhileLoop(int countdown)
    {
        //Loop is a type of statement that will continuously execute any code inside of the loop until a certain condition has been met. There are few different types here, but one we'll see here is called while loop.
        //A while loop is a type of loop that will continuously execute WHILE the condition is true
        //syntax is the following: 
        // while(/*condition*/)
        // {
        //     //any code here will continuously be executed while the condition evaluates to true
        // }
        //so... this will create a phenomena called "infinite loop"
        //while(true) { ... }
        //since the condition is never false!

        //your turn: Create a while loop that will subtract 1 from countdown variable WHILE countdown variable is greater than 0.
        //In other case, when we exit the loop, the countdown variable should be 0.
        
        while(countdown > 0)
        {
            countdown--;
        }

        Assert.Equal(0, countdown);
    }

    /// <summary>
    /// To Test This Method: do the following
    /// make sure you're in your BasicCSharp folder in your terminal
    /// type 'dotnet test --filter DisplayName~BasicCSharp.UnitThree.ForLoop' (without quotes)
    /// </summary>
    [Theory]
    [InlineData(10)]
    public void ForLoop(int timesToLoop)
    {
        //For loop is similar to while loop, with an additional important feature, a built in counter!
        //If you ever wondered, huh, how do i know how many times i have executed this loop... well you're in luck!
        //the syntax is the following:
        //for([initialize counter]; [condition]; [increment(or decrement) counter])
        //{ // code here}

        for(int i = 0; i < 10; i++)
        {

        }
        //this above loop will declare an integer variable called i and assign the value 0. then every time we complete the loop, we'll add 1 to i. The loop will continue to execute while i is less than 10. When i = 10, the loop will terminate.

        //that for loop is equivalent to the following while loop
        int j = 0;
        while(j < 10)
        {
            j++;
        }

        

        //now your turn: create a for loop that will loop for while the counter i is less than the integer variable timesToLoop. (The variable timesToLoop have already been given to you, you won't be declaring or initializing them. Just simply set the i to be less than timesToLoop) Each time you loop, add 2 to the integer variable aCounter.
        int aCounter = 0;
        for(int i = 0; i < timesToLoop; i++)
        {
            aCounter += 2;
        }

        Assert.Equal(timesToLoop * 2, aCounter);
    }
    

    [Fact]
    public void Arrays()
    {
        //Arrays are a type of data structure that can hold many items together.
        //so far we created variable
    }
}