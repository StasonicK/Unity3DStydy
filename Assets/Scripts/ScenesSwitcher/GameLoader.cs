using System;
using System.Collections;
using System.Collections.Generic;
using IJunior.TypedScenes;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    [SerializeField] private LevelConfig _levelConfig;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Game.Load(_levelConfig);
        }
    }
}