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
        // if the enemy is below the horizontal line that the player is on
        if (transform.position.y < -4)
        {
            FindFirstObjectByType<GameManager>().GameOver();
        }
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
