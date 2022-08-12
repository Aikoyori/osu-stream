#if iOS || ANDROID
using OpenTK.Graphics.ES11;
#else
using OpenTK.Graphics.OpenGL;

#endif


namespace osum
{
    public static class Constants
    {
        public const double SIXTY_FRAME_TIME = (double)1000 / 60;
#if !DEBUG

        public static string request_url = "https://beatstream.aikoyori.xyz";
#else
        public const string request_url = "http://192.168.0.135:4500";
#endif
        //public static string request_url;
        public const string CALLBACK_SCHEME = "aikodiscordauthorize";

#if iOS
        public const int COLOR_BUFFER_BIT = (int)All.ColorBufferBit;
        public const int COLOR_DEPTH_BUFFER_BIT = (int)(All.ColorBufferBit | All.DepthBufferBit);

#else
        public const ClearBufferMask COLOR_BUFFER_BIT = ClearBufferMask.ColorBufferBit;
        public const ClearBufferMask COLOR_DEPTH_BUFFER_BIT = ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit;
#endif
    }
}
