using System.Drawing;
using System.Globalization;

namespace AppSoftware.MassImageOptimizer
{
    /// <summary>
    /// Handles conversion of original image to display pictures and thumbs from a single image array.
    /// Returns Image arrays. Image sizing is defined in configuration.
    /// </summary>
    public class ImageResizer
    {
        /// <summary>
        /// Takes arguments of file path and required image dimemsions (px) - string, int, int
        /// </summary>
        /// <returns>A resized bitmap</returns>
        public static Bitmap ResizeBitmap( Bitmap originalBitmap, int requiredHeight, int requiredWidth )
        {
            // Pass dimensions to worker method depending on image type required

            var heightWidthRequiredDimensions = WorkDimensions(originalBitmap.Height, originalBitmap.Width, requiredHeight, requiredWidth);


            Bitmap resizedBitmap = new Bitmap( heightWidthRequiredDimensions[1], 
                                               heightWidthRequiredDimensions[0] ); 

            const float resolution = 72;

            resizedBitmap.SetResolution(resolution, resolution);

            Graphics graphic = Graphics.FromImage(resizedBitmap);

            graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphic.DrawImage( originalBitmap, 0, 0, resizedBitmap.Width, resizedBitmap.Height );

            graphic.Dispose();
            originalBitmap.Dispose();

            // resizedBitmap still in use

            return resizedBitmap;
        }

        /// <summary>
        /// Works dimensions based on maximum width and height compared to original dimensions.
        /// Passes out a required height and a required width that can be used with image
        /// conversion functions.
        /// </summary>
        private static int[] WorkDimensions(int originalHeight, int originalWidth, int requiredHeight, int requiredWidth )
        {
            int imgWidth = requiredHeight;
            int imgHeight = requiredWidth;
 

            int requiredHeightLocal = originalHeight;
            int requiredWidthLocal = originalWidth;

            double ratio;

            // Check height first
            // If original height exceeds maximum, get new height and work ratio.

            if ( originalHeight > imgHeight )
            {
                ratio = double.Parse( ((double) imgHeight / (double) originalHeight).ToString(CultureInfo.InvariantCulture));
                requiredHeightLocal = imgHeight;
                requiredWidthLocal = (int) ((decimal) originalWidth * (decimal) ratio );
            }

            // Check width second. It will most likely have been sized down enough 
            // in the previous if statement. If not, change both dimensions here by width.
            // If new width exceeds maximum, get new width and height ratio.
            if ( requiredWidthLocal >= imgWidth )
            {
                ratio = double.Parse(((double) imgWidth / (double) originalWidth).ToString(CultureInfo.InvariantCulture));
                requiredWidthLocal = imgWidth;
                requiredHeightLocal = (int) ((double) originalHeight * (double) ratio);
            }

            int[] heightWidthDimensionArr = { requiredHeightLocal, requiredWidthLocal };

            return heightWidthDimensionArr; 
        }
    }
}
