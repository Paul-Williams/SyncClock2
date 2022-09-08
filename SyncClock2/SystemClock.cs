using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SyncClock2;
public static class SystemClock
{
  [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
  private static extern bool SetLocalTime(ref SYSTEMTIME lpSystemTime);

  [StructLayout(LayoutKind.Sequential)]
  private struct SYSTEMTIME
  {
    public ushort wYear;
    public ushort wMonth;
    public ushort wDayOfWeek;    // ignored for the SetLocalTime function
    public ushort wDay;
    public ushort wHour;
    public ushort wMinute;
    public ushort wSecond;
    public ushort wMilliseconds;
  }

  public static void Set(DateTime dateTime)
  {
    SYSTEMTIME time = new SYSTEMTIME
    {
      wDay = (ushort)dateTime.Day,
      wMonth = (ushort)dateTime.Month,
      wYear = (ushort)dateTime.Year,
      wHour = (ushort)dateTime.Hour,
      wMinute = (ushort)dateTime.Minute,
      wSecond = (ushort)dateTime.Second,
    };

    if (!SetLocalTime(ref time))
    {
      // The native function call failed, so throw an exception
      throw new Win32Exception(Marshal.GetLastWin32Error());
    }


  }

}
