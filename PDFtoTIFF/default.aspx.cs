using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using java.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PDFtoTIFF
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String path = "C:\\";
            PDDocument doc = PDDocument.loadNonSeq(new File(path),null);
        }

        
    }
}