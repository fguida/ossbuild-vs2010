// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Task : Gst.Object {

		public Task(IntPtr raw) : base(raw) {}

		[DllImport("libgstreamer-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_task_create(GstSharp.TaskFunctionNative func, IntPtr data);

		public Task (Gst.TaskFunction func) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Task)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			GstSharp.TaskFunctionWrapper func_wrapper = new GstSharp.TaskFunctionWrapper (func);
			Raw = gst_task_create(func_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport ("gstreamersharpglue-0.10.dll")]
		extern static uint gstsharp_gst_task_get_running_offset ();

		static uint running_offset = gstsharp_gst_task_get_running_offset ();
		public bool Running {
			get {
				unsafe {
					bool* raw_ptr = (bool*)(((byte*)Handle) + running_offset);
					return (*raw_ptr);
				}
			}
		}

		[DllImport("libgstreamer-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_task_get_state(IntPtr raw);

		public Gst.TaskState State {
			get  {
				int raw_ret = gst_task_get_state(Handle);
				Gst.TaskState ret = (Gst.TaskState) raw_ret;
				return ret;
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GstTaskClass {
			private IntPtr _pool;
			public Gst.TaskPool Pool {
				get {
					return Gst.GLib.Object.GetObject(_pool) as Gst.TaskPool;
				}
				set {
					_pool = value == null ? IntPtr.Zero : value.Handle;
				}
			}
			[MarshalAs (UnmanagedType.ByValArray, SizeConst=4)]
			public IntPtr[] GstReserved;
		}

		static uint class_offset = ((Gst.GLib.GType) typeof (Gst.Object)).GetClassSize ();
		static Hashtable class_structs;

		static GstTaskClass GetClassStruct (Gst.GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Hashtable ();

			if (use_cache && class_structs.Contains (gtype))
				return (GstTaskClass) class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GstTaskClass class_struct = (GstTaskClass) Marshal.PtrToStructure (class_ptr, typeof (GstTaskClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (Gst.GLib.GType gtype, GstTaskClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgstreamer-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_task_set_state(IntPtr raw, int state);

		public bool SetState(Gst.TaskState state) {
			bool raw_ret = gst_task_set_state(Handle, (int) state);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_task_join(IntPtr raw);

		public bool Join() {
			bool raw_ret = gst_task_join(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_task_get_pool(IntPtr raw);

		[DllImport("libgstreamer-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_task_set_pool(IntPtr raw, IntPtr pool);

		public Gst.TaskPool Pool { 
			get {
				IntPtr raw_ret = gst_task_get_pool(Handle);
				Gst.TaskPool ret = Gst.GLib.Object.GetObject(raw_ret) as Gst.TaskPool;
				return ret;
			}
			set {
				gst_task_set_pool(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgstreamer-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_task_get_type();

		public static new Gst.GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_task_get_type();
				Gst.GLib.GType ret = new Gst.GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstreamer-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_task_pause(IntPtr raw);

		public bool Pause() {
			bool raw_ret = gst_task_pause(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_task_start(IntPtr raw);

		public bool Start() {
			bool raw_ret = gst_task_start(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_task_stop(IntPtr raw);

		public bool Stop() {
			bool raw_ret = gst_task_stop(Handle);
			bool ret = raw_ret;
			return ret;
		}

#endregion
#region Customized extensions
#line 1 "Task.custom"
[DllImport ("gstreamersharpglue-0.10.dll") ]
extern static uint gstsharp_gst_task_get_cond_offset ();

static uint cond_offset = gstsharp_gst_task_get_cond_offset ();
private IntPtr CondPtr {
  get {
    unsafe {
      IntPtr* raw_ptr = (IntPtr*) ( ( (byte*) Handle) + cond_offset);
      return (*raw_ptr);
    }
  }
}

[DllImport ("libglib-2.0-0.dll") ]
static extern void g_cond_wait (IntPtr cond, IntPtr mutex);
[DllImport ("libglib-2.0-0.dll") ]
static extern void g_cond_signal (IntPtr cond);

public void Wait () {
  g_cond_wait (CondPtr, LockPtr);
}

public void Signal () {
  g_cond_signal (CondPtr);
}


#endregion
	}
}
