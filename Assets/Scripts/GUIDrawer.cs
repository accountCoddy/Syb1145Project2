using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIDrawer : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    private float _vertical;
    private float _horizontal;
    private Vector2 _moveInput;
    [SerializeField] private bool _isNormalized;
    [SerializeField] private bool _isRaw;
    private GUIStyle _headStyle;
    void Start()
    {
        _headStyle = new GUIStyle();
        _headStyle.fontSize = 50;
        _headStyle.fontStyle = FontStyle.Bold;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isRaw)
        {
            _vertical = Input.GetAxisRaw("Horizontal");
            _horizontal = Input.GetAxisRaw("Vertical");
        }
        else
        {
            _vertical = Input.GetAxis("Horizontal");
            _horizontal = Input.GetAxis("Vertical");
        }
        _moveInput = new Vector2(_horizontal, _vertical);
        if (_isNormalized)
        {
            _moveInput = _moveInput.normalized;
        }
        _moveInput *= _speed;


    }
    private void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 50), $"Raw - {_isRaw}", _headStyle);
        GUI.Label(new Rect(Screen.width / 2, Screen.height / 2 - 100, 200, 50), $"Normalized - {_isNormalized}", _headStyle);
        GUI.Label(new Rect(Screen.width / 2, Screen.height / 2 -200, 100, 50), $"Speed - {_speed}", _headStyle);
        GUI.Label(new Rect(Screen.width / 2, Screen.height / 2 -300, 100, 50), $"Move Input - {_moveInput}", _headStyle);
    }
}
