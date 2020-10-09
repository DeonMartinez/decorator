using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPC : IParty
{
    private float m_BasicCost = 5f;

    public float GetCost()
    {
        return m_BasicCost;
    }
}
