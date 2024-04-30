// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// string value = "bad;
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }
// if (result > 0)
// {
//     Console.WriteLine($"Measurement (w/ offset): {50 + result}");
// }

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// Rule 1: If the value is alphabetical, concatenate it to form a message.
// Rule 2: If the value is numeric, add it to the total.
// Rule 3: The result should match the following output:

//show me how to do this
// decimal total = 0m;
// string message = string.Empty;
// foreach (string value in values)
// {
//     decimal number;
//     if (decimal.TryParse(value, out number))
//     {
//         total += number;
//     }
//     else
//     {
//         message += value;
//     }
// }
// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

//Solve for result1: Divide value1 by value2, display the result as an int
int result1 = (int)Math.Round((decimal)value1 / value2);
//or int result1 = Convert.ToInt32(value1 / value2);
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

//Solve for result2: Divide value2 by value3, display the result as a decimal
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

//Solve for result3: Divide value3 by value1, display the result as a float
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");