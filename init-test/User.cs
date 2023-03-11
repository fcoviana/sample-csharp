public class User
{
  public string? name { get; set; }
  public int age { get; set; }

  public override string ToString()
  {
    return base.ToString() + ": { name: " + this.name + "; age: " + this.age + " }";
  }
}