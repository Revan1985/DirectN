﻿// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RT_FORMAT_ARRAY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public DXGI_FORMAT[] RTFormats;
        public uint NumRenderTargets;
    }
}
