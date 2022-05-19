using System;
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
        if (_image != null)
        {
            _from = _image.color;
        }
    }

    public void SetPosition(float position)
    {
        _image.color = Color.Lerp(_from, _to, position);
    }
}