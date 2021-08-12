namespace ComboboxSelectionChangedIssue
{
    public class SomeEntity
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
