﻿// Console.WriteLine("Generating random numbers:");
// for (int i = 0; i < 10; i++)
// {
//     Console.Write($"rando number {i}:\t");
//     DisplayRandomNumbers();
// }
// void DisplayRandomNumbers()
// {
//     Random random = new Random();
//     for (int i = 0; i < 5; i++)
//     {
//         Console.Write($"\t{random.Next(1, 100)}");
//     }
//     Console.WriteLine();
// }



// int[] times = {800, 1200, 1600, 2000};
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");
// DisplayTimes();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     AdjustTimes();
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");
// DisplayTimes();

// void DisplayTimes()
// {
//     /* Format and display medicine times */
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }
//     Console.WriteLine();
// }

// void AdjustTimes() 
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }

/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/
// string[] ipAddress = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255", "22.36.02.154" };
// string[] address;
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// foreach (string ip in ipAddress)
// {
//     address = ip.Split('.', StringSplitOptions.RemoveEmptyEntries);

//     ValidateLength();
//     ValidateZeroes();
//     ValidateRange();

//     Console.WriteLine((validLength && validZeroes && validRange) ? $"{ip} is valid ipAddress" : $"{ip} is not a valid ipAddress");
// }

// void ValidateLength()
// {
//     validLength = address.Length == 4;
// }

// void ValidateZeroes()
// {
//     foreach (string a in address)
//     {
//         if (a.Length > 1 && a.StartsWith("0"))
//         {
//             validZeroes = false;
//             return;
//         }

//     }
//     validZeroes = true;
// }

// void ValidateRange()
// {
//     foreach (string a in address)
//     {
//         if (!Int32.TryParse(a, out int value) || value < 0 || value > 255)
//         {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// }

Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

TellFortune();

void TellFortune()
{
    Console.WriteLine("A fortune teller whispers the following words:");
string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
for (int i = 0; i < 4; i++) 
{
    Console.Write($"{text[i]} {fortune[i]} ");
}
}