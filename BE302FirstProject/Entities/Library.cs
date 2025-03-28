namespace BE302FirstProject.Entities;

public class Library
{
    public int Id { get; set; }
    public string Name { get; set; }
    private string[] _books;

    public string this[int index]
    {
        get 
        {
            if (_books.Length - 1 < index)
            {
                throw new Exception("Dogru index daxil et");
            }
            if (_books[index] is null)
            {
                throw new Exception("Kitab yoxdur");
            }
            return _books[index];
        }
        set
        {
            if (_books.Length - 1 < index)
            {
                throw new Exception("Dogru index daxil et");
            }
            if (_books[index] is not null)
            {
                throw new Exception("Kitab yoxdur");
            }
            _books[index] = value;
        }
    }

    public Library(string name, int maxCount)
    {
        Name = name;
        _books = new string[maxCount];
        _books[0] = "Test";
    }
}
