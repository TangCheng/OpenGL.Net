
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
		/// Binding for glGetConvolutionFilterEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetConvolutionFilterEXT(ConvolutionTargetEXT target, PixelFormat format, PixelType type, IntPtr image)
		{
			Debug.Assert(Delegates.pglGetConvolutionFilterEXT != null, "pglGetConvolutionFilterEXT not implemented");
			Delegates.pglGetConvolutionFilterEXT((Int32)target, (Int32)format, (Int32)type, image);
			LogCommand("glGetConvolutionFilterEXT", null, target, format, type, image			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetConvolutionFilterEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetConvolutionFilterEXT(ConvolutionTargetEXT target, PixelFormat format, PixelType type, Object image)
		{
			GCHandle pin_image = GCHandle.Alloc(image, GCHandleType.Pinned);
			try {
				GetConvolutionFilterEXT(target, format, type, pin_image.AddrOfPinnedObject());
			} finally {
				pin_image.Free();
			}
		}

		/// <summary>
		/// Binding for glGetConvolutionParameterfvEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ConvolutionParameterEXT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetConvolutionParameterEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetConvolutionParameterfvEXT != null, "pglGetConvolutionParameterfvEXT not implemented");
					Delegates.pglGetConvolutionParameterfvEXT((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetConvolutionParameterfvEXT", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetConvolutionParameterivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ConvolutionParameterEXT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetConvolutionParameterEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetConvolutionParameterivEXT != null, "pglGetConvolutionParameterivEXT not implemented");
					Delegates.pglGetConvolutionParameterivEXT((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetConvolutionParameterivEXT", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetSeparableFilterEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:SeparableTargetEXT"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="span">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetSeparableFilterEXT(SeparableTargetEXT target, PixelFormat format, PixelType type, IntPtr row, IntPtr column, IntPtr span)
		{
			Debug.Assert(Delegates.pglGetSeparableFilterEXT != null, "pglGetSeparableFilterEXT not implemented");
			Delegates.pglGetSeparableFilterEXT((Int32)target, (Int32)format, (Int32)type, row, column, span);
			LogCommand("glGetSeparableFilterEXT", null, target, format, type, row, column, span			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetSeparableFilterEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:SeparableTargetEXT"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="span">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetSeparableFilterEXT(SeparableTargetEXT target, PixelFormat format, PixelType type, Object row, Object column, Object span)
		{
			GCHandle pin_row = GCHandle.Alloc(row, GCHandleType.Pinned);
			GCHandle pin_column = GCHandle.Alloc(column, GCHandleType.Pinned);
			GCHandle pin_span = GCHandle.Alloc(span, GCHandleType.Pinned);
			try {
				GetSeparableFilterEXT(target, format, type, pin_row.AddrOfPinnedObject(), pin_column.AddrOfPinnedObject(), pin_span.AddrOfPinnedObject());
			} finally {
				pin_row.Free();
				pin_column.Free();
				pin_span.Free();
			}
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetConvolutionFilterEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetConvolutionFilterEXT(Int32 target, Int32 format, Int32 type, IntPtr image);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetConvolutionParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetConvolutionParameterfvEXT(Int32 target, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetConvolutionParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetConvolutionParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetSeparableFilterEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetSeparableFilterEXT(Int32 target, Int32 format, Int32 type, IntPtr row, IntPtr column, IntPtr span);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_convolution")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetConvolutionFilterEXT(Int32 target, Int32 format, Int32 type, IntPtr image);

			[ThreadStatic]
			internal static glGetConvolutionFilterEXT pglGetConvolutionFilterEXT;

			[RequiredByFeature("GL_EXT_convolution")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetConvolutionParameterfvEXT(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetConvolutionParameterfvEXT pglGetConvolutionParameterfvEXT;

			[RequiredByFeature("GL_EXT_convolution")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetConvolutionParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetConvolutionParameterivEXT pglGetConvolutionParameterivEXT;

			[RequiredByFeature("GL_EXT_convolution")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetSeparableFilterEXT(Int32 target, Int32 format, Int32 type, IntPtr row, IntPtr column, IntPtr span);

			[ThreadStatic]
			internal static glGetSeparableFilterEXT pglGetSeparableFilterEXT;

		}
	}

}
