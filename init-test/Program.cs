class TestClass
{
  static void Main(string[] args)
  {
    Console.WriteLine("Olá mundo!");
    var user = new User();
    user.name = "Francisco";
    user.age = 21;
    Console.WriteLine(user.ToString());
  }
}