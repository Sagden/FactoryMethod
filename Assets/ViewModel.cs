using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ViewModel : MonoBehaviour
{
    void Start()
    {
        var newMoney = new RubleCashMachine(1000).Create(10)?.Cast<Ruble>();
        if (newMoney == null)
            throw new Exception("Неверно введен номинал купюр (Чисто пример)");

        foreach (var i in newMoney)
        {
            Debug.Log($"{i.Nominal} {i.UniqueNumber}");
        }
    }
}
