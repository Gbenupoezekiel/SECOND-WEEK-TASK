// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// Week 2 Task: Exploring data types
// Understanding built-in data types, declaring and initialinzing variables and constants

//Numbers

// Int Types
int myNum = 10000;
Console.WriteLine(myNum);

//Long
long myLNum = 20000000;
Console.WriteLine(myLNum); 

//Floating Point types
//Float Examples
//Always end the data type wit F or D
float myFNum = 3.455F;
Console.WriteLine(myFNum);

//Double
double myDNum = 2.6777D;
Console.WriteLine(myDNum);

//Booleans
//It uses the keyword bool tod eclare true or false
bool ILoveCsharp = true;
bool CsharpIsHard = false;
Console.WriteLine(ILoveCsharp);  //this will ouput true
Console.WriteLine(CsharpIsHard); //this will output false

//Characters; it uses the key word "char" to store a single character 
//NB: the single character must be inside a single quote
char myGrade = 'A';
Console.WriteLine(myGrade);

//Strings; data type used to store sequence of characters (text. it uses the keyword 'string')
//always quoted with double quotes
string greeting = "Hello World!";
Console.WriteLine(greeting);


//Type Casting; use to covert one data type to another i.e small to large and vice-versa
//Example
int myInt = 9;
double myDouble = myInt; // convert the int value into double
Console.WriteLine(myDouble);

double myDoubletype = 5.67;
int myintType = (int)myDoubletype;
Console.WriteLine(myintType); //outputs 9

//Data type Conversion Methods
//Examples
int myInt1 = 10;
double myDouble1 = 5.25;
bool myBool1 = true;

Console.WriteLine(Convert.ToString(myInt1));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt1));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble1));  // convert double to int
Console.WriteLine(Convert.ToString(myBool1));   // convert bool to string

//User Input; Console.Writeline() is used to output (print) values while Console.Readline is used to get user input
//Example

// Type your username and press enter
Console.WriteLine("Enter username: ");

// Create a string variable and get user input from the keyboard and store it in the variable
string userName = Console.ReadLine();

// Print the value of the variable (userName), which will display the input value
Console.WriteLine("Username is " + userName);

//User input and Numbers
// any data type can be converted using the 'Convert.To' methods


//Operators are used to perform operations on variables and values
// + for sum, - for difference, * for multiplication etc
//Examples
//sum +
int sum2 = 80 + 45;
Console.WriteLine(sum2); //outputs the sum of 80 and 45

//Difference -
int dif1 = 67 - 34;
Console.WriteLine(dif1); //outputs the difference between 67 and 34

// Multiplicatiion '*'
int prod1 = 24 * 45;
Console.WriteLine(prod1);

//Assignment operators; assignmnt operators are used to assign values to variables and variablesare memory location where values can be stored
//it uses the keyword '='
int numb3 = 10; //assigns the number 10 to the variable num3
Console.WriteLine(numb3);
//-= or += minus or adds a value to variables

//Comparison Operators
int x = 5;
int y = 2;
Console.WriteLine(x > y); //returns true bcos x is greater than y

//Logical operators are used to determine the logic between variables and values. we have logica AND ' &&', we have logical OR ' ||, and Logical NOT ' ! '
int z = 5;
Console.WriteLine(z > 2 && z < 20);
Console.WriteLine(z > 7 || z < 20);

//Maths
//Math.Max(x,y) method can be used to find the highest value of x and y
//Examples
int a = 5;
int b = 59;
Math.Max(a, b);

//math.sqrt(x) returns the square rot of x
int d = 25;
Math.Sqrt(d);

// Strings length ; the length property or method is used to find the length of a string
string txt = "hhghmfh  jdfhhhjhdff hdjdhdfh";
Console.WriteLine("the length of the txt string is: " + txt.Length);

//String to uppercase and lowercase method
string txt1 = ("hello! world");
Console.WriteLine(txt1.ToUpper()); //returns HELLO! WORLD



