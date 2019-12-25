using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public sealed class Dollar : Money
{
    /// <summary>
    /// Уникальный номер
    /// </summary>
    public Guid UniqueNumber { get; private set; }

    public Dollar(int nominal)
    {
        Name = "American Dollar";
        Symbol = "$";

        Nominal = nominal;
        UniqueNumber = Guid.NewGuid();
    }
}