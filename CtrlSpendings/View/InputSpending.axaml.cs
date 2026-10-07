namespace CtrlSpendings.View;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

public partial class InputSpending : Window
{
    public InputSpending()
    {
        InitializeComponent();
        
        this.EdAmount = this.GetControl<NumericUpDown>( "edAmount" );
        this.EdConcept = this.GetControl<TextBox>( "edConcept" );
        this.BtOk = this.GetControl<Button>( "btOk" );
        this.BtCancel = this.GetControl<Button>( "btCancel" );
    }
    
    public NumericUpDown EdAmount { get; }
    public TextBox EdConcept { get; }
    public Button BtOk { get; }
    public Button BtCancel { get; }
}
