﻿#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 T Unity.Burst.Unsafe::Read(System.Void*)
// 0x00000002 T Unity.Burst.Unsafe::ReadUnaligned(System.Void*)
// 0x00000003 T Unity.Burst.Unsafe::ReadUnaligned(System.Byte&)
// 0x00000004 System.Void Unity.Burst.Unsafe::Write(System.Void*,T)
// 0x00000005 System.Void Unity.Burst.Unsafe::WriteUnaligned(System.Void*,T)
// 0x00000006 System.Void Unity.Burst.Unsafe::WriteUnaligned(System.Byte&,T)
// 0x00000007 System.Void Unity.Burst.Unsafe::Copy(System.Void*,T&)
// 0x00000008 System.Void Unity.Burst.Unsafe::Copy(T&,System.Void*)
// 0x00000009 System.Void* Unity.Burst.Unsafe::AsPointer(T&)
// 0x0000000A System.Int32 Unity.Burst.Unsafe::SizeOf()
// 0x0000000B System.Void Unity.Burst.Unsafe::CopyBlock(System.Void*,System.Void*,System.UInt32)
extern void Unsafe_CopyBlock_mEE549E5B722DBA08465F585E64B08C6F0851C63A (void);
// 0x0000000C System.Void Unity.Burst.Unsafe::CopyBlock(System.Byte&,System.Byte&,System.UInt32)
extern void Unsafe_CopyBlock_mB2F0061CE4AC8B365EA84000AB91A07EC0688CFB (void);
// 0x0000000D System.Void Unity.Burst.Unsafe::CopyBlockUnaligned(System.Void*,System.Void*,System.UInt32)
extern void Unsafe_CopyBlockUnaligned_mA98259D4AD22A90DC7F39A97ECCF621E891613F3 (void);
// 0x0000000E System.Void Unity.Burst.Unsafe::CopyBlockUnaligned(System.Byte&,System.Byte&,System.UInt32)
extern void Unsafe_CopyBlockUnaligned_m98682FA9FBBC2E6A5D4CD90EAC1D02E4E5F7B1BA (void);
// 0x0000000F System.Void Unity.Burst.Unsafe::InitBlock(System.Void*,System.Byte,System.UInt32)
extern void Unsafe_InitBlock_mA585B84FCBCAAC1BB9050AE53969FF1AF0EBD369 (void);
// 0x00000010 System.Void Unity.Burst.Unsafe::InitBlock(System.Byte&,System.Byte,System.UInt32)
extern void Unsafe_InitBlock_m9632C2B0D7D0ECC88CA7398C83BE8EBD151E81D9 (void);
// 0x00000011 System.Void Unity.Burst.Unsafe::InitBlockUnaligned(System.Void*,System.Byte,System.UInt32)
extern void Unsafe_InitBlockUnaligned_m88E390D0E318E19F7680301AD5D3810DE69CD9DE (void);
// 0x00000012 System.Void Unity.Burst.Unsafe::InitBlockUnaligned(System.Byte&,System.Byte,System.UInt32)
extern void Unsafe_InitBlockUnaligned_m617B4B62CFE8A1E30DE4B9F0AC6BF9CAB113D94A (void);
// 0x00000013 T Unity.Burst.Unsafe::As(System.Object)
// 0x00000014 T& Unity.Burst.Unsafe::AsRef(System.Void*)
// 0x00000015 T& Unity.Burst.Unsafe::AsRef(T&)
// 0x00000016 TTo& Unity.Burst.Unsafe::As(TFrom&)
// 0x00000017 T& Unity.Burst.Unsafe::Unbox(System.Object)
// 0x00000018 T& Unity.Burst.Unsafe::Add(T&,System.Int32)
// 0x00000019 System.Void* Unity.Burst.Unsafe::Add(System.Void*,System.Int32)
// 0x0000001A T& Unity.Burst.Unsafe::Add(T&,System.IntPtr)
// 0x0000001B T& Unity.Burst.Unsafe::AddByteOffset(T&,System.IntPtr)
// 0x0000001C T& Unity.Burst.Unsafe::Subtract(T&,System.Int32)
// 0x0000001D System.Void* Unity.Burst.Unsafe::Subtract(System.Void*,System.Int32)
// 0x0000001E T& Unity.Burst.Unsafe::Subtract(T&,System.IntPtr)
// 0x0000001F T& Unity.Burst.Unsafe::SubtractByteOffset(T&,System.IntPtr)
// 0x00000020 System.IntPtr Unity.Burst.Unsafe::ByteOffset(T&,T&)
// 0x00000021 System.Boolean Unity.Burst.Unsafe::AreSame(T&,T&)
// 0x00000022 System.Boolean Unity.Burst.Unsafe::IsAddressGreaterThan(T&,T&)
// 0x00000023 System.Boolean Unity.Burst.Unsafe::IsAddressLessThan(T&,T&)
// 0x00000024 System.Void System.Runtime.Versioning.NonVersionableAttribute::.ctor()
extern void NonVersionableAttribute__ctor_mBC3056ECFEE16B17F3779A50EBDCCD519078E862 (void);
// 0x00000025 System.Void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor()
extern void IsReadOnlyAttribute__ctor_m5CCFBC2EDEEA918A10A9C5A57A355234A495046D (void);
static Il2CppMethodPointer s_methodPointers[37] = 
{
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	Unsafe_CopyBlock_mEE549E5B722DBA08465F585E64B08C6F0851C63A,
	Unsafe_CopyBlock_mB2F0061CE4AC8B365EA84000AB91A07EC0688CFB,
	Unsafe_CopyBlockUnaligned_mA98259D4AD22A90DC7F39A97ECCF621E891613F3,
	Unsafe_CopyBlockUnaligned_m98682FA9FBBC2E6A5D4CD90EAC1D02E4E5F7B1BA,
	Unsafe_InitBlock_mA585B84FCBCAAC1BB9050AE53969FF1AF0EBD369,
	Unsafe_InitBlock_m9632C2B0D7D0ECC88CA7398C83BE8EBD151E81D9,
	Unsafe_InitBlockUnaligned_m88E390D0E318E19F7680301AD5D3810DE69CD9DE,
	Unsafe_InitBlockUnaligned_m617B4B62CFE8A1E30DE4B9F0AC6BF9CAB113D94A,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NonVersionableAttribute__ctor_mBC3056ECFEE16B17F3779A50EBDCCD519078E862,
	IsReadOnlyAttribute__ctor_m5CCFBC2EDEEA918A10A9C5A57A355234A495046D,
};
static const int32_t s_InvokerIndices[37] = 
{
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	12362,
	12362,
	12362,
	12362,
	12367,
	12367,
	12367,
	12367,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	9678,
	9678,
};
static const Il2CppTokenRangePair s_rgctxIndices[27] = 
{
	{ 0x06000001, { 0, 1 } },
	{ 0x06000002, { 1, 1 } },
	{ 0x06000003, { 2, 1 } },
	{ 0x06000004, { 3, 1 } },
	{ 0x06000005, { 4, 1 } },
	{ 0x06000006, { 5, 1 } },
	{ 0x06000007, { 6, 2 } },
	{ 0x06000008, { 8, 2 } },
	{ 0x06000009, { 10, 1 } },
	{ 0x0600000A, { 11, 1 } },
	{ 0x06000013, { 12, 1 } },
	{ 0x06000014, { 13, 1 } },
	{ 0x06000015, { 14, 1 } },
	{ 0x06000016, { 15, 2 } },
	{ 0x06000017, { 17, 2 } },
	{ 0x06000018, { 19, 2 } },
	{ 0x06000019, { 21, 1 } },
	{ 0x0600001A, { 22, 2 } },
	{ 0x0600001B, { 24, 1 } },
	{ 0x0600001C, { 25, 2 } },
	{ 0x0600001D, { 27, 1 } },
	{ 0x0600001E, { 28, 2 } },
	{ 0x0600001F, { 30, 1 } },
	{ 0x06000020, { 31, 1 } },
	{ 0x06000021, { 32, 1 } },
	{ 0x06000022, { 33, 1 } },
	{ 0x06000023, { 34, 1 } },
};
extern const uint32_t g_rgctx_T_t69374FF7455BF0198FC0F2F50A723741E052FE21;
extern const uint32_t g_rgctx_T_t46236521BFD11B8A5B1BABCEAD715D49ED4A1A28;
extern const uint32_t g_rgctx_T_t4C0A03328C9C8A254123851D32EB82133A725365;
extern const uint32_t g_rgctx_T_t987E376B027C09DB1CFE376088838CD47A845373;
extern const uint32_t g_rgctx_T_t5D35E9AA45F3F017961C19D66341B8F66F95CC5F;
extern const uint32_t g_rgctx_T_t90B1ABDBB86D5A9C31296CDFE2FF785AA17940C2;
extern const uint32_t g_rgctx_TU26_t910FBE619FD92D5ED597731F44768842EA57BAA2;
extern const uint32_t g_rgctx_T_t9CF1D887FD7AAE86B8801FE9FCDA9658F0727699;
extern const uint32_t g_rgctx_TU26_t4B4E963581C74481A7D3434B7BB461638F7438A0;
extern const uint32_t g_rgctx_T_tC3719F9FE9415CD0DD37B7BEB6C7775EB0F8DE9C;
extern const uint32_t g_rgctx_TU26_t761EA6B14498E87A31357019AE3D277798883F60;
extern const uint32_t g_rgctx_T_t1FDEFCA0B0E530419C707125EE8E74E3221D3778;
extern const uint32_t g_rgctx_T_t38730D07DBDB0015A3C1C51343DC42B3E35403E9;
extern const uint32_t g_rgctx_TU26_tD3468B6794620312ED0506E36D2969131D852330;
extern const uint32_t g_rgctx_TU26_t9B6F773FB1B6674CCB5EA0124BD6F5DA8899BEDB;
extern const uint32_t g_rgctx_TFromU26_tD6A1EAF239CE83FA5017188C9B152BC9468B9E44;
extern const uint32_t g_rgctx_TToU26_t601689F0D372719660A1D5485CC1468885C60FA9;
extern const uint32_t g_rgctx_T_t97B5BE2F3817B8961E8509DF5982D2B810BCE818;
extern const uint32_t g_rgctx_TU26_t7385CA1EA105629DC484567A88AE9C6BD5E99632;
extern const uint32_t g_rgctx_TU26_tD23126F23A73C0E5C23783D5C87BC3F5283C2A1D;
extern const uint32_t g_rgctx_T_tEEBA3842B319E4DD94173281BA41EA604298A6D8;
extern const uint32_t g_rgctx_T_t3DF4F371C547F52D537F3A819B23EB9BEC9C55AE;
extern const uint32_t g_rgctx_TU26_t2CDCA917FC8D69CBC8506B40FF4C3D320C394860;
extern const uint32_t g_rgctx_T_t0DA05DAAE1602D536B9336ECFD5023C7250185BB;
extern const uint32_t g_rgctx_TU26_tD09EBB3D35AA69FBDF9408105AF6FF6A03251F8A;
extern const uint32_t g_rgctx_TU26_tC50723B81528083A61284F60E05C49596E28E995;
extern const uint32_t g_rgctx_T_tD9B75C3A90F5ADAE1D4CB286BF589C64D6F826CF;
extern const uint32_t g_rgctx_T_t6431A832C0FE9B48DEC156C6F433FD40910285B7;
extern const uint32_t g_rgctx_TU26_t08C01DA18D04A544A42B97D0DDA25DC615EE0C86;
extern const uint32_t g_rgctx_T_t3B1E77C02DB4AAB58F90922E3099FF9917049F54;
extern const uint32_t g_rgctx_TU26_tFFC5E7A3CA6D8012F7EBA32164DA1EBC5F3E243C;
extern const uint32_t g_rgctx_TU26_t6129C9B1C5D5580295B13DE5CA74A05B13810AAA;
extern const uint32_t g_rgctx_TU26_t574F5771D7CFE840A81F56652DF6E0F8403287AF;
extern const uint32_t g_rgctx_TU26_t7149E8F4BE7727FB21BB16B21B61688592AFB3FB;
extern const uint32_t g_rgctx_TU26_t83D4F190A8849032DD988EA86A7B9311A5309257;
static const Il2CppRGCTXDefinition s_rgctxValues[35] = 
{
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_T_t69374FF7455BF0198FC0F2F50A723741E052FE21 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_T_t46236521BFD11B8A5B1BABCEAD715D49ED4A1A28 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_T_t4C0A03328C9C8A254123851D32EB82133A725365 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_T_t987E376B027C09DB1CFE376088838CD47A845373 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_T_t5D35E9AA45F3F017961C19D66341B8F66F95CC5F },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_T_t90B1ABDBB86D5A9C31296CDFE2FF785AA17940C2 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TU26_t910FBE619FD92D5ED597731F44768842EA57BAA2 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_T_t9CF1D887FD7AAE86B8801FE9FCDA9658F0727699 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TU26_t4B4E963581C74481A7D3434B7BB461638F7438A0 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_T_tC3719F9FE9415CD0DD37B7BEB6C7775EB0F8DE9C },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TU26_t761EA6B14498E87A31357019AE3D277798883F60 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_T_t1FDEFCA0B0E530419C707125EE8E74E3221D3778 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_T_t38730D07DBDB0015A3C1C51343DC42B3E35403E9 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TU26_tD3468B6794620312ED0506E36D2969131D852330 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TU26_t9B6F773FB1B6674CCB5EA0124BD6F5DA8899BEDB },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TFromU26_tD6A1EAF239CE83FA5017188C9B152BC9468B9E44 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TToU26_t601689F0D372719660A1D5485CC1468885C60FA9 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_T_t97B5BE2F3817B8961E8509DF5982D2B810BCE818 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TU26_t7385CA1EA105629DC484567A88AE9C6BD5E99632 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TU26_tD23126F23A73C0E5C23783D5C87BC3F5283C2A1D },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_T_tEEBA3842B319E4DD94173281BA41EA604298A6D8 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_T_t3DF4F371C547F52D537F3A819B23EB9BEC9C55AE },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TU26_t2CDCA917FC8D69CBC8506B40FF4C3D320C394860 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_T_t0DA05DAAE1602D536B9336ECFD5023C7250185BB },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TU26_tD09EBB3D35AA69FBDF9408105AF6FF6A03251F8A },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TU26_tC50723B81528083A61284F60E05C49596E28E995 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_T_tD9B75C3A90F5ADAE1D4CB286BF589C64D6F826CF },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_T_t6431A832C0FE9B48DEC156C6F433FD40910285B7 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TU26_t08C01DA18D04A544A42B97D0DDA25DC615EE0C86 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_T_t3B1E77C02DB4AAB58F90922E3099FF9917049F54 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TU26_tFFC5E7A3CA6D8012F7EBA32164DA1EBC5F3E243C },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TU26_t6129C9B1C5D5580295B13DE5CA74A05B13810AAA },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TU26_t574F5771D7CFE840A81F56652DF6E0F8403287AF },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TU26_t7149E8F4BE7727FB21BB16B21B61688592AFB3FB },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TU26_t83D4F190A8849032DD988EA86A7B9311A5309257 },
};
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_Unity_Burst_Unsafe_CodeGenModule;
const Il2CppCodeGenModule g_Unity_Burst_Unsafe_CodeGenModule = 
{
	"Unity.Burst.Unsafe.dll",
	37,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	27,
	s_rgctxIndices,
	35,
	s_rgctxValues,
	NULL,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
