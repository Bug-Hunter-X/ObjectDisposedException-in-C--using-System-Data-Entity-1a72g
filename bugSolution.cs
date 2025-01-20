public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Correct way to avoid accessing disposed object
        using (var context = new MyDbContext())
        {
            // ... some code that uses the context ...
            // Execute all operations within the using block
            context.Database.ExecuteSqlRaw("SELECT 1");
        }
    }
}