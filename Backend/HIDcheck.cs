using HidApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum ProtocolName
{
    VIA,
    VIAL,
    XAP,
    UNKNOWN
}

namespace viax_avalonia.Backend
{
    internal class HIDcheck
    {
        public ProtocolName GetProtocolType(DeviceInfo deviceInfo)
        {
            if (deviceInfo.VendorId == (ushort)0x5845 && 
                deviceInfo.UsagePage == (ushort)0xFF60 && 
                deviceInfo.Usage == (ushort)0x61)
            {
                return ProtocolName.VIA;
            }

            return ProtocolName.UNKNOWN;
        }
    }
}
