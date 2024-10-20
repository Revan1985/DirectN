﻿// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DEPTH_STENCIL_DESC2
    {
        public bool DepthEnable;
        public D3D12_DEPTH_WRITE_MASK DepthWriteMask;
        public D3D12_COMPARISON_FUNC DepthFunc;
        public bool StencilEnable;
        public D3D12_DEPTH_STENCILOP_DESC1 FrontFace;
        public D3D12_DEPTH_STENCILOP_DESC1 BackFace;
        public bool DepthBoundsTestEnable;
    }
}
