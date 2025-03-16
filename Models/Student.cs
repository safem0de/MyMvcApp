namespace MyMvcApp.Models
{
    public class Student
    {
        public required List<int> Scores;

        public string? First { get; set; }

        public string? Last { get; set; }

        public int ID { get; set; }

        public static Student[] GetDemo()
        {
            List<Student> list =
            [
                new Student
                {
                    First = "Svetlana",
                    Last = "Omelchenko",
                    ID = 111,
                    Scores = [97, 92, 81, 60]
                },
                new Student
                {
                    First = "Claire",
                    Last = "O'Donnell",
                    ID = 112,
                    Scores = [75, 84, 91, 39]
                },
                new Student
                {
                    First = "Sven",
                    Last = "Mortensen",
                    ID = 113,
                    Scores = [88, 94, 65, 91]
                },
                new Student
                {
                    First = "Cesar",
                    Last = "Garcia",
                    ID = 114,
                    Scores = [97, 89, 85, 82]
                },
                new Student
                {
                    First = "Debra",
                    Last = "Garcia",
                    ID = 115,
                    Scores = [35, 72, 91, 70]
                },
                new Student
                {
                    First = "Fadi",
                    Last = "Fakhouri",
                    ID = 116,
                    Scores = [99, 86, 90, 94]
                },
                new Student
                {
                    First = "Hanying",
                    Last = "Feng",
                    ID = 117,
                    Scores = [93, 92, 80, 87]
                },
                new Student
                {
                    First = "Hugo",
                    Last = "Garcia",
                    ID = 118,
                    Scores = [92, 90, 83, 78]
                },
                new Student
                {
                    First = "Lance",
                    Last = "Tucker",
                    ID = 119,
                    Scores = [68, 79, 88, 92]
                },
                new Student
                {
                    First = "Terry",
                    Last = "Adams",
                    ID = 120,
                    Scores = [99, 82, 81, 79]
                },
                new Student
                {
                    First = "Eugene",
                    Last = "Zabokritski",
                    ID = 121,
                    Scores = [96, 85, 91, 60]
                },
                new Student
                {
                    First = "Michael",
                    Last = "Tucker",
                    ID = 122,
                    Scores = [94, 92, 91, 91]
                }
            ];

            return list.ToArray();
        }
    }
}