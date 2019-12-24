using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Developer
{
    public string Name { get; set; }
    public Developer(string name)
    {
        Name = name;
    }
    
    abstract public House Create();
}
