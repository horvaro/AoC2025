# Advent of Code 2025

> Template from [AdventOfCode.Template](https://github.com/eduherminio/AdventOfCode.Template)

Problem example:

```csharp
using AoCHelper;
using System.Threading.Tasks;

namespace AdventOfCode;

public class Day_01 : BaseDay
{
    public override ValueTask<string> Solve_1() => new($"{Solve_Part1()}");

    public override ValueTask<string> Solve_2() => new($"{Solve_Part2()}");

    public string Solve_Part1()
    {
        return "42";
    }

    public string Solve_Part2()
    {
        return "123456789";
    }
}

```

## Basic usage

- Create one class per advent day, following `DayXX` or `Day_XX` naming convention and implementing `AoCHelper.BaseDay`.
- Place input files under `Inputs/` dir, following `XX.txt` convention.
- Read the input content from `InputFilePath` and solve the puzzle.

**By default, only your last problem will be solved when running the project**. You can change that by behavior by modifying `Program.cs`.

Invoking **different methods**:

- `Solver.SolveAll();` → solves all the days.

- `Solver.SolveLast();` → solves only the last day.

- `Solver.Solve<Day_XX>();` → solves only day `XX`.

- `Solver.Solve(new uint[] { XX, YY });` → solves only days `XX` and `YY`.


Arguments passed to the programm will be parsed, to execute the last day (default), all days (keyword "all") or just a specific day (like "5" or "5 6 7")
