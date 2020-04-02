namespace MarcusW.VncClient.Rendering
{
    /// <summary>
    /// Provides access to the target framebuffer for rendering frames.
    /// </summary>
    /// <remarks>
    /// This is an abstraction around the different framebuffer access methods for rendering backends like Avalonia (Skia, Direct2D, ...) and others.
    /// </remarks>
    public interface IFramebufferSource
    {
        /// <summary>
        /// Locks the native framebuffer in memory and returns a reference to it. The returned object should be disposed after rendering is finished.
        /// </summary>
        /// <param name="frameSize">The required frame size.</param>
        /// <returns>Framebuffer reference</returns>
        IFramebufferReference GrabReference(FrameSize frameSize);
    }
}
