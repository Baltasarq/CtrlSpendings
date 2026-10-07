namespace CtrlSpendings.View;


using Avalonia.Controls;


public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.BtNew = this.GetControl<Button>( "btNew" );
        this.LbSpendings = this.GetControl<ListBox>( "lbSpendings" );
    }

    public Button BtNew { get; }
    public ListBox LbSpendings { get; }
}
