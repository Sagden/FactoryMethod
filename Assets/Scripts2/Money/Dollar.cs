using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Dollar : Money
{
    public Guid Number { get; set; }
    public int Nominal { get; set; }

    public Dollar(int nominal) : base ("American Dollar", "$")
    {
        Number = Guid.NewGuid();
        Nominal = nominal;
    }
}
