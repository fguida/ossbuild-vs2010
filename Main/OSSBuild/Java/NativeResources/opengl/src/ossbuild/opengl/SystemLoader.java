
package ossbuild.opengl;

import ossbuild.NativeResource;
import ossbuild.Sys;

/**
 *
 * @author David Hoyt <dhoyt@hoytsoft.org>
 */
public class SystemLoader extends ossbuild.init.SystemLoader {
	@Override
	public void load() throws Throwable {
		Sys.loadNativeResources(NativeResource.OpenGL);
	}

	@Override
	public void unload() throws Throwable {
	}
}
