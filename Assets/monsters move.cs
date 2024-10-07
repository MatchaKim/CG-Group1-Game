using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript1 : MonoBehaviour
{
    Transform target;
    NavMeshAgent nav;
    Vector3[] cp ;
    int index;
    public float speed;
    
    // Start is called before the first frame update
    private void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        index = 1;
    }
    void Start()
    {
        cp = new Vector3[3];
        cp[0] = transform.position;
        cp[1] = new Vector3(28,transform.position.y,33);
        cp[2] = new Vector3(17,transform.position.y, 33);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x == cp[index].x && transform.position.z == cp[index].z) {
            index++;
            if (index == 3) {
                index = 0;
            }
        }
        nav.SetDestination(cp[index]);
        
        if (Vector3.Distance(Gamemanager.instance.player.transform.position, transform.position)<12)
        {
            nav.speed = this.speed;
            nav.SetDestination(Gamemanager.instance.player.transform.position);
        }
        else {

            nav.SetDestination(cp[index]);
            
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            EditorApplication.isPaused = true;
        }
        else if(collision.gameObject.CompareTag("checkpoint")){
            index++;
        }
    }
    
    

}
