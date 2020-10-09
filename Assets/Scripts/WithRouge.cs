using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithRouge : PartyDecorator
{
    private float m_RougeCost = 120f;

    // Constructor
    public WithRouge(IParty party) : base(party) { }

    public override float GetCost()
    {
        return base.GetCost() + m_RougeCost;
    }
}
