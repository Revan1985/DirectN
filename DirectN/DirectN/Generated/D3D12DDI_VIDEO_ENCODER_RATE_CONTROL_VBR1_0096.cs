﻿// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_RATE_CONTROL_VBR1_0096
    {
        public uint InitialQP;
        public uint MinQP;
        public uint MaxQP;
        public ulong MaxFrameBitSize;
        public ulong TargetAvgBitRate;
        public ulong PeakBitRate;
        public ulong VBVCapacity;
        public ulong InitialVBVFullness;
        public uint QualityVsSpeed;
    }
}
