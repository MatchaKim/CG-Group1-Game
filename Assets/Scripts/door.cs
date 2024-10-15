using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class door : MonoBehaviour
{
    public int kn;
    bool dopen;
    // Start is called before the first frame update
    void Start()
    {
        dopen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void open()
    {
        if (Gamemanager.instance.player.keys[kn] == true )
        {
            if (dopen == false)
            {
                transform.rotation = Quaternion.Euler(0, 90, 0);
                Debug.Log("open");
                dopen = true;
            }
            else {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                Debug.Log("close");
                dopen = false;
            }
        }
    }
}
