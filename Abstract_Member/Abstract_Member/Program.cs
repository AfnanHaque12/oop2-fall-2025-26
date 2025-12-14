using System;
abstract class Member
{
    private string name;
    private int memberId;
 public Member(string name, int memberId)
  {
     this.name = name;
     this.memberId = memberId;
  }
   public abstract double CalculateFee();
}
class StudentMember : Member
{
 public StudentMember(string name, int id) : base(name, id) { }
 public override double CalculateFee()
 {
    return 300;
 }
}
class RegularMember : Member
{
 public RegularMember(string name, int id) : base(name, id) { }
public override double CalculateFee()
{
   return 500;
 }
}
class Program
{
static void Main()
{
   Member s1 = new StudentMember("A",100);
   Member r1 = new RegularMember("B",101);

   Console.WriteLine($"Student Member Fee: " + s1.CalculateFee());
   Console.WriteLine($"Regular Member Fee: " + r1.CalculateFee());
}
}

