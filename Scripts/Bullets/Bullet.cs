using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed = 0.5f;
    private Vector2 _direction;
    public Vector2 Direction { set { _direction = value; } }

    protected virtual void OnTriggerEnter2D(Collider2D collider) => Destroy(gameObject);

    protected virtual void Start() => Destroy(gameObject, 1.5f);

    protected virtual void FixedUpdate() => transform.position = Vector2.MoveTowards(transform.position, (Vector2)transform.position + _direction, _speed);
}

    //private SpriteRenderer Sprite;
    //protected virtual void Awake() => Sprite = GetComponentInChildren<SpriteRenderer>();