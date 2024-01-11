namespace Sandbox;

public class MicrosAndNanoSecondDemo
{
    const string dt = "0001-01-01"; // yyy-mm-dd
    const string tm1 = "00:00:00.0001000"; // hh:mm:ss.ticks
    const string tm2 = "00:00:00.0000009"; // hh:mm:ss.ticks

    // 1 sec = 10^3 milli sec = 10^6 micro sec = 10^7 ticks = 10 ^9 nano sec
    // 1 tick = 10^3 nano sec

    // 1 sec  = 1_000_000 micro sec
    public static void Demo()
    {
        // In this example, 100 is micro seconds
        Console.WriteLine(new DateTime(0001, 01, 01, 00, 00, 00, 00, 100).Ticks);  // 1000 (100 micro sec = 1000 ticks)

        Console.WriteLine(DateTime.Parse($"{dt} {tm1}").Microsecond); // 100 (1000 ticks = 100 micro sec)

        Console.WriteLine(DateTime.Parse($"{dt} {tm2}").Nanosecond); // 900 (9 ticks = 900 nano ec)

        Console.WriteLine(DateTime.MinValue.Microsecond); // minimum date time micro sec
        Console.WriteLine(DateTime.MinValue.AddMicroseconds(100).Ticks); // 1000 (100 micro sec = 1000 ticks)

        // DateTimeOffSet example
        Console.WriteLine(new DateTimeOffset(0001, 01, 01, 00, 00, 00, 00, 999, TimeSpan.FromHours(-8)).Ticks); //9990 (999 micro sec = 9990 ticks)
    }
}
