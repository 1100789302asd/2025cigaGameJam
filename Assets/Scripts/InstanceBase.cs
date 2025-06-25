using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceBase<T> : MonoBehaviour where T:class
{
    public static T instacne;
    void Awake()
    {
        if (instacne == null)
            instacne = this as T;
        else
            print("error");
        //test
    }
}
