// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FormatDefinition {

		public Gst.Format Value;
		public string Nick;
		public string Description;
		public int Quark;

		public static Gst.FormatDefinition Zero = new Gst.FormatDefinition ();

		public static Gst.FormatDefinition New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.FormatDefinition.Zero;
			return (Gst.FormatDefinition) Marshal.PtrToStructure (raw, typeof (Gst.FormatDefinition));
		}

		private static Gst.GLib.GType GType {
			get { return Gst.GLib.GType.Pointer; }
		}
#endregion
	}
}
