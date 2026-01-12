namespace knightmoves;
public class Speech
{   
    public const string Quote = "...ask not what your country can do for you — ask what you can do for your country.";

    public string PrintLengthAndTwentySecondLetter()
    {
        int length = Quote.Length;
        char theLetter = Quote[21];

        return $"{length} {theLetter}";
    }
}
