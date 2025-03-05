using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // Drag the bullet prefab here
    public Transform firePoint; // Assign an empty GameObject where bullets spawn
    public float bulletSpeed = 10f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button to shoot
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Get mouse position in world coordinates
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

        // Calculate direction from player to mouse
        Vector2 shootDirection = (mousePos - firePoint.position).normalized;

        // Instantiate bullet
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        
        // Apply velocity in the calculated direction
        rb.velocity = shootDirection * bulletSpeed;

        // Rotate bullet to face the shooting direction
        float angle = Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg;
        bullet.transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
