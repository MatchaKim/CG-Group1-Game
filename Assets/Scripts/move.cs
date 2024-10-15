using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody rigid;
    public GameObject ui_text;
    private RaycastHit hit;
    private Ray ray;
    public float speed; //������ �ӵ�
    float haxis;
    float vaxis;
    [SerializeField] private float mouseSpeed = 8f; //ȸ���ӵ�
    private float mouseX = 0f; //�¿� ȸ������ ���� ����
    private float mouseY = 0f; //���Ʒ� ȸ������ ���� ����
    Vector3 movevec;
    public bool[] keys;
    // Start is called before the first frame update
    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();  
    }
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
        ObjectHit();
        
    }
    void ObjectHit()
    {
        ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.CompareTag("key") && Input.GetKeyDown(KeyCode.B))
            {
                key ak = hit.collider.gameObject.GetComponent<key>();
                int aks = ak.number;
                keys[aks] = true;
                Destroy(hit.collider.gameObject);
                Debug.Log("get key");
            }
            else if (hit.collider.gameObject.CompareTag("door") && Input.GetKeyDown(KeyCode.U)){
                hit.collider.gameObject.GetComponent<door>().open();
            }
            else if (hit.collider.gameObject.CompareTag("flashlight"))
            {   
                ui_text.SetActive(true);
                if(Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.gameObject.GetComponent<pickupFlashlight>().OnPickup();
                }
            }
            else
            {
                ui_text.SetActive(false);
            }
        }
        else
        {
            ui_text.SetActive(false);
        }
    }
}