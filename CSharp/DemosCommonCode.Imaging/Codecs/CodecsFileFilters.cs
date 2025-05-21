using System.Windows.Forms;

using Vintasoft.Imaging.Codecs.Decoders;
using Vintasoft.Imaging.Codecs.Encoders;

namespace DemosCommonCode.Imaging.Codecs
{
    /// <summary>
    /// Contains filters for Open/Save dialogs.
    /// </summary>
    public class CodecsFileFilters
    {

        #region Constants


        /// <summary>
        /// The file filter for image files.
        /// </summary>
        static string IMAGE_FILES_DIALOG_FILTER =
            "BMP Files|*.bmp|" +
            "JPEG Files|*.jpg;*.jpeg;*.jfif|" +
            "PBM/PGM/PPM files|*.pbm;*.pgm;*.ppm|" +
            "PNG Files|*.png|" +
            "PSD Files|*.psd|" +
            "SVG Files|*.svg|" +
            "TGA files|*.tga|" +
            "TIFF Files|*.tif;*.tiff|" +
            "GIF Files|*.gif|" +
            "PCX Files|*.pcx";

        /// <summary>
        /// The file filter for all image files.
        /// </summary>
        const string ALL_IMAGE_FILES_DIALOG_FILTER = "All Image Files|*.bmp;*.gif;*.jpg;*.jpeg;*.jfif;*.pbm;*.pgm;*.ppm;*.pcx;*.png;*.psd;*.svg;*.tga;*.tif;*.tiff;";

        /// <summary>
        /// The other image files extensions.
        /// </summary>
        const string OTHER_IMAGE_FILES_EXTENSIONS = "*.psd;*.cur;*.emf;*.ico;*.jls;*.wmf;";

        /// <summary>
        /// The file filter for other image files.
        /// </summary>
        static string OTHER_IMAGE_FILES_DIALOG_FILTER = 
            "PSD Files|*.psd|" +
            "Cursor Files|*.cur|" +
            "EMF Files|*.emf|" +
            "Icon Files|*.ico|" +
            "JPEG-LS Files|*.jls|" +
            "WMF Files|*.wmf";

        /// <summary>
        /// The file filter for TIFF files.
        /// </summary>
        const string TIFF_FILE_DIALOG_FILTER = "TIFF Files|*.tif;*.tiff";

        /// <summary>
        /// The file filter for JPEG files.
        /// </summary>
        const string JPEG_FILE_DIALOG_FILTER = "JPEG Files|*.jpg;*.jpeg;*.jfif";

        /// <summary>
        /// The PDF file extensions.
        /// </summary>
        const string PDF_FILE_EXTENSIONS = "*.pdf";
        /// <summary>
        /// The file filter for PDF files.
        /// </summary>
        const string PDF_FILE_DIALOG_FILTER = "PDF Files|" + PDF_FILE_EXTENSIONS;

        /// <summary>
        /// The GIF files extension.
        /// </summary>
        const string GIF_FILE_EXTENSIONS = "*.gif";
        /// <summary>
        /// The file filter for GIF files.
        /// </summary>
        const string GIF_FILE_DIALOG_FILTER = "GIF Files|" + GIF_FILE_EXTENSIONS;

        /// <summary>
        /// The PNG file extensions.
        /// </summary>
        const string PNG_FILE_EXTENSIONS = "*.png";
        /// <summary>
        /// The file filter for PNG files.
        /// </summary>
        const string PNG_FILE_DIALOG_FILTER = "PNG Files|" + PNG_FILE_EXTENSIONS;

        /// <summary>
        /// The JBIG2 file extensions.
        /// </summary>
        const string JBIG2_FILE_EXTENSIONS = "*.jb2;*.jbig2";
        /// <summary>
        /// The file filter for JBIG2 files.
        /// </summary>
        const string JBIG2_FILE_DIALOG_FILTER = "JBIG2 Files|" + JBIG2_FILE_EXTENSIONS;

        /// <summary>
        /// The JPEG2000 file extensions.
        /// </summary>
        const string JPEG2000_FILE_EXTENSIONS = "*.jp2;*.j2k;*.j2c;*.jpc";
        /// <summary>
        /// The file filter for JPEG2000 files.
        /// </summary>
        const string JPEG2000_FILE_DIALOG_FILTER = "JPEG 2000 Files|" + JPEG2000_FILE_EXTENSIONS;

