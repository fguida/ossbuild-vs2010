
package ossbuild.media.gstreamer;

import com.sun.jna.Pointer;
import java.util.concurrent.TimeUnit;

/**
 *
 * @author David Hoyt <dhoyt@hoytsoft.org>
 */
public interface IElement extends IGObject {
	String getName();
	boolean hasParent();
	
	int getFactoryRank();
	String getFactoryName();
	String getFactoryClass();
	
	State requestState();
	State requestState(long timeout);
	State requestState(TimeUnit unit, long timeout);
	StateChangeReturn changeState(State state);

	boolean setCaps(Caps caps);

	long getBaseTime();
	long getStartTime();

	boolean sendEvent(Event ev);

	Pad staticPad(String name);
	boolean addPad(Pad pad);
	boolean removePad(Pad pad);
	boolean postMessage(Message msg);
	boolean postMessage(Pointer msg);
	boolean postStateChangeMessage(State state);
	boolean postStateChangeMessage(State oldState, State newState, State pending);

	void visitPads(IPadVisitor visitor);
	void visitSrcPads(IPadVisitor visitor);
	void visitSinkPads(IPadVisitor visitor);

	//<editor-fold defaultstate="collapsed" desc="Visitors">
	public static interface IPadVisitor {
		boolean visit(IElement src, Pad pad);
	}
	//</editor-fold>
}
