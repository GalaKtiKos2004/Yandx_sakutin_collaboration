using System;
using UnityEngine;

public class Fall : MonoBehaviour
{
    [SerializeField] private HingeJoint2D joint;
    private Rigidbody2D _rigidbody;
    public GameObject _lastRope;

    private void Start()
    { 
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (joint == null)
            return;
        
        if (Input.GetMouseButton(0))
        {
            _lastRope = joint.gameObject;
            joint.enabled = false;
            joint.connectedBody = null;
            joint = null;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        // print(joint.gameObject);
        if (col.gameObject.CompareTag("Rope") && joint is null && col.gameObject != _lastRope)
        {
            print("Роман Сауктин");
            HingeJoint2D new_rope = col.gameObject.GetComponent<HingeJoint2D>();
            new_rope.connectedBody = _rigidbody;
            new_rope.enabled = true;
            joint = new_rope;
        }
    }
}
