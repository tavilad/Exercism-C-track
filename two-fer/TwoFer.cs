public static class TwoFer
{
    public static string Speak(string input="")
    {
        if (input.Equals(string.Empty))
        {
            return "One for you, one for me.";
        }

        return "One for " + input + ", one for me.";
    }
}
