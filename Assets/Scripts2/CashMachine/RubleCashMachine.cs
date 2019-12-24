using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubleCashMachine : CashMachine
{
    private int CountOnPage { get; set; } = 5;
    private int Nominal { get; set; }
    private int[] CorrectNominal = { 10, 50, 100, 1000, 5000 };

    public RubleCashMachine(int nominal = 1000) : base ("Станок для печати рублей")
    {
        Nominal = nominal;
    }

    public override Money[] Create(int pageCount)
    {
        var count = pageCount * CountOnPage;
        var money = new List<Ruble>();

        for (var i = 0; i < count; i++)
        {
            var ruble = new Ruble(Nominal);
            money.Add(ruble);
        }

        return money.ToArray();
    }
}
