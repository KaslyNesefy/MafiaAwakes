using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private GameObject _bulletPlace;
    private Vector2 _direction;
    public Vector2 Direction { set { _direction = value; } }
    public void Shoot()
    {
        Bullet thisBullet = Instantiate(_bullet, _bulletPlace.transform.position, transform.rotation);

        thisBullet.Direction = _direction;
    }

}
