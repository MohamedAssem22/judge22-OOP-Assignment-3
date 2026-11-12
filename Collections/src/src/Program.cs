namespace src;

class Program
{
    static void Main(string[] args)
    {
        string phone = "+201099010079", phone1 = "01099010079", phone2 = "0102356";
        string NationalId = "30105122700522" , NationalId1 = "00105122700522" , NationalId2 = "3010512270052";
        Console.WriteLine(phone.IsValidEgyptianPhone());
        Console.WriteLine(phone1.IsValidEgyptianPhone());
        Console.WriteLine(phone2.IsValidEgyptianPhone());
        Console.WriteLine("_______________________________");
        Console.WriteLine(NationalId.IsValidEgyptianNationalId());
        Console.WriteLine(NationalId1.IsValidEgyptianNationalId());
        Console.WriteLine(NationalId2.IsValidEgyptianNationalId()); 
    }
}