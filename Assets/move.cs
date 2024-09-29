using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed; //������ �ӵ�
    float haxis;
    float vaxis;
    [SerializeField] private float mouseSpeed = 8f; //ȸ���ӵ�
    private float mouseX = 0f; //�¿� ȸ������ ���� ����
    private float mouseY = 0f; //���Ʒ� ȸ������ ���� ����
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
        transform.position += movevec.normalized * speed * Time.deltaTime ;//����Ű�� wasd�� �̿��� �̵�
        if (Input.GetMouseButton(0))
        {
            mouseX += Input.GetAxis("Mouse X");
            transform.rotation = Quaternion.Euler(0, mouseX, 0);
        }
    }
}
