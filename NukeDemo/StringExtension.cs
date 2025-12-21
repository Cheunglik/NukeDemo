namespace NukeDemo
{
    public static class StringExtension
    {
        static string chinesesRange = @"[\u4e00-\u9fff]";
        public static bool HasChinese(this string str)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str, chinesesRange);
        }
    }
}
