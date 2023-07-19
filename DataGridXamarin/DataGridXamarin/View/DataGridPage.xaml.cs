using Syncfusion.Data;
using Syncfusion.Data.Extensions;
using Syncfusion.SfDataGrid.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace DataGridXamarin
{
    public partial class DataGridPage : ContentPage
    {
        public DataGridPage()
        {
            InitializeComponent();
            this.dataGrid.PropertyChanged += DataGrid_PropertyChanged;
        }

        private void DataGrid_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Renderer")
            {
                DependencyService.Get<IKeyIntraction>().OnKeyDown(this.dataGrid);
            }
        }
    }


}