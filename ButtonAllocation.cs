using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAllocation : MonoBehaviour
{
    CalculatorMaster calMaster;

    private void Start()
    {
        calMaster = Object.FindObjectOfType<CalculatorMaster>();
    }
    
    public void buttonNum(string num)
    {
        calMaster.convertNum(num);
    }

    public void buttonSpecial(string symbol)
    {
        calMaster.SpecialChar(symbol);
    }

    public void clearAll()
    {
        calMaster.clearAll();
    }
}
