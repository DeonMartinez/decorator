using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithCleric : PartyDecorator
{
    private float m_ClericCost = 500f;

    // Constructor
    public WithCleric (IParty party) : base(party) { }

    public override float GetCost()
    {
        return base.GetCost() + m_ClericCost;
    }
}
