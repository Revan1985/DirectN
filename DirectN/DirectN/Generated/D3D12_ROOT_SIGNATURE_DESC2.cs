﻿// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_ROOT_SIGNATURE_DESC2
    {
        public uint NumParameters;
        public IntPtr pParameters;
        public uint NumStaticSamplers;
        public IntPtr pStaticSamplers;
        public D3D12_ROOT_SIGNATURE_FLAGS Flags;
    }
}
