using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeveloperCreate : MonoBehaviour
{
    void Start()
    {
        Developer dev = new PanelDeveloper("СтарКом Жильё");
        Debug.Log("Отчитывается орагнизация: " + dev.Name);
        House house1 = dev.Create();

        dev = new WoodDeveloper("Деревянные постройки");
        Debug.Log("Отчитывается орагнизация: " + dev.Name);
        House house2 = dev.Create();
    }
}
