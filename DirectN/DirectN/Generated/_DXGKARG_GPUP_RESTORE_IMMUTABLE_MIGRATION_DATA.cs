﻿// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_GPUP_RESTORE_IMMUTABLE_MIGRATION_DATA
    {
        public uint vfIndex;
        public ulong DataSize;
        public IntPtr Data;
    }
}
