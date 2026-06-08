// ============================================================
// Program.cs — create data, pass it, iterate it
// ============================================================

IGradable[] assessments = [
    new Quiz
    {
        Title = "C# Basics",
        CorrectAnswers = 18,
        TotalQuestions = 20
    },
    new Quiz
    {
        Title = "OOP Concepts",
        CorrectAnswers = 15,
        TotalQuestions = 20
    },
    new LabAssignment
    {
        Title = "Registration API",
        FunctionalityScore = 90m,
        CodeQualityScore = 85m
    },
    new LabAssignment
    {
        Title = "Database Design",
        FunctionalityScore = 78m,
        CodeQualityScore = 92m
    }
];

PrintGradeReport(assessments);

void PrintGradeReport(IEnumerable<IGradable> assessments)
{
    Console.WriteLine("╔══════════════════════════════════════╗");
    Console.WriteLine("║         TMS GRADE REPORT             ║");
    Console.WriteLine("╚══════════════════════════════════════╝\n");

    int index = 1;

    foreach (var item in assessments)
    {
        decimal grade = item.CalculateGrade();
        string type = item.GetType().Name;

        Console.WriteLine($"  {index}. [{type}] {item.Title}");
        Console.WriteLine($"     Grade: {grade:F2}%\n");

        index++;
    }

    Console.WriteLine("══════════════════════════════════════");
}