        /// <summary>
        /// The RAW file extensions.
        /// </summary>
        const string RAW_FILE_EXTENSIONS = "*.cr2;*.crw;*.nef;*.nrw;*.dng;*.arw";
        /// <summary>
        /// The file filter for RAW files.
        /// </summary>
        const string RAW_FILE_DIALOG_FILTER = "RAW Image Files|" + RAW_FILE_EXTENSIONS;

        /// <summary>
        /// The WEBP file extensions.
        /// </summary>
        const string WEBP_FILE_EXTENSIONS = "*.webp";
        /// <summary>
        /// The file filter for WEBP files.
        /// </summary>
        const string WEBP_FILE_DIALOG_FILTER = "WEBP Image Files|" + WEBP_FILE_EXTENSIONS;

        /// <summary>
        /// The XPS file extensions.
        /// </summary>
        const string XPS_FILE_EXTENSIONS = "*.xps";
        /// <summary>
        /// The file filter for XPS files.
        /// </summary>
        const string XPS_FILE_DIALOG_FILTER = "XPS Files|" + XPS_FILE_EXTENSIONS;

        /// <summary>
        /// The WSI file extensions.
        /// </summary>
        const string WSI_FILE_EXTENSIONS = "*.ndpi;*.vms";
        /// <summary>
        /// The file filter for DICOM files.
        /// </summary>
        const string WSI_FILE_DIALOG_FILTER = "WSI (Whole-Slide image) files|" + WSI_FILE_EXTENSIONS;


        /// <summary>
        /// The DICOM file extensions.
        /// </summary>
        const string DICOM_FILE_EXTENSIONS = "*.dcm;*.dic;*.acr";
        /// <summary>
        /// The file filter for DICOM files.
        /// </summary>
        const string DICOM_FILE_DIALOG_FILTER = "DICOM files|" + DICOM_FILE_EXTENSIONS;

        /// <summary>
        /// The DOCX file extensions.
        /// </summary>
        const string DOCX_FILE_EXTENSIONS = "*.docx";
        /// <summary>
        /// The file filter for DOCX files.
        /// </summary>
        const string DOCX_FILE_DIALOG_FILTER = "DOCX files|" + DOCX_FILE_EXTENSIONS;

        /// <summary>
        /// The DOCX file extensions.
        /// </summary>
        const string DOC_FILE_EXTENSIONS = "*.doc";
        /// <summary>
        /// The file filter for DOC files.
        /// </summary>
        const string DOC_FILE_DIALOG_FILTER = "DOC files|" + DOC_FILE_EXTENSIONS;

        /// <summary>
        /// The XLSX file extensions.
        /// </summary>
        const string XLSX_FILE_EXTENSIONS = "*.xlsx";
        /// <summary>
        /// The file filter for XLSX files.
        /// </summary>
        const string XLSX_FILE_DIALOG_FILTER = "XLSX files|" + XLSX_FILE_EXTENSIONS;

        /// <summary>
        /// The XLS file extensions.
        /// </summary>
        const string XLS_FILE_EXTENSIONS = "*.xls";
        /// <summary>
        /// The file filter for XLSX files.
        /// </summary>
        const string XLS_FILE_DIALOG_FILTER = "XLS files|" + XLS_FILE_EXTENSIONS;

        /// <summary>
        /// The TSV file extensions.
        /// </summary>
        const string TSV_FILE_EXTENSIONS = "*.tsv;*.tab";
        /// <summary>
        /// The file filter for TSV files.
        /// </summary>
        const string TSV_FILE_DIALOG_FILTER = "TSV files|" + TSV_FILE_EXTENSIONS;

        /// <summary>
        /// The CSV file extensions.
        /// </summary>
        const string CSV_FILE_EXTENSIONS = "*.csv";
        /// <summary>
        /// The file filter for CSV files.
        /// </summary>
        const string CSV_FILE_DIALOG_FILTER = "CSV files|" + CSV_FILE_EXTENSIONS;

        /// <summary>
        /// The SVG file extensions.
        /// </summary>
        const string SVG_FILE_EXTENSIONS = "*.svg";

