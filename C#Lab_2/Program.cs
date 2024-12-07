using System;

class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Pupil is studying");
    }

    public virtual void Read()
    {
        Console.WriteLine("Pupil is reading");
    }

    public virtual void Write()
    {
        Console.WriteLine("Pupil is writing");
    }

    public virtual void Relax()
    {
        Console.WriteLine("Pupil is relaxing");
    }
}

class ExcellentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Excellent pupil is studying");
    }

    public override void Read()
    {
        Console.WriteLine("Excellent pupil is reading");
    }

    public override void Write()
    {
        Console.WriteLine("Excellent pupil is writing");
    }

    public override void Relax()
    {
        Console.WriteLine("Excellent pupil is relaxing");
    }
}

class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Good pupil is studying");
    }

    public override void Read()
    {
        Console.WriteLine("Good pupil is reading");
    }

    public override void Write()
    {
        Console.WriteLine("Good pupil is writing");
    }

    public override void Relax()
    {
        Console.WriteLine("Good pupil is relaxing");
    }
}

class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Bad pupil is studying");
    }

    public override void Read()
    {
        Console.WriteLine("Bad pupil is reading");
    }

    public override void Write()
    {
        Console.WriteLine("Bad pupil is writing");
    }

    public override void Relax()
    {
        Console.WriteLine("Bad pupil is relaxing");
    }
}

class ClassRoom
{
    private Pupil[] pupils;

    public ClassRoom(params Pupil[] pupils)
    {
        this.pupils = pupils;
    }

    public void PrintInfo()
    {
        for (int i = 0; i < pupils.Length; i++)
        {
            Console.WriteLine($"\nPupil {i + 1}");
            pupils[i].Study();
            pupils[i].Read();
            pupils[i].Write();
            pupils[i].Relax();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ExcellentPupil pupil1 = new ExcellentPupil();
        GoodPupil pupil2 = new GoodPupil();
        BadPupil pupil3 = new BadPupil();
        BadPupil pupil4 = new BadPupil();

        Console.WriteLine("\t\t\tClassroom with 2 pupils");
        ClassRoom classRoomWith2Pupils = new ClassRoom(pupil1, pupil2);
        classRoomWith2Pupils.PrintInfo();

        Console.WriteLine("\t\t\t\tClassroom with 3 pupils");
        ClassRoom classRoomWith3Pupils = new ClassRoom(pupil1, pupil2, pupil3);
        classRoomWith3Pupils.PrintInfo();

        Console.WriteLine("\t\t\t\tClassroom with 4 pupils");
        ClassRoom classRoomWith4Pupils = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
        classRoomWith4Pupils.PrintInfo();
    }
}
