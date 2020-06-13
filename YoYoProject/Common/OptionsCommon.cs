using System;

namespace YoYoProject.Common
{
    public enum Scale : int
    {
        KeepAspectRatio,
        FullScale
    }

    public enum SaveLocation : int
    {
        LocalAppData,
        AppData
    }

    public enum WebGLSetting : int
    {
        Disabled,
        Required,
        AutoDetect
    }
}
