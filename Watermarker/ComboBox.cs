using System.ComponentModel;
using System.Windows.Forms;

namespace Watermarker
{
    public partial class ComboBox : System.Windows.Forms.ComboBox
    {
        public ComboBox()
        {
            InitializeComponent();

            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

        }

        public ComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
