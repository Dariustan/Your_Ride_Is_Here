using System;
namespace First
{
  class First
  {/// <summary>
  ///   The main entry point for the application
  /// </summary>
  class name
  {
    public string Str;
    public char[] letter = new char[7];
    public name(string str){
      Str = str;
      letter=Str.ToCharArray();
    }
    public int count()
    {
      int i = 0;
      int j = 1;
      while(i<Str.Length)
      {
        j*=(letter[i]-64);
        i++;
      }
      int num=j%47;
      return num;
    }
  }
  [STAThread]

  public static void Main(string[] args)
  {
    string cometstr=Console.ReadLine();
    string groudstr=Console.ReadLine();
    name comet=new name(cometstr);
    name groud=new name(groudstr);
    Console.WriteLine(comet.count());
    Console.WriteLine(groud.count());
    if (groud.count()==comet.count()) {
      Console.WriteLine("GO");
    }
    else{
      Console.WriteLine("STAY");
    }
    System.Console.ReadKey();
  }

  }

}
