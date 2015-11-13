namespace AppSoftwareMassImageOptimizer
{
    /// <summary>
    /// Summary description for ImageFormatIdentifier
    /// </summary>
    public class ImageFormatIdentifier
    {
        public ImageFormatIdentifier()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        /// <summary>
        /// Takes a file extension and if recognised as an image, converts it to ImageFormatEnum
        /// </summary>
        /// <param name="fileExtention"></param>
        /// <returns></returns>
        public static ImageFormatEnum GetImageFormat(string fileExtention)
        {
            // Ensure the extension is in lower case
            fileExtention = fileExtention.ToLower();

            ImageFormatEnum imageFormat;

            switch (fileExtention)
            {
                case ".bmp":

                    imageFormat = ImageFormatEnum.bmp;
                    break;

                case ".jpeg":

                    imageFormat = ImageFormatEnum.jpeg;
                    break;

                case ".jpg":

                    imageFormat = ImageFormatEnum.jpeg;
                    break;

                case ".gif":

                    imageFormat = ImageFormatEnum.gif;
                    break;

                case ".tiff":

                    imageFormat = ImageFormatEnum.tiff;
                    break;

                case ".png":

                    imageFormat = ImageFormatEnum.png;
                    break;

                default:

                    imageFormat = ImageFormatEnum.unrecognised;
                    break;
            }

            return imageFormat;
        }
    }
}
