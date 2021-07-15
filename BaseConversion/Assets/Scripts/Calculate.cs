using System;
using UnityEngine;
using UnityEngine.UI;

public class Calculate : MonoBehaviour
{
    public InputField num1Input = null;
    public InputField num2Input = null;
    public Dropdown operatorSelect = null;
    public Dropdown num1BaseSelect = null;
    public Dropdown num2BaseSelect = null;
    public Text outputText = null;

    public void PerformCalculation()
    {
        float num1 = GoToDecimal(num1Input.text, num1BaseSelect.value);
        float num2 = GoToDecimal(num2Input.text, num2BaseSelect.value);

       float tempValue = 0f;
       switch(operatorSelect.value)
       {
           case 0: tempValue = num1 + num2; break;
           case 1: tempValue = num1 - num2; break;
           case 2: tempValue = num1 * num2; break;
           default: tempValue = num1 / num2; break;
          
       }
        outputText.text = Convert.ToString(tempValue);


    } 

    private float GoToDecimal(string numText, int numBase)
    {
        long num = 0;
        switch (numBase)
        {
            case 0: num = Convert.ToInt64(numText, 2); break;
            case 1: num = Convert.ToInt64(numText, 8); break;
            case 2: num = Convert.ToInt64(numText, 10); break;
            default: num = Convert.ToInt64(numText, 16); break;
        }
        return  (float)num;
    }

}
