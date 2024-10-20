﻿// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// PDB Version information.
    /// </summary>
    [ComImport, Guid("b04f5b50-2059-4f12-a8ff-a1e0cde1cc7e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcVersionInfo
    {
        [PreserveSig]
        HRESULT GetVersion(/* _Out_ */ out uint pMajor, /* _Out_ */ out uint pMinor);
        
        [PreserveSig]
        HRESULT GetFlags(/* _Out_ */ out uint pFlags);
    }
}
