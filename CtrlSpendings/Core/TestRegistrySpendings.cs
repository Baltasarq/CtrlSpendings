namespace CtrlSpendings.Core;


using System;


class Ppal {
    static void Prueba()
    {
        var s1 = new Spending{
                            Date = new DateTime( 2026, 10, 6, 10, 15, 0 ),
                            Concept = "Bus a la ESEI",
                            Amount = 2 };
        var s2 = new Spending{
                            Date = new DateTime( 2026, 10, 6, 12, 35, 0 ),
                            Concept = "Café en Camba's",
                            Amount = 1.05 };
        var reg = new SpendingRegistry();

        reg.Add( s1 );
        reg.Add( s2 );

        Console.WriteLine( reg );
    }
}
