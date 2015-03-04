using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Ookii.Dialogs.Design
{
    public class TaskDialogDesigner : ComponentDesigner
    {
        public override DesignerVerbCollection Verbs
        {
            get
            {
                DesignerVerbCollection verbs = new DesignerVerbCollection();
                verbs.Add(new DesignerVerb(Properties.Resources.Preview, new EventHandler(Preview)));
                return verbs;
            }
        }

        private void Preview(object sender, EventArgs e)
        {
            //todo reflection
            //((TaskDialog)Component).ShowDialog();
        }
    }
}
