namespace MColorPicker;

internal class UpdateColorEventArgs : EventArgs
{
    public Color NewColor { get; }

    public UpdateColorEventArgs(Color newColor)
    {
        NewColor = newColor;
    }
}
