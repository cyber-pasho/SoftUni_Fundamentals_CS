namespace Problem6
{
    internal class Program
    {
        static void Main()
        {
            int studentsCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            for (int i = 0; i < studentsCount; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<double>());
                    students[studentName].Add(grade);
                }
                else
                {
                    students[studentName].Add(grade);
                }
            }
            var successfulStudents = students
                .Where(s => s.Value.Average() >= 4.50)
                .ToList();
            foreach (var student in successfulStudents)
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}