using MColorPicker.Components;

namespace MColorPicker;

public partial class ColorPicker : Form
{
    private Color _SelectedColor = Color.Black;
    private readonly List<IPickerComponent> _Components = new();
    private readonly ColorPreview _Preview = new();
    private bool _PerformingColorUpdate = false;

    public Color SelectedColor
    {
        get => _SelectedColor;
        set
        {
            _SelectedColor = value;
            _UpdateUI();
        }
    }

    public ColorPicker()
    {
        InitializeComponent();
        DoubleBuffered = true;

        _Preview.Dock = DockStyle.Fill;
        groupBox1.Controls.Add(_Preview);
    }

    private void ColorPicker_Load(object sender, EventArgs e)
    {
        splitContainer1.SplitterDistance = splitContainer1.Width / 2;

        _AddComponent(new RgbSliders(), SliderTabs);
        _AddComponent(new WebSafeColors(), GraphicalTabs);

        _UpdateUI();
    }

    private void _AddComponent(IPickerComponent component, TabControl tabs)
    {
        component.SelectedColor = _SelectedColor;
        var tabPage = new TabPage(component.Title);
        tabs.TabPages.Add(tabPage);

        if (component is Control c)
        {
            c.Dock = DockStyle.Fill;
            tabPage.Controls.Add(c);
        }

        component.UpdateColor += ComponentUpdateColor;
        _Components.Add(component);
    }

    private void ComponentUpdateColor(object? sender, UpdateColorEventArgs e)
    {
        if (!_PerformingColorUpdate)
        {
            SelectedColor = e.NewColor;
        }
    }

    private void _UpdateUI()
    {
        _PerformingColorUpdate = true;
        foreach (var c in _Components)
        {
            if (!Helpers.ColorsAreEqual(c.SelectedColor, _SelectedColor))
            {
                c.SelectedColor = _SelectedColor;
            }
        }
        _Preview.PreviewColor = _SelectedColor;
        _PerformingColorUpdate = false;
    }
}