using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Private variables
    float elapsedTime = 0;

    // Public variables
    [SerializeField] int speed;
    [SerializeField] float dieAfterSeconds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= dieAfterSeconds)
        {

        }
    }
}
