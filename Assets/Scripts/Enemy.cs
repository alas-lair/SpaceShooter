using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // If the enemy has hit a projectile
        if (collision.gameObject.GetComponent<Projectile>() != null)
        {
            Destroy(gameObject);
        }
    }
}
