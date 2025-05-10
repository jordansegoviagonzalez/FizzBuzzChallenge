// Write a public method that accepts a number
    //1. access modifier -
    //2. return type
    //3. Method Name
    //4. Parameters
    //5. Scope

// when the number is divisible by 3 return the word fizz

// when the number is divisible by 5 return the word buzz

// when the number is divisible by both, return the word fizzbuzz

public string FizzBuzz(int number)
// Ask question to the interviewer 
//public is the access mod
// string is the return type
// FizzBuzz is the methods name
//(int number) is the parmeters
{
    var answer = "";
    // var answer = ""; An empty string to hold the result, think of it like a nest.

    // when the number is divisible by 3 return the word fizz

    //Bellow we created if loops statements , 


    if(number % 3 == 0)
    //Cheks if the number is divisible by 3.
    {

        answer = "Fizz"
        //Asssigns "Fizz" to "aswer" if true.

    }

    if(number % 5 == 0)
    {
        answer += "buzz";
        //Checks if the number is divisible by 5. 

    }

    if (answer == "")
    // If not divisible by 3 or 5.
    {
        answer = number.ToString();
        //Returns the number itself as a string.
    }

    return answer;
    //Final result returned.









    
} 


// public is the access modifier that is set to public 
// string because is words (fizz, buzz, fizzbuzz)