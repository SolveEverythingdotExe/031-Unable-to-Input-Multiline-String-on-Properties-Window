using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace MainApplication
{
    public class MultilineStringEditor: UITypeEditor
    {
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            //get the service used by the "Properties Window" in displaying a windows form editor
            IWindowsFormsEditorService windowsFormsEditorService =
                provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;

            //create an instance of our input form
            InputForm inputForm = new InputForm((string)value);

            //show the form as a dialog
            windowsFormsEditorService.ShowDialog(inputForm);

            //return the "Value" or the inputted by the user in the form
            return inputForm.Value;
        }

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            //set the edit style as an ellipsis (...) on the properties window
            return UITypeEditorEditStyle.Modal;
        }
    }
}
