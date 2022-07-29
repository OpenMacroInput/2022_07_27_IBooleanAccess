using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct BooleanStructBean: IBooleanAccess
{


    [SerializeField] bool m_isTrue;

    public BooleanStructBean(bool isTrue)
    {
        m_isTrue = isTrue;
    }

    public void GetBoolean(out bool isTrue)
    => isTrue = m_isTrue;
    public bool GetBoolean()
    { return m_isTrue; }
    public void SetBoolean(in bool isTrue) => m_isTrue = isTrue;
}
