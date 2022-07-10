using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb = null;



    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        //이동 제한
        float y = Mathf.Clamp(transform.position.y, -10.6f, 10.6f);
        Vector2 limit = new Vector2(transform.position.x, y);
        transform.position = limit;

        //수직 이동
        float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(0, v, 0);

        transform.position += dir.normalized * 15 * Time.deltaTime;

        //좌우 이동
        Vector3 tM = transform.position;
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (transform.position.x == -10) return;
            //rb.AddForce(Vector2.left * 10, ForceMode.Impulse);
            transform.position = new Vector3(tM.x-10, tM.y, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (transform.position.x == 10) return;
            transform.position = new Vector3(tM.x+10, tM.y, 0);
        }
    }
}
