using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithFighter : PartyDecorator
{
    private float m_FighterCost = 250f;

    // Constructor
    public WithFighter(IParty party) : base(party) { }

    public override float GetCost()
    {
        return base.GetCost() + m_FighterCost;
    }
}