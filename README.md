# ObjectDisposedException in C# using System.Data.Entity

This repository demonstrates a common error in C# applications that use Entity Framework (System.Data.Entity): accessing a disposed object after it's been released by a `using` statement.  This can lead to `ObjectDisposedException` errors.  The example shows both the problematic code and a solution to avoid the issue.

## Bug

The `bug.cs` file contains code that attempts to use an Entity Framework `DbContext` after it's already been disposed of. This will result in an `ObjectDisposedException`. 

## Solution

The `bugSolution.cs` file demonstrates a correct way to interact with the `DbContext`, ensuring that all operations occur before the object is disposed of.