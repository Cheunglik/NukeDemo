namespace NukeDemo
{
    public static class StringExtension
    {
        static string chinesesRange = @"[\u4e00-\u9fff]";
        public static bool HasChinese(this string str)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str, chinesesRange);
        }

        public static double ParseToDouble(this string input)
        {
            if (string.IsNullOrEmpty(input)) return 0;
            if (input.Contains("/"))
            {
                var parts = input.Split('/');
                if (parts.Length == 2)
                {
                    if (double.TryParse(parts[0], out double p1) &&
                      double.TryParse(parts[1], out double p2))
                    {
                        if (p2 != 0)
                        {
                            return (p1 / p2);
                        }
                    }
                    return 0;
                }
                else
                {
                    if (double.TryParse(input, out double tmp))
                    {
                        return tmp;
                    }
                    return 0;
                }
            }
            else if (input.EndsWith("%"))
            {
                input = input.Substring(0, input.Length - 1);
                if (double.TryParse(input, out double tmp))
                {
                    return tmp / 100.0;
                }
                return 0;
            }
            else
            {
                if (double.TryParse(input, out double tmp))
                {
                    return tmp;
                }
                return 0;
            }
        }
    }
}
