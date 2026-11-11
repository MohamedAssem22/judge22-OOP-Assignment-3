namespace part_03.BlockedUsers;
using System.Diagnostics;
public class BlockedUserChecker
{
    public static int CountBlocked(List<int> blockedIds, int[] requestIds)
    {
        int blocked = 0;
        HashSet<int> blockedUsers = new HashSet<int>(blockedIds);
        foreach(var id in requestIds)
            if (blockedUsers.Contains(id))
                blocked += 1;
        return blocked;
    }
    public static List<int> BuildBlockedIds(int count)
    {
        var list = new List<int>(count);
        for (var i = 0; i < count; i++)
            list.Add(i);
        return list;
    }

    public static int[] BuildRequestIds(int count, int maxId, int seed = 42) 
    {
        var rnd = new Random(seed);
        var ids = new int[count];
        for (var i = 0; i < count; i++)
            ids[i] = rnd.Next(maxId);
        return ids;
    }

    public static long MeasureMs(List<int> blockedIds, int[] requestIds, out int found)
    {
        var sw = Stopwatch.StartNew();
        found = CountBlocked(blockedIds, requestIds);
        sw.Stop();
        return sw.ElapsedMilliseconds;
        return 0; 
    }
}