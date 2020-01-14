using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    [Header("移動速度"), Range(0f, 100f)]
    public float speed = 1.5f;
    [Header("剛體")]
    public Rigidbody2D rig;
    [Header("Sr")]
    public SpriteRenderer Sr;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
    private void FixedUpdate()
    {
        Move();
    }   

    private void Move()
    {
       
        rig.AddForce(transform.right * Input.GetAxisRaw("Horizontal") * speed);
        if (Input.GetKeyDown(KeyCode.A)) { Sr.flipX = true; }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) { Sr.flipX = true; }
        if (Input.GetKeyDown(KeyCode.D)) { Sr.flipX = false; }
        if (Input.GetKeyDown(KeyCode.RightArrow)) { Sr.flipX = false; }
    }





}
