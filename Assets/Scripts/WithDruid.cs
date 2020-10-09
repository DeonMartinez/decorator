using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithDruid : PartyDecorator
{
    private float m_DruidCost = 100f;

    // Constructor
    public WithDruid(IParty party) : base(party) { }

    public override float GetCost()
    {
        return base.GetCost() + m_DruidCost;
    }
}
