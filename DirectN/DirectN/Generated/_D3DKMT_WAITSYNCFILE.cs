﻿// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_WAITSYNCFILE
    {
        public ulong hSyncFile;
        public uint hContext;
        public uint Reserved;
    }
}