        /// <summary>
        /// The file filter for SVG files.
        /// </summary>
        const string SVG_FILE_DIALOG_FILTER = "SVG Files|" + SVG_FILE_EXTENSIONS;

        /// <summary>
        /// The RTF file extensions.
        /// </summary>
        const string RTF_FILE_EXTENSIONS = "*.rtf";

        /// <summary>
        /// The file filter for RTF files.
        /// </summary>
        const string RTF_FILE_DIALOG_FILTER = "RTF Files|" + RTF_FILE_EXTENSIONS;

        /// <summary>
        /// The HTML file extensions.
        /// </summary>
        const string HTML_FILE_EXTENSIONS = "*.html;*.htm";

        /// <summary>
        /// The file filter for HTML files.
        /// </summary>
        const string HTML_FILE_DIALOG_FILTER = "HTML Files|" + HTML_FILE_EXTENSIONS;

        /// <summary>
        /// The ODT file extensions.
        /// </summary>
        const string ODT_FILE_EXTENSIONS = "*.odt";

        /// <summary>
        /// The file filter for ODT files.
        /// </summary>
        const string ODT_FILE_DIALOG_FILTER = "ODT Files|" + ODT_FILE_EXTENSIONS;

        /// <summary>
        /// The ODT file extensions.
        /// </summary>
        const string ODS_FILE_EXTENSIONS = "*.ods";

        /// <summary>
        /// The file filter for ODT files.
        /// </summary>
        const string ODS_FILE_DIALOG_FILTER = "ODS Files|" + ODS_FILE_EXTENSIONS;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CodecsFileFilters"/> class.
        /// </summary>
        public CodecsFileFilters()
        {
        }

        #endregion



        #region Properties

        #region Decoders

        static string _imageDecoderFilter = null;
        /// <summary>
        /// Gets the file filter for image file decoders.
        /// </summary>
        public static string ImageDecoderFilter
        {
            get
            {
                if (_imageDecoderFilter == null)
                    InitImageDecoderFilter();
                return _imageDecoderFilter;
            }
        }

        static int _imageDecoderFilterDefaultIndex = -1;
        /// <summary>
        /// Gets the default index in file filter for image file decoders.
        /// </summary>
        public static int ImageDecoderFilterDefaultIndex
        {
            get
            {
                if (_imageDecoderFilterDefaultIndex == -1)
                    InitImageDecoderFilter();
                return _imageDecoderFilterDefaultIndex;
            }
        }

        #endregion


        #region Encoders

        static string _imageEncoderFilter = null;
        /// <summary>
        /// Gets the file filter for image file encoders.
        /// </summary>
        public static string ImageEncoderFilter
        {
            get
            {
                if (_imageEncoderFilter == null)
                    InitImageEncoderFilter();
                return _imageEncoderFilter;
            }
        }

        static int _imageEncoderFilterDefaultIndex = -1;
        /// <summary>
        /// Gets the default index in file filter for image file encoders.
        /// </summary>
        public static int ImageEncoderFilterDefaultIndex
        {
            get
            {
                if (_imageEncoderFilterDefaultIndex == -1)
                    InitImageEncoderFilter();
                return _imageEncoderFilterDefaultIndex;
            }
        }

        static string _multipageImageEncoderFilter = null;
        /// <summary>
        /// Gets the file filter for multipage image file encoders.
        /// </summary>
        public static string MultipageImageEncoderFilter
        {
            get
            {
                if (_multipageImageEncoderFilter == null)
                    InitMultipageImageEncoderFilter();
                return _multipageImageEncoderFilter;
            }
        }


        static int _multipageImageEncoderFilterDefaultIndex = -1;
        /// <summary>
        /// Gets the default index in file filter for multipage image file encoders.
        /// </summary>
        public static int MultipageImageEncoderFilterDefaultIndex
        {
            get
            {
                if (_multipageImageEncoderFilterDefaultIndex == -1)
                    InitMultipageImageEncoderFilter();
                return _multipageImageEncoderFilterDefaultIndex;
            }
        }


