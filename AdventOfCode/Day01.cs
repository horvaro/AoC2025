namespace AdventOfCode;

public class Day01 : BaseDay
{
    private readonly string _input;

    public Day01()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    public override ValueTask<string> Solve_1() => new($"{Solve_Part1()}");

    public override ValueTask<string> Solve_2() => new($"{Solve_Part2()}");

    public string Solve_Part1()
    {
        var text = _input.ToUpper();
        return $"Solution to {ClassPrefix} {CalculateIndex()}, part 1 => {text}";
    }

    public string Solve_Part2()
    {
        return $"Solution to {ClassPrefix} {CalculateIndex()}, part 1 => 42";
    }
}
