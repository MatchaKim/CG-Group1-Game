using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    [SerializeField] private float mouseSpeed = 8f; //ȸ���ӵ�
    private float mouseX = 0f; //�¿� ȸ������ ���� ����
    private float mouseY = 0f; //���Ʒ� ȸ������ ���� ����
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position;// ��ġ�� �÷��̾ ����
        if (Input.GetMouseButton(0))
        {
            mouseX += Input.GetAxis("Mouse X");
            mouseY += Input.GetAxis("Mouse Y");
            transform.localEulerAngles = new Vector3(mouseY, mouseX, 0);
        }
    }
    
}
