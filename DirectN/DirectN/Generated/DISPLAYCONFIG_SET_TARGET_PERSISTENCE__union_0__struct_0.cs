﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wingdi.h(3123,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DISPLAYCONFIG_SET_TARGET_PERSISTENCE__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint bootPersistenceOn { get => InteropRuntime.GetUInt32(__bits, 0, 1); set => InteropRuntime.SetUInt32(value, __bits, 0, 1); }
        public uint reserved { get => InteropRuntime.GetUInt32(__bits, 1, 31); set => InteropRuntime.SetUInt32(value, __bits, 1, 31); }
    }
}