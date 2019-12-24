using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class CashMachine
{
    public string Name { get; set; }

    public CashMachine(string name)
    {
        Name = name;
    }

    abstract public Money[] Create(int pageCount); 
}
