using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

/*
 * TODO:
 * 1) Vytvoř třídu Rectangle, kterou budeme reprezentovat obecný obdélník
 *    Přidej třídě Rectangle dvě proměnné - width a height (datový typ nechám na tobě)
 *    Přidej třídě Rectangle tři funkce - CalculateArea, která spočítá obsah plochy obdélníka
 *                                      - CalculateAspectRatio, která spočítá poměr stran. Využij spočítaný poměr k určení toho, jestli je obdélník široký, vysoký, nebo je to čtverec
 *                                      - ContainsPoint, která jako vstupní parametr přijme souřadnice x,y nějakého bodu a určí, jestli se daný bod nachází v obdélníku, nebo ne,
 *                                                       a podle toho vrátí true/false
 *    Přidej třídě Rectangle konstruktor, který bude přijímat dva parametry - šířku a výšku, a při jeho zavolání je správně nastaví
 * 
 * 1) BONUS - Až vytvoříš Rectangle, zkus vytvořit obdobnou třídu se stejnou funkcionalitou pro kruh nebo třeba trojúhelník.
 * 
 * 2) Vytvoř třídu BankAccount, kterou budeme reprezentovat bankovní účet
 *    Přidej třídě BankAccount čtyři proměnné - accountNumber jako číslo účtu
 *                                            - holderName jako jméno osoby, které účet patří
 *                                            - currency jako měna, ve které je účet vedený
 *                                            - balance jako zůstatek na účtu
 *    Přidej třídě BankAccount čtyři funkce - Deposit, která jako vstupní parametr přijme množství peněz a vloží je na účet
 *                                          - Withdraw, která jako vstupní parametr přijme množství peněz a z účtu "vybere" peníze, tedy sníží zůstatek a navrátí požadované množství
 *                                                      Pokud na účtu není dostatek peněz, uživatele upozorní a vrátí nulu.
 *                                          - Transfer, která jako vstupní parametry přijme množství peněz a číslo účtu, na které se budou peníze posílat, a převede peníze
 *                                                      z jednoho účtu na druhý (opět pouze pokud je na účtu, ze kterého převod jde, dostatek peněz)
 *    Přidej třídě BankAccount konstruktor, který bude přijímat dva parametry - jméno majitele účtu a měnu, ve které bude účet vedený
 *                                                                            - Při jeho zavolání nastav jméno a měnu podle vstupních parametrů, accountNumber nastav jako náhodně
 *                                                                              vygenerované číslo velké alespoň 100 000 000 a menší, než 10 000 000 000 a balance nastav na nulu
 * 
 * 2) BONUS - Až vytvoříš BankAccount, přidej varianty funkcí výběru, vkladu a převodu s měnou jako vstupním parametrem, tedy pokud měna při vkladu/výběru (nebo měna účtu, na který se převádí)
 *            je odlišná od měny, ve které je účet veden, zohledni to a správně vynásob peníze kurzem, který najdeš na internetu. Pro uložení kurzů si můžeš udělat novou statickou třídu,
 *            ve které budeš mít public static float proměnné pojmenované podle toho, jaký kurz z jaké do jaké měny představují, a jeho hodnotu.
 *
 * 3) Vytvoř třídu Student, kterou budeme reprezentovat studenta
 *    Přidej třídě Student proměnné - year pro aktuální ročník studenta
 *                                  - id pro identifikační číslo studenta
 *                                  - subjects pro seznam předmětů studenta (bude to slovník (https://www.geeksforgeeks.org/c-sharp-dictionary-with-examples/), který bude mít jako klíč string a jako hodnotu List (https://www.geeksforgeeks.org/c-sharp-list-class/) známek) Dictionary<string, List<int>> subjects = new...        subjects["čeština"] = new List<int> { 2, 3, 1 }
 *                                  - name pro jméno studenta
 *    Přidej třídě Student čtyři funkce - AddSubject, která jako vstupní parametr přijme název předmětu a přidá nový klíč do subjects
 *                                      - AddGrade, která jako vstupní parametr přijme název předmětu a známku a přidá podle názvu předmětu další známku danému předmětu
 *                                      - CalculateSubjectGrade, která jako stupní parametr přijme název předmětu a spočítá průměrnou známku na vysvědčení z daného předmětu
 *                                      - CaculateTotalGrade, která spočítá studijní průměr (průměr všech známek)
 *    Přidej třídě Student konstruktor, který bude přijímat dva parametry - jméno a ročník studenta
 *                                                                        - Při jeho zavolání nastav jméno a ročník podle vstupních parametrů, id vygeneruj podobně, jako accountNumber
 *                                                                          ve tříde BankAccount, a subjects nastav na nový prázdný List
 * 
 * 3) BONUS - Až vytvoříš Student, přidej možnost mít u známek váhy. Způsob nechám na tobě, možností je víc. Můžeš celou třídu překopat na známky pouze s váhou, a nebo můžeš zachovat
 *            možnost přidávat známky bez váhy s tím, že ty budou mít nějakou výchozí váhu automaticky, a přidáš varianty funkcí na přidávání známek s váhou
 * 
 * V mainu využívej tebou naprogramované třídy a funkce, vypisuj výsledky do konzole, hraj si s tím a sleduj, co se kdy děje a co kdy jaká třída dělá.
 * Když si s něčím nebudeš vědět rady, zvedni ruku nebo na mě zavolej, já přijdu a poradím :)
 * Uděláš, co stihneš. Budeme na tom pracovat i nadále, takže se nestresuj časem a v klidu si všechno postupně rozmýšlej a piš takovým tempem, jaké je ti příjemné.
 */

