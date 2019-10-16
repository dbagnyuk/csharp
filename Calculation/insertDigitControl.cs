using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDigitInsert
{
    class insertDigitControl
    {
        public static double processingInput()
        {
            char enteredSymbol; // char for the value of the pressed key
            char decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0]; // default decimal separator which depends on the local settings
            int stringSize = 64; // size for char array in which we will store the entered digits
            var sString = new char[stringSize]; // char array in which we will store the entered digits
            int digitsCount = 0; // how many digits we already store
            bool separatorCount = false; // control if decimal separator is already entered

            // loop in which we will analyze pressed keys
            while (true)
            {
                // read the ASCII code from pressed button and save it in char. ReadKey(true) - is for decline write it in console
                enteredSymbol = Console.ReadKey(true).KeyChar;

                // condition: if the entered symbol is a digit between 0 and 9
                // and the count of entered digits less than the size of the char array
                if (enteredSymbol >= 48 && enteredSymbol <= 57 && digitsCount < stringSize)
                {
                    Console.Write((char)enteredSymbol);
                    sString[digitsCount++] = (char)enteredSymbol;
                }

                // condition: if the entered symbol is the dot or the comma
                // and the count of entered digits 1 or more
                // and the entered only one decimal separator
                // and the count of entered digits less than the size of the char array
                else if ((enteredSymbol == 46 || enteredSymbol == 44) && digitsCount > 0 && separatorCount == false && digitsCount < stringSize)
                {
                    separatorCount = true; // already entered decimal separator
                    enteredSymbol = decimalSeparator;
                    Console.Write((char)enteredSymbol);
                    sString[digitsCount++] = (char)enteredSymbol;

                }

                // condition: if the entered symbol is the dot or the comma
                // and no entered digits. if we entered decimal separator first
                // and the entered only one decimal separator
                // and the count of entered digits less than the size of the char array
                else if ((enteredSymbol == 46 || enteredSymbol == 44) && digitsCount == 0 && separatorCount == false && digitsCount < stringSize)
                {
                    separatorCount = true; // already entered decimal separator
                    enteredSymbol = '0'; // if we enter "." as first symbol we change entering on "0."
                    Console.Write((char)enteredSymbol);
                    sString[digitsCount++] = (char)enteredSymbol;
                    enteredSymbol = decimalSeparator;
                    Console.Write((char)enteredSymbol);
                    sString[digitsCount++] = (char)enteredSymbol;
                }

                // condition: if pressed Enter and we nothing entered before, we substitute "0" as value
                else if (enteredSymbol == 13 && digitsCount == 0)
                {
                    enteredSymbol = '0';
                    Console.Write((char)enteredSymbol);
                    sString[digitsCount++] = (char)enteredSymbol;
                    break;
                }

                // condition: if pressed Backspace we delete digit from char array which is we wrote in before
                else if (enteredSymbol == 8 && digitsCount > 0)
                {
                    digitsCount--;
                    Console.Write("\b \b"); // return cursor on the previous position
                    if (sString[digitsCount] == decimalSeparator)
                        separatorCount = false;  // when we delete decimal separator
                    sString[digitsCount] = '\0';
                }
                // condition: if pressed Esc we clear the char array and digits in console
                else if (enteredSymbol == 27)
                {
                    // clear the char array from digits we entered before
                    for (int i = 0; i < digitsCount; i++)
                    {
                        sString[i] = '\0';
                        Console.Write("\b \b"); // return cursor on the previous position
                    }
                    digitsCount = 0; // count of digits we entered should be 0
                    separatorCount = false; // false for entered separator trigger
                }

                // condition: if the Enter button pressed we finish read the entering
                else if (enteredSymbol == 13)
                    break;
            }

            Console.Clear(); // clearing the console

            string savedNumber = new string(sString); // creating the string variable and save in it all what is recorded on char array
            double d = Convert.ToDouble(savedNumber); // converting the string with our digits to double type variable

            return d; // return the double type digit
        }

    }
}
