using System;
using Xunit;
using XenCube.EscPos;

namespace XenCube.EscPos.Test
{
    public class PrinterSpec
    {
        [Fact]
        public void Should_Create_A_Printer()
        {
          var printer = new Printer();
          Assert.NotNull(printer);
        }

        [Fact]
        public void Should_Be_Able_To_Print_A_Line()
        {
          var printer = new Printer();
          printer.PrintLine("Hello");
        }
    }
}