namespace ClassPlayground
{
    internal class Program
    {
        static int Getnumber()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("úloha 1 = a, úloha 2 = b, úloha 3 = c");
            Random rnd = new Random();
            char o = Convert.ToChar(Console.ReadLine());
            switch (o)
            {
                case 'a':
                    Console.WriteLine("úloha 1 zadej šířku a výšku");
                    Rectangbluble rectangle1 = new Rectangbluble();
                    rectangle1.width = Getnumber();
                    rectangle1.height = Getnumber();
                    int obsah = rectangle1.Getarea();
                    float ratio = rectangle1.Ratio();
                    Console.WriteLine("Obsah tohoto obdélníku je " + obsah + " poměr stran je " + ratio);
                    break;
                
                case 'b':
                    Console.WriteLine("úloha 2 bankovní účet, číslo účtu je náhodně generované, zadej jméno majitele a měnu, ve které je účet veden, balance je defaultně nula");
                    BankAccount account1 = new BankAccount();
                    account1.accountNumber = new Random().Next(100000000,1000000000);
                    account1.balance = 0;
                    account1.ownerName = Console.ReadLine();
                    account1.currency = Console.ReadLine();
                    account1.Stats();
                    Console.WriteLine("kolik mám na účet poslat z účtu agrofertu");
                    account1.Deposit(Getnumber());
                    account1.Stats();
                    Console.WriteLine("kolik z účtu mám poslat na účet Gymvodu?");
                    account1.Withdrawn(Getnumber());
                    account1.Stats();
                    Console.WriteLine(" tak a teď si založíme druhý učet abychom mezi nimi mohli posílat");
                    BankAccount account2 = new BankAccount();
                    account2.accountNumber = new Random().Next(100000000, 1000000000);
                    account2.balance = 0;
                    account2.ownerName = Console.ReadLine();
                    account2.currency = Console.ReadLine();
                    account2.Stats();
                    Console.WriteLine($"pro jednoduchost půjdou posílat peníze pouze z účtu {account1.accountNumber} na {account2.accountNumber}, zadej kolik chceš převést");
                    account1.Trasnsfer(Getnumber(), account2 );
                    account1.Stats();
                    account2.Stats();
                    break;
                
                case 'c':
                    Console.WriteLine("úloha 3 student, zadej jméno studenta, jeho id a ročník, a přidej předmět");
                    student newstudent = new student();
                    newstudent.name = Console.ReadLine();
                    newstudent.id = Getnumber();
                    newstudent.year = Getnumber();
                    newstudent.AddSubject(Console.ReadLine());
                    Console.WriteLine($"Jméno studenta je {newstudent.name} jeho id je {newstudent.id} je v {newstudent.year}. ročníku ");
                    break;
                
                default:
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
