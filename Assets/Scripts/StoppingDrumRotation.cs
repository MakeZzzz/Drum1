using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class StoppingDrumRotation : MonoBehaviour
{
    private Rigidbody _rigidbody;
    
    private void Awake()
    { 
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    [UsedImplicitly]
    public void StopRotation()
    {
        _rigidbody.isKinematic = true;
    }
}
