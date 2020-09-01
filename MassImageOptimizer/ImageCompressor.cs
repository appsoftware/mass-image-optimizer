using System.Drawing;
using System.Drawing.Imaging;

namespace AppSoftware.MassImageOptimizer
{
    /// <summary>
    /// Summary description for ImageCompressor
    /// </summary>
    public class ImageCompressor
    {
        /// <summary>
        /// Compresses the image to a quality suitable for display on the web, and saves the 
        /// compressed file to disk
        /// </summary>
        /// <param name="imageToSave"></param>
        /// <param name="savePath"></param>
        /// <param name="imageFormat"></param>
        /// <param name="quality"></param>
        public void CompressAndSaveImage(Bitmap imageToSave, string savePath, ImageFormatEnum imageFormat, int quality)
        {
            EncoderParameters encoderParams = new EncoderParameters();

            long[] imageQuality = new long[1];

            imageQuality[0] = quality;

            EncoderParameter encParameter = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, imageQuality);
            encoderParams.Param[0] = encParameter;


            ImageCodecInfo imageCodecInfo = GetImageCodecInfo( imageFormat );

            imageToSave.Save(savePath, imageCodecInfo, encoderParams);

            imageToSave.Dispose();
        }


        /// <summary>
        /// Get the correct codec for this image based on the type of image that has been uploaded
        /// </summary>
        /// <param name="imageFormat"></param>
        /// <returns></returns>
        private ImageCodecInfo GetImageCodecInfo(ImageFormatEnum imageFormat)
        {
            ImageCodecInfo[] imageCodecArray = ImageCodecInfo.GetImageEncoders();

            ImageCodecInfo imageCodec;

            switch (imageFormat)
            {
                case ImageFormatEnum.bmp:

                    imageCodec = imageCodecArray[0];
                    break;

                case ImageFormatEnum.jpeg:

                    imageCodec = imageCodecArray[1];
                    break;
                case ImageFormatEnum.jpg:

                    imageCodec = imageCodecArray[1];
                    break;

                case ImageFormatEnum.gif:

                    imageCodec = imageCodecArray[2];
                    break;

                case ImageFormatEnum.tiff:

                    imageCodec = imageCodecArray[3];
                    break;

                case ImageFormatEnum.png:

                    imageCodec = imageCodecArray[4];
                    break;

                default:
                    imageCodec = null;
                    break;
            }

            return imageCodec;
        }
    }
}
