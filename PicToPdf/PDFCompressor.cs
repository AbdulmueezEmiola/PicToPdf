using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Pdf;
using Aspose.Pdf.Optimization;
namespace PicToPdf
{
    static class PDFCompressor
    {
        public static void compressFiles(string path, string optimizedPath)
        {
            Document document = new Document(path);
            var optimizeOptions = new OptimizationOptions();
            optimizeOptions.ImageCompressionOptions.CompressImages = true;
            optimizeOptions.ImageCompressionOptions.ImageQuality = 50;
            optimizeOptions.ImageCompressionOptions.ResizeImages = true;
            optimizeOptions.ImageCompressionOptions.MaxResolution = 300;
            document.OptimizeResources(optimizeOptions);
            document.Save(optimizedPath);
        }

    }
}
