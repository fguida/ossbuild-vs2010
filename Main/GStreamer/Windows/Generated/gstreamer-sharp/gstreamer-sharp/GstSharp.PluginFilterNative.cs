// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GstSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate bool PluginFilterNative(IntPtr plugin, IntPtr user_data);

	internal class PluginFilterInvoker {

		PluginFilterNative native_cb;
		IntPtr __data;
		Gst.GLib.DestroyNotify __notify;

		~PluginFilterInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal PluginFilterInvoker (PluginFilterNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal PluginFilterInvoker (PluginFilterNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal PluginFilterInvoker (PluginFilterNative native_cb, IntPtr data, Gst.GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.PluginFilter Handler {
			get {
				return new Gst.PluginFilter(InvokeNative);
			}
		}

		bool InvokeNative (Gst.Plugin plugin)
		{
			bool result = native_cb (plugin == null ? IntPtr.Zero : plugin.Handle, __data);
			return result;
		}
	}

	internal class PluginFilterWrapper {

		public bool NativeCallback (IntPtr plugin, IntPtr user_data)
		{
			try {
				bool __ret = managed (Gst.GLib.Object.GetObject(plugin) as Gst.Plugin);
				if (release_on_call)
					gch.Free ();
				return __ret;
			} catch (Exception e) {
				Gst.GLib.ExceptionManager.RaiseUnhandledException (e, false);
				return false;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal PluginFilterNative NativeDelegate;
		Gst.PluginFilter managed;

		public PluginFilterWrapper (Gst.PluginFilter managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new PluginFilterNative (NativeCallback);
		}

		public static Gst.PluginFilter GetManagedDelegate (PluginFilterNative native)
		{
			if (native == null)
				return null;
			PluginFilterWrapper wrapper = (PluginFilterWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
