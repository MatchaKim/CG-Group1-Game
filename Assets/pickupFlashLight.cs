using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupFlashlight : MonoBehaviour
{
    public GameObject flashlight_table, flashlight_hand;
    public AudioSource pickup;

    // 상호작용 가능한 이벤트에 플래시라이트 핸들러 추가
    public void Start() 
    {
        
    }

    // 플래시라이트를 테이블에서 들어 손에 들었을 때
    public void OnPickup()
    {
        flashlight_hand.SetActive(true);
        flashlight_table.SetActive(false);
    }
}
