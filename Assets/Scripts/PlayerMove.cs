using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    private CharacterController _controller;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector2 moveInput = new Vector2(horizontal, vertical);
        moveInput.Normalize();
        Vector3 directionMove = new Vector3(moveInput.x, 0, moveInput.y);
        directionMove = transform.TransformDirection(directionMove);
        _controller.SimpleMove(directionMove * _speed);
    }
}
