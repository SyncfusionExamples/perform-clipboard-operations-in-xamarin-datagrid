using DataGridXamarin.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.Forms.Platform.UWP;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Syncfusion.SfDataGrid.XForms;
using static System.Net.Mime.MediaTypeNames;

[assembly: Xamarin.Forms.Dependency(typeof(KeyIntractionsWindows))]
namespace DataGridXamarin.UWP
{
    internal class KeyIntractionsWindows : IKeyIntraction
    {
        SfDataGrid grid;
        public void OnKeyDown(View view)
        {
            if (grid == null)
                grid = view as SfDataGrid;


            IVisualElementRenderer visualElementRenderer = view.GetOrCreateRenderer();

            if (visualElementRenderer != null)
            {
                visualElementRenderer.GetNativeElement().KeyDown += KeyIntractionsWindows_KeyDown;
            }
        }

        

        private async void KeyIntractionsWindows_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (Window.Current.CoreWindow.GetAsyncKeyState(VirtualKey.Control).HasFlag(CoreVirtualKeyStates.Down))
            {
                switch (e.Key)
                {
                    case VirtualKey.C:
                        {
                            // Copy
                            if (this.grid.IsFocused && this.grid.CurrentItem != null)
                            {
                                var cellValue = this.grid.GetCellValue(this.grid.CurrentItem, this.grid.Columns[this.grid.CurrentCellManager.RowColumnIndex.ColumnIndex].MappingName);
                                if (cellValue != null)
                                {
                                    await Clipboard.SetTextAsync(cellValue.ToString());
                                }
                            }
                            break;
                        }
                    case VirtualKey.X:
                        {
                            // Cut
                            if (this.grid.IsFocused && this.grid.CurrentItem != null)
                            {
                                var cellValue = this.grid.GetCellValue(this.grid.CurrentItem, this.grid.Columns[this.grid.CurrentCellManager.RowColumnIndex.ColumnIndex].MappingName);
                                if (cellValue != null)
                                {
                                    await Clipboard.SetTextAsync(cellValue.ToString());
                                }

                                var cell = this.grid.CurrentItem as OrderInfo;
                                string selectedColumnName = this.grid.Columns[this.grid.CurrentCellManager.RowColumnIndex.ColumnIndex].MappingName;

                                if (cell != null)
                                {
                                    cell.GetType().GetProperty(selectedColumnName).SetValue(cell, null);
                                }
                            }
                            break;
                        }
                    case VirtualKey.V:
                        {
                            // Paste
                            if (this.grid.IsFocused && this.grid.CurrentItem != null)
                            {
                                var cell = this.grid.CurrentItem as OrderInfo;
                                string selectedColumnName = this.grid.Columns[this.grid.CurrentCellManager.RowColumnIndex.ColumnIndex].MappingName;

                                if (cell != null)
                                {
                                    var copiedText = await Clipboard.GetTextAsync();
                                    var type = cell.GetType().GetProperty(selectedColumnName);

                                    var value = Convert.ChangeType(copiedText, type.PropertyType);
                                    cell.GetType().GetProperty(selectedColumnName).SetValue(cell, value);
                                }
                            }
                            break;
                        }
                }
            }
        }
    }
}
