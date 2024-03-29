﻿using System;

namespace NetFundamentals
{
    public class Program
    {
        static void Main()
        {
            do
            {
                Print.Text("Select exercise to be done: \nDelete symbol from text(1),\nDelete symbol from text in RegularExpressions(2)," +
                "\nDelete symbol from text using dynamic array(3),\nCharacter-by-character text(4),\nReverse case text(5), \nGet highest and lowest number from array(6)");
                var variant = int.Parse(Console.ReadLine());
                Print.Text("Enter your text(tasks from 1 - 5)/numbers(task 6):");
                var textToWrite = Console.ReadLine();
                switch (variant)
                {
                    case 1:
                        var symbolToRemove = StringHelper.GetSymbolForDelete();
                        var newText = StringHelper.DeleteSymbol(textToWrite,symbolToRemove);
                        Print.Text(newText);
                        break;
                    case 2:
                        var symbolToCut = StringHelper.GetSymbolForDelete();
                        var newTextLine = StringHelper.DeleteByRegularExpressions(textToWrite,symbolToCut);
                        Print.Text(newTextLine);
                        break;
                    case 3:
                        var symbolToDelete = StringHelper.GetSymbolForDelete();
                        var newTextInLine = StringHelper.DeleteSymbolDynamic(textToWrite, symbolToDelete);
                        Print.Text(newTextInLine);
                        break;
                    case 4:
                        Print.TextToColumn(textToWrite);
                        break;
                    case 5:
                        var newTextToPrint = StringHelper.ReverseCase(textToWrite);
                        Print.Text(newTextToPrint);
                        break;
                    case 6:
                        var numberResults = ReturnNumbers.GetNumberResults(textToWrite);
                        Print.Text(numberResults, "Highest and lowest numbers in array are:");
                        break;
                }
                Print.Text("\nPress Enter to continue doing exercises or press the Escape (Esc) to quit!");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}



