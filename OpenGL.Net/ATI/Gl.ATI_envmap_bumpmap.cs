
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
		/// [GL] Value of GL_BUMP_ROT_MATRIX_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public const int BUMP_ROT_MATRIX_ATI = 0x8775;

		/// <summary>
		/// [GL] Value of GL_BUMP_ROT_MATRIX_SIZE_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public const int BUMP_ROT_MATRIX_SIZE_ATI = 0x8776;

		/// <summary>
		/// [GL] Value of GL_BUMP_NUM_TEX_UNITS_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public const int BUMP_NUM_TEX_UNITS_ATI = 0x8777;

		/// <summary>
		/// [GL] Value of GL_BUMP_TEX_UNITS_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public const int BUMP_TEX_UNITS_ATI = 0x8778;

		/// <summary>
		/// [GL] Value of GL_DUDV_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public const int DUDV_ATI = 0x8779;

		/// <summary>
		/// [GL] Value of GL_DU8DV8_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public const int DU8DV8_ATI = 0x877A;

		/// <summary>
		/// [GL] Value of GL_BUMP_ENVMAP_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public const int BUMP_ENVMAP_ATI = 0x877B;

		/// <summary>
		/// [GL] Value of GL_BUMP_TARGET_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public const int BUMP_TARGET_ATI = 0x877C;

		/// <summary>
		/// Binding for glTexBumpParameterivATI.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public static void TexBumpParameterATI(Int32 pname, Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglTexBumpParameterivATI != null, "pglTexBumpParameterivATI not implemented");
					Delegates.pglTexBumpParameterivATI(pname, p_param);
					LogCommand("glTexBumpParameterivATI", null, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexBumpParameterfvATI.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public static void TexBumpParameterATI(Int32 pname, float[] param)
		{
			unsafe {
				fixed (float* p_param = param)
				{
					Debug.Assert(Delegates.pglTexBumpParameterfvATI != null, "pglTexBumpParameterfvATI not implemented");
					Delegates.pglTexBumpParameterfvATI(pname, p_param);
					LogCommand("glTexBumpParameterfvATI", null, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTexBumpParameterivATI.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public static void GetTexBumpParameterATI(Int32 pname, [Out] Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglGetTexBumpParameterivATI != null, "pglGetTexBumpParameterivATI not implemented");
					Delegates.pglGetTexBumpParameterivATI(pname, p_param);
					LogCommand("glGetTexBumpParameterivATI", null, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTexBumpParameterfvATI.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public static void GetTexBumpParameterATI(Int32 pname, [Out] float[] param)
		{
			unsafe {
				fixed (float* p_param = param)
				{
					Debug.Assert(Delegates.pglGetTexBumpParameterfvATI != null, "pglGetTexBumpParameterfvATI not implemented");
					Delegates.pglGetTexBumpParameterfvATI(pname, p_param);
					LogCommand("glGetTexBumpParameterfvATI", null, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexBumpParameterivATI", ExactSpelling = true)]
			internal extern static unsafe void glTexBumpParameterivATI(Int32 pname, Int32* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexBumpParameterfvATI", ExactSpelling = true)]
			internal extern static unsafe void glTexBumpParameterfvATI(Int32 pname, float* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexBumpParameterivATI", ExactSpelling = true)]
			internal extern static unsafe void glGetTexBumpParameterivATI(Int32 pname, Int32* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexBumpParameterfvATI", ExactSpelling = true)]
			internal extern static unsafe void glGetTexBumpParameterfvATI(Int32 pname, float* param);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ATI_envmap_bumpmap")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexBumpParameterivATI(Int32 pname, Int32* param);

			[ThreadStatic]
			internal static glTexBumpParameterivATI pglTexBumpParameterivATI;

			[RequiredByFeature("GL_ATI_envmap_bumpmap")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexBumpParameterfvATI(Int32 pname, float* param);

			[ThreadStatic]
			internal static glTexBumpParameterfvATI pglTexBumpParameterfvATI;

			[RequiredByFeature("GL_ATI_envmap_bumpmap")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexBumpParameterivATI(Int32 pname, Int32* param);

			[ThreadStatic]
			internal static glGetTexBumpParameterivATI pglGetTexBumpParameterivATI;

			[RequiredByFeature("GL_ATI_envmap_bumpmap")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexBumpParameterfvATI(Int32 pname, float* param);

			[ThreadStatic]
			internal static glGetTexBumpParameterfvATI pglGetTexBumpParameterfvATI;

		}
	}

}
