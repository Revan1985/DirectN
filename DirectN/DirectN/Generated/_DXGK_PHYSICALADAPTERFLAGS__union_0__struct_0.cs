﻿// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PHYSICALADAPTERFLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint IoMmuSupported {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 0, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 1); } }
        public uint GpuMmuSupported {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 1, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 1, 1); } }
        public uint MovePagingSupported {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 2, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 2, 1); } }
        public uint VPRPagingContextRequired {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 3, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 3, 1); } }
        public uint AllowHardwareProtectedNoVpr {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 4, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 4, 1); } }
        public uint VirtualCopyEngineSupported {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 5, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 5, 1); } }
        public uint GpuVaIommuRequired {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 6, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 6, 1); } }
        public uint GpuVaIommuGlobalRequired {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 7, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 7, 1); } }
        public uint GpuVaIommuCacheCoherent {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 8, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 8, 1); } }
        public uint Reserved {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 9, 23);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 9, 23); } }
    }
}
