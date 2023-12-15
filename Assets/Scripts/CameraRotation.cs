using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed = 100;
    private float _angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseY = Input.GetAxisRaw("Mouse Y");
        _angle += mouseY * _rotateSpeed * Time.deltaTime;
        _angle = Mathf.Clamp(_angle, -40, 50);
        transform.localEulerAngles = Vector3.left * _angle;
    }
}
