
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
		/// Binding for glGetGraphicsResetStatusEXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		public static GraphicsResetStatus GetGraphicsResetStatusEXT()
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetGraphicsResetStatusEXT != null, "pglGetGraphicsResetStatusEXT not implemented");
			retValue = Delegates.pglGetGraphicsResetStatusEXT();
			LogCommand("glGetGraphicsResetStatusEXT", (GraphicsResetStatus)retValue			);
			DebugCheckErrors(retValue);

			return ((GraphicsResetStatus)retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetGraphicsResetStatusEXT", ExactSpelling = true)]
			internal extern static Int32 glGetGraphicsResetStatusEXT();

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetGraphicsResetStatusEXT();

			[ThreadStatic]
			internal static glGetGraphicsResetStatusEXT pglGetGraphicsResetStatusEXT;

		}
	}

}
