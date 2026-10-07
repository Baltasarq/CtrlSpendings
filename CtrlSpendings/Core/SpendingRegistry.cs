namespace CtrlSpendings.Core;


using System;
using System.Collections.Generic;
using System.Text;


public class SpendingRegistry
{
    public SpendingRegistry()
    {
        this.spendings = new List<Spending>();
    }

    public IEnumerable<Spending> All => new List<Spending>( this.spendings );

    public void Add(Spending g)
    {
        this.spendings.Add( g );
    }

    public override string ToString()
    {
        return string.Join( "\n", this.spendings );
    }

    private List<Spending> spendings;
}
