// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Interfaces {

	using System;

#region Autogenerated code
	public partial interface Mixer : Gst.GLib.IWrapper {

		void VolumeChanged(Gst.Interfaces.MixerTrack track, int[] volumes);
		Gst.Interfaces.MixerTrack[] ListTracks();
		void SetOption(Gst.Interfaces.MixerOptions opts, string value);
		void SetVolume(Gst.Interfaces.MixerTrack track, int[] volumes);
		Gst.Interfaces.MixerType MixerType { 
			get;
		}
		void OptionChanged(Gst.Interfaces.MixerOptions opts, string value);
		string GetOption(Gst.Interfaces.MixerOptions opts);
		void SetRecord(Gst.Interfaces.MixerTrack track, bool record);
		void ListChanged(Gst.Interfaces.MixerOptions opts);
		void RecordToggled(Gst.Interfaces.MixerTrack track, bool record);
		void MuteToggled(Gst.Interfaces.MixerTrack track, bool mute);
		int[] GetVolume(Gst.Interfaces.MixerTrack track);
		Gst.Interfaces.MixerFlags MixerFlags { 
			get;
		}
		void MixerChanged();
		void SetMute(Gst.Interfaces.MixerTrack track, bool mute);
	}

	[Gst.GLib.GInterface (typeof (MixerAdapter))]
	public partial interface MixerImplementor : Gst.GLib.IWrapper {

		Gst.Interfaces.MixerTrack[] ListTracks ();
		void SetVolume (Gst.Interfaces.MixerTrack track, int[] volumes);
		int[] GetVolume (Gst.Interfaces.MixerTrack track);
		void SetMute (Gst.Interfaces.MixerTrack track, bool mute);
		void SetRecord (Gst.Interfaces.MixerTrack track, bool record);
		void SetOption (Gst.Interfaces.MixerOptions opts, string value);
		string GetOption (Gst.Interfaces.MixerOptions opts);
		Gst.Interfaces.MixerFlags MixerFlags { get; }
	}
#endregion
}
