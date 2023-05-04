using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace pharmacyp.Miscellaneous
{
    public static class NTPClient
    {
        public static class NetworkTime
        {
            private static readonly string[] NtpServerHostnames = new string[] { "time.nist.gov", "time.google.com", "time.windows.com" };

            public static async Task<DateTime> GetNetworkTimeAsync()
            {
                foreach (var hostname in NtpServerHostnames)
                {
                    try
                    {
                        var ntpData = await GetNtpDataAsync(hostname);
                        if (ntpData != null)
                        {
                            var timestamp = GetTimestamp(ntpData);
                            var dateTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestamp).ToLocalTime();
                            return dateTime;
                        }
                    }
                    catch
                    {
                        // Ignore any errors and try the next NTP server
                    }
                }

                return DateTime.MaxValue; // If all NTP servers fail, return null
            }

            private static async Task<byte[]> GetNtpDataAsync(string hostname)
            {
                using (var udpClient = new UdpClient(hostname, 123))
                {
                    udpClient.Client.ReceiveTimeout = 3000;

                    var ntpData = new byte[48];
                    ntpData[0] = 0x1B;

                    await udpClient.SendAsync(ntpData, ntpData.Length);
                    var receiveResult = await udpClient.ReceiveAsync();
                    return receiveResult.Buffer;
                }
            }

            private static ulong GetTimestamp(byte[] ntpData)
            {
                const int ntpTimestampOffset = 40;
                var timestamp = (ulong)ntpData[ntpTimestampOffset] << 24;
                timestamp |= (ulong)ntpData[ntpTimestampOffset + 1] << 16;
                timestamp |= (ulong)ntpData[ntpTimestampOffset + 2] << 8;
                timestamp |= (ulong)ntpData[ntpTimestampOffset + 3];
                return timestamp;
            }
        }

    }
}

