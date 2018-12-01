﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12video.h(1273,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3b60536e-ad29-4e64-a269-f853837e5e53"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12VideoDecodeCommandList : ID3D12CommandList
    {
        // ID3D12Object
        [PreserveSig]
        new HRESULT GetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _Inout_ */ ref uint pDataSize, /* _Out_writes_bytes_opt_( *pDataSize ) */ out IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_ */ uint DataSize, /* _In_reads_bytes_opt_( DataSize ) */ out IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new HRESULT SetName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name);
        
        // ID3D12DeviceChild
        [PreserveSig]
        new HRESULT GetDevice([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvDevice);
        
        // ID3D12CommandList
        [PreserveSig]
        new D3D12_COMMAND_LIST_TYPE GetType();
        
        // ID3D12VideoDecodeCommandList
        [PreserveSig]
        HRESULT Close();
        
        [PreserveSig]
        HRESULT Reset(/* _In_ */ ID3D12CommandAllocator pAllocator);
        
        [PreserveSig]
        void ClearState();
        
        [PreserveSig]
        void ResourceBarrier(/* _In_ */ uint NumBarriers, /* _In_reads_(NumBarriers) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_RESOURCE_BARRIER[] pBarriers);
        
        [PreserveSig]
        void DiscardResource(/* _In_ */ ID3D12Resource pResource, /* _In_opt_ */ ref D3D12_DISCARD_REGION pRegion);
        
        [PreserveSig]
        void BeginQuery(/* _In_ */ ID3D12QueryHeap pQueryHeap, /* _In_ */ D3D12_QUERY_TYPE Type, /* _In_ */ uint Index);
        
        [PreserveSig]
        void EndQuery(/* _In_ */ ID3D12QueryHeap pQueryHeap, /* _In_ */ D3D12_QUERY_TYPE Type, /* _In_ */ uint Index);
        
        [PreserveSig]
        void ResolveQueryData(/* _In_ */ ID3D12QueryHeap pQueryHeap, /* _In_ */ D3D12_QUERY_TYPE Type, /* _In_ */ uint StartIndex, /* _In_ */ uint NumQueries, /* _In_ */ ID3D12Resource pDestinationBuffer, /* _In_ */ ulong AlignedDestinationBufferOffset);
        
        [PreserveSig]
        void SetPredication(/* _In_opt_ */ ID3D12Resource pBuffer, /* _In_ */ ulong AlignedBufferOffset, /* _In_ */ D3D12_PREDICATION_OP Operation);
        
        [PreserveSig]
        void SetMarker(uint Metadata, /* _In_reads_bytes_opt_(Size) */ out IntPtr pData, uint Size);
        
        [PreserveSig]
        void BeginEvent(uint Metadata, /* _In_reads_bytes_opt_(Size) */ out IntPtr pData, uint Size);
        
        [PreserveSig]
        void EndEvent();
        
        [PreserveSig]
        void DecodeFrame(/* _In_ */ ID3D12VideoDecoder pDecoder, /* _In_ */ ref D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS pOutputArguments, /* _In_ */ ref D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS pInputArguments);
        
        [PreserveSig]
        void WriteBufferImmediate(uint Count, /* _In_reads_(Count) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_WRITEBUFFERIMMEDIATE_PARAMETER[] pParams, /* _In_reads_opt_(Count) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_WRITEBUFFERIMMEDIATE_MODE[] pModes);
    }
}