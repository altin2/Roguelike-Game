using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifetime = 2f;
    public int damageAmount = 5;
    public int pierceamount;
    private int piercecount= 1;


    void Start()
    {
        Destroy(gameObject, lifetime); // Destroy bullet after some time
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Enemy health = other.GetComponent<Enemy>();

        if (health != null)
        {
            health.TakeDamage(damageAmount); // Reduce HP
        }
        if (piercecount < pierceamount)
        {
            piercecount++;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
