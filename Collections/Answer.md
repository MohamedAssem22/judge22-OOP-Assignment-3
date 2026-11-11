## Task 2.1 — Research: IReadOnlyDictionary & SortedDictionary

### 1. What is each one?
* **`IReadOnlyDictionary<TKey, TValue>`**: An interface that provides a read-only view of a dictionary collection, allowing users to look up and read values without permitting any modifications (no adding, removing, or changing items).
* **`SortedDictionary<TKey, TValue>`**: A collection of key/value pairs that are automatically sorted by key, maintaining their sorted order dynamically whenever items are added or removed.

### 2. How is IReadOnlyDictionary different from `Dictionary`, and why return it?
* **Difference:** A standard `Dictionary` is fully mutable (allows CRUD operations), whereas `IReadOnlyDictionary` restricts access to read-only operations.
* **Why return it:** Returning an `IReadOnlyDictionary` from public methods protects internal state and ensures data encapsulation, signaling to callers that they can read data (like prices or settings) but cannot mutate or corrupt the underlying collection.

### 3. How is `SortedDictionary` different from `Dictionary` in ordering and lookup speed, and when would you choose it?
* **Ordering:** A standard `Dictionary` keeps no guaranteed order of elements. A `SortedDictionary` automatically keeps all keys sorted in ascending order.
* **Lookup Speed:** 
  * `Dictionary` offers constant average lookup time ($\mathcal{O}(1)$) via hashing.
  * `SortedDictionary` uses a balanced binary search tree underneath, resulting in logarithmic lookup time ($\mathcal{O}(\log N)$).
* **When to choose it:** Choose `SortedDictionary` when you need elements to automatically remain in a strictly sorted key order while items are dynamically added or removed (such as a time-ordered schedule or timetable).




## Task 2.2 — Pick the Collection

| Scenario | Chosen Collection | Reason |
| :--- | :--- | :--- |
| **S1** Find a student by national ID — thousands of times a day. | `Dictionary` | Provides instant $\mathcal{O}(1)$ average key-value lookup speed. |
| **S2** Keep the tags of a course. The same tag must never be stored twice. | `HashSet` | Automatically prevents duplicate entries while providing fast lookups. |
| **S3** Keep a student's grades in the order they were entered. The same grade can appear more than once. | `List` | Preserves insertion order and permits duplicate elements. |
| **S4** A public method returns the course price list. Callers can read prices but must not add or change any. | `IReadOnlyDictionary` | Exposes read-only views to protect internal data from external modifications. |
| **S5** A timetable keyed by session start time. Sessions are added at any moment, and it must always print in time order. | `SortedDictionary` | Dynamically maintains elements sorted by key order on insertion. |
| **S6** A method returns results that the caller only loops over once — and may stop early. | `IEnumerable` | Supports deferred execution and on-demand evaluation via `yield return`. |