## Part 3: Performance Optimization

4. Task 1.4 — Blocked Users & Student Catalog Optimization
A. Blocked Users Checker (BlockedUserChecker)
Time Complexity Before: 
O(N×M)
 — List<int>.Contains() performs a linear lookup for every request ID.

Time Complexity After: 
O(N+M)
 — Converting blockedIds to a HashSet<int> allows instant 
O(1)
 lookups.

Performance Benchmark:

Time Before Refactoring: 62 ms

Time After Refactoring: 3 ms

Refactoring Summary:
Converted blockedIds list into a HashSet<int> prior to evaluation, reducing lookup overhead from linear search to constant time lookup and drastically accelerating execution.

B. Student Catalog (StudentCatalog)
Problem Identified:GetAllStudents() previously generated and allocated 1,000,000 Student instances in memory even when only the first 3 students were requested.

Optimization Technique: Lazy Evaluation / Deferred Execution using yield return.

Refactoring Summary:

Changed return type of GetAllStudents() from List<Student> to IEnumerable<Student>.

Used yield return inside the loop to yield items on-demand.

Execution stops immediately after requested elements (e.g., .Take(3)) are consumed, preventing unnecessary loop iterations and memory allocations for the remaining 999,997 students.