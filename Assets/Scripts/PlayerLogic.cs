using UnityEngine;
using UnityEngine.InputSystem.Processors;

public class PlayerLogic : MonoBehaviour
{
    [SerializeField] int speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate((verticalInput * Vector2.up * Time.deltaTime * speed) + (horizontalInput * Vector2.right * Time.deltaTime * speed));
    }
}
