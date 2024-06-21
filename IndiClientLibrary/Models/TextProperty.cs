namespace IndiClientLibrary.Models;

public class TextProperty : IndiProperty
{
    public string Value { get; set; }
    
    public override void SetValue(object value)
    {
        if (value is string text)
        {
            Value = text;
        }
    }

    public override object GetValue()
    {
        return Value;
    }
}