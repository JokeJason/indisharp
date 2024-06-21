namespace IndiClientLibrary.Models;

public class SwitchProperty : IndiProperty
{
    public List<string> Options { get; set; } = new List<string>();
    public int SelectedIndex { get; set; }

    public override void SetValue(object value)
    {
        if (value is int index && index >= 0 && index < Options.Count)
        {
            SelectedIndex = index;
        }
    }
    
    public override object GetValue()
    {
        return SelectedIndex;
    }
}