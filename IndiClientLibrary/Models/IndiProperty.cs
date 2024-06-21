namespace IndiClientLibrary.Models;

public abstract class IndiProperty
{
    public string Name { get; set; }
    public string Labal { get; set; }
    public abstract void SetValue(object value);
    public abstract object GetValue();
}