# Outdated project #

Not much maintenance is going on here anymore. For new projects I suggest to use the official GStreamer 1.0 Windows builds: http://gstreamer.freedesktop.org/data/pkg/windows/


---


This is an attempt to make [OSSBuild](http://code.google.com/p/ossbuild/) gstreamer compile on Visual Studio 2010.

The deployment package is simply a zip file of a directory. By setting environment `PATH` and `GST_PLUGIN_SYSTEM_PATH` using `env.bat`, it can be run without installation.

Current component versions:

| GStreamer | 0.10.35 |
|:----------|:--------|
| gst-plugins-base | 0.10.35 |
| gst-plugins-good | 0.10.30 |
| gst-plugins-bad | 0.10.22 |
| gst-plugins-ugly | 0.10.18 |
| gst-ffmpeg | 0.10.11 |
| gst-sharp | Git as of 29.5.2012 |

You can check the newest upstream versions [here](http://gstreamer.freedesktop.org/releases/).