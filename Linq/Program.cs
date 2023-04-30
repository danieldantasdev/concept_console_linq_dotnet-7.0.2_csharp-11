//LINQ

var students = new List<Student>
{
    new Student(1, "Daniel", "2121212", 100),
    new Student(2, "Eve", "2121212", 65),
    new Student(3, "Davi", "2121212", 32),
    new Student(4, "Renata", "2121212", 56),
    new Student(5, "Daniel", "2121212", 94)
};

var any = students.Any();
var any100 = students.Any(s => s.Note == 100);

var single = students.Single(s => s.Id == 1);
var singleOrDefault = students.SingleOrDefault(s => s.Note == 0);

var first = students.First(s => s.FullName == "Daniel");
var firstOrDefault = students.FirstOrDefault(s => s.FullName == "Daniel");

var orderedByNote = students.OrderBy(s => s.Note);
var orderedByNoteDescending = students.OrderByDescending(s => s.Note);

var where = students.Where(s => s.Note >= 70);

var select = students.Select(s => s.Note);
var selectMany = students.SelectMany(s => s.PhoneNumbers);

var sum = students.Sum(s => s.Note);
var min = students.Min(s => s.Note);
var max = students.Max(s => s.Note);
var count = students.Count;

public class Student
{
    public int Id { get; set; } = int.MinValue;
    public string FullName { get; set; } = string.Empty;
    public string Document { get; set; } = string.Empty;
    public int Note { get; set; } = int.MinValue;
    public List<string> PhoneNumbers { get; set; } = new List<string>();

    public Student(int id, string fullName, string document, int note)
    {
        Id = id;
        Note = note;
        FullName = fullName;
        Document = document;
        PhoneNumbers = new List<string> { "21 98732122", "32 65236253", "32 32637233" };
    }
}