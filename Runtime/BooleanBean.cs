using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanBean : IBooleanAccess
{
    [SerializeField] bool m_isTrue;

    public BooleanBean(bool isTrue)
    {
        m_isTrue = isTrue;
    }
    public BooleanBean() : this(false)
    {
    }
    public void GetBoolean(out bool isTrue)
    =>isTrue = m_isTrue;
    public bool GetBoolean()
    { return m_isTrue; }
    public void SetBoolean(in bool isTrue) => m_isTrue = isTrue;
}


