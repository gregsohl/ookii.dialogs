using System;
using System.ComponentModel.Design;
using System.Reflection;

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
            Type typeTaskDialog = Component.GetType();
            MethodInfo showDlg = typeTaskDialog.GetMethod("ShowDialog", Type.EmptyTypes);
            if (showDlg != null) showDlg.Invoke(Component, null);
        }
    }
}