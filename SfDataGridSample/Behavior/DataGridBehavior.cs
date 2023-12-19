using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridSample.Behaviors
{
    public class DataGridBehavior : Behavior<Button>
    {
        protected override void OnAttachedTo(Button button)
        {
            base.OnAttachedTo(button);
            button.Clicked += OnButtonClicked;
        }

        protected override void OnDetachingFrom(Button button)
        {
            base.OnDetachingFrom(button);
            button.Clicked -= OnButtonClicked;
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            var data = ((sender as Button).BindingContext as Employee);
            data.EmployeeStatus = true;
        }
    }
}
