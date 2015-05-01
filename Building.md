# Build requirements #
  * Visual Studio 2010 Professional
  * Possibly Windows SDK, have to check if it is really needed.

# Build instructions #
  * Checkout the source code from Git.
  * Open `GStreamer.sln` in Visual Studio.
  * Go to Tools -> Options -> Projects and Solutions -> Build and Run and set **maximum number of parallel project builds** to 1. There are still some missing dependency relations which cause parallel build to fail.
  * On the toolbar, select build configuration as `Release (LGPL)`. The GPL build has not been tested yet.
  * Select Build -> Build solution

# Expected warnings #
The following warnings are expected, and should be ignored:

  * `Warning C4133: '=' : incompatible types - from 'gpointer (__cdecl *)(GstObject *,gpointer)' to 'xmlNodePtr (__cdecl *)(GstObject *,xmlNodePtr)'` Some kind of missing cast inside gstreamer.
  * `Warning MSB8012: TargetPath does not match the Linker's OutputFile property value`   This is caused by VS2010 having tighter requirements for the use of `OutDir` project variable than VS2008 did. I haven't found a way to disable this warning, so only way to fix it would be to change the usage of `OutDir` at every point where it is referenced.

# Creating a distribution package #
  * Run `Packaging\make_full_package.bat`. A distribution folder will be generated under the Deployment folder.