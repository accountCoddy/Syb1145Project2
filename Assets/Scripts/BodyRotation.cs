using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyRotation : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed = 300;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X");
        transform.eulerAngles += Vector3.up * _rotateSpeed * mouseX * Time.deltaTime;
    }
}
