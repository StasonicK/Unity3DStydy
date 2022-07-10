using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScreenshotsListWithHandlerView : MonoBehaviour
{
    [SerializeField] private ScreenshotViewWithHandler _template;
    [SerializeField] private Transform _container;
    [SerializeField] private Sprite _defaultSprite;
    [SerializeField] private Transform _dragingParent;

    private void Awake()
    {
        Render(new List<Screenshot>()
        {
            new Screenshot(_defaultSprite, DateTime.Now),
            new Screenshot(_defaultSprite, DateTime.Now),
            new Screenshot(_defaultSprite, DateTime.Now)
        });
    }

    private void Render(IEnumerable<Screenshot> screenshots)
    {
        foreach (var screenshot in screenshots)
        {
            var view = Instantiate(_template, _container) as ScreenshotViewWithHandler;
            view.Init(_dragingParent);
            view.Render(screenshot);
        }
    }
}