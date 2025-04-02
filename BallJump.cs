using UnityEngine;

public class BallJump : MonoBehaviour
{
    public float jumpForce = 5f; // Сила подбрасывания

    private Rigidbody rb;

    void Start()
    {
        // Получаем компонент Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Если нажат пробел и шарик на полу (опционально)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Применяем силу вверх
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}