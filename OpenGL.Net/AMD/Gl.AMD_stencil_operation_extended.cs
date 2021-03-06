
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
		/// [GL] Value of GL_SET_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_stencil_operation_extended")]
		public const int SET_AMD = 0x874A;

		/// <summary>
		/// [GL] Value of GL_REPLACE_VALUE_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_stencil_operation_extended")]
		public const int REPLACE_VALUE_AMD = 0x874B;

		/// <summary>
		/// [GL] Value of GL_STENCIL_OP_VALUE_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_stencil_operation_extended")]
		public const int STENCIL_OP_VALUE_AMD = 0x874C;

		/// <summary>
		/// [GL] Value of GL_STENCIL_BACK_OP_VALUE_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_stencil_operation_extended")]
		public const int STENCIL_BACK_OP_VALUE_AMD = 0x874D;

		/// <summary>
		/// Binding for glStencilOpValueAMD.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:StencilFaceDirection"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_stencil_operation_extended")]
		public static void StencilOpAMD(StencilFaceDirection face, UInt32 value)
		{
			Debug.Assert(Delegates.pglStencilOpValueAMD != null, "pglStencilOpValueAMD not implemented");
			Delegates.pglStencilOpValueAMD((Int32)face, value);
			LogCommand("glStencilOpValueAMD", null, face, value			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glStencilOpValueAMD", ExactSpelling = true)]
			internal extern static void glStencilOpValueAMD(Int32 face, UInt32 value);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_AMD_stencil_operation_extended")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilOpValueAMD(Int32 face, UInt32 value);

			[ThreadStatic]
			internal static glStencilOpValueAMD pglStencilOpValueAMD;

		}
	}

}
