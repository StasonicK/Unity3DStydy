using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField] private Vector3[] _waypoints;

    void Start()
    {
        Tween tween = transform.DOPath(_waypoints, 5, PathType.CatmullRom).SetOptions(true).SetLookAt(0.01f);

        tween.SetEase(Ease.Linear).SetLoops(-1);
    }
}