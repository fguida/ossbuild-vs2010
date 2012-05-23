// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class VideoUtil {

		[DllImport("libgstvideo-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_get_size(IntPtr pad, out int width, out int height);

		public static bool GetSize(Gst.Pad pad, out int width, out int height) {
			bool raw_ret = gst_video_get_size(pad == null ? IntPtr.Zero : pad.Handle, out width, out height);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstvideo-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_format_is_yuv(int format);

		public static bool FormatIsYuv(Gst.Video.VideoFormat format) {
			bool raw_ret = gst_video_format_is_yuv((int) format);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstvideo-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_video_format_from_fourcc(uint fourcc);

		public static Gst.Video.VideoFormat FormatFromFourcc(uint fourcc) {
			int raw_ret = gst_video_format_from_fourcc(fourcc);
			Gst.Video.VideoFormat ret = (Gst.Video.VideoFormat) raw_ret;
			return ret;
		}

		[DllImport("libgstvideo-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_video_format_get_component_width(int format, int component, int width);

		public static int FormatGetComponentWidth(Gst.Video.VideoFormat format, int component, int width) {
			int raw_ret = gst_video_format_get_component_width((int) format, component, width);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgstvideo-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_parse_caps_framerate(IntPtr caps, out int fps_n, out int fps_d);

		public static bool ParseCapsFramerate(Gst.Caps caps, out int fps_n, out int fps_d) {
			bool raw_ret = gst_video_parse_caps_framerate(caps == null ? IntPtr.Zero : caps.Handle, out fps_n, out fps_d);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstvideo-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_video_format_get_size(int format, int width, int height);

		public static int FormatGetSize(Gst.Video.VideoFormat format, int width, int height) {
			int raw_ret = gst_video_format_get_size((int) format, width, height);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgstvideo-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_format_new_caps_interlaced(int format, int width, int height, int framerate_n, int framerate_d, int par_n, int par_d, bool interlaced);

		public static Gst.Caps FormatNewCaps(Gst.Video.VideoFormat format, int width, int height, int framerate_n, int framerate_d, int par_n, int par_d, bool interlaced) {
			IntPtr raw_ret = gst_video_format_new_caps_interlaced((int) format, width, height, framerate_n, framerate_d, par_n, par_d, interlaced);
			Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) Gst.GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), false);
			return ret;
		}

		[DllImport("libgstvideo-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_video_format_get_row_stride(int format, int component, int width);

		public static int FormatGetRowStride(Gst.Video.VideoFormat format, int component, int width) {
			int raw_ret = gst_video_format_get_row_stride((int) format, component, width);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgstvideo-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_calculate_display_ratio(out uint dar_n, out uint dar_d, uint video_width, uint video_height, uint video_par_n, uint video_par_d, uint display_par_n, uint display_par_d);

		public static bool CalculateDisplayRatio(out uint dar_n, out uint dar_d, uint video_width, uint video_height, uint video_par_n, uint video_par_d, uint display_par_n, uint display_par_d) {
			bool raw_ret = gst_video_calculate_display_ratio(out dar_n, out dar_d, video_width, video_height, video_par_n, video_par_d, display_par_n, display_par_d);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstvideo-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_format_parse_caps(IntPtr caps, out int format, out int width, out int height);

		public static bool FormatParseCaps(Gst.Caps caps, out Gst.Video.VideoFormat format, out int width, out int height) {
			int native_format;
			bool raw_ret = gst_video_format_parse_caps(caps == null ? IntPtr.Zero : caps.Handle, out native_format, out width, out height);
			bool ret = raw_ret;
			format = (Gst.Video.VideoFormat) native_format;
			return ret;
		}

		[DllImport("libgstvideo-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_video_format_get_component_offset(int format, int component, int width, int height);

		public static int FormatGetComponentOffset(Gst.Video.VideoFormat format, int component, int width, int height) {
			int raw_ret = gst_video_format_get_component_offset((int) format, component, width, height);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgstvideo-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_parse_caps_pixel_aspect_ratio(IntPtr caps, out int par_n, out int par_d);

		public static bool ParseCapsPixelAspectRatio(Gst.Caps caps, out int par_n, out int par_d) {
			bool raw_ret = gst_video_parse_caps_pixel_aspect_ratio(caps == null ? IntPtr.Zero : caps.Handle, out par_n, out par_d);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstvideo-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_video_format_get_pixel_stride(int format, int component);

		public static int FormatGetPixelStride(Gst.Video.VideoFormat format, int component) {
			int raw_ret = gst_video_format_get_pixel_stride((int) format, component);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgstvideo-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_format_has_alpha(int format);

		public static bool FormatHasAlpha(Gst.Video.VideoFormat format) {
			bool raw_ret = gst_video_format_has_alpha((int) format);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstvideo-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_format_is_rgb(int format);

		public static bool FormatIsRgb(Gst.Video.VideoFormat format) {
			bool raw_ret = gst_video_format_is_rgb((int) format);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstvideo-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_format_new_caps(int format, int width, int height, int framerate_n, int framerate_d, int par_n, int par_d);

		public static Gst.Caps FormatNewCaps(Gst.Video.VideoFormat format, int width, int height, int framerate_n, int framerate_d, int par_n, int par_d) {
			IntPtr raw_ret = gst_video_format_new_caps((int) format, width, height, framerate_n, framerate_d, par_n, par_d);
			Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) Gst.GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), false);
			return ret;
		}

		[DllImport("libgstvideo-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_video_format_get_component_height(int format, int component, int height);

		public static int FormatGetComponentHeight(Gst.Video.VideoFormat format, int component, int height) {
			int raw_ret = gst_video_format_get_component_height((int) format, component, height);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgstvideo-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_format_convert(int format, int width, int height, int fps_n, int fps_d, int src_format, long src_value, int dest_format, out long dest_value);

		public static bool FormatConvert(Gst.Video.VideoFormat format, int width, int height, int fps_n, int fps_d, Gst.Format src_format, long src_value, Gst.Format dest_format, out long dest_value) {
			bool raw_ret = gst_video_format_convert((int) format, width, height, fps_n, fps_d, (int) src_format, src_value, (int) dest_format, out dest_value);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstvideo-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_format_parse_caps_interlaced(IntPtr caps, out bool interlaced);

		public static bool FormatParseCapsInterlaced(Gst.Caps caps, out bool interlaced) {
			bool raw_ret = gst_video_format_parse_caps_interlaced(caps == null ? IntPtr.Zero : caps.Handle, out interlaced);
			bool ret = raw_ret;
			return ret;
		}

#endregion
#region Customized extensions
#line 1 "VideoUtil.custom"
[DllImport ("libgstvideo-0.10.dll") ]
static extern IntPtr gst_video_frame_rate (IntPtr pad);

public static Gst.Fraction GetFrameRate (Gst.Pad pad) {
  IntPtr raw_ret = gst_video_frame_rate (pad == null ? IntPtr.Zero : pad.Handle);
  if (raw_ret == IntPtr.Zero)
    return new Gst.Fraction ();

  Gst.GLib.Value ret = (Gst.GLib.Value) Marshal.PtrToStructure (raw_ret, typeof (Gst.GLib.Value));
  return (Gst.Fraction) ret.Val;
}

[DllImport ("libgstvideo-0.10.dll") ]
static extern uint gst_video_format_to_fourcc (int format);

public static Gst.Fourcc FormatToFourcc (Gst.Video.VideoFormat format) {
  uint raw_ret = gst_video_format_to_fourcc ( (int) format);
  uint ret = raw_ret;
  return new Gst.Fourcc (ret);
}

public static Gst.Video.VideoFormat FormatFromFourcc (Gst.Fourcc fourcc) {
  return FormatFromFourcc (fourcc.Val);
}

[DllImport ("gstreamersharpglue-0.10.dll") ]
static extern IntPtr gstsharp_gst_videoutil_get_template_caps (Gst.Video.VideoFormat fmt);

public static Gst.Caps FormatToTemplateCaps (Gst.Video.VideoFormat fmt) {
  IntPtr raw_ret = gstsharp_gst_videoutil_get_template_caps (fmt);
  if (raw_ret == IntPtr.Zero)
    return null;

  return (Gst.Caps) Gst.GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), true);
}

#endregion
	}
}
