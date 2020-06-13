using System;

namespace YoYoProject.Common
{
    public enum DeviceSupport : int
    {
        OnlyWithGPU, // Only install on devices with a GPU.
        AllDevices // Install on any supported device.
    }

    public enum InstallLocation : int
    {
        Automatic,
        PreferExternal
    }

    public enum ScreenDepth : int
    {
        SixteenBit,
        TwentyFourBit
    }
}
