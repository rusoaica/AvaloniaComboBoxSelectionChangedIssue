using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ComboboxSelectionChangedIssue
{
    public partial class StartupV : Window
    {
        public StartupV()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
