public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Accessing a disposed object
        using (var context = new MyDbContext())
        {
            // ... some code that uses the context ...
        }

        // This will throw an exception if MyDbContext is not properly disposed
        context.Database.ExecuteSqlRaw("SELECT 1");
    }
}