using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    private void Start()
    {
        transform.DOMove(new Vector3(0, 5, 0), 3).From().SetLoops(-1,LoopType.Yoyo);
    }
}