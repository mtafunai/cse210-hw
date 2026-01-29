public class Comment
{
    public string CommenterName { get; set;}
    public string Text {get; set;}

    public Comment (String commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}