﻿// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_17
    {
        public uint NodeOrdinal;
        public uint EngineOrdinal;
        public uint SignaledNativeFenceCount;
        public IntPtr pSignaledNativeFenceArray;
        public IntPtr hHWQueue;
    }
}
