/* Build a program with a variable of all fourteen types described in this level.
Assign each of them a value using a literal of the correct type.
Use Console.WriteLine to display the contents of each variable.*/

byte unByte = 255;
sbyte unSbyte = -128;
short unShort = 32767;
ushort unUshort = 65535;
int unInt = 2147483647;
uint unUint = 4294967295;
long unLong = 9223372036854775807;
ulong unUlong = 18446744073709551615;
float unFloat = 3.4E+38F;
double unDouble = 1.7E+308;
decimal unDecimal = 79228162514264337593543950335M;
char unChar = 'A';
string unString = "Hello World!";
bool unBool = true;
Console.WriteLine("Una variable byte: "+unByte);
Console.WriteLine("Una variable sbyte: "+unSbyte);
Console.WriteLine("Una variable short: "+unShort);
Console.WriteLine("Una variable ushort: "+unUshort);
Console.WriteLine("Una variable int: "+unInt);
Console.WriteLine("Una variable uint: "+unUint);
Console.WriteLine("Una variable long: "+unLong);
Console.WriteLine("Una variable ulong: "+unUlong);
Console.WriteLine("Una variable float: "+unFloat);
Console.WriteLine("Una variable double: "+unDouble);
Console.WriteLine("Una variable decimal: "+unDecimal);
Console.WriteLine("Una variable char: "+unChar);
Console.WriteLine("Una variable string: "+unString);
Console.WriteLine("Una variable bool: "+unBool);
Console.ReadKey();