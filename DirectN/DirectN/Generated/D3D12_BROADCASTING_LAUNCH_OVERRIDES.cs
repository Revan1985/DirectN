﻿// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_BROADCASTING_LAUNCH_OVERRIDES
    {
        public IntPtr pLocalRootArgumentsTableIndex;
        public IntPtr pProgramEntry;
        public IntPtr pNewName;
        public IntPtr pShareInputOf;
        public IntPtr pDispatchGrid;
        public IntPtr pMaxDispatchGrid;
        public uint NumOutputOverrides;
        public IntPtr pOutputOverrides;
    }
}
