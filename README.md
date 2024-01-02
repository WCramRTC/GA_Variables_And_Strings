# Guided Assignment - Introduction to Variables and Strings

## Introduction
In this assignment we take a look at the key fundamentals of programming, variables.

If you think about memory in a computer as an empty book shelf, a variable is a box with a specific size and shape that you write a name on, and then put something of value in and place on the shelf.

`string variableName = "Will"`

- In this example the box "size and shape" is string. Anything that I put inside of it HAS to be a string. 
- Next is the word `variableName`, the is the name we give our variable. 
- The `=` is how we assign a value to our variable name.
- And `"Will"` is the value assigned to our `variableName`.

---

## Requirements

1. Create a new console application called GA_Strings_***YourName***
2. Follow the step by step instructions
3. Upload to github and submit the repo link in canvas

---

### Starting Code
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World");
    }
}
```

We are going to focus on the Main code block.

**Write this code**  
- Add a comment to the bottom curly brace of our Main code block. 

`// End of Main`

```csharp
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World");
    } // End of Main
```

---

### **Step 1: Display Your First Name**

Replace `"Hello, World"` with your First Name. Make sure to wrap your name in double quotes.

```csharp
static void Main(string[] args)
{
    Console.WriteLine("Your First Name");
} // End of Main
```

**Run your code**  
You should see your name appear.

***Example***
```
William
```

**What's Happening**

Wrapping anything in double quotes, `""`, tells C# that the phrase between is a `String`. A string is a sequence of characters, such as words or paragraphs.

In `Console.WriteLine("Your First Name");`

---

### **Step 2: Declaring a string variable**

Now we are going to create a variable to hold our name. 

> Variables are named containers used to hold data values.  
> [W3 Schools - Variables](https://www.w3schools.com/cs/cs_variables.php)

1. Above our `Console.WriteLine()` write the following code, putting YOUR first name.

```csharp
    string myFirstName = "Your First Name"; // Replace with your first name
```

2. Then replace
```csharp
    Console.WriteLine("Your First Name"); // Replace this
```

with 

```csharp
    Console.WriteLine(myFirstName); // With this
```
    
    

> When using a variable name, you don't not want to wrap it in double quotes. Wrapping your variable name in double quotes will just turn it into a string.  
> Example:   
> Declare a variable: `string myFirstName = "Will";`  
> No Quotes: `Console.WriteLine(myFirstName); // Prints Will`  
> Double Quotes: `Console.WriteLine("myFirstName"); // Prints myFirstName`  


```csharp
static void Main(string[] args)
{
    // Declare a string variable and assigning my name
    string myFirstName = "Your First Name";

    // Displaying my name
    Console.WriteLine(myFirstName);
} // End of Main
```

**Run your code**  

Your name will appear again, but this time we use the value stored in our variable.

```
William
```

**What's Happening**

We have just **Declared** our first variable. 
When we declare a variable in C#, we instruct the program to allocate memory, assign it a specific name, and specify a particular data type for storing values.

The syntax is

### ***type name = value;***

So with `string firstName = "Will;"`
- Type: `string`
- Variable Name: `firstName`
- Assignment Operator: `=`
- Value: `Will`

Once we have **Declared** our variable and given it a name, and assigned a value, we can call it over and over again by just using the variable name.

---

### **Step 3: Declaring a second string variable**

1. Declare a second variable called `myLastName` underneath `myFirstName`.
2. Assign your last name
3. Replace `myFirstName` with `myLastName` in our `Console.WriteLine();` 

```csharp
static void Main(string[] args)
{

    string myFirstName = "Your First Name";
    // Declare a new string variable and assign YOUR last name
    string myLastName = "Your Last Name";
    
    // Display `myLastName`
    Console.WriteLine(myLastName);
} // End of Main
```


**Run your code**  

Your last name should now appear

```
Cram
```

### **Step 4: Concatenating Strings**

What if we wanted to display more than 1 string at a time, for that we can ***Concatenate*** our strings, which is a fancy word for ***Adding Them Together***.

1. Declare a 3rd variable underneath our `myLastName` variable, and call it `myFullName`.
2. Instead of typing in your name we are going to add your `myFirstName` and `myLastName` variables together, and assign the value to `myFullName`.

```csharp
    string myFullName = myFirstName + " " + myLastName;
```

3. Pass this variable into our `Console.WriteLine()`.

```csharp
static void Main(string[] args)
{

    string myFirstName = "Your First Name";
    string myLastName = "Your Last Name";

    // Concatenating our first and last name
    string myFullName = myFirstName + " " + myLastName;
    
    // Display `myLastName`
    Console.WriteLine(myFullName);
} // End of Main
```

**Run The Code**

If it runs correctly you should see your full name display.

```
William Cram
```

***What happened?***

We just added our 2 strings together to make one long string, this is called ***`Concatenation`***. We can either insert words at the end of other strings, or even between to format our result.

In our variable `myFullName` notice how we added an space inbetween our two variables, " ". That was literally adding a space between our first and last name. Without that it would just add the two words directly together.

```csharp
    myFirstName + myLastName; // Result WilliamCram
    myFirstName + " " + myLastName; // Result William Cram
```

### **Step 5: Reassigning Values**

What happens if we want to change a value to one of our variables? We can reassign a value.

1. Underneath `Console.WriteLine(myFullName)` add the following code.

```csharp
    // Reassigning my teachers name to myFirstName
    myFirstName = "William";
    // Reassigning my teachers name to myLastName
    myLastName = "Cram";
    // Adding another string to myFullName
    myFullName = myFirstName + " " + myLastName + " is my professor";
    // Displaying the result
    Console.WriteLine(myFullName);
```

6. Upload to GitHub and Submit in Canvas

---

## Rubric

| Criteria | Description | Points |
|----------|-------------|--------|
| **Project Setup** | Proper creation of a new console application named GA_Strings_YourName. | 20 |
| **Implementation of Initial Code** | Correct implementation of the initial code block with string variables and `Console.WriteLine()`. | 15 |
| **Code Modification** | Accurate modification of the `myFirstName` and `myLastName` variables. | 15 |
| **String Concatenation** | Correct use of string concatenation to form `myFullName`. | 15 |
| **Output Accuracy** | The final output matches the expected result, including proper string concatenation and correct names. | 20 |
| **Code Readability and Comments** | Clear and readable code with comments explaining each step. | 10 |
| **Running Code** | Code compiles and runs without errors. | 5 |
| **Submission** | Successful upload to GitHub and correct submission link provided on Canvas. | 10 |
| **Total** |  | 100 |

