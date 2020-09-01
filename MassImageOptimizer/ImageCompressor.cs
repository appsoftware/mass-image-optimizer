using System.Drawing;
using System.Drawing.Imaging;

namespace AppSoftware.MassImageOptimizer
{
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
        public void CompressAndSaveImage(Bitmap imageToSave, string savePath, ImageFormat imageFormat, int quality)
        {
            EncoderParameters encoderParams = new EncoderParameters();

            long[] imageQuality = new long[1];

            imageQuality[0] = quality;

            EncoderParameter encParameter = new EncoderParameter(Encoder.Quality, imageQuality);
            encoderParams.Param[0] = encParameter;


            ImageCodecInfo imageCodecInfo = GetImageCodecInfo(imageFormat);

            imageToSave.Save(savePath, imageCodecInfo, encoderParams);

            imageToSave.Dispose();
        }


        /// <summary>
        /// Get the correct codec for this image based on the type of image that has been uploaded
        /// </summary>
        /// <param name="imageFormat"></param>
        /// <returns></returns>
        private ImageCodecInfo GetImageCodecInfo(ImageFormat imageFormat)
        {
            ImageCodecInfo[] imageCodecArray = ImageCodecInfo.GetImageEncoders();

            ImageCodecInfo imageCodec;

            switch (imageFormat)
            {
                case ImageFormat.Bmp:

                    imageCodec = imageCodecArray[0];
                    break;

                case ImageFormat.Jpeg:

                    imageCodec = imageCodecArray[1];
                    break;
                case ImageFormat.Jpg:

                    imageCodec = imageCodecArray[1];
                    break;

                case ImageFormat.Gif:

                    imageCodec = imageCodecArray[2];
                    break;

                case ImageFormat.Tiff:

                    imageCodec = imageCodecArray[3];
                    break;

                case ImageFormat.Png:

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
