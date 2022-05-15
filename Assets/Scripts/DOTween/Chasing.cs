using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Chasing : MonoBehaviour
{
    [SerializeField] private Transform _target;
    
    private Vector3 _targetLastPosition;
    private Tweener _tweener;

    private void Start()
    {
        _tweener = transform.DOMove(_target.position, 2).SetAutoKill(false);
        _targetLastPosition = _target.position;
    }

    private void Update()
    {
        if (_targetLastPosition != _target.position)
        {
            _tweener.ChangeEndValue(_target.position, true).Restart();
            _targetLastPosition = _target.position;
        }
    }
}