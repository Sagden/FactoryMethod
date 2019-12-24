using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Money
{
    public string Name { get; set; }
    public string Symbol { get; set; }

    public Money(string name, string symbol)
    {
        Name = name;
        Symbol = symbol;
    }
}
