﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(1187,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_HEVC__union_1__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint scaling_list_enabled_flag => InteropRuntime.GetUInt32Bits(__bits, 0, 1);
        public uint amp_enabled_flag => InteropRuntime.GetUInt32Bits(__bits, 1, 1);
        public uint sample_adaptive_offset_enabled_flag => InteropRuntime.GetUInt32Bits(__bits, 2, 1);
        public uint pcm_enabled_flag => InteropRuntime.GetUInt32Bits(__bits, 3, 1);
        public uint pcm_sample_bit_depth_luma_minus1 => InteropRuntime.GetUInt32Bits(__bits, 4, 4);
        public uint pcm_sample_bit_depth_chroma_minus1 => InteropRuntime.GetUInt32Bits(__bits, 8, 4);
        public uint log2_min_pcm_luma_coding_block_size_minus3 => InteropRuntime.GetUInt32Bits(__bits, 12, 2);
        public uint log2_diff_max_min_pcm_luma_coding_block_size => InteropRuntime.GetUInt32Bits(__bits, 14, 2);
        public uint pcm_loop_filter_disabled_flag => InteropRuntime.GetUInt32Bits(__bits, 16, 1);
        public uint long_term_ref_pics_present_flag => InteropRuntime.GetUInt32Bits(__bits, 17, 1);
        public uint sps_temporal_mvp_enabled_flag => InteropRuntime.GetUInt32Bits(__bits, 18, 1);
        public uint strong_intra_smoothing_enabled_flag => InteropRuntime.GetUInt32Bits(__bits, 19, 1);
        public uint dependent_slice_segments_enabled_flag => InteropRuntime.GetUInt32Bits(__bits, 20, 1);
        public uint output_flag_present_flag => InteropRuntime.GetUInt32Bits(__bits, 21, 1);
        public uint num_extra_slice_header_bits => InteropRuntime.GetUInt32Bits(__bits, 22, 3);
        public uint sign_data_hiding_enabled_flag => InteropRuntime.GetUInt32Bits(__bits, 25, 1);
        public uint cabac_init_present_flag => InteropRuntime.GetUInt32Bits(__bits, 26, 1);
        public uint ReservedBits3 => InteropRuntime.GetUInt32Bits(__bits, 27, 5);
    }
}