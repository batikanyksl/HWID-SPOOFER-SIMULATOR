using System;
using System.Linq;
using System.Management;

public static class HWIDReader
{
    private static readonly string realBIOS = RealBIOS();
    private static readonly string realDisk = RealDisk();
    private static readonly string realCPU = RealCPU();

    private static string spoofedBIOS = null;
    private static string spoofedDisk = null;
    private static string spoofedCPU = null;

    private static bool isSpoofed = false;

    public static void SpoofHWID()
    {
        var rand = new Random();
        spoofedBIOS = GenerateRandomHex(rand, 12);
        spoofedDisk = GenerateRandomHex(rand, 8);
        spoofedCPU = GenerateRandomHex(rand, 16);
        isSpoofed = true;
    }

    public static string GetBIOSSerial() => realBIOS;
    public static string GetDiskID() => realDisk;
    public static string GetCPUID() => realCPU;

    public static string SpoofedBIOS => spoofedBIOS ?? "-";
    public static string SpoofedDisk => spoofedDisk ?? "-";
    public static string SpoofedCPU => spoofedCPU ?? "-";

    private static string RealBIOS()
    {
        try
        {
            using var searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BIOS");
            foreach (var obj in searcher.Get())
                return obj["SerialNumber"]?.ToString() ?? "N/A";
        }
        catch { }
        return "N/A";
    }

    private static string RealDisk()
    {
        try
        {
            using var searcher = new ManagementObjectSearcher("SELECT VolumeSerialNumber FROM Win32_LogicalDisk WHERE DeviceID='C:'");
            foreach (var obj in searcher.Get())
                return obj["VolumeSerialNumber"]?.ToString() ?? "N/A";
        }
        catch { }
        return "N/A";
    }

    private static string RealCPU()
    {
        try
        {
            using var searcher = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor");
            foreach (var obj in searcher.Get())
                return obj["ProcessorId"]?.ToString() ?? "N/A";
        }
        catch { }
        return "N/A";
    }

    private static string GenerateRandomHex(Random rand, int length)
    {
        const string chars = "0123456789ABCDEF";
        return new string(Enumerable.Repeat(chars, length).Select(s => s[rand.Next(s.Length)]).ToArray());
    }
}
