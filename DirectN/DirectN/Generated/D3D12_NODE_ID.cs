﻿// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_NODE_ID
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Name;
        public uint ArrayIndex;
    }
}
