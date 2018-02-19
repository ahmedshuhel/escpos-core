using System;

namespace XenCube.EscPos
{

  public interface IDevice
  {
    void Print(string line);
  }

  public class Printer
  {
    IDevice _device;

    public Printer(IDevice device)
    {
      _device = device;
    }

    public void PrintLine(string line)
    {
      _device.Print(line);
    }
  }
}
