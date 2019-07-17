namespace CodeWars.Mumbling
{
    public static class Mumbling
    {
        public static string Accum(string s)
        {
            s = s.ToLower();
            var resultString = "";
            var upperChar = char.ToUpper(s[0]);

            for (var i = 0; i <= s.Length - 1; i++)
            {
                if (i == 0)
                {
                    resultString += upperChar;
                    resultString += '-';
                }
                else if (i == s.Length - 1)
                {
                    upperChar = char.ToUpper(s[i]);
                    resultString += upperChar;
                    for (var j = 0; j < i; j++)
                    {
                        resultString += s[i];
                    }
                }
                else
                {
                    upperChar = char.ToUpper(s[i]);
                    resultString += upperChar;
                    for (var j = 0; j < i; j++)
                    {
                        resultString += s[i];
                    }

                    resultString += '-';
                }
            }

            return resultString;
        }
    }
}