using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Money
{
    /// <summary>
    /// Название валюты
    /// </summary>
    public string Name { get; protected set; }

    /// <summary>
    /// Символ валюты
    /// </summary>
    public string Symbol { get; protected set; }

    /// <summary>
    /// Номинал валюты
    /// </summary>
    public int Nominal { get; protected set; }
}
