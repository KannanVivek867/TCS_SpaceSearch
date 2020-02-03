using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{
   public GameObject glieseplanetInfo;
   public GameObject keplerplanetInfo;

    private void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Gliese"))
        {
            glieseplanetInfo.SetActive(true);
        }
        if(collider.gameObject.CompareTag("kepler"))
        {
            keplerplanetInfo.SetActive(true);
        }
    }
private void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Gliese"))
        {
            glieseplanetInfo.SetActive(false);
        }
        if(collider.gameObject.CompareTag("kepler"))
        {
            keplerplanetInfo.SetActive(false);
        }
    
    }
     

}
