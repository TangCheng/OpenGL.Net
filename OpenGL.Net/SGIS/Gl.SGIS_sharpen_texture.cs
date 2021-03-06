
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
		/// [GL] Value of GL_LINEAR_SHARPEN_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		public const int LINEAR_SHARPEN_SGIS = 0x80AD;

		/// <summary>
		/// [GL] Value of GL_LINEAR_SHARPEN_ALPHA_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		public const int LINEAR_SHARPEN_ALPHA_SGIS = 0x80AE;

		/// <summary>
		/// [GL] Value of GL_LINEAR_SHARPEN_COLOR_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		public const int LINEAR_SHARPEN_COLOR_SGIS = 0x80AF;

		/// <summary>
		/// [GL] Value of GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		public const int SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0;

		/// <summary>
		/// Binding for glSharpenTexFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		public static void SharpenTexFuncSGIS(TextureTarget target, Int32 n, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglSharpenTexFuncSGIS != null, "pglSharpenTexFuncSGIS not implemented");
					Delegates.pglSharpenTexFuncSGIS((Int32)target, n, p_points);
					LogCommand("glSharpenTexFuncSGIS", null, target, n, points					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetSharpenTexFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		public static void GetSharpenTexFuncSGIS(TextureTarget target, [Out] float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglGetSharpenTexFuncSGIS != null, "pglGetSharpenTexFuncSGIS not implemented");
					Delegates.pglGetSharpenTexFuncSGIS((Int32)target, p_points);
					LogCommand("glGetSharpenTexFuncSGIS", null, target, points					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSharpenTexFuncSGIS", ExactSpelling = true)]
			internal extern static unsafe void glSharpenTexFuncSGIS(Int32 target, Int32 n, float* points);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetSharpenTexFuncSGIS", ExactSpelling = true)]
			internal extern static unsafe void glGetSharpenTexFuncSGIS(Int32 target, float* points);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_SGIS_sharpen_texture")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSharpenTexFuncSGIS(Int32 target, Int32 n, float* points);

			[ThreadStatic]
			internal static glSharpenTexFuncSGIS pglSharpenTexFuncSGIS;

			[RequiredByFeature("GL_SGIS_sharpen_texture")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetSharpenTexFuncSGIS(Int32 target, float* points);

			[ThreadStatic]
			internal static glGetSharpenTexFuncSGIS pglGetSharpenTexFuncSGIS;

		}
	}

}
