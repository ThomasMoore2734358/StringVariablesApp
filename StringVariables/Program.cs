// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
string firstName = string.Empty;
string lastName = string.Empty;
string filePath = string.Empty;

firstName = "Pipi";
lastName = "Kaka";

Console.WriteLine(firstName + " " + lastName);

Console.WriteLine($"Hello, {firstName} {lastName}!"); // Подстановка переменных в строку

filePath = "c:\\temp\\drive";
//OR
filePath = @"c:\temp\drive";

//and now we can do that:

Console.WriteLine($@"Your name is {firstName}, and your secrets are in a folder called {filePath}");

// strings

int age = 0;
age = 43;

int ageInTenYears = age + 10;

// max =~ two billions +-
// signed int32
// Unsigned - 4 billions
// bit = 1 or 0
// 

Console.WriteLine(age);
Console.WriteLine(age.ToString()); // turning int into string

Console.WriteLine(ageInTenYears);

//Do not divide ints
Console.WriteLine(age / 2);

//Double

double averageAge;

averageAge = (43.0 + 22 + 33) / 3;
Console.WriteLine(averageAge);

//Decimal

decimal bankAccountBalance;

// next comand will turn into double and we don't want that
// bankAccountBalance = 3.45; 
// and this is how we fix that:

bankAccountBalance = 2.34M;

Console.WriteLine(bankAccountBalance);

// Bool
// True or False

bool isComplete = true;

isComplete = !isComplete;

Console.WriteLine(isComplete);
Console.WriteLine(!isComplete);

// Null allows us to say that variable lacks of value
// it allows variable to store NULL value
// nullAble

int? myAge = null;
