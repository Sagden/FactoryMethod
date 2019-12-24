using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ViewModel : MonoBehaviour
{
    void Start()
    {
        var newMoney = new RubleCashMachine(100).Create(1).Cast<Ruble>();

        foreach (var i in newMoney)
        {
            Debug.Log(i.Nominal);
        }
    }
}
