namespace OldPhoneKeyPad;

class Program
{
    public static void Main(string[] args)
    {
        string input1 = "222 2 22#";
        string output1 = OldPhoneKeyPadConverter.OldPhoneKeyPad(input1);
        Console.WriteLine($"OldPhonePad(\"{input1}\") -> Output: \"{output1}\"");

        string input2 = "33#";
        string output2 = OldPhoneKeyPadConverter.OldPhoneKeyPad(input2);
        Console.WriteLine($"OldPhonePad(\"{input2}\") -> Output: \"{output2}\"");
    
        string input3 = "227*#";
        string output3 = OldPhoneKeyPadConverter.OldPhoneKeyPad(input3);
        Console.WriteLine($"OldPhonePad(\"{input3}\") -> Output: \"{output3}\"");
        
        string input4 = "4433555 555666#";
        string output4 = OldPhoneKeyPadConverter.OldPhoneKeyPad(input4);
        Console.WriteLine($"OldPhonePad(\"{input4}\") -> Output: \"{output4}\"");
        
        string input5 = "8 88777444666*664#";
        string output5 = OldPhoneKeyPadConverter.OldPhoneKeyPad(input5);        
        Console.WriteLine($"OldPhonePad(\"{input5}\") -> Output: \"{output5}\"");

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}