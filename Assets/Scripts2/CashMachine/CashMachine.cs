using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CashMachine
{
    /// <summary>
    /// Название машины
    /// </summary>
    public string Name { get; protected set; }

    /// <summary>
    /// Печать листов
    /// </summary>
    public abstract Money[] Create(int pageCount);
}
