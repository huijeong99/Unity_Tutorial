﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldUITest : MonoBehaviour
{
    [SerializeField] private Text txt_Money;
    [SerializeField] private InputField inputTxT_Money;

    // Start is called before the first frame update
    private int currentMoney;

    public void Input()
    {
        currentMoney += int.Parse(inputTxT_Money.text);

        txt_Money.text = currentMoney.ToString();
    }

    public void Output()
    {
        currentMoney -= int.Parse(inputTxT_Money.text);

        txt_Money.text = currentMoney.ToString();
    }
}
