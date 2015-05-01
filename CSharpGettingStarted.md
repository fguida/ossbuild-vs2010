# Introduction #

GStreamer has C# bindings called [gstreamer-sharp](http://gstreamer.freedesktop.org/releases/gstreamer-sharp/0.9.1.html), which were originally developed for Mono but work also under Microsoft .NET.

# Building the example project #
You can find a C# example project in [Examples\csharp-helloworld](http://code.google.com/p/ossbuild-vs2010/source/browse/#git%2FExamples%2Fcsharp-helloworld) folder. It uses Windows Forms and GStreamer's `d3drenderer` to render video from the `videotestsrc`.

  * Before running the application, you must copy the `gstreamer` folder with the binaries to `bin\Debug` folder. You can get it from the Downloads page, just uncompress the .zip.

![http://wiki.ossbuild-vs2010.googlecode.com/git-history/master/csharpscreenshot.png](http://wiki.ossbuild-vs2010.googlecode.com/git-history/master/csharpscreenshot.png)

# Details #

The program uses gstreamer binaries that are simply in a subfolder in the `.exe` directory. This eases deployment, as the libraries don't have to be installed globally and added to path. You will find code that sets the PATH and other environment variables in [Program.cs](http://code.google.com/p/ossbuild-vs2010/source/browse/Examples/csharp-helloworld/Program.cs).

The example demonstrates how to create a pipeline, set some element properties and how to play and stop the pipeline. It also runs the GLib mainloop in a separate thread, and stops it cleanly when the form is closed.

The video is rendered to the window using `d3dvideosink`. The target window is set using the [XOverlay](http://gstreamer.freedesktop.org/data/doc/gstreamer/head/gst-plugins-base-libs/html/gst-plugins-base-libs-gstxoverlay.html) GStreamer interface. On Windows, it simply takes the `HWND` of the target control.

With XOverlay, one question is when to set the window handle. Officially, it should be done when `prepare-xwindow-id` message is posted on `Pipeline.Bus`. However, for the simplicity of the example, it just sets it before starting playback.

# More examples #

More gstreamer-sharp examples are available in the upstream repo. They use GTK# instead of winforms, but the GStreamer stuff is the same:
http://cgit.freedesktop.org/gstreamer/gstreamer-sharp/tree/samples/