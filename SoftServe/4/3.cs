public enum ColourEnum
{
    Red, Green, Blue
}

public interface IColoured
{
    ColourEnum Colour { get => ColourEnum.Red; }
}

public interface IDocument
{
    static string defaultText = "Lorem ipsum";
    public int Pages { get=>0; set => this.Pages=value; }
    string Name { get; set; }

    public void AddPages(int pages)
    {
        this.Pages += pages;
    }
    public void Rename(string name)
    {
        this.Name = name;
    }   
}

public class ColouredDocument: IDocument, IColoured
{
    public ColourEnum Colour { get; set; }
    public int Pages { get; set; }
    public string Name { get; set; }

    public ColouredDocument()
    {
        Colour = ColourEnum.Red;
    }
    public ColouredDocument(ColourEnum colour)
    {
        Colour = colour;
    }
}

public class Example
{
    public static void Do()
    {
        ColouredDocument doc1 = new ColouredDocument() { Name = "Document1" };
        Console.WriteLine(doc1.Name);
        ((IDocument)doc1).Rename("Document2");
        Console.WriteLine(doc1.Name);
    }
}