using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Button : MonoBehaviour
{
    public TMP_Text Text;

    public void OnButtonClick()
    {
        Destroy(Text);
    }
}