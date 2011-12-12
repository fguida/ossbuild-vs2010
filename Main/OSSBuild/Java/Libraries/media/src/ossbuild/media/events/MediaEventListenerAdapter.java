package ossbuild.media.events;

import ossbuild.media.IMediaPlayer;
import ossbuild.media.IMediaRequest;

public abstract class MediaEventListenerAdapter implements IMediaEventListener {
	@Override
	public void mediaPaused(IMediaPlayer source) {
	}

	@Override
	public void mediaContinued(IMediaPlayer source) {
	}

	@Override
	public void mediaStopped(IMediaPlayer source) {
	}

	@Override
	public void mediaPlayRequested(IMediaPlayer source, IMediaRequest request) {
	}

	@Override
	public void mediaPlayed(IMediaPlayer source) {
	}
}
