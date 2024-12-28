using System;
using UnityEngine;

public class EnumFlagExample : MonoBehaviour
{
    [EnumFlag] 
    [SerializeField] Fruits fruit;

    void Update()
    {
        print(fruit);
        
    }

    [Flags]
    public enum Fruits
    {
        None, 
        Orange,
        Potato
    }
}