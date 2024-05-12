using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Car : MonoBehaviour
{
    
    [SerializeField] private float _speed;
    private void Update()
    {
        var step = _speed * Time.deltaTime;
        var angle = 90 * Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            var localVector = Vector3.right * step;
            transform.position += transform.TransformDirection(localVector);
            
        }
        else if (Input.GetKey(KeyCode.S))
        {
            var localVector = Vector3.right * step;
            transform.position -= transform.TransformDirection(localVector);
        } 
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down, angle);
            
        }else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.down, angle);
        }
    }
}
