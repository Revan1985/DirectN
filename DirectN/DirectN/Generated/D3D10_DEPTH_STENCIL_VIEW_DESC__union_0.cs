﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10.h(3208,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_DEPTH_STENCIL_VIEW_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] __bits;
        public D3D10_TEX1D_DSV Texture1D => InteropRuntime.GetBits<D3D10_TEX1D_DSV>(__bits, 0, 32);
        public D3D10_TEX1D_ARRAY_DSV Texture1DArray => InteropRuntime.GetBits<D3D10_TEX1D_ARRAY_DSV>(__bits, 0, 96);
        public D3D10_TEX2D_DSV Texture2D => InteropRuntime.GetBits<D3D10_TEX2D_DSV>(__bits, 0, 32);
        public D3D10_TEX2D_ARRAY_DSV Texture2DArray => InteropRuntime.GetBits<D3D10_TEX2D_ARRAY_DSV>(__bits, 0, 96);
        public D3D10_TEX2DMS_DSV Texture2DMS => InteropRuntime.GetBits<D3D10_TEX2DMS_DSV>(__bits, 0, 32);
        public D3D10_TEX2DMS_ARRAY_DSV Texture2DMSArray => InteropRuntime.GetBits<D3D10_TEX2DMS_ARRAY_DSV>(__bits, 0, 64);
    }
}