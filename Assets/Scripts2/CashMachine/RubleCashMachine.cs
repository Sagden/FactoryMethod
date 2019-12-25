using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubleCashMachine : CashMachine
{
    private int _countOnPage;
    private int _nominal;
    private int[] _correctNominals;

    public RubleCashMachine(int nominal)
    {
        Name = "Станок для печати рублей";

        _countOnPage = 5;
        _nominal = nominal;
        _correctNominals =
            new int[] { 10, 50, 100, 1000, 5000 };
    }

    public override Money[] Create(int pageCount)
    {
        if (!_correctNominals.Any(n => n == _nominal))
            return null;

        var count = pageCount * _countOnPage;
        var money = new Money[count];

        for (var i = 0; i < count; i++)
        {
            var uniqueNumber = new Random().Next(1000000, 9999999);
            money[i] = new Ruble(_nominal, uniqueNumber);
        }

        return money;
    }
}
