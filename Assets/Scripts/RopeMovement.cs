using UnityEngine;

public class RopeMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        float direction = Input.GetAxisRaw("Horizontal");
        _rigidbody.AddForce(new Vector2(direction * 3, 0));
    }
}
