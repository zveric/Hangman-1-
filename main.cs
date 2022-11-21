using System;

class Program {
	static string WordGenerator(){
		// This function has a array of random words it picks a random word and returns it to the main branch of the program //
		
		string[] strWords = {"spare", "shade","guitar", "sneaky", "mark", "size", "cut", "savory", "yam", "bead", "thin", "poke", "foamy", "exotic","champ", "seal", "bent","pause", "record", "tiny", "burly", "lock", "hot", "cat", "lamp", "monitor", "play", "big","lumberjack", "boy"};

		Random rnd = new Random();
		int intNum = rnd.Next(0,29); // Arrays start at zero 
		string strChoice = strWords[intNum];
		return strChoice;
	}

	
	
	
	public static void Main (string[] args) {
		
		string strWord = WordGenerator();

		Console.WriteLine(strWord);

		// This creates a variable containing the length of the word that is to be guessed
		int intWordLen = strWord.Length;
		int intMaxGuess = intWordLen + intWordLen/2; //Creates a maximum guess limit
		int intGuessRemaining = intMaxGuess;
		Console.WriteLine("Welcome to Hangman!");
		Console.WriteLine("You have {0} guesses to guess the {1} letter word that has been randomly generated",intGuessRemaining,intWordLen);

		//Guess Arrays
		char[] acharBadGuess = new char[intGuessRemaining];
		char[] acharCorrectGuess = new char[intWordLen];
		
		//Replacing astrCorrectGuess with underscores for formatting
		for (int i = 0; i < intWordLen; i++)
		{
			acharCorrectGuess[i] = ('_');
		}
		
		for (int i = 0; i <= intMaxGuess; i++) // This is a loop that continues until no guesses remain
		{
			string strComparison = new string(acharCorrectGuess); 
			Console.WriteLine("You have {0} Guesses left", intGuessRemaining);
			Console.WriteLine("So far you have guessed these letters correctly: {0}", strComparison);
			strBadGuesses = new string(acharCorrectGuess);
			Console.WriteLine("And these letters incorectly {0}", );
			Console.Write("Enter your guess:");
			string strGuess = Console.ReadLine();
			char charGuess = strGuess[0]; //Converting the string from the input into a charactor
			int intIndex = strWord.IndexOf(strGuess);
			if (intIndex==-1) //If the value isnt present
				{
					acharBadGuess[0] = charGuess;
					Console.WriteLine("Unfortunatly that is incorrect");
				}
			else
			{
				acharCorrectGuess[intIndex] = charGuess; //Add value to the array in the correct place
				Console.WriteLine("Well Done that is the correct letter!");
			}

			strComparison = new string(acharCorrectGuess); //Converting the array into a string for easier comparison.
			bool boolSame = strComparison.Equals(strWord); //Creates a boolean containing whether the guesses are the same as the word
			if (boolSame == true)
			{
				Console.WriteLine("Well Done that is the correct word!");
				break;
			}
			
			intGuessRemaining = intGuessRemaining - 1; 
		}
  }
}