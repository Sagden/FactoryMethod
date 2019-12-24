using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelDeveloper : Developer
{
    public PanelDeveloper(string n) : base(n) {}

    public override House Create()
    {
        return new PanelHouse();
    }
}
