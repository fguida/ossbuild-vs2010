// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;

	public delegate void ParentSetHandler(object o, ParentSetArgs args);

	public class ParentSetArgs : Gst.GLib.SignalArgs {
		public Gst.Object Parent{
			get {
				return (Gst.Object) Args [0];
			}
		}

	}
}
