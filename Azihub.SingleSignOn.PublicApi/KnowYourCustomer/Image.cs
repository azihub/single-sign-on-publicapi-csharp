namespace Azihub.SingleSignOn.PublicApi.KnowYourCustomer
{
    public class Image
    {
        private Image()
        {
        }

        /// <summary>
        /// Create Instance of Image
        /// </summary>
        /// <param name="bytes">Byte array</param>
        /// <param name="format">String Enum of Supported Format</param>
        public Image(byte[] bytes, Format format)
        {
            Bytes = bytes;
            Format = format;
        }
        public byte[] Bytes { get; set; }
        public Format Format { get; set; }
    }

    /// <summary>
    /// List of Selected supported format
    /// </summary>
    public class Format
    {
        private Format(string extension) { Extension = extension; }
        public string Extension { get; }

        public static Format Png => new Format("PNG");
        public static Format Jpg => new Format("JPG");
        public static Format Gif => new Format("GIF");
        public static Format Pdf => new Format("PDF");
        public static Format Tiff => new Format("TIFF");
    }
}