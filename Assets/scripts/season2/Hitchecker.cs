using UnityEngine;

public class HitChecker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Something entered hitbox: " + collision.name);

        if (collision.CompareTag("Enemy"))
        {
           Damageable enemy = collision.GetComponentInParent<Damageable>();

            if (enemy != null)
            {
                Debug.Log("Calling Fall()");
                enemy.Hit(10, Vector2.zero);
            }

            else
            {
                Debug.Log("Demogorgan script not found on parent!");
            }
        }
    }

}
