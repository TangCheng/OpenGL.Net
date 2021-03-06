
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
		/// [GL] Value of GL_QUAD_MESH_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_mesh_array")]
		public const int QUAD_MESH_SUN = 0x8614;

		/// <summary>
		/// [GL] Value of GL_TRIANGLE_MESH_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_mesh_array")]
		public const int TRIANGLE_MESH_SUN = 0x8615;

		/// <summary>
		/// Binding for glDrawMeshArraysSUN.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_mesh_array")]
		public static void DrawMeshArraysSUN(PrimitiveType mode, Int32 first, Int32 count, Int32 width)
		{
			Debug.Assert(Delegates.pglDrawMeshArraysSUN != null, "pglDrawMeshArraysSUN not implemented");
			Delegates.pglDrawMeshArraysSUN((Int32)mode, first, count, width);
			LogCommand("glDrawMeshArraysSUN", null, mode, first, count, width			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawMeshArraysSUN", ExactSpelling = true)]
			internal extern static void glDrawMeshArraysSUN(Int32 mode, Int32 first, Int32 count, Int32 width);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_SUN_mesh_array")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawMeshArraysSUN(Int32 mode, Int32 first, Int32 count, Int32 width);

			[ThreadStatic]
			internal static glDrawMeshArraysSUN pglDrawMeshArraysSUN;

		}
	}

}
