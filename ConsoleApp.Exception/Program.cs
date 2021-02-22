using System;

namespace ConsoleApp.Exception
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 101;
      try
      {
        //var a = 5;
        //var b = a / 0;
        //Console.WriteLine(b);

        //throw new DivideByZeroException("gasgagwgtqwgsgagwgqwg");
        throw new MyOwnException();
      }
      catch (MyOwnException ex)
      {
        Console.WriteLine(ex.Message);
      }
      catch (System.Exception ex) when (i == 10)
      {

        Console.WriteLine(ex.Message + " (i == 10)");
      }
      catch (System.Exception ex)
      {

        Console.WriteLine(ex.Message);
      }
      finally
      {
        Console.WriteLine("Done");
      }
      Console.ReadLine();
    }
  }
}
