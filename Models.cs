// ============================================================
// Models.cs — every type the program needs
// ============================================================

// ── INTERFACE ─────────────────────────────────────────────
public interface IGradable
{
    string Title { get; }
    decimal CalculateGrade();
}

// ── QUIZ (implements IGradable) ────────────────────────────
public class Quiz : IGradable
{
    public required string Title { get; init; }
    public required int CorrectAnswers { get; init; }
    public required int TotalQuestions { get; init; }

    public decimal CalculateGrade()
    {
        if (TotalQuestions == 0) return 0m;
        return (decimal)CorrectAnswers / TotalQuestions * 100m;
    }
}

// ── LAB ASSIGNMENT (implements IGradable) ──────────────────
public class LabAssignment : IGradable
{
    public required string Title { get; init; }
    public required decimal FunctionalityScore { get; init; }
    public required decimal CodeQualityScore { get; init; }

    public decimal CalculateGrade()
    {
        return (FunctionalityScore * 0.7m) + (CodeQualityScore * 0.3m);
    }
}