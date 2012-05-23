// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Base {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ByteReader : Gst.GLib.Opaque {

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_uint16_le(IntPtr raw, out ushort val);

		public bool PeekUInt16Le(out ushort val) {
			bool raw_ret = gst_byte_reader_peek_uint16_le(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_int64_be(IntPtr raw, out long val);

		public bool PeekInt64Be(out long val) {
			bool raw_ret = gst_byte_reader_peek_int64_be(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_float64_be(IntPtr raw, out double val);

		public bool PeekFloat64Be(out double val) {
			bool raw_ret = gst_byte_reader_peek_float64_be(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_uint32_le(IntPtr raw, out uint val);

		public bool PeekUInt32Le(out uint val) {
			bool raw_ret = gst_byte_reader_peek_uint32_le(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_byte_reader_get_pos(IntPtr raw);

		public uint Pos { 
			get {
				uint raw_ret = gst_byte_reader_get_pos(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_uint32_be(IntPtr raw, out uint val);

		public bool PeekUInt32Be(out uint val) {
			bool raw_ret = gst_byte_reader_peek_uint32_be(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_uint8(IntPtr raw, out byte val);

		public bool PeekUInt8(out byte val) {
			bool raw_ret = gst_byte_reader_peek_uint8(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_byte_reader_get_remaining(IntPtr raw);

		public uint Remaining { 
			get {
				uint raw_ret = gst_byte_reader_get_remaining(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_int64_le(IntPtr raw, out long val);

		public bool GetInt64Le(out long val) {
			bool raw_ret = gst_byte_reader_get_int64_le(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_int32_le(IntPtr raw, out int val);

		public bool GetInt32Le(out int val) {
			bool raw_ret = gst_byte_reader_get_int32_le(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_int64_be(IntPtr raw, out long val);

		public bool GetInt64Be(out long val) {
			bool raw_ret = gst_byte_reader_get_int64_be(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_int32_be(IntPtr raw, out int val);

		public bool GetInt32Be(out int val) {
			bool raw_ret = gst_byte_reader_get_int32_be(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_uint24_be(IntPtr raw, out uint val);

		public bool PeekUInt24Be(out uint val) {
			bool raw_ret = gst_byte_reader_peek_uint24_be(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_int8(IntPtr raw, out sbyte val);

		public bool GetInt8(out sbyte val) {
			bool raw_ret = gst_byte_reader_get_int8(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_int8(IntPtr raw, out sbyte val);

		public bool PeekInt8(out sbyte val) {
			bool raw_ret = gst_byte_reader_peek_int8(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_skip(IntPtr raw, uint nbytes);

		public bool Skip(uint nbytes) {
			bool raw_ret = gst_byte_reader_skip(Handle, nbytes);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_byte_reader_masked_scan_uint32(IntPtr raw, uint mask, uint pattern, uint offset, uint size);

		public uint MaskedScanUint32(uint mask, uint pattern, uint offset, uint size) {
			uint raw_ret = gst_byte_reader_masked_scan_uint32(Handle, mask, pattern, offset, size);
			uint ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_uint16_be(IntPtr raw, out ushort val);

		public bool PeekUInt16Be(out ushort val) {
			bool raw_ret = gst_byte_reader_peek_uint16_be(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_string_utf8(IntPtr raw, out IntPtr str);

		public bool PeekString(out string str) {
			IntPtr native_str;
			bool raw_ret = gst_byte_reader_peek_string_utf8(Handle, out native_str);
			bool ret = raw_ret;
			str = Gst.GLib.Marshaller.Utf8PtrToString (native_str);
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_int24_le(IntPtr raw, out int val);

		public bool GetInt24Le(out int val) {
			bool raw_ret = gst_byte_reader_get_int24_le(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_int24_be(IntPtr raw, out int val);

		public bool GetInt24Be(out int val) {
			bool raw_ret = gst_byte_reader_get_int24_be(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_int16_le(IntPtr raw, out short val);

		public bool GetInt16Le(out short val) {
			bool raw_ret = gst_byte_reader_get_int16_le(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_float32_be(IntPtr raw, out float val);

		public bool PeekFloat32Be(out float val) {
			bool raw_ret = gst_byte_reader_peek_float32_be(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_set_pos(IntPtr raw, uint pos);

		public bool SetPos(uint pos) {
			bool raw_ret = gst_byte_reader_set_pos(Handle, pos);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_uint24_be(IntPtr raw, out uint val);

		public bool GetUInt24Be(out uint val) {
			bool raw_ret = gst_byte_reader_get_uint24_be(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_uint24_le(IntPtr raw, out uint val);

		public bool GetUInt24Le(out uint val) {
			bool raw_ret = gst_byte_reader_get_uint24_le(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_int16_be(IntPtr raw, out short val);

		public bool PeekInt16Be(out short val) {
			bool raw_ret = gst_byte_reader_peek_int16_be(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_uint8(IntPtr raw, out byte val);

		public bool GetUInt8(out byte val) {
			bool raw_ret = gst_byte_reader_get_uint8(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_uint32_be(IntPtr raw, out uint val);

		public bool GetUInt32Be(out uint val) {
			bool raw_ret = gst_byte_reader_get_uint32_be(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_uint32_le(IntPtr raw, out uint val);

		public bool GetUInt32Le(out uint val) {
			bool raw_ret = gst_byte_reader_get_uint32_le(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_int16_le(IntPtr raw, out short val);

		public bool PeekInt16Le(out short val) {
			bool raw_ret = gst_byte_reader_peek_int16_le(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_uint64_le(IntPtr raw, out ulong val);

		public bool GetUint64Le(out ulong val) {
			bool raw_ret = gst_byte_reader_get_uint64_le(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_float64_le(IntPtr raw, out double val);

		public bool PeekFloat64Le(out double val) {
			bool raw_ret = gst_byte_reader_peek_float64_le(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_string_utf8(IntPtr raw, out IntPtr str);

		public bool GetString(out string str) {
			IntPtr native_str;
			bool raw_ret = gst_byte_reader_get_string_utf8(Handle, out native_str);
			bool ret = raw_ret;
			str = Gst.GLib.Marshaller.Utf8PtrToString (native_str);
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_int24_le(IntPtr raw, out int val);

		public bool PeekInt24Le(out int val) {
			bool raw_ret = gst_byte_reader_peek_int24_le(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_uint64_be(IntPtr raw, out ulong val);

		public bool PeekUInt64Be(out ulong val) {
			bool raw_ret = gst_byte_reader_peek_uint64_be(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_int16_be(IntPtr raw, out short val);

		public bool GetInt16Be(out short val) {
			bool raw_ret = gst_byte_reader_get_int16_be(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_int32_be(IntPtr raw, out int val);

		public bool PeekInt32Be(out int val) {
			bool raw_ret = gst_byte_reader_peek_int32_be(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_int64_le(IntPtr raw, out long val);

		public bool PeekInt64Le(out long val) {
			bool raw_ret = gst_byte_reader_peek_int64_le(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_uint64_le(IntPtr raw, out ulong val);

		public bool PeekUint64Le(out ulong val) {
			bool raw_ret = gst_byte_reader_peek_uint64_le(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_uint16_be(IntPtr raw, out ushort val);

		public bool GetUInt16Be(out ushort val) {
			bool raw_ret = gst_byte_reader_get_uint16_be(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_uint16_le(IntPtr raw, out ushort val);

		public bool GetUInt16Le(out ushort val) {
			bool raw_ret = gst_byte_reader_get_uint16_le(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_uint64_be(IntPtr raw, out ulong val);

		public bool GetUInt64Be(out ulong val) {
			bool raw_ret = gst_byte_reader_get_uint64_be(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_skip_string_utf8(IntPtr raw);

		public bool SkipString() {
			bool raw_ret = gst_byte_reader_skip_string_utf8(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_float64_be(IntPtr raw, out double val);

		public bool GetFloat64Be(out double val) {
			bool raw_ret = gst_byte_reader_get_float64_be(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_float32_le(IntPtr raw, out float val);

		public bool PeekFloat32Le(out float val) {
			bool raw_ret = gst_byte_reader_peek_float32_le(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_float32_be(IntPtr raw, out float val);

		public bool GetFloat32Be(out float val) {
			bool raw_ret = gst_byte_reader_get_float32_be(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_float64_le(IntPtr raw, out double val);

		public bool GetFloat64Le(out double val) {
			bool raw_ret = gst_byte_reader_get_float64_le(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_int24_be(IntPtr raw, out int val);

		public bool PeekInt24Be(out int val) {
			bool raw_ret = gst_byte_reader_peek_int24_be(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_int32_le(IntPtr raw, out int val);

		public bool PeekInt32Le(out int val) {
			bool raw_ret = gst_byte_reader_peek_int32_le(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_peek_uint24_le(IntPtr raw, out uint val);

		public bool PeekUInt24Le(out uint val) {
			bool raw_ret = gst_byte_reader_peek_uint24_le(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_byte_reader_get_float32_le(IntPtr raw, out float val);

		public bool GetFloat32Le(out float val) {
			bool raw_ret = gst_byte_reader_get_float32_le(Handle, out val);
			bool ret = raw_ret;
			return ret;
		}

		public ByteReader(IntPtr raw) : base(raw) {}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_byte_reader_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			gst_byte_reader_free (raw);
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gst_byte_reader_free (handle);
				return false;
			}
		}

		~ByteReader ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			Gst.GLib.Timeout.Add (50, new Gst.GLib.TimeoutHandler (info.Handler));
		}

#endregion
#region Customized extensions
#line 1 "ByteReader.custom"
Gst.Buffer buffer = null;
public Gst.Buffer Buffer {
  get {
    return buffer;
  }
}

[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
static extern IntPtr gst_byte_reader_new_from_buffer(IntPtr buffer);

public ByteReader (Gst.Buffer buffer)
{
  Raw = gst_byte_reader_new_from_buffer(buffer == null ? IntPtr.Zero : buffer.Handle);
  this.buffer = buffer;
}

[DllImport ("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl) ]
static extern bool gst_byte_reader_peek_data (IntPtr raw, uint size, out IntPtr val);

public bool PeekData (uint size, out byte[] val) {
  IntPtr raw_ret;

  bool ret = gst_byte_reader_peek_data (Handle, size, out raw_ret);

  if (!ret || raw_ret == IntPtr.Zero) {
    val = null;
  } else {
    val = new byte[size];
    Marshal.Copy (raw_ret, val, 0, (int) size);
  }

  return ret;
}

[DllImport ("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl) ]
static extern bool gst_byte_reader_get_data (IntPtr raw, uint size, out IntPtr val);

public bool GetData (uint size, out byte[] val) {
  IntPtr raw_ret;

  bool ret = gst_byte_reader_get_data (Handle, size, out raw_ret);

  if (!ret || raw_ret == IntPtr.Zero) {
    val = null;
  } else {
    val = new byte[size];
    Marshal.Copy (raw_ret, val, 0, (int) size);
  }

  return ret;
}

#endregion
	}
}