        static string _imageEncoderWithAnnotationsFilter = null;
        /// <summary>
        /// Gets the file filter for image file encoders with annotation support.
        /// </summary>
        public static string ImageEncoderWithAnnotationsFilter
        {
            get
            {
                if (_imageEncoderWithAnnotationsFilter == null)
                    InitImageEncoderWithAnnotationsFilter();
                return _imageEncoderWithAnnotationsFilter;
            }
        }

        static int _imageEncoderWithAnnotationsFilterDefaultIndex = -1;
        /// <summary>
        /// Gets the default index in file filter for image file encoders with annotation support.
        /// </summary>
        public static int ImageEncoderWithAnnotationsFilterDefaultIndex
        {
            get
            {
                if (_imageEncoderWithAnnotationsFilterDefaultIndex == -1)
                    InitImageEncoderWithAnnotationsFilter();
                return _imageEncoderWithAnnotationsFilterDefaultIndex;
            }
        }

        static string _multipageImageEncoderWithAnnotationsFilter = null;
        /// <summary>
        /// Gets the file filter for multipage image file encoders with annotation support.
        /// </summary>
        public static string MultipageEncoderFiltersWithAnnotations
        {
            get
            {
                if (_multipageImageEncoderWithAnnotationsFilter == null)
                    InitMultipageImageEncoderWithAnnotationsFilter();
                return _multipageImageEncoderWithAnnotationsFilter;
            }
        }

        static int _multipageImageEncoderWithAnnotationsFilterDefaultIndex = -1;
        /// <summary>
        /// Gets the default index in file filter for multipage image file encoders with annotation support.
        /// </summary>
        public static int MultipageEncoderWithAnnotationsFilterDefaultIndex
        {
            get
            {
                if (_multipageImageEncoderWithAnnotationsFilterDefaultIndex == -1)
                    InitMultipageImageEncoderWithAnnotationsFilter();
                return _multipageImageEncoderWithAnnotationsFilterDefaultIndex;
            }
        }

        #endregion

        #endregion



        #region Methods

        #region PUBLIC

        /// <summary>
        /// Sets the filter for open file dialog.
        /// </summary>
        /// <param name="dialog">The open file dialog.</param>
        public static void SetOpenFileDialogFilter(OpenFileDialog dialog)
        {
            try
            {
                dialog.Filter = ImageDecoderFilter;
                dialog.FilterIndex = ImageDecoderFilterDefaultIndex;
            }
            catch
            {
            }
        }

        /// <summary>
        /// Sets the filter for save file dialog.
        /// </summary>
        /// <param name="dialog">The save file dialog.</param>
        /// <param name="multipageOnly">A value indicating whether the image encoder must support multiple pages.</param>
        /// <param name="annotationsSupport">A value indicating whether the image encoder must support annotations.</param>
        public static void SetSaveFileDialogFilter(SaveFileDialog dialog, bool multipageOnly, bool annotationsSupport)
        {
            if (annotationsSupport)
            {
                if (multipageOnly)
                {
                    dialog.Filter = MultipageEncoderFiltersWithAnnotations;
                    dialog.FilterIndex = MultipageEncoderWithAnnotationsFilterDefaultIndex;
                }
                else
                {
                    dialog.Filter = ImageEncoderWithAnnotationsFilter;
                    dialog.FilterIndex = ImageEncoderWithAnnotationsFilterDefaultIndex;
                }
                dialog.OverwritePrompt = false;
                dialog.DefaultExt = ".tif";
            }
            else
            {
                try
                {
                    if (multipageOnly)
                    {
                        dialog.Filter = MultipageImageEncoderFilter;
                        dialog.FilterIndex = MultipageImageEncoderFilterDefaultIndex;
                        dialog.DefaultExt = ".tif";
                    }
                    else
                    {
                        dialog.Filter = ImageEncoderFilter;
                        dialog.FilterIndex = ImageEncoderFilterDefaultIndex;
                        dialog.DefaultExt = ".png";
                    }
                    dialog.OverwritePrompt = false;
                }
                catch
                {
                }
            }
        }

        #endregion


        #region PRIVATE

        #region Decoders

