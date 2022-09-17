using System.Collections;

namespace Lesson_15;

class Doctor
{

    public string Name { get; set; }
    public string Surname { get; set; }
    public int WorkYear { get; set; }
    public List<bool> isReserved { get; set; }

    public Doctor(string name, string surname, int workYear)
    {
        Name = name;
        Surname = surname;
        WorkYear = workYear;
        isReserved = new List<bool> { false, false, false };
    }

    public override string ToString() =>
$@"{Name} {Surname} with {WorkYear} years of work time";

}