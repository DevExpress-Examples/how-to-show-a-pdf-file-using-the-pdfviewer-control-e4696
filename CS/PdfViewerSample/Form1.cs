using System;
using System.Windows.Forms;

namespace PdfViewerSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.pdfViewer1.LoadDocument(@"..\..\Report.pdf");
        }
    }
}
