using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MColorPicker;

internal interface IPickerComponent
{
    Color SelectedColor { get; set; }
    event EventHandler<UpdateColorEventArgs>? UpdateColor;
    string Title { get; }
}
