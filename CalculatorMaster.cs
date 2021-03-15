using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalculatorMaster : MonoBehaviour
{
    public TextMeshPro textDisplay;
    string addNumbers;
    string storedSymbol;
    float num1 = 0f;
    float num2 = 0f;
    
    // Update is called once per frame
    void Update()
    {
        textDisplay.text = addNumbers;
    }

    public void clearAll()
    {
        // resets all values back to default
        num1 = 0f;
        num2 = 0f;
        addNumbers = "";
        storedSymbol = "";
        
    }

    public void convertNum(string convertedNum)
    {
        // gets the button numbers and adds them as a string
        addNumbers = addNumbers + convertedNum;
    }

    public void SpecialChar(string special)
    {
        // does the math of converting the string values into numbers the program can calculate
        float finalNumber;

        if (num1 == 0f)
        {
            num1 = float.Parse(addNumbers);
            addNumbers = "";
        }
        else
        {
            num2 = float.Parse(addNumbers);
        }

        
        if (special != "=")
        {
            storedSymbol = special;
        }
        else
        {
            switch (storedSymbol)
            {
                case "+":
                    finalNumber = num1 + num2;
                    addNumbers = finalNumber.ToString();
                    break;
                case "-":
                    finalNumber = num1 - num2;
                    addNumbers = finalNumber.ToString();
                    break;
                case "*":
                    finalNumber = num1 * num2;
                    addNumbers = finalNumber.ToString();
                    break;
                case "/":
                    finalNumber = num1 / num2;
                    addNumbers = finalNumber.ToString();
                    break;
            }
        }
    }
}
