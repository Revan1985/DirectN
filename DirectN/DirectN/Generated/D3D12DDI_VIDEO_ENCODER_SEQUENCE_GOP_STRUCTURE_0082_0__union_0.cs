﻿// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_0082_0__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public IntPtr pH264GroupOfPictures {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
        public IntPtr pHEVCGroupOfPictures {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
        public IntPtr pAV1SequenceStructure {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
    }
}
