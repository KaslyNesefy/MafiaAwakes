using UnityEngine;

public class Player : MonoBehaviour
{
    private const float _DELTAROTATION = 1f;
    private const float _MAXROTATION = 360f;

    private float _rotation = 0f;

    [SerializeField] private GameObject _face;

    [SerializeField] private Gun _gun;

    private Vector2 _playerDirection;
    public Vector2 PlayerDirection { set { _playerDirection = value; } }

    private void FixedUpdate()
    {
        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, _rotation), Time.deltaTime);
        transform.rotation = Quaternion.Euler(0f, 0f, _rotation);
        _rotation = _rotation >= _MAXROTATION ? 0f : _rotation + _DELTAROTATION;
        //MaxRotationEvent();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            PlayerDirection = transform.position + _face.transform.position;
            _gun.Direction = _playerDirection;
            _gun.Shoot(); 
        }
    }

}
