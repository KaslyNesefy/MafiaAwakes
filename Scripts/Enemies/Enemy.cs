using UnityEngine;
class Enemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider) => Destroy(gameObject);
}
