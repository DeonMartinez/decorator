using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithWizard : PartyDecorator
{
    private float m_WizardCost = 350f;

    // Constructor
    public WithWizard(IParty party) : base(party) { }

    public override float GetCost()
    {
        return base.GetCost() + m_WizardCost;
    }
}
