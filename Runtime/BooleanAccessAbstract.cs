using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BooleanAccessAbstract : IBooleanAccess
{
    public abstract void GetBoolean(out bool isTrue);
    public abstract bool GetBoolean();
    public abstract void SetBoolean(in bool isTrue);
}

