using ColorCode.WFP;
using System.Windows;
using System.Windows.Documents;

namespace ColorCode.WPFTests
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var csharpstring = "public void Method()\n{\n}";
            var formatter2 = new RichTextBlockFormatter();
            formatter2.FormatRichTextBlock(csharpstring, Languages.CSharp, htmlbox1.Document);

            var paragraph = new Paragraph();
            var formatter = new RichTextBlockFormatter(true);
            formatter.FormatInlines(csharpstring, Languages.CSharp, paragraph.Inlines);
            htmlbox2.Document.Blocks.Add(paragraph);
        }
    }
}
