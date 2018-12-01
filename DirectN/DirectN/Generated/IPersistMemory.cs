﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(2386,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("bd1ae5e0-a6ae-11ce-bd37-504200c10000"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPersistMemory
    {
        [PreserveSig]
        HRESULT IsDirty();
        
        [PreserveSig]
        HRESULT Load(/* [size_is][in] */ IntPtr pMem, /* [in] */ uint cbSize);
        
        [PreserveSig]
        HRESULT Save(/* [size_is][out] */ IntPtr pMem, /* [in] */ bool fClearDirty, /* [in] */ uint cbSize);
        
        [PreserveSig]
        HRESULT GetSizeMax(/* [out] __RPC__out */ out uint pCbSize);
        
        [PreserveSig]
        HRESULT InitNew();
    }
}