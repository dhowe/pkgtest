using System;
using Antlr4.Runtime;

namespace pkgtest {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine(new AntlrInputStream("Test"));
    }
  }
}
