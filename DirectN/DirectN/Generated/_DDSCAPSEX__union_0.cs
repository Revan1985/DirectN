﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(356,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDSCAPSEX__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint dwCaps4 => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public uint dwVolumeDepth => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
    }
}