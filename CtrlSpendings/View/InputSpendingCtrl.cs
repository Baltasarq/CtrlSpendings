namespace CtrlSpendings.View;

using System;
using AvUi = Avalonia.Controls;
using Core;

public class InputSpendingCtrl {
    public InputSpendingCtrl(AvUi.Window parent)
    {
        this.parent = parent;
        this.actWhenOk = (g) => {};
        this.View = new InputSpending();
        this.View.BtOk.Click += (_, _) => this.OnOk();
        this.View.BtCancel.Click += (_, _) => this.OnCancel();
    }
    
    public void Show(Action<Spending> act)
    {
        this.actWhenOk = act;
        this.View.ShowDialog( parent );
    }
    
    private void OnOk()
    {
        var spending = new Spending {
            Date = DateTime.Now,
            Concept = this.View.EdConcept.Text ?? "",
            Amount = float.Parse( this.View.EdAmount.Text ?? "0" )
        };
        
        this.actWhenOk( spending );
        this.View.Close();
    }
    
    private void OnCancel()
    {
        this.View.Close();
    }

    public InputSpending View { get; }
    private AvUi.Window parent;
    private Action<Spending> actWhenOk;
}
