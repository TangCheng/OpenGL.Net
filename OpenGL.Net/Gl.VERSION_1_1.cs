
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
		/// <para>
		/// [GL4] Gl.Get: data returns a single boolean value indicating whether a fragment's RGBA color values are merged into the 
		/// framebuffer using a logical operation. The initial value is Gl.FALSE. See Gl.LogicOp.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.Enable: If enabled, apply the currently selected logical operation to the computed fragment color and color 
		/// buffer values. See Gl.LogicOp.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.Get: params returns a single boolean value indicating whether logical operation on color values is enabled. 
		/// The initial value is Gl.FALSE. See Gl.LogicOp.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int COLOR_LOGIC_OP = 0x0BF2;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value. This value is multiplied by an implementation-specific value and then 
		/// added to the depth value of each fragment generated when a polygon is rasterized. The initial value is 0. See 
		/// Gl.PolygonOffset.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int POLYGON_OFFSET_UNITS = 0x2A00;

		/// <summary>
		/// [GL4] Gl.Get: data returns a single boolean value indicating whether polygon offset is enabled for polygons in point 
		/// mode. The initial value is Gl.FALSE. See Gl.PolygonOffset.
		/// </summary>
		[AliasOf("GL_POLYGON_OFFSET_POINT_NV")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		public const int POLYGON_OFFSET_POINT = 0x2A01;

		/// <summary>
		/// [GL4] Gl.Get: data returns a single boolean value indicating whether polygon offset is enabled for polygons in line 
		/// mode. The initial value is Gl.FALSE. See Gl.PolygonOffset.
		/// </summary>
		[AliasOf("GL_POLYGON_OFFSET_LINE_NV")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		public const int POLYGON_OFFSET_LINE = 0x2A02;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data returns a single boolean value indicating whether polygon offset is enabled for polygons in fill 
		/// mode. The initial value is Gl.FALSE. See Gl.PolygonOffset.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns a single boolean value indicating whether polygon offset is enabled for polygons. The 
		/// initial value is Gl.FALSE. See Gl.PolygonOffset.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int POLYGON_OFFSET_FILL = 0x8037;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, the scaling factor used to determine the variable offset that is added to 
		/// the depth value of each fragment generated when a polygon is rasterized. The initial value is 0. See Gl.PolygonOffset.
		/// </summary>
		[AliasOf("GL_POLYGON_OFFSET_FACTOR_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_polygon_offset")]
		public const int POLYGON_OFFSET_FACTOR = 0x8038;

		/// <summary>
		/// [GL4] Gl.Get: data returns a single value, the name of the texture currently bound to the target Gl.TEXTURE_1D. The 
		/// initial value is 0. See Gl.BindTexture.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public const int TEXTURE_BINDING_1D = 0x8068;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns a single value, the name of the texture currently bound to the target Gl.TEXTURE_2D. 
		/// The initial value is 0. See Gl.BindTexture.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public const int TEXTURE_BINDING_2D = 0x8069;

		/// <summary>
		/// [GL4|GLES3.2] Gl.GetTexLevelParameter: params returns a single value, the internal format of the texture image.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		public const int TEXTURE_INTERNAL_FORMAT = 0x1003;

		/// <summary>
		/// <para>
		/// [GL4] Gl.GetTexLevelParameter: The internal storage resolution of an individual component. The resolution chosen by the 
		/// GL will be a close match for the resolution requested by the user with the component argument of Gl.TexImage1D, 
		/// Gl.TexImage2D, Gl.TexImage3D, Gl.CopyTexImage1D, and Gl.CopyTexImage2D. The initial value is 0.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.GetTexLevelParameter: The actual internal storage resolution of an individual component.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_RED_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int TEXTURE_RED_SIZE = 0x805C;

		/// <summary>
		/// [GL2.1] Gl.GetTexLevelParameter: 
		/// </summary>
		[AliasOf("GL_TEXTURE_GREEN_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int TEXTURE_GREEN_SIZE = 0x805D;

		/// <summary>
		/// [GL2.1] Gl.GetTexLevelParameter: 
		/// </summary>
		[AliasOf("GL_TEXTURE_BLUE_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int TEXTURE_BLUE_SIZE = 0x805E;

		/// <summary>
		/// [GL2.1] Gl.GetTexLevelParameter: 
		/// </summary>
		[AliasOf("GL_TEXTURE_ALPHA_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int TEXTURE_ALPHA_SIZE = 0x805F;

		/// <summary>
		/// [GL] Value of GL_DOUBLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE = 0x140A;

		/// <summary>
		/// [GL] Value of GL_PROXY_TEXTURE_1D symbol.
		/// </summary>
		[AliasOf("GL_PROXY_TEXTURE_1D_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int PROXY_TEXTURE_1D = 0x8063;

		/// <summary>
		/// [GL] Value of GL_PROXY_TEXTURE_2D symbol.
		/// </summary>
		[AliasOf("GL_PROXY_TEXTURE_2D_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int PROXY_TEXTURE_2D = 0x8064;

		/// <summary>
		/// [GL] Value of GL_R3_G3_B2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int R3_G3_B2 = 0x2A10;

		/// <summary>
		/// [GL] Value of GL_RGB4 symbol.
		/// </summary>
		[AliasOf("GL_RGB4_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB4 = 0x804F;

		/// <summary>
		/// [GL] Value of GL_RGB5 symbol.
		/// </summary>
		[AliasOf("GL_RGB5_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB5 = 0x8050;

		/// <summary>
		/// [GL] Value of GL_RGB8 symbol.
		/// </summary>
		[AliasOf("GL_RGB8_EXT")]
		[AliasOf("GL_RGB8_OES")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		[RequiredByFeature("GL_OES_rgb8_rgba8", Api = "gles1|gles2|glsc2")]
		public const int RGB8 = 0x8051;

		/// <summary>
		/// [GL] Value of GL_RGB10 symbol.
		/// </summary>
		[AliasOf("GL_RGB10_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		public const int RGB10 = 0x8052;

		/// <summary>
		/// [GL] Value of GL_RGB12 symbol.
		/// </summary>
		[AliasOf("GL_RGB12_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB12 = 0x8053;

		/// <summary>
		/// [GL] Value of GL_RGB16 symbol.
		/// </summary>
		[AliasOf("GL_RGB16_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_EXT_texture_norm16", Api = "gles2")]
		public const int RGB16 = 0x8054;

		/// <summary>
		/// [GL] Value of GL_RGBA2 symbol.
		/// </summary>
		[AliasOf("GL_RGBA2_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGBA2 = 0x8055;

		/// <summary>
		/// [GL] Value of GL_RGBA4 symbol.
		/// </summary>
		[AliasOf("GL_RGBA4_EXT")]
		[AliasOf("GL_RGBA4_OES")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		public const int RGBA4 = 0x8056;

		/// <summary>
		/// [GL] Value of GL_RGB5_A1 symbol.
		/// </summary>
		[AliasOf("GL_RGB5_A1_EXT")]
		[AliasOf("GL_RGB5_A1_OES")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		public const int RGB5_A1 = 0x8057;

		/// <summary>
		/// [GL] Value of GL_RGBA8 symbol.
		/// </summary>
		[AliasOf("GL_RGBA8_EXT")]
		[AliasOf("GL_RGBA8_OES")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		[RequiredByFeature("GL_OES_rgb8_rgba8", Api = "gles1|gles2|glsc2")]
		public const int RGBA8 = 0x8058;

		/// <summary>
		/// [GL] Value of GL_RGB10_A2 symbol.
		/// </summary>
		[AliasOf("GL_RGB10_A2_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		public const int RGB10_A2 = 0x8059;

		/// <summary>
		/// [GL] Value of GL_RGBA12 symbol.
		/// </summary>
		[AliasOf("GL_RGBA12_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGBA12 = 0x805A;

		/// <summary>
		/// [GL] Value of GL_RGBA16 symbol.
		/// </summary>
		[AliasOf("GL_RGBA16_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_EXT_texture_norm16", Api = "gles2")]
		public const int RGBA16 = 0x805B;

		/// <summary>
		/// [GL] Value of GL_CLIENT_PIXEL_STORE_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint CLIENT_PIXEL_STORE_BIT = 0x00000001;

		/// <summary>
		/// [GL] Value of GL_CLIENT_VERTEX_ARRAY_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint CLIENT_VERTEX_ARRAY_BIT = 0x00000002;

		/// <summary>
		/// [GL] Value of GL_CLIENT_ALL_ATTRIB_BITS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint CLIENT_ALL_ATTRIB_BITS = 0xFFFFFFFF;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_VERTEX_ARRAY_POINTER_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int VERTEX_ARRAY_POINTER = 0x808E;

		/// <summary>
		/// [GL] Value of GL_NORMAL_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_NORMAL_ARRAY_POINTER_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int NORMAL_ARRAY_POINTER = 0x808F;

		/// <summary>
		/// [GL] Value of GL_COLOR_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_COLOR_ARRAY_POINTER_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int COLOR_ARRAY_POINTER = 0x8090;

		/// <summary>
		/// [GL] Value of GL_INDEX_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_INDEX_ARRAY_POINTER_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int INDEX_ARRAY_POINTER = 0x8091;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_COORD_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_TEXTURE_COORD_ARRAY_POINTER_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_COORD_ARRAY_POINTER = 0x8092;

		/// <summary>
		/// [GL] Value of GL_EDGE_FLAG_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_EDGE_FLAG_ARRAY_POINTER_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int EDGE_FLAG_ARRAY_POINTER = 0x8093;

		/// <summary>
		/// [GL] Value of GL_FEEDBACK_BUFFER_POINTER symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int FEEDBACK_BUFFER_POINTER = 0x0DF0;

		/// <summary>
		/// [GL] Value of GL_SELECTION_BUFFER_POINTER symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int SELECTION_BUFFER_POINTER = 0x0DF3;

		/// <summary>
		/// [GL2.1] Gl.Get: params returns one value indicating the depth of the attribute stack. The initial value is 0. See 
		/// Gl.PushClientAttrib.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.Enable: If enabled, apply the currently selected logical operation to the incoming index and color buffer 
		/// indices. See Gl.LogicOp.
		/// </para>
		/// <para>
		/// [GL2.1] Gl.Get: params returns a single boolean value indicating whether a fragment's index values are merged into the 
		/// framebuffer using a logical operation. The initial value is Gl.FALSE. See Gl.LogicOp.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int INDEX_LOGIC_OP = 0x0BF1;

		/// <summary>
		/// [GL2.1] Gl.Get: params returns one value indicating the maximum supported depth of the client attribute stack. See 
		/// Gl.PushClientAttrib.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B;

		/// <summary>
		/// [GL2.1] Gl.Get: params returns one value, the size of the feedback buffer. See Gl.FeedbackBuffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int FEEDBACK_BUFFER_SIZE = 0x0DF1;

		/// <summary>
		/// [GL2.1] Gl.Get: params returns one value, the type of the feedback buffer. See Gl.FeedbackBuffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int FEEDBACK_BUFFER_TYPE = 0x0DF2;

		/// <summary>
		/// [GL2.1] Gl.Get: params return one value, the size of the selection buffer. See Gl.SelectBuffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int SELECTION_BUFFER_SIZE = 0x0DF4;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.EnableClientState: If enabled, the vertex array is enabled for writing and used during rendering when 
		/// Gl.ArrayElement, Gl.DrawArrays, Gl.DrawElements, Gl.DrawRangeElementsGl.MultiDrawArrays, or Gl.MultiDrawElements is 
		/// called. See Gl.VertexPointer.
		/// </para>
		/// <para>
		/// [GL2.1] Gl.Get: params returns a single boolean value indicating whether the vertex array is enabled. The initial value 
		/// is Gl.FALSE. See Gl.VertexPointer.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.EnableClientState: If enabled, the vertex array is enabled for writing and used during rendering when 
		/// Gl.DrawArrays, or Gl.DrawElements is called. See Gl.VertexPointer.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.Get: params returns a single boolean value indicating whether the vertex array is enabled. The initial 
		/// value is Gl.FALSE. See Gl.VertexPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_VERTEX_ARRAY_EXT")]
		[AliasOf("GL_VERTEX_ARRAY_KHR")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int VERTEX_ARRAY = 0x8074;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.EnableClientState: If enabled, the normal array is enabled for writing and used during rendering when 
		/// Gl.ArrayElement, Gl.DrawArrays, Gl.DrawElements, Gl.DrawRangeElementsGl.MultiDrawArrays, or Gl.MultiDrawElements is 
		/// called. See Gl.NormalPointer.
		/// </para>
		/// <para>
		/// [GL2.1] Gl.Get: params returns a single boolean value, indicating whether the normal array is enabled. The initial value 
		/// is Gl.FALSE. See Gl.NormalPointer.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.EnableClientState: If enabled, the normal array is enabled for writing and used during rendering when 
		/// Gl.DrawArrays, or Gl.DrawElements is called. See Gl.NormalPointer.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.Get: params returns a single boolean value indicating whether the normal array is enabled. The initial 
		/// value is Gl.FALSE. See Gl.NormalPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_NORMAL_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int NORMAL_ARRAY = 0x8075;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.EnableClientState: If enabled, the color array is enabled for writing and used during rendering when 
		/// Gl.ArrayElement, Gl.DrawArrays, Gl.DrawElements, Gl.DrawRangeElementsGl.MultiDrawArrays, or Gl.MultiDrawElements is 
		/// called. See Gl.ColorPointer.
		/// </para>
		/// <para>
		/// [GL2.1] Gl.Get: params returns a single boolean value indicating whether the color array is enabled. The initial value 
		/// is Gl.FALSE. See Gl.ColorPointer.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.EnableClientState: If enabled, the color array is enabled for writing and used during rendering when 
		/// Gl.DrawArrays, or Gl.DrawElements is called. See Gl.ColorPointer.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.Get: params returns a single boolean value indicating whether the color array is enabled. The initial value 
		/// is Gl.FALSE. See Gl.ColorPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_COLOR_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int COLOR_ARRAY = 0x8076;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.EnableClientState: If enabled, the index array is enabled for writing and used during rendering when 
		/// Gl.ArrayElement, Gl.DrawArrays, Gl.DrawElements, Gl.DrawRangeElementsGl.MultiDrawArrays, or Gl.MultiDrawElements is 
		/// called. See Gl.IndexPointer.
		/// </para>
		/// <para>
		/// [GL2.1] Gl.Get: params returns a single boolean value indicating whether the color index array is enabled. The initial 
		/// value is Gl.FALSE. See Gl.IndexPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_INDEX_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int INDEX_ARRAY = 0x8077;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.EnableClientState: If enabled, the texture coordinate array is enabled for writing and used during rendering 
		/// when Gl.ArrayElement, Gl.DrawArrays, Gl.DrawElements, Gl.DrawRangeElementsGl.MultiDrawArrays, or Gl.MultiDrawElements is 
		/// called. See Gl.TexCoordPointer.
		/// </para>
		/// <para>
		/// [GL2.1] Gl.Get: params returns a single boolean value indicating whether the texture coordinate array is enabled. The 
		/// initial value is Gl.FALSE. See Gl.TexCoordPointer.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.EnableClientState: If enabled, the texture coordinate array is enabled for writing and used during 
		/// rendering when Gl.DrawArrays, or Gl.DrawElements is called. See Gl.TexCoordPointer.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.Get: params returns a single boolean value indicating whether the texture coordinate array is enabled. The 
		/// initial value is Gl.FALSE. See Gl.TexCoordPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_COORD_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_COORD_ARRAY = 0x8078;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.EnableClientState: If enabled, the edge flag array is enabled for writing and used during rendering when 
		/// Gl.ArrayElement, Gl.DrawArrays, Gl.DrawElements, Gl.DrawRangeElementsGl.MultiDrawArrays, or Gl.MultiDrawElements is 
		/// called. See Gl.EdgeFlagPointer.
		/// </para>
		/// <para>
		/// [GL2.1] Gl.Get: params returns a single boolean value indicating whether the edge flag array is enabled. The initial 
		/// value is Gl.FALSE. See Gl.EdgeFlagPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_EDGE_FLAG_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int EDGE_FLAG_ARRAY = 0x8079;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.Get: params returns one value, the number of coordinates per vertex in the vertex array. The initial value is 
		/// 4. See Gl.VertexPointer.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.Get: params returns one value, number of coordinates per vertex in the vertex array. See Gl.VertexPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_VERTEX_ARRAY_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int VERTEX_ARRAY_SIZE = 0x807A;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.Get: params returns one value, the data type of each coordinate in the vertex array. The initial value is 
		/// Gl.FLOAT. See Gl.VertexPointer.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.Get: params returns one value, returns the data type of each coordinate in the vertex array. See 
		/// Gl.VertexPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_VERTEX_ARRAY_TYPE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int VERTEX_ARRAY_TYPE = 0x807B;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.Get: params returns one value, the byte offset between consecutive vertices in the vertex array. The initial 
		/// value is 0. See Gl.VertexPointer.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.Get: params returns one value, the byte offset between consecutive vertexes in the vertex array. See 
		/// Gl.VertexPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_VERTEX_ARRAY_STRIDE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int VERTEX_ARRAY_STRIDE = 0x807C;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.Get: params returns one value, the data type of each coordinate in the normal array. The initial value is 
		/// Gl.FLOAT. See Gl.NormalPointer.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.Get: params returns one value, the data type of each normal in the normal array. See Gl.NormalPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_NORMAL_ARRAY_TYPE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int NORMAL_ARRAY_TYPE = 0x807E;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.Get: params returns one value, the byte offset between consecutive normals in the normal array. The initial 
		/// value is 0. See Gl.NormalPointer.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.Get: params returns one value, the byte offset between consective normals in the normal array. See 
		/// Gl.NormalPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_NORMAL_ARRAY_STRIDE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int NORMAL_ARRAY_STRIDE = 0x807F;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.Get: params returns one value, the number of components per color in the color array. The initial value is 4. 
		/// See Gl.ColorPointer.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.Get: params returns one value, the number of components per color in the color array. See Gl.ColorPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_COLOR_ARRAY_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int COLOR_ARRAY_SIZE = 0x8081;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.Get: params returns one value, the data type of each component in the color array. The initial value is 
		/// Gl.FLOAT. See Gl.ColorPointer.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.Get: params returns one value, returns the data type of each component in the color array. See 
		/// Gl.ColorPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_COLOR_ARRAY_TYPE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int COLOR_ARRAY_TYPE = 0x8082;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.Get: params returns one value, the byte offset between consecutive colors in the color array. The initial 
		/// value is 0. See Gl.ColorPointer.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.Get: params returns one value, the byte offset between consecutive colors in the color array. See 
		/// Gl.ColorPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_COLOR_ARRAY_STRIDE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int COLOR_ARRAY_STRIDE = 0x8083;

		/// <summary>
		/// [GL2.1] Gl.Get: params returns one value, the data type of indexes in the color index array. The initial value is 
		/// Gl.FLOAT. See Gl.IndexPointer.
		/// </summary>
		[AliasOf("GL_INDEX_ARRAY_TYPE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int INDEX_ARRAY_TYPE = 0x8085;

		/// <summary>
		/// [GL2.1] Gl.Get: params returns one value, the byte offset between consecutive color indexes in the color index array. 
		/// The initial value is 0. See Gl.IndexPointer.
		/// </summary>
		[AliasOf("GL_INDEX_ARRAY_STRIDE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int INDEX_ARRAY_STRIDE = 0x8086;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.Get: params returns one value, the number of coordinates per element in the texture coordinate array. The 
		/// initial value is 4. See Gl.TexCoordPointer.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.Get: params returns one value, the number of coordinates per element in the texture coordinate array. See 
		/// Gl.TexCoordPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_COORD_ARRAY_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_COORD_ARRAY_SIZE = 0x8088;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.Get: params returns one value, the data type of the coordinates in the texture coordinate array. The initial 
		/// value is Gl.FLOAT. See Gl.TexCoordPointer.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.Get: params returns one value, returns the data type of each coordinate in the texture coordinate array. 
		/// See Gl.TexCoordPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_COORD_ARRAY_TYPE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_COORD_ARRAY_TYPE = 0x8089;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.Get: params returns one value, the byte offset between consecutive elements in the texture coordinate array. 
		/// The initial value is 0. See Gl.TexCoordPointer.
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.Get: params returns one value, the byte offset between consecutive elements in the texture coordinate 
		/// array. See Gl.TexCoordPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_COORD_ARRAY_STRIDE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_COORD_ARRAY_STRIDE = 0x808A;

		/// <summary>
		/// [GL2.1] Gl.Get: params returns one value, the byte offset between consecutive edge flags in the edge flag array. The 
		/// initial value is 0. See Gl.EdgeFlagPointer.
		/// </summary>
		[AliasOf("GL_EDGE_FLAG_ARRAY_STRIDE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int EDGE_FLAG_ARRAY_STRIDE = 0x808C;

		/// <summary>
		/// [GL2.1] Gl.GetTexLevelParameter: 
		/// </summary>
		[AliasOf("GL_TEXTURE_LUMINANCE_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_LUMINANCE_SIZE = 0x8060;

		/// <summary>
		/// [GL2.1] Gl.GetTexLevelParameter: 
		/// </summary>
		[AliasOf("GL_TEXTURE_INTENSITY_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_INTENSITY_SIZE = 0x8061;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.GetTexParameter: Returns the residence priority of the target texture (or the named texture bound to it). The 
		/// initial value is 1. See Gl.PrioritizeTextures.
		/// </para>
		/// <para>
		/// [GL2.1] Gl.TexParameter: Specifies the texture residence priority of the currently bound texture. Permissible values are 
		/// in the range 01. See Gl.PrioritizeTextures and Gl.BindTexture for more information.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_PRIORITY_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture_object")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_PRIORITY = 0x8066;

		/// <summary>
		/// [GL2.1] Gl.GetTexParameter: Returns the residence status of the target texture. If the value returned in params is 
		/// Gl.TRUE, the texture is resident in texture memory. See Gl.AreTexturesResident.
		/// </summary>
		[AliasOf("GL_TEXTURE_RESIDENT_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture_object")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_RESIDENT = 0x8067;

		/// <summary>
		/// [GL] Value of GL_ALPHA4 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_ALPHA4_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ALPHA4 = 0x803B;

		/// <summary>
		/// [GL] Value of GL_ALPHA8 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_ALPHA8_EXT")]
		[AliasOf("GL_ALPHA8_OES")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ALPHA8 = 0x803C;

		/// <summary>
		/// [GL] Value of GL_ALPHA12 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_ALPHA12_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ALPHA12 = 0x803D;

		/// <summary>
		/// [GL] Value of GL_ALPHA16 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_ALPHA16_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ALPHA16 = 0x803E;

		/// <summary>
		/// [GL] Value of GL_LUMINANCE4 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LUMINANCE4_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LUMINANCE4 = 0x803F;

		/// <summary>
		/// [GL] Value of GL_LUMINANCE8 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LUMINANCE8_EXT")]
		[AliasOf("GL_LUMINANCE8_OES")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LUMINANCE8 = 0x8040;

		/// <summary>
		/// [GL] Value of GL_LUMINANCE12 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LUMINANCE12_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LUMINANCE12 = 0x8041;

		/// <summary>
		/// [GL] Value of GL_LUMINANCE16 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LUMINANCE16_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LUMINANCE16 = 0x8042;

		/// <summary>
		/// [GL] Value of GL_LUMINANCE4_ALPHA4 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LUMINANCE4_ALPHA4_EXT")]
		[AliasOf("GL_LUMINANCE4_ALPHA4_OES")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LUMINANCE4_ALPHA4 = 0x8043;

		/// <summary>
		/// [GL] Value of GL_LUMINANCE6_ALPHA2 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LUMINANCE6_ALPHA2_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LUMINANCE6_ALPHA2 = 0x8044;

		/// <summary>
		/// [GL] Value of GL_LUMINANCE8_ALPHA8 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LUMINANCE8_ALPHA8_EXT")]
		[AliasOf("GL_LUMINANCE8_ALPHA8_OES")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LUMINANCE8_ALPHA8 = 0x8045;

		/// <summary>
		/// [GL] Value of GL_LUMINANCE12_ALPHA4 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LUMINANCE12_ALPHA4_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LUMINANCE12_ALPHA4 = 0x8046;

		/// <summary>
		/// [GL] Value of GL_LUMINANCE12_ALPHA12 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LUMINANCE12_ALPHA12_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LUMINANCE12_ALPHA12 = 0x8047;

		/// <summary>
		/// [GL] Value of GL_LUMINANCE16_ALPHA16 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LUMINANCE16_ALPHA16_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LUMINANCE16_ALPHA16 = 0x8048;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.TexImage1D: Each element is a single intensity value. The GL converts it to floating point, then assembles it 
		/// into an RGBA element by replicating the intensity value three times for red, green, blue, and alpha. Each component is 
		/// then multiplied by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range 
		/// [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// [GL2.1] Gl.TexImage2D: Each element is a single intensity value. The GL converts it to floating point, then assembles it 
		/// into an RGBA element by replicating the intensity value three times for red, green, blue, and alpha. Each component is 
		/// then multiplied by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range 
		/// [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// [GL2.1] Gl.TexImage3D: Each element is a single intensity value. The GL converts it to floating point, then assembles it 
		/// into an RGBA element by replicating the intensity value three times for red, green, blue, and alpha. Each component is 
		/// then multiplied by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range 
		/// [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// </summary>
		[AliasOf("GL_INTENSITY_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int INTENSITY = 0x8049;

		/// <summary>
		/// [GL] Value of GL_INTENSITY4 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_INTENSITY4_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int INTENSITY4 = 0x804A;

		/// <summary>
		/// [GL] Value of GL_INTENSITY8 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_INTENSITY8_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int INTENSITY8 = 0x804B;

		/// <summary>
		/// [GL] Value of GL_INTENSITY12 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_INTENSITY12_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int INTENSITY12 = 0x804C;

		/// <summary>
		/// [GL] Value of GL_INTENSITY16 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_INTENSITY16_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int INTENSITY16 = 0x804D;

		/// <summary>
		/// [GL] Value of GL_V2F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int V2F = 0x2A20;

		/// <summary>
		/// [GL] Value of GL_V3F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int V3F = 0x2A21;

		/// <summary>
		/// [GL] Value of GL_C4UB_V2F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int C4UB_V2F = 0x2A22;

		/// <summary>
		/// [GL] Value of GL_C4UB_V3F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int C4UB_V3F = 0x2A23;

		/// <summary>
		/// [GL] Value of GL_C3F_V3F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int C3F_V3F = 0x2A24;

		/// <summary>
		/// [GL] Value of GL_N3F_V3F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int N3F_V3F = 0x2A25;

		/// <summary>
		/// [GL] Value of GL_C4F_N3F_V3F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int C4F_N3F_V3F = 0x2A26;

		/// <summary>
		/// [GL] Value of GL_T2F_V3F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int T2F_V3F = 0x2A27;

		/// <summary>
		/// [GL] Value of GL_T4F_V4F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int T4F_V4F = 0x2A28;

		/// <summary>
		/// [GL] Value of GL_T2F_C4UB_V3F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int T2F_C4UB_V3F = 0x2A29;

		/// <summary>
		/// [GL] Value of GL_T2F_C3F_V3F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int T2F_C3F_V3F = 0x2A2A;

		/// <summary>
		/// [GL] Value of GL_T2F_N3F_V3F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int T2F_N3F_V3F = 0x2A2B;

		/// <summary>
		/// [GL] Value of GL_T2F_C4F_N3F_V3F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int T2F_C4F_N3F_V3F = 0x2A2C;

		/// <summary>
		/// [GL] Value of GL_T4F_C4F_N3F_V4F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int T4F_C4F_N3F_V4F = 0x2A2D;

		/// <summary>
		/// render primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="first">
		/// Specifies the starting index in the enabled arrays.
		/// </param>
		/// <param name="count">
		/// Specifies the number of indices to be rendered.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		/// data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		[AliasOf("glDrawArraysEXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void DrawArrays(PrimitiveType mode, Int32 first, Int32 count)
		{
			Debug.Assert(Delegates.pglDrawArrays != null, "pglDrawArrays not implemented");
			Delegates.pglDrawArrays((Int32)mode, first, count);
			LogCommand("glDrawArrays", null, mode, first, count			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// render primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in <paramref name="indices"/>. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or 
		/// Gl.UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void DrawElements(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices)
		{
			Debug.Assert(Delegates.pglDrawElements != null, "pglDrawElements not implemented");
			Delegates.pglDrawElements((Int32)mode, count, (Int32)type, indices);
			LogCommand("glDrawElements", null, mode, count, type, indices			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// render primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in <paramref name="indices"/>. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or 
		/// Gl.UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void DrawElements(PrimitiveType mode, Int32 count, DrawElementsType type, Object indices)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElements(mode, count, type, pin_indices.AddrOfPinnedObject());
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// return the address of the specified pointer
		/// </summary>
		/// <param name="pname">
		/// Specifies the pointer to be returned. Must be one of Gl.DEBUG_CALLBACK_FUNCTION or Gl.DEBUG_CALLBACK_USER_PARAM.
		/// </param>
		/// <param name="params">
		/// Returns the pointer value specified by <paramref name="pname"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.DebugMessageCallback"/>
		[AliasOf("glGetPointervEXT")]
		[AliasOf("glGetPointervKHR")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_VERSION_4_3", Profile = "core")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RequiredByFeature("GL_KHR_debug")]
		[RequiredByFeature("GL_KHR_debug", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetPointer(GetPointervPName pname, out IntPtr @params)
		{
			unsafe {
				fixed (IntPtr* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetPointerv != null, "pglGetPointerv not implemented");
					Delegates.pglGetPointerv((Int32)pname, p_params);
					LogCommand("glGetPointerv", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the address of the specified pointer
		/// </summary>
		/// <param name="pname">
		/// Specifies the pointer to be returned. Must be one of Gl.DEBUG_CALLBACK_FUNCTION or Gl.DEBUG_CALLBACK_USER_PARAM.
		/// </param>
		/// <param name="params">
		/// Returns the pointer value specified by <paramref name="pname"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.DebugMessageCallback"/>
		[AliasOf("glGetPointervEXT")]
		[AliasOf("glGetPointervKHR")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_VERSION_4_3", Profile = "core")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RequiredByFeature("GL_KHR_debug")]
		[RequiredByFeature("GL_KHR_debug", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetPointer(GetPointervPName pname, Object @params)
		{
			GCHandle pin_params = GCHandle.Alloc(@params, GCHandleType.Pinned);
			try {
				GetPointer(pname, pin_params.AddrOfPinnedObject());
			} finally {
				pin_params.Free();
			}
		}

		/// <summary>
		/// set the scale and units used to calculate depth values
		/// </summary>
		/// <param name="factor">
		/// Specifies a scale factor that is used to create a variable depth offset for each polygon. The initial value is 0.
		/// </param>
		/// <param name="units">
		/// Is multiplied by an implementation-specific value to create a constant depth offset. The initial value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PolygonOffset is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void PolygonOffset(float factor, float units)
		{
			Debug.Assert(Delegates.pglPolygonOffset != null, "pglPolygonOffset not implemented");
			Delegates.pglPolygonOffset(factor, units);
			LogCommand("glPolygonOffset", null, factor, units			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// copy pixels into a 1D texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be Gl.TEXTURE_1D.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format of the texture. Must be one of the following symbolic constants: Gl.ALPHA, Gl.ALPHA4, 
		/// Gl.ALPHA8, Gl.ALPHA12, Gl.ALPHA16, Gl.COMPRESSED_ALPHA, Gl.COMPRESSED_LUMINANCE, Gl.COMPRESSED_LUMINANCE_ALPHA, 
		/// Gl.COMPRESSED_INTENSITY, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA, Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, 
		/// Gl.DEPTH_COMPONENT24, Gl.DEPTH_COMPONENT32, Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8, Gl.LUMINANCE12, Gl.LUMINANCE16, 
		/// Gl.LUMINANCE_ALPHA, Gl.LUMINANCE4_ALPHA4, Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8, Gl.LUMINANCE12_ALPHA4, 
		/// Gl.LUMINANCE12_ALPHA12, Gl.LUMINANCE16_ALPHA16, Gl.INTENSITY, Gl.INTENSITY4, Gl.INTENSITY8, Gl.INTENSITY12, 
		/// Gl.INTENSITY16, Gl.RGB, Gl.R3_G3_B2, Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, 
		/// Gl.RGBA4, Gl.RGB5_A1, Gl.RGBA8, Gl.RGB10_A2, Gl.RGBA12, Gl.RGBA16, Gl.SLUMINANCE, Gl.SLUMINANCE8, Gl.SLUMINANCE_ALPHA, 
		/// Gl.SLUMINANCE8_ALPHA8, Gl.SRGB, Gl.SRGB8, Gl.SRGB_ALPHA, or Gl.SRGB8_ALPHA8.
		/// </param>
		/// <param name="x">
		/// Specify the window coordinates of the left corner of the row of pixels to be copied.
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the left corner of the row of pixels to be copied.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image. Must be 0 or 2n+2⁡border for some integer n. The height of the texture image 
		/// is 1.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2⁢max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="internalformat"/> is not an allowable value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than 0 or greater than 2 + Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if non-power-of-two textures are not supported and the <paramref name="width"/> cannot be 
		/// represented as 2n+2⁡border for some integer value of n.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="border"/> is not 0 or 1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.CopyTexImage1D is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalformat"/> is Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, 
		/// Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32 and there is no depth buffer.
		/// </exception>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glCopyTexImage1DEXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_copy_texture")]
		public static void CopyTexImage1D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border)
		{
			Debug.Assert(Delegates.pglCopyTexImage1D != null, "pglCopyTexImage1D not implemented");
			Delegates.pglCopyTexImage1D((Int32)target, level, (Int32)internalformat, x, y, width, border);
			LogCommand("glCopyTexImage1D", null, target, level, internalformat, x, y, width, border			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// copy pixels into a 2D texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be Gl.TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, or 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format of the texture. Must be one of the following symbolic constants: Gl.ALPHA, Gl.ALPHA4, 
		/// Gl.ALPHA8, Gl.ALPHA12, Gl.ALPHA16, Gl.COMPRESSED_ALPHA, Gl.COMPRESSED_LUMINANCE, Gl.COMPRESSED_LUMINANCE_ALPHA, 
		/// Gl.COMPRESSED_INTENSITY, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA, Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, 
		/// Gl.DEPTH_COMPONENT24, Gl.DEPTH_COMPONENT32, Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8, Gl.LUMINANCE12, Gl.LUMINANCE16, 
		/// Gl.LUMINANCE_ALPHA, Gl.LUMINANCE4_ALPHA4, Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8, Gl.LUMINANCE12_ALPHA4, 
		/// Gl.LUMINANCE12_ALPHA12, Gl.LUMINANCE16_ALPHA16, Gl.INTENSITY, Gl.INTENSITY4, Gl.INTENSITY8, Gl.INTENSITY12, 
		/// Gl.INTENSITY16, Gl.RGB, Gl.R3_G3_B2, Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, 
		/// Gl.RGBA4, Gl.RGB5_A1, Gl.RGBA8, Gl.RGB10_A2, Gl.RGBA12, Gl.RGBA16, Gl.SLUMINANCE, Gl.SLUMINANCE8, Gl.SLUMINANCE_ALPHA, 
		/// Gl.SLUMINANCE8_ALPHA8, Gl.SRGB, Gl.SRGB8, Gl.SRGB_ALPHA, or Gl.SRGB8_ALPHA8.
		/// </param>
		/// <param name="x">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image. Must be 0 or 2n+2⁡border for some integer n.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image. Must be 0 or 2m+2⁡border for some integer m.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, or Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2⁢max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than 0 or greater than 2 + Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if non-power-of-two textures are not supported and the <paramref name="width"/> or 
		/// <paramref name="depth"/> cannot be represented as 2k+2⁡border for some integer k.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="border"/> is not 0 or 1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="internalformat"/> is not an accepted format.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.CopyTexImage2D is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalformat"/> is Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, 
		/// Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32 and there is no depth buffer.
		/// </exception>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glCopyTexImage2DEXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_copy_texture")]
		public static void CopyTexImage2D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
		{
			Debug.Assert(Delegates.pglCopyTexImage2D != null, "pglCopyTexImage2D not implemented");
			Delegates.pglCopyTexImage2D((Int32)target, level, (Int32)internalformat, x, y, width, height, border);
			LogCommand("glCopyTexImage2D", null, target, level, internalformat, x, y, width, height, border			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// copy a one-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be Gl.TEXTURE_1D.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies the texel offset within the texture array.
		/// </param>
		/// <param name="x">
		/// Specify the window coordinates of the left corner of the row of pixels to be copied.
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the left corner of the row of pixels to be copied.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if /<paramref name="target"/> is not Gl.TEXTURE_1D.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous Gl\.TexImage1D or 
		/// Gl\.CopyTexImage1D operation.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if level&gt;log2⁡max, where max is the returned value of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;-b, or xoffset+width&gt;w-b, where w is the Gl.TEXTURE_WIDTH and b is the 
		/// Gl.TEXTURE_BORDER of the texture image being modified. Note that w includes twice the border width.
		/// </exception>
		/// <exception cref="KhronosException">
		/// </exception>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[AliasOf("glCopyTexSubImage1DEXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_copy_texture")]
		public static void CopyTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width)
		{
			Debug.Assert(Delegates.pglCopyTexSubImage1D != null, "pglCopyTexSubImage1D not implemented");
			Delegates.pglCopyTexSubImage1D((Int32)target, level, xoffset, x, y, width);
			LogCommand("glCopyTexSubImage1D", null, target, level, xoffset, x, y, width			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// copy a two-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be Gl.TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, or 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="x">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, or Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous Gl\.TexImage2D or 
		/// Gl\.CopyTexImage2D operation.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if level&gt;log2⁡max, where max is the returned value of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, where w 
		/// is the Gl.TEXTURE_WIDTH, h is the Gl.TEXTURE_HEIGHT, and b is the Gl.TEXTURE_BORDER of the texture image being modified. 
		/// Note that w and h include twice the border width.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.CopyTexSubImage2D is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[AliasOf("glCopyTexSubImage2DEXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_copy_texture")]
		public static void CopyTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglCopyTexSubImage2D != null, "pglCopyTexSubImage2D not implemented");
			Delegates.pglCopyTexSubImage2D((Int32)target, level, xoffset, yoffset, x, y, width, height);
			LogCommand("glCopyTexSubImage2D", null, target, level, xoffset, yoffset, x, y, width, height			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a one-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.TexSubImage1D. Must be Gl.TEXTURE_1D.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR, 
		/// Gl.RGBA, Gl.DEPTH_COMPONENT, and Gl.STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureSubImage1D if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;-b, or if xoffset+width&gt;w-b, where w is the Gl.TEXTURE_WIDTH, and b is 
		/// the width of the Gl.TEXTURE_BORDER of the texture image being modified. Note that w includes twice the border width.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage1D operation.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and the base internal format is not 
		/// Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="pixels"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated 
		/// by <paramref name="type"/>.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[AliasOf("glTexSubImage1DEXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_subtexture")]
		public static void TexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexSubImage1D != null, "pglTexSubImage1D not implemented");
			Delegates.pglTexSubImage1D((Int32)target, level, xoffset, width, (Int32)format, (Int32)type, pixels);
			LogCommand("glTexSubImage1D", null, target, level, xoffset, width, format, type, pixels			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a one-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.TexSubImage1D. Must be Gl.TEXTURE_1D.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR, 
		/// Gl.RGBA, Gl.DEPTH_COMPONENT, and Gl.STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureSubImage1D if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;-b, or if xoffset+width&gt;w-b, where w is the Gl.TEXTURE_WIDTH, and b is 
		/// the width of the Gl.TEXTURE_BORDER of the texture image being modified. Note that w includes twice the border width.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage1D operation.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and the base internal format is not 
		/// Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="pixels"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated 
		/// by <paramref name="type"/>.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[AliasOf("glTexSubImage1DEXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_subtexture")]
		public static void TexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexSubImage1D(target, level, xoffset, width, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// specify a two-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.TexSubImage2D. Must be Gl.TEXTURE_2D, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.TEXTURE_1D_ARRAY.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR, 
		/// Gl.RGBA, Gl.BGRA, Gl.DEPTH_COMPONENT, and Gl.STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// Gl.TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.TEXTURE_1D_ARRAY.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureSubImage2D if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, where w 
		/// is the Gl.TEXTURE_WIDTH, h is the Gl.TEXTURE_HEIGHT, and b is the border width of the texture image being modified. Note 
		/// that w and h include twice the border width.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage2D operation.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and the base internal format is not 
		/// Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="pixels"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated 
		/// by <paramref name="type"/>.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glTexSubImage2DEXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_subtexture")]
		public static void TexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexSubImage2D != null, "pglTexSubImage2D not implemented");
			Delegates.pglTexSubImage2D((Int32)target, level, xoffset, yoffset, width, height, (Int32)format, (Int32)type, pixels);
			LogCommand("glTexSubImage2D", null, target, level, xoffset, yoffset, width, height, format, type, pixels			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a two-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.TexSubImage2D. Must be Gl.TEXTURE_2D, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.TEXTURE_1D_ARRAY.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR, 
		/// Gl.RGBA, Gl.BGRA, Gl.DEPTH_COMPONENT, and Gl.STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// Gl.TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.TEXTURE_1D_ARRAY.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureSubImage2D if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, where w 
		/// is the Gl.TEXTURE_WIDTH, h is the Gl.TEXTURE_HEIGHT, and b is the border width of the texture image being modified. Note 
		/// that w and h include twice the border width.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage2D operation.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and the base internal format is not 
		/// Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="pixels"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated 
		/// by <paramref name="type"/>.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glTexSubImage2DEXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_subtexture")]
		public static void TexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// bind a named texture to a texturing target
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound. Must be one of Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, 
		/// Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_RECTANGLE, Gl.TEXTURE_CUBE_MAP, Gl.TEXTURE_CUBE_MAP_ARRAY, 
		/// Gl.TEXTURE_BUFFER, Gl.TEXTURE_2D_MULTISAMPLE or Gl.TEXTURE_2D_MULTISAMPLE_ARRAY.
		/// </param>
		/// <param name="texture">
		/// Specifies the name of a texture.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="texture"/> is not a name returned from a previous call to 
		/// glGenTextures.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="texture"/> was previously created with a target that doesn't match 
		/// that of <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.DeleteTextures"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.IsTexture"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage2DMultisample"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexImage3DMultisample"/>
		/// <seealso cref="Gl.TexBuffer"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glBindTextureEXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_object")]
		public static void BindTexture(TextureTarget target, UInt32 texture)
		{
			Debug.Assert(Delegates.pglBindTexture != null, "pglBindTexture not implemented");
			Delegates.pglBindTexture((Int32)target, texture);
			LogCommand("glBindTexture", null, target, texture			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// delete named textures
		/// </summary>
		/// <param name="textures">
		/// Specifies an array of textures to be deleted.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void DeleteTextures(params UInt32[] textures)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				{
					Debug.Assert(Delegates.pglDeleteTextures != null, "pglDeleteTextures not implemented");
					Delegates.pglDeleteTextures((Int32)textures.Length, p_textures);
					LogCommand("glDeleteTextures", null, textures.Length, textures					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// generate texture names
		/// </summary>
		/// <param name="textures">
		/// Specifies an array in which the generated texture names are stored.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void GenTextures(UInt32[] textures)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				{
					Debug.Assert(Delegates.pglGenTextures != null, "pglGenTextures not implemented");
					Delegates.pglGenTextures((Int32)textures.Length, p_textures);
					LogCommand("glGenTextures", null, textures.Length, textures					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// generate texture names
		/// </summary>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static UInt32 GenTexture()
		{
			UInt32[] retValue = new UInt32[1];
			GenTextures(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// determine if a name corresponds to a texture
		/// </summary>
		/// <param name="texture">
		/// Specifies a value that may be the name of a texture.
		/// </param>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static bool IsTexture(UInt32 texture)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsTexture != null, "pglIsTexture not implemented");
			retValue = Delegates.pglIsTexture(texture);
			LogCommand("glIsTexture", retValue, texture			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// render a vertex using the specified vertex array element
		/// </summary>
		/// <param name="i">
		/// Specifies an index into the enabled vertex data arrays.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="i"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		/// data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.GetPointerv"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[AliasOf("glArrayElementEXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ArrayElement(Int32 i)
		{
			Debug.Assert(Delegates.pglArrayElement != null, "pglArrayElement not implemented");
			Delegates.pglArrayElement(i);
			LogCommand("glArrayElement", null, i			);
		}

		/// <summary>
		/// define an array of colors
		/// </summary>
		/// <param name="size">
		/// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each color component in the array. Symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, Gl.UNSIGNED_INT, Gl.FLOAT, and Gl.DOUBLE are accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive colors. If <paramref name="stride"/> is 0, the colors are understood to be 
		/// tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 3 or 4.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ColorPointer(Int32 size, ColorPointerType type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglColorPointer != null, "pglColorPointer not implemented");
			Delegates.pglColorPointer(size, (Int32)type, stride, pointer);
			LogCommand("glColorPointer", null, size, type, stride, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of colors
		/// </summary>
		/// <param name="size">
		/// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each color component in the array. Symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, Gl.UNSIGNED_INT, Gl.FLOAT, and Gl.DOUBLE are accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive colors. If <paramref name="stride"/> is 0, the colors are understood to be 
		/// tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 3 or 4.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ColorPointer(Int32 size, ColorPointerType type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				ColorPointer(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// enable or disable client-side capability
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:EnableCap"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="cap"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.EnableClientState is not allowed between the execution of Gl\.Begin and the corresponding Gl\.End, but an error may 
		/// or may not be generated. If no error is generated, the behavior is undefined.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.GetPointerv"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void DisableClientState(EnableCap array)
		{
			Debug.Assert(Delegates.pglDisableClientState != null, "pglDisableClientState not implemented");
			Delegates.pglDisableClientState((Int32)array);
			LogCommand("glDisableClientState", null, array			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of edge flags
		/// </summary>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive edge flags. If <paramref name="stride"/> is 0, the edge flags are 
		/// understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first edge flag in the array. The initial value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EdgeFlagPointer(Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglEdgeFlagPointer != null, "pglEdgeFlagPointer not implemented");
			Delegates.pglEdgeFlagPointer(stride, pointer);
			LogCommand("glEdgeFlagPointer", null, stride, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of edge flags
		/// </summary>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive edge flags. If <paramref name="stride"/> is 0, the edge flags are 
		/// understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first edge flag in the array. The initial value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EdgeFlagPointer(Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				EdgeFlagPointer(stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// enable or disable client-side capability
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:EnableCap"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="cap"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.EnableClientState is not allowed between the execution of Gl\.Begin and the corresponding Gl\.End, but an error may 
		/// or may not be generated. If no error is generated, the behavior is undefined.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.GetPointerv"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EnableClientState(EnableCap array)
		{
			Debug.Assert(Delegates.pglEnableClientState != null, "pglEnableClientState not implemented");
			Delegates.pglEnableClientState((Int32)array);
			LogCommand("glEnableClientState", null, array			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of color indexes
		/// </summary>
		/// <param name="type">
		/// Specifies the data type of each color index in the array. Symbolic constants Gl.UNSIGNED_BYTE, Gl.SHORT, Gl.INT, 
		/// Gl.FLOAT, and Gl.DOUBLE are accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive color indexes. If <paramref name="stride"/> is 0, the color indexes are 
		/// understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first index in the array. The initial value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void IndexPointer(IndexPointerType type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglIndexPointer != null, "pglIndexPointer not implemented");
			Delegates.pglIndexPointer((Int32)type, stride, pointer);
			LogCommand("glIndexPointer", null, type, stride, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of color indexes
		/// </summary>
		/// <param name="type">
		/// Specifies the data type of each color index in the array. Symbolic constants Gl.UNSIGNED_BYTE, Gl.SHORT, Gl.INT, 
		/// Gl.FLOAT, and Gl.DOUBLE are accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive color indexes. If <paramref name="stride"/> is 0, the color indexes are 
		/// understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first index in the array. The initial value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void IndexPointer(IndexPointerType type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				IndexPointer(type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// simultaneously specify and enable several interleaved arrays
		/// </summary>
		/// <param name="format">
		/// Specifies the type of array to enable. Symbolic constants Gl.V2F, Gl.V3F, Gl.C4UB_V2F, Gl.C4UB_V3F, Gl.C3F_V3F, 
		/// Gl.N3F_V3F, Gl.C4F_N3F_V3F, Gl.T2F_V3F, Gl.T4F_V4F, Gl.T2F_C4UB_V3F, Gl.T2F_C3F_V3F, Gl.T2F_N3F_V3F, Gl.T2F_C4F_N3F_V3F, 
		/// and Gl.T4F_C4F_N3F_V4F are accepted.
		/// </param>
		/// <param name="stride">
		/// Specifies the offset in bytes between each aggregate array element.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.GetPointerv"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void InterleavedArrays(InterleavedArrayFormat format, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglInterleavedArrays != null, "pglInterleavedArrays not implemented");
			Delegates.pglInterleavedArrays((Int32)format, stride, pointer);
			LogCommand("glInterleavedArrays", null, format, stride, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// simultaneously specify and enable several interleaved arrays
		/// </summary>
		/// <param name="format">
		/// Specifies the type of array to enable. Symbolic constants Gl.V2F, Gl.V3F, Gl.C4UB_V2F, Gl.C4UB_V3F, Gl.C3F_V3F, 
		/// Gl.N3F_V3F, Gl.C4F_N3F_V3F, Gl.T2F_V3F, Gl.T4F_V4F, Gl.T2F_C4UB_V3F, Gl.T2F_C3F_V3F, Gl.T2F_N3F_V3F, Gl.T2F_C4F_N3F_V3F, 
		/// and Gl.T4F_C4F_N3F_V4F are accepted.
		/// </param>
		/// <param name="stride">
		/// Specifies the offset in bytes between each aggregate array element.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.GetPointerv"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void InterleavedArrays(InterleavedArrayFormat format, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				InterleavedArrays(format, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// define an array of normals
		/// </summary>
		/// <param name="type">
		/// Specifies the data type of each coordinate in the array. Symbolic constants Gl.BYTE, Gl.SHORT, Gl.INT, Gl.FLOAT, and 
		/// Gl.DOUBLE are accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive normals. If <paramref name="stride"/> is 0, the normals are understood to 
		/// be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void NormalPointer(NormalPointerType type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglNormalPointer != null, "pglNormalPointer not implemented");
			Delegates.pglNormalPointer((Int32)type, stride, pointer);
			LogCommand("glNormalPointer", null, type, stride, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of normals
		/// </summary>
		/// <param name="type">
		/// Specifies the data type of each coordinate in the array. Symbolic constants Gl.BYTE, Gl.SHORT, Gl.INT, Gl.FLOAT, and 
		/// Gl.DOUBLE are accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive normals. If <paramref name="stride"/> is 0, the normals are understood to 
		/// be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void NormalPointer(NormalPointerType type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				NormalPointer(type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// define an array of texture coordinates
		/// </summary>
		/// <param name="size">
		/// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each texture coordinate. Symbolic constants Gl.SHORT, Gl.INT, Gl.FLOAT, or Gl.DOUBLE are 
		/// accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive texture coordinate sets. If <paramref name="stride"/> is 0, the array 
		/// elements are understood to be tightly packed. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 1, 2, 3, or 4.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoordPointer(Int32 size, TexCoordPointerType type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglTexCoordPointer != null, "pglTexCoordPointer not implemented");
			Delegates.pglTexCoordPointer(size, (Int32)type, stride, pointer);
			LogCommand("glTexCoordPointer", null, size, type, stride, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of texture coordinates
		/// </summary>
		/// <param name="size">
		/// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each texture coordinate. Symbolic constants Gl.SHORT, Gl.INT, Gl.FLOAT, or Gl.DOUBLE are 
		/// accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive texture coordinate sets. If <paramref name="stride"/> is 0, the array 
		/// elements are understood to be tightly packed. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 1, 2, 3, or 4.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoordPointer(Int32 size, TexCoordPointerType type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				TexCoordPointer(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// define an array of vertex data
		/// </summary>
		/// <param name="size">
		/// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each coordinate in the array. Symbolic constants Gl.SHORT, Gl.INT, Gl.FLOAT, or Gl.DOUBLE are 
		/// accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive vertices. If <paramref name="stride"/> is 0, the vertices are understood 
		/// to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 2, 3, or 4.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void VertexPointer(Int32 size, VertexPointerType type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexPointer != null, "pglVertexPointer not implemented");
			Delegates.pglVertexPointer(size, (Int32)type, stride, pointer);
			LogCommand("glVertexPointer", null, size, type, stride, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of vertex data
		/// </summary>
		/// <param name="size">
		/// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each coordinate in the array. Symbolic constants Gl.SHORT, Gl.INT, Gl.FLOAT, or Gl.DOUBLE are 
		/// accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive vertices. If <paramref name="stride"/> is 0, the vertices are understood 
		/// to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 2, 3, or 4.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void VertexPointer(Int32 size, VertexPointerType type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				VertexPointer(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// determine if textures are loaded in texture memory
		/// </summary>
		/// <param name="textures">
		/// Specifies an array containing the names of the textures to be queried.
		/// </param>
		/// <param name="residences">
		/// Specifies an array in which the texture residence status is returned. The residence status of a texture named by an 
		/// element of <paramref name="textures"/> is returned in the corresponding element of <paramref name="residences"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if any element in <paramref name="textures"/> is 0 or does not name a texture. In that 
		/// case, the function returns Gl.FALSE and the contents of <paramref name="residences"/> is indeterminate.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.AreTexturesResident is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.PrioritizeTextures"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static bool AreTexturesResident(UInt32[] textures, [Out] bool[] residences)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_textures = textures)
				fixed (bool* p_residences = residences)
				{
					Debug.Assert(Delegates.pglAreTexturesResident != null, "pglAreTexturesResident not implemented");
					retValue = Delegates.pglAreTexturesResident((Int32)textures.Length, p_textures, p_residences);
					LogCommand("glAreTexturesResident", retValue, textures.Length, textures, residences					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// set texture residence priority
		/// </summary>
		/// <param name="textures">
		/// Specifies an array containing the names of the textures to be prioritized.
		/// </param>
		/// <param name="priorities">
		/// Specifies an array containing the texture priorities. A priority given in an element of <paramref name="priorities"/> 
		/// applies to the texture named by the corresponding element of <paramref name="textures"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PrioritizeTextures is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.AreTexturesResident"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glPrioritizeTexturesEXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture_object")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PrioritizeTextures(UInt32[] textures, params float[] priorities)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				fixed (float* p_priorities = priorities)
				{
					Debug.Assert(Delegates.pglPrioritizeTextures != null, "pglPrioritizeTextures not implemented");
					Delegates.pglPrioritizeTextures((Int32)textures.Length, p_textures, p_priorities);
					LogCommand("glPrioritizeTextures", null, textures.Length, textures, priorities					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.IndexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(byte c)
		{
			Debug.Assert(Delegates.pglIndexub != null, "pglIndexub not implemented");
			Delegates.pglIndexub(c);
			LogCommand("glIndexub", null, c			);
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.IndexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(byte[] c)
		{
			unsafe {
				fixed (byte* p_c = c)
				{
					Debug.Assert(Delegates.pglIndexubv != null, "pglIndexubv not implemented");
					Delegates.pglIndexubv(p_c);
					LogCommand("glIndexubv", null, c					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// push and pop the client attribute stack
		/// </summary>
		/// <exception cref="KhronosException">
		/// Gl.STACK_OVERFLOW is generated if Gl.PushClientAttrib is called while the attribute stack is full.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.STACK_UNDERFLOW is generated if Gl\.PopClientAttrib is called while the attribute stack is empty.
		/// </exception>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.NewList"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PushAttrib"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PopClientAttrib()
		{
			Debug.Assert(Delegates.pglPopClientAttrib != null, "pglPopClientAttrib not implemented");
			Delegates.pglPopClientAttrib();
			LogCommand("glPopClientAttrib", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// push and pop the client attribute stack
		/// </summary>
		/// <param name="mask">
		/// Specifies a mask that indicates which attributes to save. Values for <paramref name="mask"/> are listed below.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.STACK_OVERFLOW is generated if Gl.PushClientAttrib is called while the attribute stack is full.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.STACK_UNDERFLOW is generated if Gl\.PopClientAttrib is called while the attribute stack is empty.
		/// </exception>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.NewList"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PushAttrib"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PushClientAttrib(ClientAttribMask mask)
		{
			Debug.Assert(Delegates.pglPushClientAttrib != null, "pglPushClientAttrib not implemented");
			Delegates.pglPushClientAttrib((UInt32)mask);
			LogCommand("glPushClientAttrib", null, mask			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawArrays", ExactSpelling = true)]
			internal extern static void glDrawArrays(Int32 mode, Int32 first, Int32 count);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawElements", ExactSpelling = true)]
			internal extern static unsafe void glDrawElements(Int32 mode, Int32 count, Int32 type, IntPtr indices);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetPointerv", ExactSpelling = true)]
			internal extern static unsafe void glGetPointerv(Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPolygonOffset", ExactSpelling = true)]
			internal extern static void glPolygonOffset(float factor, float units);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCopyTexImage1D", ExactSpelling = true)]
			internal extern static void glCopyTexImage1D(Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 border);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCopyTexImage2D", ExactSpelling = true)]
			internal extern static void glCopyTexImage2D(Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCopyTexSubImage1D", ExactSpelling = true)]
			internal extern static void glCopyTexSubImage1D(Int32 target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCopyTexSubImage2D", ExactSpelling = true)]
			internal extern static void glCopyTexSubImage2D(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexSubImage1D", ExactSpelling = true)]
			internal extern static unsafe void glTexSubImage1D(Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexSubImage2D", ExactSpelling = true)]
			internal extern static unsafe void glTexSubImage2D(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBindTexture", ExactSpelling = true)]
			internal extern static void glBindTexture(Int32 target, UInt32 texture);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDeleteTextures", ExactSpelling = true)]
			internal extern static unsafe void glDeleteTextures(Int32 n, UInt32* textures);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGenTextures", ExactSpelling = true)]
			internal extern static unsafe void glGenTextures(Int32 n, UInt32* textures);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsTexture", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsTexture(UInt32 texture);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glArrayElement", ExactSpelling = true)]
			internal extern static void glArrayElement(Int32 i);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColorPointer", ExactSpelling = true)]
			internal extern static unsafe void glColorPointer(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDisableClientState", ExactSpelling = true)]
			internal extern static void glDisableClientState(Int32 array);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEdgeFlagPointer", ExactSpelling = true)]
			internal extern static unsafe void glEdgeFlagPointer(Int32 stride, IntPtr pointer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEnableClientState", ExactSpelling = true)]
			internal extern static void glEnableClientState(Int32 array);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexPointer", ExactSpelling = true)]
			internal extern static unsafe void glIndexPointer(Int32 type, Int32 stride, IntPtr pointer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glInterleavedArrays", ExactSpelling = true)]
			internal extern static unsafe void glInterleavedArrays(Int32 format, Int32 stride, IntPtr pointer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormalPointer", ExactSpelling = true)]
			internal extern static unsafe void glNormalPointer(Int32 type, Int32 stride, IntPtr pointer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoordPointer", ExactSpelling = true)]
			internal extern static unsafe void glTexCoordPointer(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexPointer", ExactSpelling = true)]
			internal extern static unsafe void glVertexPointer(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glAreTexturesResident", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static unsafe bool glAreTexturesResident(Int32 n, UInt32* textures, bool* residences);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPrioritizeTextures", ExactSpelling = true)]
			internal extern static unsafe void glPrioritizeTextures(Int32 n, UInt32* textures, float* priorities);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexub", ExactSpelling = true)]
			internal extern static void glIndexub(byte c);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexubv", ExactSpelling = true)]
			internal extern static unsafe void glIndexubv(byte* c);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPopClientAttrib", ExactSpelling = true)]
			internal extern static void glPopClientAttrib();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPushClientAttrib", ExactSpelling = true)]
			internal extern static void glPushClientAttrib(UInt32 mask);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_EXT_vertex_array")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawArrays(Int32 mode, Int32 first, Int32 count);

			[AliasOf("glDrawArrays")]
			[AliasOf("glDrawArraysEXT")]
			[ThreadStatic]
			internal static glDrawArrays pglDrawArrays;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawElements(Int32 mode, Int32 count, Int32 type, IntPtr indices);

			[ThreadStatic]
			internal static glDrawElements pglDrawElements;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_VERSION_4_3", Profile = "core")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_EXT_vertex_array")]
			[RequiredByFeature("GL_KHR_debug")]
			[RequiredByFeature("GL_KHR_debug", Api = "gles2")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPointerv(Int32 pname, IntPtr* @params);

			[AliasOf("glGetPointerv")]
			[AliasOf("glGetPointervEXT")]
			[AliasOf("glGetPointervKHR")]
			[ThreadStatic]
			internal static glGetPointerv pglGetPointerv;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPolygonOffset(float factor, float units);

			[ThreadStatic]
			internal static glPolygonOffset pglPolygonOffset;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_EXT_copy_texture")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTexImage1D(Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 border);

			[AliasOf("glCopyTexImage1D")]
			[AliasOf("glCopyTexImage1DEXT")]
			[ThreadStatic]
			internal static glCopyTexImage1D pglCopyTexImage1D;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_EXT_copy_texture")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTexImage2D(Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

			[AliasOf("glCopyTexImage2D")]
			[AliasOf("glCopyTexImage2DEXT")]
			[ThreadStatic]
			internal static glCopyTexImage2D pglCopyTexImage2D;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_EXT_copy_texture")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTexSubImage1D(Int32 target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

			[AliasOf("glCopyTexSubImage1D")]
			[AliasOf("glCopyTexSubImage1DEXT")]
			[ThreadStatic]
			internal static glCopyTexSubImage1D pglCopyTexSubImage1D;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_EXT_copy_texture")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTexSubImage2D(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[AliasOf("glCopyTexSubImage2D")]
			[AliasOf("glCopyTexSubImage2DEXT")]
			[ThreadStatic]
			internal static glCopyTexSubImage2D pglCopyTexSubImage2D;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_EXT_subtexture")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexSubImage1D(Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 type, IntPtr pixels);

			[AliasOf("glTexSubImage1D")]
			[AliasOf("glTexSubImage1DEXT")]
			[ThreadStatic]
			internal static glTexSubImage1D pglTexSubImage1D;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_EXT_subtexture")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexSubImage2D(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[AliasOf("glTexSubImage2D")]
			[AliasOf("glTexSubImage2DEXT")]
			[ThreadStatic]
			internal static glTexSubImage2D pglTexSubImage2D;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_EXT_texture_object")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindTexture(Int32 target, UInt32 texture);

			[AliasOf("glBindTexture")]
			[AliasOf("glBindTextureEXT")]
			[ThreadStatic]
			internal static glBindTexture pglBindTexture;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteTextures(Int32 n, UInt32* textures);

			[ThreadStatic]
			internal static glDeleteTextures pglDeleteTextures;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenTextures(Int32 n, UInt32* textures);

			[ThreadStatic]
			internal static glGenTextures pglGenTextures;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsTexture(UInt32 texture);

			[ThreadStatic]
			internal static glIsTexture pglIsTexture;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_EXT_vertex_array")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glArrayElement(Int32 i);

			[AliasOf("glArrayElement")]
			[AliasOf("glArrayElementEXT")]
			[ThreadStatic]
			internal static glArrayElement pglArrayElement;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColorPointer(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glColorPointer pglColorPointer;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisableClientState(Int32 array);

			[ThreadStatic]
			internal static glDisableClientState pglDisableClientState;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEdgeFlagPointer(Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glEdgeFlagPointer pglEdgeFlagPointer;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnableClientState(Int32 array);

			[ThreadStatic]
			internal static glEnableClientState pglEnableClientState;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexPointer(Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glIndexPointer pglIndexPointer;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glInterleavedArrays(Int32 format, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glInterleavedArrays pglInterleavedArrays;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormalPointer(Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glNormalPointer pglNormalPointer;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoordPointer(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glTexCoordPointer pglTexCoordPointer;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexPointer(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glVertexPointer pglVertexPointer;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glAreTexturesResident(Int32 n, UInt32* textures, bool* residences);

			[ThreadStatic]
			internal static glAreTexturesResident pglAreTexturesResident;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RequiredByFeature("GL_EXT_texture_object")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPrioritizeTextures(Int32 n, UInt32* textures, float* priorities);

			[AliasOf("glPrioritizeTextures")]
			[AliasOf("glPrioritizeTexturesEXT")]
			[ThreadStatic]
			internal static glPrioritizeTextures pglPrioritizeTextures;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexub(byte c);

			[ThreadStatic]
			internal static glIndexub pglIndexub;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexubv(byte* c);

			[ThreadStatic]
			internal static glIndexubv pglIndexubv;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPopClientAttrib();

			[ThreadStatic]
			internal static glPopClientAttrib pglPopClientAttrib;

			[RequiredByFeature("GL_VERSION_1_1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPushClientAttrib(UInt32 mask);

			[ThreadStatic]
			internal static glPushClientAttrib pglPushClientAttrib;

		}
	}

}
