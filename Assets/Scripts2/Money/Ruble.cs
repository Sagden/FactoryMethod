using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruble : Money
{
    public int Number { get; set; }
    public int Nominal { get; set; }

    public Ruble(int nominal) : base ("Российский рубль", "Р")
    {
        var random = new System.Random();

        Number = random.Next(1000000, 9999999);
        Nominal = nominal;
    }
}
