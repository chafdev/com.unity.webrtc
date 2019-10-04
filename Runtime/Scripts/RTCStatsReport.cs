using System;

namespace Unity.WebRTC
{
    public class RTCStatsReport : IDisposable
    {
        internal IntPtr nativePtrObj;

        internal RTCStatsReport(IntPtr ptr)
        {
            nativePtrObj = ptr;
        }

        public string ToJson()
        {
            return NativeMethods.StatsReportToJson(nativePtrObj);
        }

        public void Dispose()
        {
            WebRTC.Context.DeleteStatsReport(nativePtrObj);
        }
    }

    public class RTCStats : IDisposable
    {
        internal IntPtr nativePtrObj;

        internal RTCStats(IntPtr ptr)
        {
            nativePtrObj = ptr;
        }

        public string ToJson()
        {
            return NativeMethods.StatsToJson(nativePtrObj);
        }
        public void Dispose()
        {
            WebRTC.Context.DeleteStats(nativePtrObj);
        }
    }
}
