Console.WriteLine("Welcome to the Pig Latin Translator!");
Console.WriteLine("\n"); 

string userAnswer = "y";
char lastCharacter = ' ';

Console.WriteLine("Enter a line to be translated:");
string userSentence = Console.ReadLine(); 

if (userSentence[userSentence.Length - 1] == '.' || userSentence[userSentence.Length - 1] == '?' || userSentence[userSentence.Length - 1] == '.')
{
    lastCharacter = userSentence[userSentence.Length - 1];
}

while (userAnswer == "y")
{

    while (userSentence.Length > 0)
    {

        string word = "";
        for (int i = 0; i < userSentence.Length; i++)
        {
            if (userSentence[i] == ' ' || userSentence[i] == '.' || userSentence[i] == '?' || userSentence[i] == '!')
            {
                break;
            }
            word += userSentence[i];
        }
        if (word.Length < userSentence.Length)
        {
            userSentence = userSentence.Remove(0, word.Length + 1);
        }
        else if (word.Length == userSentence.Length || userSentence[word.Length - 1] == '.' || userSentence[word.Length - 1] == '?' || userSentence[word.Length - 1] == '!')
        {
            userSentence = userSentence.Remove(0, word.Length);
        }


        string vowels = "aeiouAEIOU";
        string constants = "";
        int firstVowelPosition = 0;
        for (int j = 0; j < word.Length; j++)
        {
            bool isVowelFound = false;
            foreach (char chVowel in vowels)
            {
                if (word[j] == chVowel)
                {
                    firstVowelPosition = j;
                    isVowelFound = true;
                    break;
                }
            }
            if (isVowelFound)
            {
                break;
            }

        }
        if (firstVowelPosition == 0)
        {
            word = word + "way";
        }
        else
        {
            for (int k = 0; k < firstVowelPosition; k++)
            {
                constants += word[k];
            }
            word = word.Remove(0, firstVowelPosition) + constants + "ay";
        }

        if (userSentence.Length == 0)
        {
            Console.Write(word.ToLower() + lastCharacter);
            break;
        }
        else
        {
            Console.Write(word.ToLower() + " ");
        }
    }

    Console.WriteLine("\n");

    Console.WriteLine("Enter a new sentence? (y/n)");
    userAnswer = Console.ReadLine();

    while (userAnswer.ToLower() != "y" && userAnswer.ToLower() != "n")
    {
        Console.WriteLine("\n");
        Console.WriteLine("Please enter a valid responce.");
        userAnswer = Console.ReadLine();
    }

    if (userAnswer.ToLower() == "y")
    {
        Console.WriteLine("\n");
        Console.WriteLine("Enter the new sentence");
        userSentence = Console.ReadLine();
    }
}

if  (userAnswer.ToLower() == "n")
{
    Console.WriteLine("\n");
    Console.WriteLine("Goodbye!");
}