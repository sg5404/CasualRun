using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControll : MonoBehaviour
{
    [SerializeField] private float zSpeed;
    [SerializeField] private float xSpeed;

    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float z = Input.GetAxisRaw("Horizontal");
        rigid.velocity = new Vector3(-xSpeed, rigid.velocity.y, zSpeed * z);
    }
}
