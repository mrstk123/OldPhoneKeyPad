namespace OldPhoneKeyPad;

class Program
{
    public static void Main(string[] args)
    {
        string input1 = "222 2 22#";
        string output1 = OldPhoneKeyPadConverter.OldPhonePad(input1);
        Console.WriteLine($"OldPhonePad(\"{input1}\") -> Output: \"{output1}\"");

        string input2 = "33#";
        string output2 = OldPhoneKeyPadConverter.OldPhonePad(input2);
        Console.WriteLine($"OldPhonePad(\"{input2}\") -> Output: \"{output2}\"");
    
        string input3 = "227*#";
        string output3 = OldPhoneKeyPadConverter.OldPhonePad(input3);
        Console.WriteLine($"OldPhonePad(\"{input3}\") -> Output: \"{output3}\"");
        
        string input4 = "4433555 555666#";
        string output4 = OldPhoneKeyPadConverter.OldPhonePad(input4);
        Console.WriteLine($"OldPhonePad(\"{input4}\") -> Output: \"{output4}\"");
        
        string input5 = "8 88777444666*664#";
        string output5 = OldPhoneKeyPadConverter.OldPhonePad(input5);        
        Console.WriteLine($"OldPhonePad(\"{input5}\") -> Output: \"{output5}\"");

        Console.WriteLine("\n------------------------------------------");
        Console.WriteLine("--- Interactive Mode ---");
        Console.WriteLine("Enter your own keypad string to test.");
        Console.WriteLine("Type 'e' or 'q' to close the program.");
        Console.WriteLine("------------------------------------------\n");
        
        while (true)
        {
            Console.Write("Input:  ");
            string userInput = Console.ReadLine();

            // Check for exit condition
            if (userInput.ToLower() == "e" || userInput.ToLower() == "q")
            {
                break; // Exit 
            }
            
            string output = OldPhoneKeyPadConverter.OldPhonePad(userInput);

            Console.WriteLine($"Output: {output}\n");
        }

        Console.WriteLine("Program has ended. Press any key to close the window.");
        Console.ReadKey();
    }
}