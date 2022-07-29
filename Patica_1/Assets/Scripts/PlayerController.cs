using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jump = 500f;
    public Rigidbody rB;

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.W))
        {
            rB.AddForce(Vector3.up* jump);

        }
    }
}
