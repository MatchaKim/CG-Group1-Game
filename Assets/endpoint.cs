using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class endpoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player") {
            EditorApplication.isPaused = true;
        }
    }
}
