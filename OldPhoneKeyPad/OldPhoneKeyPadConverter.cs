using System.Text;

namespace OldPhoneKeyPad;
public static class OldPhoneKeyPadConverter
{
    /// <summary>
    /// A static, read-only dictionary that maps keypad digits to their corresponding characters.
    /// </summary>
    private static readonly Dictionary<char, string> KeyMap = new Dictionary<char, string>
    {
        { '1', "&'(" }, 
        { '2', "ABC" },
        { '3', "DEF" },
        { '4', "GHI" },
        { '5', "JKL" },
        { '6', "MNO" },
        { '7', "PQRS" },
        { '8', "TUV" },
        { '9', "WXYZ" },
        { '0', " " }
    };

    /// <summary>
    /// Converts a sequence of key presses from an old phone keypad to a readable string.
    /// </summary>
    /// <param name="input">A string representing the sequence of key presses</param>
    /// <returns>The readable string.</returns>
    public static string OldPhonePad(string input)
    {
        // validation: If the input is null, empty, or doesn't end with '#', return an empty string
        if (string.IsNullOrEmpty(input) || !input.EndsWith("#"))
        {
            return "";
        }

        StringBuilder sb = new StringBuilder();

        // Iterate through the input string, stopping before the final '#' character
        for (int i = 0; i < input.Length - 1; i++)
        {
            char currentChar = input[i];

            if (currentChar == '*')
            {
                // Handle backspace
                if (sb.Length > 0)
                {
                    sb.Remove(sb.Length - 1, 1); 
                }
            }
            else if (currentChar == ' ')
            {
                continue;   // Skip
            }
            else if (KeyMap.ContainsKey(currentChar))
            {
                int pressCount = 1;
                // Check the next char
                while (i + 1 < input.Length - 1 && input[i + 1] == currentChar)
                {
                    pressCount++;
                    i++;
                }

                // Get the string of characters for the key
                string charsOnKey = KeyMap[currentChar];
                int charIndex = (pressCount - 1) % charsOnKey.Length;
                
                // Append the character
                sb.Append(charsOnKey[charIndex]);
            }
        }

        return sb.ToString();
    }
}