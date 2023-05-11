using System;

public class Programmer : Creator
{
    public override void Create()
    {
        if (base.CreativityLevel >= 70 && base.Energy >= 80)
        {
            this.BrainstormSolutions();
            this.PickMostOptimalSolution();
            this.WriteCode();
            this.TestCode();
        }
        else {
            throw new Exception("Not enough creativity or energy to create coding solution");
        }
    }

    private void BrainstormSolutions() {
        base.CreativityLevel -= 15;
        base.Energy -= 10;
        Console.WriteLine("Brainstorming solutions...");
    }

    private void PickMostOptimalSolution() {
        base.CreativityLevel -= 5;
        base.Energy -= 5;
        Console.WriteLine("Picking most optimal solution...");
    }

    private void WriteCode() {
        base.CreativityLevel -= 7;
        base.Energy -= 5;
        Console.WriteLine("Writing code...");
    }

    private void TestCode() {
        base.CreativityLevel -= 3;
        base.Energy -= 3;
        Console.WriteLine("Testing code...");
    }
}