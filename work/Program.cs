/* Вид 1

void Metod1()
{
    Console.WriteLine("Автор...");
}
Metod1(); */

/*void Metod2(string msg)
{
    Console.WriteLine(msg);
}
Metod2("Текст сообщения");
*/


/* Вид 2

void Metod21(string msg, int count)
{
    int i = 0;
    while (i < count){
        Console.WriteLine(msg);
        i++;
    }
}
//Metod21(msg:"Текст", count : 4);
Metod21(count : 4, msg:"Новый Текст"); */



/* Вид 3

int Metod3()
{
return DateTime.Now.Year;
}
int year = Metod3();
Console.WriteLine(year);   */

/* Вид 4

string Metod4(int count, string text)
{
   int i = 0;
   string result = String.Empty;

while (i<count)
    {
        result = result + text;
        i++;
    }
   return result;
}

string res = Metod4(10,"asdf");
Console.WriteLine(res);
 */