using System.Text.RegularExpressions;

namespace src;

public static class StringValidationExtensions
{
    public static bool IsValidEgyptianPhone(this string str)
    {
        if (string.IsNullOrWhiteSpace(str)) return false;
        return (Regex.IsMatch(str.Trim(), @"^(?:\+20|0)(11|10|12|15)\d{8}$")); 
    }   

    public static bool IsValidEgyptianNationalId(this string str)
    {
        if (string.IsNullOrWhiteSpace(str)) return false;
        return (Regex.IsMatch(str.Trim(), @"^(2|3)\d{13}$"));
    }
}