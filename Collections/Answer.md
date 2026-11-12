# Task 2.2 — Pick the Collection

* **S1**: `Dictionary` — Provides $O(1)$ fast lookups by national ID, making it ideal for frequent retrieval.
* **S2**: `HashSet` — Automatically prevents duplicate tags while ensuring efficient uniqueness checks.
* **S3**: `List` — Preserves the insertion order of grades and allows duplicate elements.
* **S4**: `IReadOnlyDictionary` — Exposes the data for reading while protecting it from external modifications or additions.
* **S5**: `SortedDictionary` — Automatically maintains keys in strict time order while supporting dynamic insertions.
* **S6**: `IEnumerable` — Enables deferred execution, allowing the caller to loop over results and stop early without evaluating the entire sequence upfront.