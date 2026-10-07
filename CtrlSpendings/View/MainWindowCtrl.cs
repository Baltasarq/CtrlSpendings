
namespace CtrlSpendings.View;


using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using Core;


public class MainWindowCtrl {
    public MainWindowCtrl()
    {
        this.reg = new SpendingRegistry();
        this.View = new MainWindow();
        this.View.BtNew.Click += (_, _) => this.OnNew();

        this.List();
    }

    public void OnNew()
    {
        var dlg = new InputSpendingCtrl( this.View );
        
        dlg.Show( (g) => { this.reg.Add( g ); this.List(); });
    }

    private void List()
    {
        this.View.LbSpendings.ItemsSource = this.All;
    }

    public MainWindow View { get; }
    public IEnumerable<Spending> All => this.reg.All;
    private SpendingRegistry reg;
}
