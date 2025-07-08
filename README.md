# README: Old Phone KeyPad Converter
This simple C# class brings back that classic keypad phone experience, letting you convert input strings into the right text.

## Description

This handy utility gives you a single `OldPhoneKeyPad()` method that does all the heavy lifting. Just feed it a string of key presses, and it'll decode it into a readable message. It works just like you remember, handling everything from cycling through letters on a key to dealing with pauses and backspaces.

## Prerequisites

- .NET 8 or later

## Features

Here's what it can do:

- **Classic Text Conversion***: Translates digits (`0`-`9`) into their corresponding characters.
- **Character Cycling**: Handles pressing the same key multiple times to cycle through letters (e.g., `33` becomes `E`).
- **Pauses**: Recognizes a space character (` `) as a pause. This is how you can type consecutive letters that are on the same key (e.g., `222 2 22` becomes `CAB`).
- **Backspace Functionality**: Processes the `*` character as a backspace, deleting the previously typed character.
- **Input Termination**: Knows you're done typing when it sees a `#` character at the end of your input.

## How to Use

Since the entire solution is provided, getting started is straightforward.

  1. Clone or download the repository to your local machine.

  2. Open the solution file (e.g., OldPhoneKeyPad.sln) in your preferred IDE like Visual Studio or JetBrains Rider.

  3. Build and run the project. The main program is already set up to run the examples and will display the output in your console.

**Here's a quick example:**

```csharp
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Example 1: CAB
         string input1 = "222 2 22#";
        string output1 = OldPhoneKeyPadConverter.OldPhoneKeyPad(input1);
        Console.WriteLine($"OldPhonePad(\"{input1}\") -> Output: \"{output1}\"");

        // Example 2: E
        string input2 = "33#";
        string output2 = OldPhoneKeyPadConverter.OldPhoneKeyPad(input2);
        Console.WriteLine($"OldPhonePad(\"{input2}\") -> Output: \"{output2}\"");
    
        // Example 3: B
        string input3 = "227*#";
        string output3 = OldPhoneKeyPadConverter.OldPhoneKeyPad(input3);
        Console.WriteLine($"OldPhonePad(\"{input3}\") -> Output: \"{output3}\"");
        
    }
}

// Expected Output:
// OldPhonePad("222 2 22#") -> Output: "CAB"
// OldPhonePad("33#") -> Output: "E"
// OldPhonePad("227*#") -> Output: "B"

