# Research: IReadOnlyDictionary & SortedDictionary

## 1. What is each one?
* **`IReadOnlyDictionary<TKey, TValue>`**: An interface that represents a generic, read-only collection of key/value pairs. It provides methods to retrieve keys and values and check for keys, but it does not expose methods to add, remove, or modify items after creation.
* **`SortedDictionary<TKey, TValue>`**: A collection of key/value pairs that are sorted automatically by key. It implements standard dictionary operations and keeps its elements ordered based on a specific `IComparer<TKey>` or the key's natural ordering.

---

## 2. `IReadOnlyDictionary` vs. `Dictionary`
* **How it differs**: A standard `Dictionary<TKey, TValue>` allows callers to modify its contents (add, update, or delete items). `IReadOnlyDictionary` wraps or exposes a dictionary through a read-only contract, stripping away all modification methods.
* **Why return it from a public method**: You return an `IReadOnlyDictionary` instead of a regular `Dictionary` to protect internal state (encapsulation). It prevents external consumers from corrupting, clearing, or modifying your data directly, while still allowing them to read and query it safely.

---

## 3. `SortedDictionary` vs. `Dictionary`
* **Ordering**: 
  * A standard `Dictionary` stores keys in an unpredictable order (based on hash codes and internal bucket allocation).
  * A `SortedDictionary` keeps its keys strictly sorted at all times (ascending by default, or based on a custom comparer).
* **Lookup Speed**: 
  * A standard `Dictionary` offers $O(1)$ average time complexity for lookups, insertions, and deletions using hash-based bucketing.
  * A `SortedDictionary` relies on a self-balancing binary search tree (Red-Black tree), making lookups and operations run in $O(\log n)$ time.

---

## 4. When would you choose `SortedDictionary`?
You choose a `SortedDictionary` when you explicitly need your data to remain ordered by key, or when you need efficient range-based queries (like finding all keys between X and Y, or getting the minimum/maximum keys) without having to sort the collection manually every time.