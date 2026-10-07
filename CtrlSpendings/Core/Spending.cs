namespace CtrlSpendings.Core;


using System;
using System.Collections.Generic;
using System.Text;


public class Spending
{
    public required DateTime Date { get; init; }
    public required string Concept { get; init; }
    public required double Amount { get; init; }

    public override string ToString()
    {
        return $"{this.Date}/{this.Amount:0.00}€ {this.Concept}";
    }
}
