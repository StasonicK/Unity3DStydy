using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class LookAtIK : MonoBehaviour
{
    protected Animator _animator;
    public bool ikActive;
    public Transform lookObj = null;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnAnimatorIK()
    {
        if (_animator)
        {
            if (ikActive)
            {
                if (lookObj != null)
                {
                    _animator.SetLookAtWeight(1);
                    _animator.SetLookAtPosition(lookObj.position);
                }
            }
        }
    }
}