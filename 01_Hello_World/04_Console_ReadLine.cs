
// =============================================
// LESSON 4: CONSOLE.READLINE
// SUBJECT: HELLO WORLD
// LEVEL: BEGINNER
// =============================================


// ---------------------------------------------
// 1. WHAT IS CONSOLE.READLINE()?
// ---------------------------------------------

// Console.ReadLine() reads text entered by the user.
// It waits until the user presses Enter.
// The entered text is returned as a string.


// ---------------------------------------------
// 2. BASIC USAGE
// ---------------------------------------------

string input = Console.ReadLine();

Console.WriteLine(input);


// ---------------------------------------------
// 3. STORING USER INPUT IN A VARIABLE
// ---------------------------------------------

// Create a string variable called name.
// Read the user's input and store it in name.

string name = Console.ReadLine();


// ---------------------------------------------
// 4. DISPLAYING THE INPUT
// ---------------------------------------------

// Display the value stored in the variable.

Console.WriteLine(name);


// ---------------------------------------------
// 5. UNDERSTANDING THE CODE
// ---------------------------------------------

// string = data type for text
// name = variable name
// = = assignment operator
// Console.ReadLine() = reads user input
// Console.WriteLine() = displays output


// ---------------------------------------------
// 6. IMPORTANT INFORMATION
// ---------------------------------------------

// Console.ReadLine() returns a string.
// Even when the user enters a number,
// the result is initially stored as text.


// ---------------------------------------------
// 7. PRACTICE EXERCISE
// ---------------------------------------------

// Create a method called GreetUser().
//
// 1. Read the user's name.
// 2. Store it in a string variable.
// 3. Display the name using Console.WriteLine().
//
// Method signature:
//
// public static void GreetUser()
//
//
// Expected output:
//
// Input: Alice
// Output: Alice
