# Answers for Generics Lab

## Step 2 — A store for students vs. Courses
* **What is the same:** Both `StudentStore` and `CourseStore` share the exact same logic and structure. They both use an internal list to store items and implement the same four core operations: `Add`, `GetById`, `GetAll`, and `Remove`.
* **What is different:** The data type they operate on. One is strictly hardcoded to `Student`, while the other is hardcoded to `Course`.

---

## Step 3 — Compiler Error on `Store<T>`
When trying to implement `GetById(int id)` on a generic `Store<T>` before applying constraints, the compiler rejects the code with an error similar to this:

> **Compiler Error:** 
> `CS1061: 'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'T' could be found (are you missing a using directive or an assembly reference?)`

* **Why the compiler rejects it:** The compiler treats `T` as a completely unknown/generic type. Because `T` could theoretically be anything (like a `string` or a primitive type), the compiler cannot guarantee that every `T` will possess an `Id` property. Therefore, it prevents any code that tries to access `.Id` on `T` to ensure type safety.

---

## Step 7 — The `new Store<()` test (Must NOT Compile)
* **Code snippet:**
  ```csharp
  // var invalidStore = new Store<string>(); // must NOT compile
Explanation: This line does not compile because Store<T> has a strict generic constraint: where T : IHasId. Since the string class does not implement the IHasId interface (it doesn't have an Id property), the compiler blocks the instantiation immediately to enforce type safety and maintain architectural rules.

Final Question — Common Pattern Name
What is the common name for the kind of class built in Steps 4 and 5?

It is commonly known as the Generic Repository Pattern (or generic data access repository), which is widely used to encapsulate data storage logic and perform CRUD operations generically across multiple entity types.