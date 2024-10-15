using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    [SerializeField] private float mouseSpeed = 8f; //회전속도
    private float mouseX = 0f; //좌우 회전값을 담을 변수
    private float mouseY = 0f; //위아래 회전값을 담을 변수
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position;// 위치는 플레이어를 따라감
        if (Input.GetMouseButton(0))
        {
            mouseX += Input.GetAxis("Mouse X");
            mouseY += Input.GetAxis("Mouse Y");
            transform.localEulerAngles = new Vector3(mouseY, mouseX, 0);
        }
    }
    
}
