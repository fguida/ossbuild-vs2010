// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GstSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void TypeFindFunctionNative(IntPtr find, IntPtr data);

	internal class TypeFindFunctionInvoker {

		TypeFindFunctionNative native_cb;
		IntPtr __data;
		Gst.GLib.DestroyNotify __notify;

		~TypeFindFunctionInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal TypeFindFunctionInvoker (TypeFindFunctionNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal TypeFindFunctionInvoker (TypeFindFunctionNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal TypeFindFunctionInvoker (TypeFindFunctionNative native_cb, IntPtr data, Gst.GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.TypeFindFunction Handler {
			get {
				return new Gst.TypeFindFunction(InvokeNative);
			}
		}

		void InvokeNative (Gst.TypeFind find)
		{
			native_cb (find == null ? IntPtr.Zero : find.Handle, __data);
		}
	}

	internal class TypeFindFunctionWrapper {

		public void NativeCallback (IntPtr find, IntPtr data)
		{
			try {
				managed (find == IntPtr.Zero ? null : (Gst.TypeFind) Gst.GLib.Opaque.GetOpaque (find, typeof (Gst.TypeFind), false));
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				Gst.GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal TypeFindFunctionNative NativeDelegate;
		Gst.TypeFindFunction managed;

		public TypeFindFunctionWrapper (Gst.TypeFindFunction managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new TypeFindFunctionNative (NativeCallback);
		}

		public static Gst.TypeFindFunction GetManagedDelegate (TypeFindFunctionNative native)
		{
			if (native == null)
				return null;
			TypeFindFunctionWrapper wrapper = (TypeFindFunctionWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
