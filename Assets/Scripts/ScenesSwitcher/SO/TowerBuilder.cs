using System.Collections;
using System.Collections.Generic;
using IJunior.TypedScenes;
using UnityEngine;

public class TowerBuilder : MonoBehaviour, ISceneLoadHandler<LevelConfig>
{
    public void OnSceneLoaded(LevelConfig argument)
    {
        Debug.Log(argument.TowerSize);
    }
}
