
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
	public partial class Egl
	{
		/// <summary>
		/// Binding for eglWaitSyncKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_wait_sync")]
		public static int WaitSyncKHR(IntPtr dpy, IntPtr sync, int flags)
		{
			int retValue;

			Debug.Assert(Delegates.peglWaitSyncKHR != null, "peglWaitSyncKHR not implemented");
			retValue = Delegates.peglWaitSyncKHR(dpy, sync, flags);
			LogCommand("eglWaitSyncKHR", retValue, dpy, sync, flags			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglWaitSyncKHR", ExactSpelling = true)]
			internal extern static unsafe int eglWaitSyncKHR(IntPtr dpy, IntPtr sync, int flags);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_KHR_wait_sync")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int eglWaitSyncKHR(IntPtr dpy, IntPtr sync, int flags);

			internal static eglWaitSyncKHR peglWaitSyncKHR;

		}
	}

}
