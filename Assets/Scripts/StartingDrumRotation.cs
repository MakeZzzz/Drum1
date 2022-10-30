using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class StartingDrumRotation : MonoBehaviour
{
    [SerializeField] private float _speed = 100f;
    [SerializeField] private float _force = 30f;
    private Rigidbody _rigidbody;
    private ReversingDrum _reversingDrum;
    private HingeJoint _hingeJoint;
    private void Awake()
    { 
        _hingeJoint = GetComponent<HingeJoint>();
        _reversingDrum = GetComponent<ReversingDrum>();
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.isKinematic = true;
    }
    
    [UsedImplicitly]
    public void StartRotation()
    {
        var motor = _hingeJoint.motor;
        motor.targetVelocity = _speed;
        motor.force = _force;
        if (!_reversingDrum.IsReverse)
        {
            motor.targetVelocity = -_speed;
        }
        _hingeJoint.motor = motor;
        _rigidbody.isKinematic = false;
    }
}
