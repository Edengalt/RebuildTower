using System;
using UnityEngine;

public class RotsteCamera : MonoBehaviour
{
    public float speed = 5f;
    public Transform _rotator;
    public bool Rotate;




    public void Start()
    {
        _rotator = GetComponent<Transform>();

    }

    public void Update()
    {
        if (!Rotate)
            _rotator.Rotate(0, speed * Time.deltaTime, 0);
        else
        {
            _rotator.Rotate(0, 0, 0);
        }
    }
}
  
