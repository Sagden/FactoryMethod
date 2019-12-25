using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Ruble : Money
{
    /// <summary>
    /// Уникальный номер
    /// </summary>
    public int UniqueNumber { get; private set; }

    public Ruble(int nominal, int uniqueNumber)
    {
        Name = "Российский рубль";
        Symbol = "Р";

        Nominal = nominal;
        UniqueNumber = uniqueNumber;
    }
}
