using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ReversingDrum : MonoBehaviour
{
    private HingeJoint _hingeJoint;
    public bool IsReverse;
    

    private void Awake()
    {
        _hingeJoint = GetComponent<HingeJoint>();
    }

    [UsedImplicitly]
    public void CheckReverse()
    {
        var reverse = _hingeJoint.motor;
        reverse.targetVelocity  *= -1;
        _hingeJoint.motor = reverse;
        if (IsReverse)
        {
            IsReverse = !IsReverse;
        }
        else
        {
            IsReverse = true;
        }
    }
}