        /// <summary>
        /// Inits the image decoder filter.
        /// </summary>
        static void InitImageDecoderFilter()
        {
            string filter1 = string.Format("{0}|{1}", IMAGE_FILES_DIALOG_FILTER, OTHER_IMAGE_FILES_DIALOG_FILTER);
            string filter2 = ALL_IMAGE_FILES_DIALOG_FILTER + OTHER_IMAGE_FILES_EXTENSIONS;
            _imageDecoderFilterDefaultIndex = 17;

            // if JBIG2 decoder is available
            if (AvailableDecoders.IsDecoderAvailable("Jbig2"))
            {
                filter1 += "|" + JBIG2_FILE_DIALOG_FILTER;
                filter2 += JBIG2_FILE_EXTENSIONS + ";";
                _imageDecoderFilterDefaultIndex++;
            }

            // if PDF decoder is available
            if (AvailableDecoders.IsDecoderAvailable("Pdf"))
            {
                filter1 += "|" + PDF_FILE_DIALOG_FILTER;
                filter2 += PDF_FILE_EXTENSIONS + ";";
                _imageDecoderFilterDefaultIndex++;
            }

            // if DOCX decoder is available
            if (AvailableDecoders.IsDecoderAvailable("Docx"))
            {
                filter1 += "|" + DOCX_FILE_DIALOG_FILTER;
                filter2 += DOCX_FILE_EXTENSIONS + ";";
                _imageDecoderFilterDefaultIndex++;

                filter1 += "|" + DOC_FILE_DIALOG_FILTER;
                filter2 += DOC_FILE_EXTENSIONS + ";";
                _imageDecoderFilterDefaultIndex++;

                filter1 += "|" + RTF_FILE_DIALOG_FILTER;
                filter2 += RTF_FILE_EXTENSIONS + ";";
                _imageDecoderFilterDefaultIndex++;

                filter1 += "|" + HTML_FILE_DIALOG_FILTER;
                filter2 += HTML_FILE_EXTENSIONS + ";";
                _imageDecoderFilterDefaultIndex++;

                filter1 += "|" + ODT_FILE_DIALOG_FILTER;
                filter2 += ODT_FILE_EXTENSIONS + ";";
                _imageDecoderFilterDefaultIndex++;
            }

            // if XLSX decoder is available
            if (AvailableDecoders.IsDecoderAvailable("Xlsx"))
            {
                filter1 += "|" + XLSX_FILE_DIALOG_FILTER;
                filter2 += XLSX_FILE_EXTENSIONS + ";";
                _imageDecoderFilterDefaultIndex++;

                filter1 += "|" + XLS_FILE_DIALOG_FILTER;
                filter2 += XLS_FILE_EXTENSIONS + ";";
                _imageDecoderFilterDefaultIndex++;

                filter1 += "|" + TSV_FILE_DIALOG_FILTER;
                filter2 += TSV_FILE_EXTENSIONS + ";";
                _imageDecoderFilterDefaultIndex++;

                filter1 += "|" + CSV_FILE_DIALOG_FILTER;
                filter2 += CSV_FILE_EXTENSIONS + ";";
                _imageDecoderFilterDefaultIndex++;

                filter1 += "|" + ODS_FILE_DIALOG_FILTER;
                filter2 += ODS_FILE_EXTENSIONS + ";";
                _imageDecoderFilterDefaultIndex++;
            }

            // if JPEG2000 decoder is available
            if (AvailableDecoders.IsDecoderAvailable("Jpeg2000"))
            {
                filter1 += "|" + JPEG2000_FILE_DIALOG_FILTER;
                filter2 += JPEG2000_FILE_EXTENSIONS + ";";
                _imageDecoderFilterDefaultIndex++;
            }

            // if RAW decoder is available
            if (AvailableDecoders.IsDecoderAvailable("Raw"))
            {
                filter1 += "|" + RAW_FILE_DIALOG_FILTER;
                filter2 += RAW_FILE_EXTENSIONS + ";";
                _imageDecoderFilterDefaultIndex++;
            }

            // if WEBP decoder is available
            if (AvailableDecoders.IsDecoderAvailable("Webp"))
            {
                filter1 += "|" + WEBP_FILE_DIALOG_FILTER;
                filter2 += WEBP_FILE_EXTENSIONS + ";";
                _imageDecoderFilterDefaultIndex++;
            }

            // if XPS decoder is available
            if (AvailableDecoders.IsDecoderAvailable("Xps"))
            {
                filter1 += "|" + XPS_FILE_DIALOG_FILTER;
                filter2 += XPS_FILE_EXTENSIONS + ";";
                _imageDecoderFilterDefaultIndex++;
            }

            // if DICOM decoder is available
            if (AvailableDecoders.IsDecoderAvailable("Dicom"))
            {
                filter1 += "|" + DICOM_FILE_DIALOG_FILTER;
                filter2 += DICOM_FILE_EXTENSIONS + ";";
                _imageDecoderFilterDefaultIndex++;
            }

            // if WSI decoders (NDPI) is available
            if (AvailableDecoders.IsDecoderAvailable("Ndpi"))
            {
                filter1 += "|" + WSI_FILE_DIALOG_FILTER;
                filter2 += WSI_FILE_EXTENSIONS + ";";
                _imageDecoderFilterDefaultIndex++;
            }

            _imageDecoderFilter = string.Format("{0}|{1}", filter1, filter2);
        }

