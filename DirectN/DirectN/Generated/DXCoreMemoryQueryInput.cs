﻿// generated from <Windows SDK Path>\um\dxcore_interface.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXCoreMemoryQueryInput
    {
        public uint physicalAdapterIndex;
        public DXCoreMemoryType memoryType;
    }
}
