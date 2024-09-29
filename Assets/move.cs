using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed; //움직일 속도
    float haxis;
    float vaxis;
    [SerializeField] private float mouseSpeed = 8f; //회전속도
    private float mouseX = 0f; //좌우 회전값을 담을 변수
    private float mouseY = 0f; //위아래 회전값을 담을 변수
    Vector3 movevec;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        haxis = Input.GetAxisRaw("Horizontal");
        vaxis = Input.GetAxisRaw("Vertical");
        movevec = transform.forward*vaxis+transform.right*haxis;
        transform.position += movevec.normalized * speed * Time.deltaTime ;//방향키와 wasd를 이용해 이동
        if (Input.GetMouseButton(0))
        {
            mouseX += Input.GetAxis("Mouse X");
            transform.rotation = Quaternion.Euler(0, mouseX, 0);
        }
    }
}
