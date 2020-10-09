using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public Text CostText;

    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            IParty party = new BasicPC();
            CostText.text = "Basic cost: " + party.GetCost();
          
        }

        if (Input.GetKeyDown("c"))
        {
            IParty party = new BasicPC();
            party = new WithCleric(party);
            CostText.text = "With Cleric cost: " + party.GetCost();
        }

        if (Input.GetKeyDown("d"))
        {
            IParty party = new BasicPC();
            party = new WithDruid(party);
            CostText.text = "With Druid cost: " + party.GetCost();
        }

        if (Input.GetKeyDown("w"))
        {
            IParty party = new BasicPC();
            party = new WithWizard(party);
            CostText.text = "With Wizard cost: " + party.GetCost();
        }

        if (Input.GetKeyDown("f"))
        {
            IParty party = new BasicPC();
            party = new WithFighter(party);
            CostText.text = "With Fighter cost: " + party.GetCost();
        }

        if (Input.GetKeyDown("r"))
        {
            IParty party = new BasicPC();
            party = new WithRouge(party);
            CostText.text = "With Rouge cost: " + party.GetCost();
        }

        if (Input.GetKeyDown("q"))
        {
            IParty party = new BasicPC();
            //I'm very sorry about this call because its gross
            party = new WithRouge(new WithFighter(new WithWizard(new WithDruid(new WithCleric(party)))));
            CostText.text = "Full Party cost: " + party.GetCost();
        }
    }
}
