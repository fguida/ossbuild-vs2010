// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.App {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class AppSink : Gst.Base.BaseSink {

		public AppSink(IntPtr raw) : base(raw) {}

		[DllImport("libgstapp-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_app_sink_get_drop(IntPtr raw);

		[DllImport("libgstapp-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_app_sink_set_drop(IntPtr raw, bool drop);

		[Gst.GLib.Property ("drop")]
		public bool Drop {
			get  {
				bool raw_ret = gst_app_sink_get_drop(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gst_app_sink_set_drop(Handle, value);
			}
		}

		[DllImport("libgstapp-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_app_sink_get_max_buffers(IntPtr raw);

		[DllImport("libgstapp-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_app_sink_set_max_buffers(IntPtr raw, uint max);

		[Gst.GLib.Property ("max-buffers")]
		public uint MaxBuffers {
			get  {
				uint raw_ret = gst_app_sink_get_max_buffers(Handle);
				uint ret = raw_ret;
				return ret;
			}
			set  {
				gst_app_sink_set_max_buffers(Handle, value);
			}
		}

		[DllImport("libgstapp-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_app_sink_get_caps(IntPtr raw);

		[DllImport("libgstapp-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_app_sink_set_caps(IntPtr raw, IntPtr caps);

		[Gst.GLib.Property ("caps")]
		public Gst.Caps Caps {
			get  {
				IntPtr raw_ret = gst_app_sink_get_caps(Handle);
				Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) Gst.GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), true);
				return ret;
			}
			set  {
				gst_app_sink_set_caps(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgstapp-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_app_sink_get_emit_signals(IntPtr raw);

		[DllImport("libgstapp-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_app_sink_set_emit_signals(IntPtr raw, bool emit);

		[Gst.GLib.Property ("emit-signals")]
		public bool EmitSignals {
			get  {
				bool raw_ret = gst_app_sink_get_emit_signals(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gst_app_sink_set_emit_signals(Handle, value);
			}
		}

		[Gst.GLib.Signal("new-preroll")]
		public event System.EventHandler NewPreroll {
			add {
				Gst.GLib.Signal sig = Gst.GLib.Signal.Lookup (this, "new-preroll");
				sig.AddDelegate (value);
			}
			remove {
				Gst.GLib.Signal sig = Gst.GLib.Signal.Lookup (this, "new-preroll");
				sig.RemoveDelegate (value);
			}
		}

		[Gst.GLib.Signal("new-buffer-list")]
		public event Gst.App.NewBufferListHandler NewBufferList {
			add {
				Gst.GLib.Signal sig = Gst.GLib.Signal.Lookup (this, "new-buffer-list", typeof (Gst.App.NewBufferListArgs));
				sig.AddDelegate (value);
			}
			remove {
				Gst.GLib.Signal sig = Gst.GLib.Signal.Lookup (this, "new-buffer-list", typeof (Gst.App.NewBufferListArgs));
				sig.RemoveDelegate (value);
			}
		}

		[Gst.GLib.Signal("eos")]
		public event System.EventHandler Eos {
			add {
				Gst.GLib.Signal sig = Gst.GLib.Signal.Lookup (this, "eos");
				sig.AddDelegate (value);
			}
			remove {
				Gst.GLib.Signal sig = Gst.GLib.Signal.Lookup (this, "eos");
				sig.RemoveDelegate (value);
			}
		}

		[Gst.GLib.Signal("new-buffer")]
		public event System.EventHandler NewBuffer {
			add {
				Gst.GLib.Signal sig = Gst.GLib.Signal.Lookup (this, "new-buffer");
				sig.AddDelegate (value);
			}
			remove {
				Gst.GLib.Signal sig = Gst.GLib.Signal.Lookup (this, "new-buffer");
				sig.RemoveDelegate (value);
			}
		}

		static EosNativeDelegate Eos_cb_delegate;
		static EosNativeDelegate EosVMCallback {
			get {
				if (Eos_cb_delegate == null)
					Eos_cb_delegate = new EosNativeDelegate (Eos_cb);
				return Eos_cb_delegate;
			}
		}

		static void OverrideEos (Gst.GLib.GType gtype)
		{
			OverrideEos (gtype, EosVMCallback);
		}

		static void OverrideEos (Gst.GLib.GType gtype, EosNativeDelegate callback)
		{
			GstAppSinkClass class_iface = GetClassStruct (gtype, false);
			class_iface.Eos = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void EosNativeDelegate (IntPtr inst);

		static void Eos_cb (IntPtr inst)
		{
			try {
				AppSink __obj = Gst.GLib.Object.GetObject (inst, false) as AppSink;
				__obj.OnEos ();
			} catch (Exception e) {
				Gst.GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[Gst.GLib.DefaultSignalHandler(Type=typeof(Gst.App.AppSink), ConnectionMethod="OverrideEos")]
		protected virtual void OnEos ()
		{
			InternalEos ();
		}

		private void InternalEos ()
		{
			EosNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Eos;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static NewPrerollNativeDelegate NewPreroll_cb_delegate;
		static NewPrerollNativeDelegate NewPrerollVMCallback {
			get {
				if (NewPreroll_cb_delegate == null)
					NewPreroll_cb_delegate = new NewPrerollNativeDelegate (NewPreroll_cb);
				return NewPreroll_cb_delegate;
			}
		}

		static void OverrideNewPreroll (Gst.GLib.GType gtype)
		{
			OverrideNewPreroll (gtype, NewPrerollVMCallback);
		}

		static void OverrideNewPreroll (Gst.GLib.GType gtype, NewPrerollNativeDelegate callback)
		{
			GstAppSinkClass class_iface = GetClassStruct (gtype, false);
			class_iface.NewPreroll = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void NewPrerollNativeDelegate (IntPtr inst);

		static void NewPreroll_cb (IntPtr inst)
		{
			try {
				AppSink __obj = Gst.GLib.Object.GetObject (inst, false) as AppSink;
				__obj.OnNewPreroll ();
			} catch (Exception e) {
				Gst.GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[Gst.GLib.DefaultSignalHandler(Type=typeof(Gst.App.AppSink), ConnectionMethod="OverrideNewPreroll")]
		protected virtual void OnNewPreroll ()
		{
			InternalNewPreroll ();
		}

		private void InternalNewPreroll ()
		{
			NewPrerollNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).NewPreroll;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static NewBufferNativeDelegate NewBuffer_cb_delegate;
		static NewBufferNativeDelegate NewBufferVMCallback {
			get {
				if (NewBuffer_cb_delegate == null)
					NewBuffer_cb_delegate = new NewBufferNativeDelegate (NewBuffer_cb);
				return NewBuffer_cb_delegate;
			}
		}

		static void OverrideNewBuffer (Gst.GLib.GType gtype)
		{
			OverrideNewBuffer (gtype, NewBufferVMCallback);
		}

		static void OverrideNewBuffer (Gst.GLib.GType gtype, NewBufferNativeDelegate callback)
		{
			GstAppSinkClass class_iface = GetClassStruct (gtype, false);
			class_iface.NewBuffer = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void NewBufferNativeDelegate (IntPtr inst);

		static void NewBuffer_cb (IntPtr inst)
		{
			try {
				AppSink __obj = Gst.GLib.Object.GetObject (inst, false) as AppSink;
				__obj.OnNewBuffer ();
			} catch (Exception e) {
				Gst.GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[Gst.GLib.DefaultSignalHandler(Type=typeof(Gst.App.AppSink), ConnectionMethod="OverrideNewBuffer")]
		protected virtual void OnNewBuffer ()
		{
			InternalNewBuffer ();
		}

		private void InternalNewBuffer ()
		{
			NewBufferNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).NewBuffer;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static NewBufferListNativeDelegate NewBufferList_cb_delegate;
		static NewBufferListNativeDelegate NewBufferListVMCallback {
			get {
				if (NewBufferList_cb_delegate == null)
					NewBufferList_cb_delegate = new NewBufferListNativeDelegate (NewBufferList_cb);
				return NewBufferList_cb_delegate;
			}
		}

		static void OverrideNewBufferList (Gst.GLib.GType gtype)
		{
			OverrideNewBufferList (gtype, NewBufferListVMCallback);
		}

		static void OverrideNewBufferList (Gst.GLib.GType gtype, NewBufferListNativeDelegate callback)
		{
			GstAppSinkClass class_iface = GetClassStruct (gtype, false);
			class_iface.NewBufferList = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr NewBufferListNativeDelegate (IntPtr inst);

		static IntPtr NewBufferList_cb (IntPtr inst)
		{
			try {
				AppSink __obj = Gst.GLib.Object.GetObject (inst, false) as AppSink;
				Gst.BufferList __result = __obj.OnNewBufferList ();
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				Gst.GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[Gst.GLib.DefaultSignalHandler(Type=typeof(Gst.App.AppSink), ConnectionMethod="OverrideNewBufferList")]
		protected virtual Gst.BufferList OnNewBufferList ()
		{
			return InternalNewBufferList ();
		}

		private Gst.BufferList InternalNewBufferList ()
		{
			NewBufferListNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).NewBufferList;
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle);
			return Gst.MiniObject.GetObject(__result) as Gst.BufferList;
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GstAppSinkClass {
			public EosNativeDelegate Eos;
			public NewPrerollNativeDelegate NewPreroll;
			public NewBufferNativeDelegate NewBuffer;
			IntPtr PullPreroll;
			IntPtr PullBuffer;
			public NewBufferListNativeDelegate NewBufferList;
			IntPtr PullBufferList;
			[MarshalAs (UnmanagedType.ByValArray, SizeConst=2)]
			public IntPtr[] GstReserved;
		}

		static uint class_offset = ((Gst.GLib.GType) typeof (Gst.Base.BaseSink)).GetClassSize ();
		static Hashtable class_structs;

		static GstAppSinkClass GetClassStruct (Gst.GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Hashtable ();

			if (use_cache && class_structs.Contains (gtype))
				return (GstAppSinkClass) class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GstAppSinkClass class_struct = (GstAppSinkClass) Marshal.PtrToStructure (class_ptr, typeof (GstAppSinkClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (Gst.GLib.GType gtype, GstAppSinkClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgstapp-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_app_sink_pull_buffer(IntPtr raw);

		public Gst.Buffer PullBuffer() {
			IntPtr raw_ret = gst_app_sink_pull_buffer(Handle);
			Gst.Buffer ret = Gst.MiniObject.GetObject(raw_ret, true) as Gst.Buffer;
			return ret;
		}

		[DllImport("libgstapp-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_app_sink_pull_preroll(IntPtr raw);

		public Gst.Buffer PullPreroll() {
			IntPtr raw_ret = gst_app_sink_pull_preroll(Handle);
			Gst.Buffer ret = Gst.MiniObject.GetObject(raw_ret, true) as Gst.Buffer;
			return ret;
		}

		[DllImport("libgstapp-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_app_sink_get_type();

		public static new Gst.GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_app_sink_get_type();
				Gst.GLib.GType ret = new Gst.GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstapp-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_app_sink_is_eos(IntPtr raw);

		public bool IsEos { 
			get {
				bool raw_ret = gst_app_sink_is_eos(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgstapp-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_app_sink_pull_buffer_list(IntPtr raw);

		public Gst.BufferList PullBufferList() {
			IntPtr raw_ret = gst_app_sink_pull_buffer_list(Handle);
			Gst.BufferList ret = Gst.MiniObject.GetObject(raw_ret, true) as Gst.BufferList;
			return ret;
		}


		static AppSink ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}
#endregion
#region Customized extensions
#line 1 "AppSink.custom"
[DllImport ("libgstreamer-0.10.dll") ]
static extern IntPtr gst_element_factory_make (IntPtr element, IntPtr name);

public AppSink (string name) : base (IntPtr.Zero) {
  IntPtr native_name = Gst.GLib.Marshaller.StringToPtrGStrdup (name);
  IntPtr native_element = Gst.GLib.Marshaller.StringToPtrGStrdup ("appsink");
  Raw = gst_element_factory_make (native_element, native_name);
  Gst.GLib.Marshaller.Free (native_name);
  Gst.GLib.Marshaller.Free (native_element);
  if (Raw == IntPtr.Zero)
    throw new Exception ("Failed to instantiate element \"appsink\"");
}

public AppSink () : this ( (string) null) { }

#endregion
	}
}
