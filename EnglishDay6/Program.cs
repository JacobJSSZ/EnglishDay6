using EnglishDay6;

Drudger drudger1 = new Drudger("Maciek", "Adamczyk", "Years: 38");
Drudger drudger2 = new Drudger("Adrian", "Zagórsku", "Years: 42");
Drudger drudger3 = new Drudger("Damian", "Przyński", "Years: 56");

drudger1.AddScore(1);
drudger2.AddScore(4);
drudger3.AddScore(8);
drudger1.AddScore(10);
drudger2.AddScore(4);
drudger3.AddScore(8);
drudger1.AddScore(9);
drudger2.AddScore(2);
drudger3.AddScore(7);
drudger1.AddScore(6);
drudger2.AddScore(2);
drudger3.AddScore(9);

var Ultimate_Solution = drudger1.Ultimate_Solution;
var Ultimate_Solution2 = drudger2.Ultimate_Solution;
var Ultimate_Solution3 = drudger3.Ultimate_Solution;
Console.WriteLine(drudger1.Ultimate_Solution);
Console.WriteLine(drudger2.Ultimate_Solution2);
Console.WriteLine(drudger3.Ultimate_Solution3);

List<Drudger> drudgers = new List<Drudger>()
{
    drudger1, drudger2, drudger3
};

int Final_Result = -1;
Drudger drudger_With_Final_Result = null;

foreach (var drudger in drudgers)
{
    if (drudger.Ultimate_Solution > Final_Result)
    {
        drudger_With_Final_Result = drudger;
        Final_Result = drudger.Ultimate_Solution;
    }
}
Console.WriteLine("Drudger with the highest accumulated efficiency:" + " " + drudger_With_Final_Result.Name + " " + drudger_With_Final_Result.Surname + " " + "age of theirs is:" + " " + drudger_With_Final_Result.Years);
Console.WriteLine("The highest efficient number of drudgery is" + " " + Final_Result);
