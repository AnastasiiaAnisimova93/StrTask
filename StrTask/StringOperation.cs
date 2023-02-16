namespace StringTask;

public class StringOperation
{
    /// <summary>
    /// Сравнить строки по количеству повторений символов
    /// </summary>
    /// <param name="strFirst"></param>
    /// <param name="strSecond"></param>
    /// <returns></returns>
    public static bool CompareStrings(string strFirst, string strSecond)
    {
        try
        {
            ValidateStrings(strFirst, strSecond);

            var charSequenceFirst = GetDictionaryCharWithCount(strFirst);
            var charSequenceSecond = GetDictionaryCharWithCount(strSecond);

            return charSequenceFirst.Keys.All(k => charSequenceSecond.ContainsKey(k) && charSequenceFirst[k] == charSequenceSecond[k]);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());

            return false;
        }
    }


    #region Private methods
    private static Dictionary<char, int> GetDictionaryCharWithCount(string str)
    {
        return str.GroupBy(e => e).ToDictionary(k => k.FirstOrDefault(), v => v.Count());
    }

    private static void ValidateStrings(string strFirst, string strSecond)
    {
        if (string.IsNullOrEmpty(strFirst) || string.IsNullOrEmpty(strSecond))
        {
            throw new Exception("ERROR | Строки не могут быть не заданы!");
        }

        if (strFirst.Length != strSecond.Length)
        {
            throw new Exception("ERROR | Строки не могут быть разной длины!");
        }

    }
    #endregion
}
