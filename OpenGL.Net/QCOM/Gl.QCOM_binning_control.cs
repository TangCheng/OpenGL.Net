
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
		/// [GL] Value of GL_BINNING_CONTROL_HINT_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_binning_control", Api = "gles2")]
		public const int BINNING_CONTROL_HINT_QCOM = 0x8FB0;

		/// <summary>
		/// [GL] Value of GL_CPU_OPTIMIZED_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_binning_control", Api = "gles2")]
		public const int CPU_OPTIMIZED_QCOM = 0x8FB1;

		/// <summary>
		/// [GL] Value of GL_GPU_OPTIMIZED_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_binning_control", Api = "gles2")]
		public const int GPU_OPTIMIZED_QCOM = 0x8FB2;

		/// <summary>
		/// [GL] Value of GL_RENDER_DIRECT_TO_FRAMEBUFFER_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_binning_control", Api = "gles2")]
		public const int RENDER_DIRECT_TO_FRAMEBUFFER_QCOM = 0x8FB3;

	}

}
