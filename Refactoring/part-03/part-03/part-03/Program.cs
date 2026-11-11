namespace part_03;
using part_03.Students;
using part_03.BlockedUsers;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Blocked users ===");
        const int blockedCount = 50_000;
        const int requestCount = 5_000;
        var blockedIds = BlockedUserChecker.BuildBlockedIds(blockedCount);
        var requestIds = BlockedUserChecker.BuildRequestIds(requestCount, blockedCount);
        var ms = BlockedUserChecker.MeasureMs(blockedIds, requestIds, out var found);
        Console.WriteLine($"blockedIds={blockedCount}, requests={requestCount}, found={found}, time={ms} ms");
        Console.WriteLine();
        
        Console.Write("==== Students (1_000_000) ====");
        var printed = 0; 
        foreach (var student in StudentCatalog.GetAllStudents())
        {
            Console.WriteLine($"{student.Id}: {student.Name}"); 
                printed += 1;
                if (printed == 3)
                    break; 
        }
        Console.WriteLine($"printed={printed}");
    }

   
}