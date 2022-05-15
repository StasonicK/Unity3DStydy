using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ToText : MonoBehaviour
{
    public TMP_Text Text;

    public TMP_Dropdown Dropdown;

    public void DropdownText(int num)
    {
        Text.text = Dropdown.options[num].text;
    }
}