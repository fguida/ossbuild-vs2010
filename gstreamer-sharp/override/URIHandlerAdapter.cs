// This file was generated by the Gtk# code generator.
// Modified to correctly handle the Get{Type,Protocols}Full vmethods

namespace Gst {

	using System;
	using System.Runtime.InteropServices;
	using System.Reflection;
	using System.Collections;

#region Autogenerated code
	public class URIHandlerAdapter : GLib.GInterfaceAdapter, Gst.URIHandler {

		[StructLayout (LayoutKind.Sequential)]
		struct GstURIHandlerInterface {
			IntPtr NewUri;
			IntPtr GetType;
			IntPtr GetProtocols;
			public GetUriNativeDelegate GetUri;
			public SetUriNativeDelegate SetUri;
			public GetTypeFullNativeDelegate GetTypeFull;
			public GetProtocolsFullNativeDelegate GetProtocolsFull;
			[MarshalAs (UnmanagedType.ByValArray, SizeConst=2)]
			public IntPtr[] GstReserved;
		}

		static GstURIHandlerInterface iface;

		static URIHandlerAdapter ()
		{
			GLib.GType.Register (_gtype, typeof(URIHandlerAdapter));
			iface.GetTypeFull = new GetTypeFullNativeDelegate (GetTypeFull_cb);
			iface.GetProtocolsFull = new GetProtocolsFullNativeDelegate (GetProtocolsFull_cb);
			iface.GetUri = new GetUriNativeDelegate (GetUri_cb);
			iface.SetUri = new SetUriNativeDelegate (SetUri_cb);
		}

		[GLib.CDeclCallback]
		delegate int GetTypeFullNativeDelegate (IntPtr gtype);

		static int GetTypeFull_cb (IntPtr gtype)
		{
			try {
				GLib.GType gt = new GLib.GType (gtype);
				System.Type t = (System.Type) gt;

				System.Reflection.PropertyInfo pi = t.GetProperty ("Type", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.FlattenHierarchy);
				Gst.URIType __result = Gst.URIType.Unknown;
				if (pi != null && pi.PropertyType == typeof (Gst.URIType))
				  __result = (Gst.URIType) pi.GetValue (null, null);

				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.CDeclCallback]
		delegate IntPtr[] GetProtocolsFullNativeDelegate (IntPtr gtype);

		static Hashtable protocols_cache = new Hashtable ();

		static IntPtr[] GetProtocolsFull_cb (IntPtr gtype)
		{
			try {
				GLib.GType gt = new GLib.GType (gtype);
				System.Type t = (System.Type) gt;

				if (protocols_cache.Contains (gtype)) {
				  return (IntPtr[]) protocols_cache[gtype];
				}

				System.Reflection.PropertyInfo pi = t.GetProperty ("Protocols", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.FlattenHierarchy);
				string[] __result;
				if (pi != null && pi.PropertyType == typeof (string[]))
				  __result = (string[]) pi.GetValue (null, null);
				else
				  __result = new string[] {};
				IntPtr[] ret = GLib.Marshaller.StringArrayToNullTermPointer (__result);
				protocols_cache.Add (gtype, ret);

				return ret;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.CDeclCallback]
		delegate IntPtr GetUriNativeDelegate (IntPtr inst);

		static IntPtr GetUri_cb (IntPtr inst)
		{
			try {
				URIHandlerImplementor __obj = GLib.Object.GetObject (inst, false) as URIHandlerImplementor;
				string __result = __obj.Uri;
				return GLib.Marshaller.StringToPtrGStrdup (__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.CDeclCallback]
		delegate bool SetUriNativeDelegate (IntPtr inst, IntPtr uri);

		static bool SetUri_cb (IntPtr inst, IntPtr uri)
		{
			try {
				URIHandlerImplementor __obj = GLib.Object.GetObject (inst, false) as URIHandlerImplementor;
				bool __result = __obj.SetUri (GLib.Marshaller.Utf8PtrToString (uri));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			GstURIHandlerInterface native_iface = (GstURIHandlerInterface) Marshal.PtrToStructure (ifaceptr, typeof (GstURIHandlerInterface));
			native_iface.GetTypeFull = iface.GetTypeFull;
			native_iface.GetProtocolsFull = iface.GetProtocolsFull;
			native_iface.GetUri = iface.GetUri;
			native_iface.SetUri = iface.SetUri;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
			GCHandle gch = (GCHandle) data;
			gch.Free ();
		}

		public URIHandlerAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		URIHandlerImplementor implementor;

		public URIHandlerAdapter (URIHandlerImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			this.implementor = implementor;
		}

		public URIHandlerAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			this.handle = handle;
		}

		[DllImport("gstreamer-0.10.dll")]
		static extern IntPtr gst_uri_handler_get_type();

		private static GLib.GType _gtype = new GLib.GType (gst_uri_handler_get_type ());

		public override GLib.GType GType {
			get {
				return _gtype;
			}
		}

		IntPtr handle;
		public override IntPtr Handle {
			get {
				if (handle != IntPtr.Zero)
					return handle;
				return implementor == null ? IntPtr.Zero : implementor.Handle;
			}
		}

		public static URIHandler GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static URIHandler GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is URIHandlerImplementor)
				return new URIHandlerAdapter (obj as URIHandlerImplementor);
			else if (obj as URIHandler == null)
				return new URIHandlerAdapter (obj.Handle);
			else
				return obj as URIHandler;
		}

		public URIHandlerImplementor Implementor {
			get {
				return implementor;
			}
		}

		[GLib.Signal("new-uri")]
		public event Gst.NewUriHandler NewUri {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (GLib.Object.GetObject (Handle), "new-uri", typeof (Gst.NewUriArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (GLib.Object.GetObject (Handle), "new-uri", typeof (Gst.NewUriArgs));
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("gstreamer-0.10.dll")]
		static extern uint gst_uri_handler_get_uri_type(IntPtr raw);

		public Gst.URIType UriType { 
			get {
				uint raw_ret = gst_uri_handler_get_uri_type(Handle);
				Gst.URIType ret = (Gst.URIType) raw_ret;
				return ret;
			}
		}

		[DllImport("gstreamer-0.10.dll")]
		static extern bool gst_uri_handler_set_uri(IntPtr raw, IntPtr uri);

		public bool SetUri(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			bool raw_ret = gst_uri_handler_set_uri(Handle, native_uri);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			return ret;
		}

		[DllImport("gstreamer-0.10.dll")]
		static extern IntPtr gst_uri_handler_get_protocols(IntPtr raw);

		public string[] Protocols { 
			get {
				IntPtr raw_ret = gst_uri_handler_get_protocols(Handle);
				string[] ret = GLib.Marshaller.NullTermPtrToStringArray(raw_ret, false);
				return ret;
			}
		}

		[DllImport("gstreamer-0.10.dll")]
		static extern IntPtr gst_uri_handler_get_uri(IntPtr raw);

		public string Uri { 
			get {
				IntPtr raw_ret = gst_uri_handler_get_uri(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

#endregion
	}
}
