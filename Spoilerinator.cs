namespace DiscordSpoilerMessageV3
{
    public class Spoilerinator
    {
        public static string Spoil(string input)
        {
            string product = string.Empty;
            foreach(char c in input)
            {
                product += "||" + c + "||";
            }
            return product;
        }
    }
}
