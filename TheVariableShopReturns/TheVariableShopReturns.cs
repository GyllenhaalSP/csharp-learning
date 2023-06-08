/* Build a program with a variable of all fourteen types described in this level.
Assign each of them a value using a literal of the correct type.
Use Console.WriteLine to display the contents of each variable.*/

byte unByte = 254;
sbyte unSbyte = -127;
short unShort = 32766;
ushort unUshort = 65534;
int unInt = 2147483646;
uint unUint = 4294967294;
long unLong = 9223372036854775806;
ulong unUlong = 18446744073709551614;
float unFloat = 3.4E+37F;
double unDouble = 1.7E+307;
decimal unDecimal = 79228162514264337593543950334M;
char unChar = 'B';
string unString = "Hello Mario!";
bool unBool = false;
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