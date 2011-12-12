
package ossbuild.media.gstreamer.api;

import com.sun.jna.Pointer;
import java.lang.reflect.Constructor;
import ossbuild.media.gstreamer.INativeObject;

/**
 *
 * @author David Hoyt <dhoyt@hoytsoft.org>
 */
public class GTypeCacheRecord implements IGTypeCacheRecord {
	//<editor-fold defaultstate="collapsed" desc="Variables">
	private Class<? extends INativeObject> cls;
	private Constructor<? extends INativeObject> constructor;
	//</editor-fold>

	//<editor-fold defaultstate="collapsed" desc="Initialization">
	public GTypeCacheRecord(Class<? extends INativeObject> cls) {
		init(cls);
	}

	private void init(Class<? extends INativeObject> cls) {
		try {
			this.cls = cls;
			this.constructor = cls.getDeclaredConstructor(Pointer.class);
			this.constructor.setAccessible(true);
		} catch(Throwable t) {
			throw new RuntimeException(t);
		}
	}
	//</editor-fold>

	//<editor-fold defaultstate="collapsed" desc="Getters">
	@Override
	public Class<? extends INativeObject> getJavaClass() {
		return cls;
	}

	public Constructor<? extends INativeObject> getJavaConstructor() {
		return constructor;
	}
	//</editor-fold>

	@Override
	public INativeObject instantiateFromPointer(Pointer ptr) {
		try {
			return constructor.newInstance(ptr);
		} catch(Throwable t) {
			return null;
		}
	}
}