        #endregion


        #region Encoders

        /// <summary>
        /// Inits the image encoder filter.
        /// </summary>
        static void InitImageEncoderFilter()
        {
            string filter1 = IMAGE_FILES_DIALOG_FILTER;
            _imageEncoderFilterDefaultIndex = 4;

            filter1 += "|" + SVG_FILE_DIALOG_FILTER;

            // if JBIG2 encoder is available
            if (AvailableEncoders.IsEncoderAvailable("Jbig2"))
                filter1 += "|" + JBIG2_FILE_DIALOG_FILTER;

            // if PDF encoder is available
            if (AvailableEncoders.IsEncoderAvailable("Pdf"))
                filter1 += "|" + PDF_FILE_DIALOG_FILTER;

            // if JPEG encoder is available
            if (AvailableEncoders.IsEncoderAvailable("Jpeg2000"))
                filter1 += "|" + JPEG2000_FILE_DIALOG_FILTER;

            _imageEncoderFilter = filter1;
        }

        /// <summary>
        /// Inits the multipage image encoder filter.
        /// </summary>
        static void InitMultipageImageEncoderFilter()
        {
            string filter1 = "TIFF Files|*.tif;*.tiff";
            _multipageImageEncoderFilterDefaultIndex = 0;

            // if JBIG2 encoder is available
            if (AvailableEncoders.IsEncoderAvailable("Jbig2"))
                filter1 += "|" + JBIG2_FILE_DIALOG_FILTER;

            // if PDF encoder is available
            if (AvailableEncoders.IsEncoderAvailable("Pdf"))
                filter1 += "|" + PDF_FILE_DIALOG_FILTER;

            filter1 += "|" + GIF_FILE_DIALOG_FILTER;

            _multipageImageEncoderFilter = filter1;
        }

        /// <summary>
        /// Inits the image encoder with annotations filter.
        /// </summary>
        static void InitImageEncoderWithAnnotationsFilter()
        {
            string filter1 = TIFF_FILE_DIALOG_FILTER;
            _imageEncoderWithAnnotationsFilterDefaultIndex = 0;

            // if PDF encoder is available
            if (AvailableEncoders.IsEncoderAvailable("Pdf"))
                filter1 += "|" + PDF_FILE_DIALOG_FILTER;

            filter1 += "|" + JPEG_FILE_DIALOG_FILTER;

            filter1 += "|" + JPEG2000_FILE_DIALOG_FILTER;

            filter1 += "|" + PNG_FILE_DIALOG_FILTER;

            _imageEncoderWithAnnotationsFilter = filter1;
        }

        /// <summary>
        /// Inits the multipage image encoder with annotations filter.
        /// </summary>
        static void InitMultipageImageEncoderWithAnnotationsFilter()
        {
            string filter1 = TIFF_FILE_DIALOG_FILTER;
            _multipageImageEncoderWithAnnotationsFilterDefaultIndex = 0;

            // if PDF encoder is available
            if (AvailableEncoders.IsEncoderAvailable("Pdf"))
                filter1 += "|" + PDF_FILE_DIALOG_FILTER;

            _multipageImageEncoderWithAnnotationsFilter = filter1;
        }

        #endregion

        #endregion

        #endregion

    }
}
