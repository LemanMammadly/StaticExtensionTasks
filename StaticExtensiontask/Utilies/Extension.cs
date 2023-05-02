namespace StaticExtensiontask.Utilies;

public static class Extension
{
	public static int MatchCount(this string str,string search)
	{
        int count = 0;
        for (int i = 0; i <= str.Length - search.Length; i++)
        {
            bool match = true;
            for (int j = 0; j < search.Length; j++)
            {
                if (str[i + j] != search[j])
                {
                    match = false;
                }
            }

            if (match)
            {
                count++;
            }
        }
        return count;
    }
}

