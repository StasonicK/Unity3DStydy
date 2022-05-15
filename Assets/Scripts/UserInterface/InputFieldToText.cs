using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputFieldToText : MonoBehaviour
{
    public TMP_Text Text;

    public void ToText(string str)
    {
        Text.text = str;
    }
}