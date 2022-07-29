using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Just allows to access a boolean without knowing form where it come from.
/// </summary>
public interface IBooleanAccess: IBooleanAccessGet, IBooleanAccessSet
{}

public interface IBooleanAccessGet
{
    public void GetBoolean(out bool isTrue);
    public bool GetBoolean();
}
public interface IBooleanAccessSet
{
    public void SetBoolean(in bool isTrue);
}




public interface ICanComputeBoolean<T> {

    public void ComputeBoolean(in T givenValue, out bool isTrue);
}
public abstract class AbstractCanComputeBoolean<T> : ICanComputeBoolean<T>
{
    public abstract void ComputeBoolean(in T givenValue, out bool isTrue);
}