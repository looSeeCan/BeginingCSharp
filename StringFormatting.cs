using System;

namespace BeginingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("hello world"); 
            Console.WriteLine("Escape Character Sequence");//Use character escape sequences when you need to insert a special character into a literal string, like a tab \t, new line \n, or a double quotion mark

            Console.WriteLine("Hello\nWorld!");//escape character sequences
            Console.WriteLine("Hello\tWorld!");//the n will add the world on a new line and the t will add a tab

            //Console.WriteLine("Hello "World"!");//what if you want to have qoutes around "World"
            Console.WriteLine("Hello \"World\"!");//so I think that if you put the escape character in front of hte quotes
            Console.WriteLine("c:\\source\\repos\n");//to solve the problem for file extensions, use a double slash
            
            Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");//the \n is like a break.
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t\n");

            Console.WriteLine("Verbatim String Literal");//use the @ directive to create a verbatim string literal that keeps all whitespace formatting and backslash characters in a string

            //Console.WriteLine("c:\source\repos");//unrecognized escape sequence
            Console.WriteLine("c:\\source\\repos");//escape sequence
            Console.WriteLine(@"verbatim string literal: c:\source\repos");//verbatim string literal
            Console.WriteLine("\n");

            Console.WriteLine("Generating invoices for customer \"ABC Corp\"...\n");
            Console.WriteLine("Invoice: 1021\t\tComplete");
            Console.WriteLine("Invoice: 1022\t\tComplete\n");
            Console.WriteLine("OutPut Directory:");
            Console.WriteLine(@"c:\invoices");//verbatim string literal
            Console.WriteLine("\n");

            Console.WriteLine("Unicode Escape Characters");

            // Kon'nichiwa World
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");//these are supposed to be Japanese characters
            Console.WriteLine("\u3053");//windows prompt will show question mark characters instead
            Console.WriteLine("\u3093");
            Console.WriteLine("\u306b");
            Console.WriteLine("\u3061");
            Console.WriteLine("\u306f");
            Console.WriteLine("World!\n");

            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            Console.WriteLine(@"c:\invoices\app.exe -j");

            Console.WriteLine("\nGeneratng invoices for custormer \"ABC Corp\" ...\n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");
            Console.WriteLine(@"c:\invoices");
            //To generate Japanese invoices:
            //Nihon no seikyu-sho o seisei suru ni wa:
            Console.Write("\n\n\u6535\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            Console.WriteLine(@"c:\invoices\app.exe -j");

            Console.WriteLine("\nUNIT 3");
            Console.WriteLine("Exercise - String Concatenation\n");

            string firstName = "Bob";
            string message = "Hello " + firstName;
            string message1 = "Hello" + " " + firstName;
            Console.WriteLine(message);
            Console.WriteLine(message1);

            string firstName1 = "Bob";
            string greeting1 = "Hello";
            string message2 = greeting1 + " " + firstName1 + "!";//intermediate variables
            Console.WriteLine(message2);

            
            string firstName2 = "Bob";
            string greeting2 = "Hello";
            Console.WriteLine("\n" + greeting2 + " " + firstName2 + "!");//avoid using intermediat varables by performing the concatenatiion operation as you need it

            Console.WriteLine("\nUnit 4");
            Console.WriteLine("String Interpolation\n");

            Console.WriteLine($"{greeting2} {firstName2}!");

            Console.WriteLine("\nCombine verbatime literals and string interpolation");
            string projectName = "First-Project";
            Console.WriteLine($@"c:\Output\{projectName}\Data");

            Console.WriteLine("\nUnit 5 Challenge\n");

            Console.WriteLine("\n");

            string projectName2 = "Acme";
            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            Console.WriteLine($@"View English output: 
        c:\Exercise\{projectName2}\data.txt");//so here I could not figure out how to get to the second line so I just hit enter and manually placed it
            Console.WriteLine($@"{russianMessage}:
        c:\Exercise\{projectName2}\ru-RU\data.txt");

            Console.WriteLine("\n");

            //^this is a correct solution. you can only create two instructions that actually print output to the console. If you need to print additional new lines or add any formatting, you must use what you've learned in this module to accomplish it.
            string englishLocation = $@"c:\Exercise\{projectName2}\data.txt";//the solution was to declare another variable and with the interpolation and directive 
            string russianLocation = $@"c:\Exercise\{projectName2}\ru-Ru\data.txt";
            Console.WriteLine($"View Engllish output:\n\t\t{englishLocation}\n");//then just use the interpolation here with the following escape sequences
            Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");//escape sequences: new line then tab tab
            */
            ////////////////////////////////////////////////////////
            //Add decision logic to your code

            // Random dice = new Random();//create a new instrance of the System.random class and store the reference to that object inthe dice variable
            // Console.WriteLine(dice);

            // int roll1 = dice.Next(1,7);//then we call the Random.Next method. (lower bounds, upperbounds)
            // int roll2 = dice.Next(1,7);//picks a number from 1 to 6
            // int roll3 = dice.Next(1,7);
            
            // Console.WriteLine(roll1);
            // Console.WriteLine(roll2);
            // Console.WriteLine(roll3);

            // int total = roll1 + roll2 + roll3;//sum of the dice rolls
            // Console.WriteLine("\n");
            // Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            // if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))//if there is a double
            // {
            //     if ((roll1 == roll2) && (roll2 == roll3))//if there is a tripple
            //     {
            //         Console.WriteLine("You rolled tripples! +6 bonus to total!");
            //     }
            //     else //just doubles
            //     {
            //     Console.WriteLine("You rolled doubles! + 2 bonus to total!");
            //     total +=2;
            //     Console.WriteLine(total);
            //     }
            // }
            
            // string win = "You Win";
            // if(total >= 16)//so I initially wrote this if statement ascending: 7, 10, 16. when the total was 16 it would 
            //     //the else if for the macbook would execute. IDKW, but when I rewrote it descending it works.
            // {
            //     Console.WriteLine($"{win} a brand new GTR!");
            // }
            // else if(total >= 10)
            // {
            //     Console.WriteLine($"{win} a brand new MacBook!");//when you only want one outcome to happen, but you have several possible condtions and results, then
            //     //use as many else if statements as you want
            // }
            // else if(total == 7)
            // {
            //     Console.WriteLine($"{win} a Cruise Trip to the Bahamas!");
            // }
            // else
            // {
            //     Console.WriteLine($"{win} a fluffy kitty!");
            // };
            // string message = "The quick brown fox jumps over the lazy dog.";
            // bool result = message.Contains("fox");

            // if (result)
            // {
            //     Console.WriteLine("What does the fox say?");
            // }   
            // else
            // {
            //     Console.WriteLine("What fox!!");
            // };

            // Console.WriteLine("\n");
            
            // //Challenge
            // Random random = new Random();
            // int daysUntilExpiration = random.Next(12); Console.WriteLine($"Days Untill: {daysUntilExpiration}");
            // int discountPercentage = 0;

            // string sub = "Your subscription";
            // if (daysUntilExpiration == 0)
            // {
            //     Console.WriteLine($"{sub} has expired.");
            // }
            // else if(daysUntilExpiration == 1)
            // {
            //     Console.WriteLine($"{sub} expires within a day! Renew now and save {discountPercentage + 20}%!");

            // }
            // else if(daysUntilExpiration <= 5)
            // {
            //     Console.WriteLine($"{sub} expires in {daysUntilExpiration} days. Renew now and save {discountPercentage + 10}%!");
            // }

            // if(daysUntilExpiration <= 10 && daysUntilExpiration >= 6)
            // {
            //     Console.WriteLine($"{sub} will expire soon. Renew now!");
            // }
            // else if(daysUntilExpiration > 10)
            // {
            //     Console.WriteLine(daysUntilExpiration);
            // }
            //Challenge Solution in notes.
            //so I did this pretty mucy exactly the way the lesson wanted me to do it. I just misinterpreted the instructions
            //branch or nest 3 in the first if statement. I thought I could only use three of the rules in the first if statement
            //I misinterperted the rules a bit. But I knew that I could just use all else ifs.
            /////////////////////////////////////////////////////////

            ///////////////////////////////////////////////////////////////
            ///Store and iterate thru sequences of datat using Arrays and the forEach statement

            // string [] fraudulentOrderIDs = new string[3];//declaring an array of strings
            // Console.WriteLine(fraudulentOrderIDs);

            // fraudulentOrderIDs[0] = "A123";//assigning a value to the array
            // fraudulentOrderIDs[1] = "B456";
            // fraudulentOrderIDs[2] = "C789";

            string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

            Console.WriteLine(fraudulentOrderIDs);
            Console.WriteLine($"first: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"third: {fraudulentOrderIDs[2]}");

            Console.WriteLine($"reasign first: {fraudulentOrderIDs[0] = "F000"}");
            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fruadulent orders to process.");

            string[] names = {"Lucycan", "Sheng", "Pang"};
            foreach(string value in names)
            {
                Console.WriteLine(value[0]);
            }

            int[] inventory = {200, 450, 700, 175, 250};
            int bin = 0;
            int sum = 0;
            foreach(int items in inventory)
            {   
                sum += items;
                bin ++;
                Console.WriteLine($"Bin: {bin} has {items} finished products. Total:{sum}.");

            }
            Console.WriteLine($"We have {sum} items in the inventory.");
        
            
            ///Challenge
            string[] fakeOrderIds = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"}; 
            Console.WriteLine(fakeOrderIds);
            foreach(string item in fakeOrderIds)
            {
                if(item.StartsWith("B"))
                {
                    Console.WriteLine($"B Orders: {item}");
                }
                else
                {
                    Console.WriteLine(item);
                };
            }
        }



    }
}