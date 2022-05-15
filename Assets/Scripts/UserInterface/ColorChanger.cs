using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Color _from;
    [SerializeField] private Color _to;

    [ContextMenu("Load From Color")]
    public void LoadFromColor()
    {
        
    }
}