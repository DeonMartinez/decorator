using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class PartyDecorator : IParty
{
    protected IParty m_DecoratedParty;

    public PartyDecorator (IParty party)
    {
        m_DecoratedParty = party;
    }
    public virtual float GetCost()
    {
        return m_DecoratedParty.GetCost();
    }
}
