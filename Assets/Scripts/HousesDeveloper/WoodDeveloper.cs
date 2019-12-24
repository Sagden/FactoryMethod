using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodDeveloper : Developer
{
    public WoodDeveloper(string n) : base(n) {}

    public override House Create()
    {
        return new WoodHouse();
    }
}
