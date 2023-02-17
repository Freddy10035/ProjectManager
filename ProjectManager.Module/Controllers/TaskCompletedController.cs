using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Pdf.Native.BouncyCastle.X509;
using ProjectManager.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Module.Controllers
{
        public class TaskCompletedController : ViewController
        {
            SimpleAction Complete;
            public TaskCompletedController()
            {
                TargetObjectType = typeof(ProjectTask);

                Complete = new SimpleAction(this, "Complete", DevExpress.Persistent.Base.PredefinedCategory.Edit);
                Complete.SelectionDependencyType = SelectionDependencyType.RequireSingleObject;
                Complete.Execute += Complete_Execute;
            }

            private void Complete_Execute(object sender, SimpleActionExecuteEventArgs e)
            {
                // throw new NotImplementedException();
                var currentObj = e.CurrentObject as ProjectTask;
                if (currentObj != null)
                {
                    currentObj.Status = Status.Completed;
                   // ObjectSpace.CommitChanges();
                }

                if (this.ObjectSpace.IsModified)
                    this.ObjectSpace.CommitChanges();
            }

            protected override void OnActivated()
            {
                base.OnActivated();
                // Perform various tasks depending on the target View.
            }
            protected override void OnViewControlsCreated()
            {
                base.OnViewControlsCreated();
                // Access and customize the target View control.
            }
            protected override void OnDeactivated()
            {
                // Unsubscribe from previously subscribed events and release other references and resources.
                base.OnDeactivated();
            }
        }
}
