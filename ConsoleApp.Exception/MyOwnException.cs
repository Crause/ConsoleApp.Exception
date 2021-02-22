using System;

namespace ConsoleApp.Exception
{
  class MyOwnException : System.Exception
  {
    public MyOwnException() : base("It's my exception")
    {
    }
    public MyOwnException(string message) : base(message)
    {
    }
  }
}
