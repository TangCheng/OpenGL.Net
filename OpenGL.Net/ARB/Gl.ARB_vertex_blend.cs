
// Copyright (C) 2015-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_MAX_VERTEX_UNITS_ARB symbol.
		/// </summary>
		[AliasOf("GL_MAX_VERTEX_UNITS_OES")]
		[RequiredByFeature("GL_ARB_vertex_blend")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int MAX_VERTEX_UNITS_ARB = 0x86A4;

		/// <summary>
		/// [GL] Value of GL_ACTIVE_VERTEX_UNITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int ACTIVE_VERTEX_UNITS_ARB = 0x86A5;

		/// <summary>
		/// [GL] Value of GL_WEIGHT_SUM_UNITY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int WEIGHT_SUM_UNITY_ARB = 0x86A6;

		/// <summary>
		/// [GL] Value of GL_VERTEX_BLEND_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int VERTEX_BLEND_ARB = 0x86A7;

		/// <summary>
		/// [GL] Value of GL_CURRENT_WEIGHT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int CURRENT_WEIGHT_ARB = 0x86A8;

		/// <summary>
		/// [GL] Value of GL_WEIGHT_ARRAY_TYPE_ARB symbol.
		/// </summary>
		[AliasOf("GL_WEIGHT_ARRAY_TYPE_OES")]
		[RequiredByFeature("GL_ARB_vertex_blend")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int WEIGHT_ARRAY_TYPE_ARB = 0x86A9;

		/// <summary>
		/// [GL] Value of GL_WEIGHT_ARRAY_STRIDE_ARB symbol.
		/// </summary>
		[AliasOf("GL_WEIGHT_ARRAY_STRIDE_OES")]
		[RequiredByFeature("GL_ARB_vertex_blend")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int WEIGHT_ARRAY_STRIDE_ARB = 0x86AA;

		/// <summary>
		/// [GL] Value of GL_WEIGHT_ARRAY_SIZE_ARB symbol.
		/// </summary>
		[AliasOf("GL_WEIGHT_ARRAY_SIZE_OES")]
		[RequiredByFeature("GL_ARB_vertex_blend")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int WEIGHT_ARRAY_SIZE_ARB = 0x86AB;

		/// <summary>
		/// [GL] Value of GL_WEIGHT_ARRAY_POINTER_ARB symbol.
		/// </summary>
		[AliasOf("GL_WEIGHT_ARRAY_POINTER_OES")]
		[RequiredByFeature("GL_ARB_vertex_blend")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int WEIGHT_ARRAY_POINTER_ARB = 0x86AC;

		/// <summary>
		/// [GL] Value of GL_WEIGHT_ARRAY_ARB symbol.
		/// </summary>
		[AliasOf("GL_WEIGHT_ARRAY_OES")]
		[RequiredByFeature("GL_ARB_vertex_blend")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int WEIGHT_ARRAY_ARB = 0x86AD;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW0_ARB symbol.
		/// </summary>
		[AliasOf("GL_MODELVIEW0_EXT")]
		[RequiredByFeature("GL_ARB_vertex_blend")]
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int MODELVIEW0_ARB = 0x1700;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW1_ARB symbol.
		/// </summary>
		[AliasOf("GL_MODELVIEW1_EXT")]
		[RequiredByFeature("GL_ARB_vertex_blend")]
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int MODELVIEW1_ARB = 0x850A;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW2_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW2_ARB = 0x8722;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW3_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW3_ARB = 0x8723;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW4_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW4_ARB = 0x8724;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW5_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW5_ARB = 0x8725;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW6_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW6_ARB = 0x8726;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW7_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW7_ARB = 0x8727;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW8_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW8_ARB = 0x8728;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW9_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW9_ARB = 0x8729;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW10_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW10_ARB = 0x872A;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW11_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW11_ARB = 0x872B;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW12_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW12_ARB = 0x872C;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW13_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW13_ARB = 0x872D;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW14_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW14_ARB = 0x872E;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW15_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW15_ARB = 0x872F;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW16_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW16_ARB = 0x8730;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW17_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW17_ARB = 0x8731;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW18_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW18_ARB = 0x8732;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW19_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW19_ARB = 0x8733;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW20_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW20_ARB = 0x8734;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW21_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW21_ARB = 0x8735;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW22_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW22_ARB = 0x8736;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW23_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW23_ARB = 0x8737;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW24_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW24_ARB = 0x8738;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW25_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW25_ARB = 0x8739;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW26_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW26_ARB = 0x873A;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW27_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW27_ARB = 0x873B;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW28_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW28_ARB = 0x873C;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW29_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW29_ARB = 0x873D;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW30_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW30_ARB = 0x873E;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW31_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW31_ARB = 0x873F;

		/// <summary>
		/// Binding for glWeightbvARB.
		/// </summary>
		/// <param name="weights">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void WeightARB(sbyte[] weights)
		{
			unsafe {
				fixed (sbyte* p_weights = weights)
				{
					Debug.Assert(Delegates.pglWeightbvARB != null, "pglWeightbvARB not implemented");
					Delegates.pglWeightbvARB((Int32)weights.Length, p_weights);
					LogCommand("glWeightbvARB", null, weights.Length, weights					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWeightsvARB.
		/// </summary>
		/// <param name="weights">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void WeightARB(Int16[] weights)
		{
			unsafe {
				fixed (Int16* p_weights = weights)
				{
					Debug.Assert(Delegates.pglWeightsvARB != null, "pglWeightsvARB not implemented");
					Delegates.pglWeightsvARB((Int32)weights.Length, p_weights);
					LogCommand("glWeightsvARB", null, weights.Length, weights					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWeightivARB.
		/// </summary>
		/// <param name="weights">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void WeightARB(Int32[] weights)
		{
			unsafe {
				fixed (Int32* p_weights = weights)
				{
					Debug.Assert(Delegates.pglWeightivARB != null, "pglWeightivARB not implemented");
					Delegates.pglWeightivARB((Int32)weights.Length, p_weights);
					LogCommand("glWeightivARB", null, weights.Length, weights					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWeightfvARB.
		/// </summary>
		/// <param name="weights">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void WeightARB(float[] weights)
		{
			unsafe {
				fixed (float* p_weights = weights)
				{
					Debug.Assert(Delegates.pglWeightfvARB != null, "pglWeightfvARB not implemented");
					Delegates.pglWeightfvARB((Int32)weights.Length, p_weights);
					LogCommand("glWeightfvARB", null, weights.Length, weights					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWeightdvARB.
		/// </summary>
		/// <param name="weights">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void WeightARB(double[] weights)
		{
			unsafe {
				fixed (double* p_weights = weights)
				{
					Debug.Assert(Delegates.pglWeightdvARB != null, "pglWeightdvARB not implemented");
					Delegates.pglWeightdvARB((Int32)weights.Length, p_weights);
					LogCommand("glWeightdvARB", null, weights.Length, weights					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWeightubvARB.
		/// </summary>
		/// <param name="weights">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void WeightARB(byte[] weights)
		{
			unsafe {
				fixed (byte* p_weights = weights)
				{
					Debug.Assert(Delegates.pglWeightubvARB != null, "pglWeightubvARB not implemented");
					Delegates.pglWeightubvARB((Int32)weights.Length, p_weights);
					LogCommand("glWeightubvARB", null, weights.Length, weights					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWeightusvARB.
		/// </summary>
		/// <param name="weights">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void WeightARB(UInt16[] weights)
		{
			unsafe {
				fixed (UInt16* p_weights = weights)
				{
					Debug.Assert(Delegates.pglWeightusvARB != null, "pglWeightusvARB not implemented");
					Delegates.pglWeightusvARB((Int32)weights.Length, p_weights);
					LogCommand("glWeightusvARB", null, weights.Length, weights					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWeightuivARB.
		/// </summary>
		/// <param name="weights">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void WeightARB(UInt32[] weights)
		{
			unsafe {
				fixed (UInt32* p_weights = weights)
				{
					Debug.Assert(Delegates.pglWeightuivARB != null, "pglWeightuivARB not implemented");
					Delegates.pglWeightuivARB((Int32)weights.Length, p_weights);
					LogCommand("glWeightuivARB", null, weights.Length, weights					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWeightPointerARB.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void WeightPointerARB(Int32 size, Int32 type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglWeightPointerARB != null, "pglWeightPointerARB not implemented");
			Delegates.pglWeightPointerARB(size, type, stride, pointer);
			LogCommand("glWeightPointerARB", null, size, type, stride, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWeightPointerARB.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void WeightPointerARB(Int32 size, Int32 type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				WeightPointerARB(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glVertexBlendARB.
		/// </summary>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void VertexBlendARB(Int32 count)
		{
			Debug.Assert(Delegates.pglVertexBlendARB != null, "pglVertexBlendARB not implemented");
			Delegates.pglVertexBlendARB(count);
			LogCommand("glVertexBlendARB", null, count			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWeightbvARB", ExactSpelling = true)]
			internal extern static unsafe void glWeightbvARB(Int32 size, sbyte* weights);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWeightsvARB", ExactSpelling = true)]
			internal extern static unsafe void glWeightsvARB(Int32 size, Int16* weights);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWeightivARB", ExactSpelling = true)]
			internal extern static unsafe void glWeightivARB(Int32 size, Int32* weights);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWeightfvARB", ExactSpelling = true)]
			internal extern static unsafe void glWeightfvARB(Int32 size, float* weights);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWeightdvARB", ExactSpelling = true)]
			internal extern static unsafe void glWeightdvARB(Int32 size, double* weights);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWeightubvARB", ExactSpelling = true)]
			internal extern static unsafe void glWeightubvARB(Int32 size, byte* weights);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWeightusvARB", ExactSpelling = true)]
			internal extern static unsafe void glWeightusvARB(Int32 size, UInt16* weights);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWeightuivARB", ExactSpelling = true)]
			internal extern static unsafe void glWeightuivARB(Int32 size, UInt32* weights);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWeightPointerARB", ExactSpelling = true)]
			internal extern static unsafe void glWeightPointerARB(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexBlendARB", ExactSpelling = true)]
			internal extern static void glVertexBlendARB(Int32 count);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ARB_vertex_blend")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWeightbvARB(Int32 size, sbyte* weights);

			[ThreadStatic]
			internal static glWeightbvARB pglWeightbvARB;

			[RequiredByFeature("GL_ARB_vertex_blend")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWeightsvARB(Int32 size, Int16* weights);

			[ThreadStatic]
			internal static glWeightsvARB pglWeightsvARB;

			[RequiredByFeature("GL_ARB_vertex_blend")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWeightivARB(Int32 size, Int32* weights);

			[ThreadStatic]
			internal static glWeightivARB pglWeightivARB;

			[RequiredByFeature("GL_ARB_vertex_blend")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWeightfvARB(Int32 size, float* weights);

			[ThreadStatic]
			internal static glWeightfvARB pglWeightfvARB;

			[RequiredByFeature("GL_ARB_vertex_blend")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWeightdvARB(Int32 size, double* weights);

			[ThreadStatic]
			internal static glWeightdvARB pglWeightdvARB;

			[RequiredByFeature("GL_ARB_vertex_blend")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWeightubvARB(Int32 size, byte* weights);

			[ThreadStatic]
			internal static glWeightubvARB pglWeightubvARB;

			[RequiredByFeature("GL_ARB_vertex_blend")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWeightusvARB(Int32 size, UInt16* weights);

			[ThreadStatic]
			internal static glWeightusvARB pglWeightusvARB;

			[RequiredByFeature("GL_ARB_vertex_blend")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWeightuivARB(Int32 size, UInt32* weights);

			[ThreadStatic]
			internal static glWeightuivARB pglWeightuivARB;

			[RequiredByFeature("GL_ARB_vertex_blend")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWeightPointerARB(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glWeightPointerARB pglWeightPointerARB;

			[RequiredByFeature("GL_ARB_vertex_blend")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexBlendARB(Int32 count);

			[ThreadStatic]
			internal static glVertexBlendARB pglVertexBlendARB;

		}
	}

}
