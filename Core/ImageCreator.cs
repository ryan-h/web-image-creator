using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.IO;

namespace WebImageCreator.Core
{
    class ImageCreator
    {
        /// <summary>
        /// Creates a new optimized jpeg image based on the original.
        /// </summary>
        /// <param name="objOriginalImage"></param>
        /// <param name="nMaxWidth"></param>
        /// <param name="nMaxHeight"></param>
        /// <param name="nJPGQualityPercentage"></param>
        /// <returns>Image Data</returns>
        public static Byte[] Create(Image objOriginalImage, Int32 nMaxWidth, Int32 nMaxHeight, Int64 nJPGQualityPercentage)
        {
            Bitmap objNewImage = null;
            Graphics objGraphics = null;
            EncoderParameters objEncoderParameters = new EncoderParameters(1);
            SizeF sizeMax, sizeNewImage;
            Byte[] arrImageData = null;

            try
            {
                //setup dimensions for the new image
                sizeMax = new SizeF(nMaxWidth, nMaxHeight);
                sizeNewImage = GetImageDimensions(objOriginalImage.Size, sizeMax);

                //create the new empty image
                objNewImage = new Bitmap((int)sizeNewImage.Width, (int)sizeNewImage.Height);

                //set the original resolution
                objNewImage.SetResolution(objOriginalImage.HorizontalResolution, objOriginalImage.VerticalResolution);

                //draw the new optimized image from the original
                objGraphics = Graphics.FromImage(objNewImage);
                objGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                objGraphics.CompositingMode = CompositingMode.SourceCopy;
                objGraphics.CompositingQuality = CompositingQuality.HighQuality;
                objGraphics.SmoothingMode = SmoothingMode.HighQuality;
                objGraphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                objGraphics.DrawImage(objOriginalImage, 0, 0, sizeNewImage.Width, sizeNewImage.Height);

                try
                {
                    //maintain original exif properties, also create/update the 'program' property
                    foreach (PropertyItem propExif in objOriginalImage.PropertyItems)
                    {
                        objNewImage.SetPropertyItem(propExif);
                    }
                    objNewImage.SetPropertyItem(GetProgramPropItem());
                }
                catch (Exception ex)
                {
                    //continue image creation without exif information
                    Core.Diagnostics.LogException(ex, "Core.ImageCreator.Create_Exif_Props", false);
                }

                //setup encoder for jpeg quality percentage
                objEncoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, nJPGQualityPercentage);

                using (MemoryStream strmNewImage = new MemoryStream())
                {
                    //save the new jpeg image
                    objNewImage.Save(strmNewImage, GetEncoderInfo("image/jpeg"), objEncoderParameters);

                    //write the new image to a byte array for return
                    arrImageData = strmNewImage.ToArray();
                }
            }
            finally
            {
                objEncoderParameters.Dispose();
                objEncoderParameters = null;
                if (objNewImage != null)
                {
                    objNewImage.Dispose();
                    objNewImage = null;
                }
                if (objGraphics != null)
                {
                    objGraphics.Dispose();
                    objGraphics = null;
                }
            }

            return arrImageData;
        }

        /// <summary>
        /// Gets a file name for the new optimized image.
        /// </summary>
        /// <param name="szOrigImageName"></param>
        /// <param name="szFileNameSuffix"></param>
        /// <returns>filename</returns>
        public static String GetNewImageName(String szOrigImageName, String szFileNameSuffix)
        {
            string szName = Path.GetFileNameWithoutExtension(szOrigImageName);
            string szExt = Path.GetExtension(szOrigImageName).ToLower();

            if (!(szExt.Equals(".jpg") || szExt.Equals(".jpeg")))
            {
                szExt = ".jpg";
            }

            return String.Concat(szName, szFileNameSuffix, szExt);
        }

        #region Private Methods

        private static ImageCodecInfo GetEncoderInfo(String szMimeType)
        {
            ImageCodecInfo[] objEncoders = ImageCodecInfo.GetImageEncoders();
            for (int i = 0; i < objEncoders.Length; i++)
            {
                if (objEncoders[i].MimeType.Equals(szMimeType))
                {
                    return objEncoders[i];
                }
            }
            return null;
        }

        private static SizeF GetImageDimensions(SizeF sizeOriginal, SizeF sizeMax)
        {
            //new image is smaller than max
            if ((sizeMax.Width > sizeOriginal.Width) && (sizeMax.Height > sizeOriginal.Height))
            {
                return sizeOriginal;
            }

            //get the new dimensions based on the max
            Single nAspect = (sizeOriginal.Width / sizeOriginal.Height);
            if (sizeOriginal.Width >= sizeOriginal.Height)
            {
                return new SizeF(sizeMax.Width, (sizeMax.Width / nAspect));
            }
            else
            {
                return new SizeF((sizeMax.Height * nAspect), sizeMax.Height);
            }
        }

        private static PropertyItem GetProgramPropItem()
        {
            Bitmap objImage = null;
            PropertyItem objPropItem = null;

            try
            {
                objImage = (Bitmap)Properties.Resources.EmptyWithProperties;
                if (objImage != null)
                {
                    objPropItem = objImage.GetPropertyItem(305);
                }
            }
            finally
            {
                if (objImage != null)
                {
                    objImage.Dispose();
                    objImage = null;
                }
            }

            return objPropItem;
        }

        #endregion
    }
}
