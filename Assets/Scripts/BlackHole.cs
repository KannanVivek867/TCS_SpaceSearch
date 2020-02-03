using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BlackHole : MonoBehaviour
{
    public float rotationSpeed;
    private float playerOriginalSize = 0.1f;
    public PlayerController playerController;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,rotationSpeed * Time.deltaTime);

    }

    public void BlackHoleRotate()
    {
         transform.Rotate(0,0,rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
          playerController.PlayerShrink();
          KillPlayer();
        }
    }
private void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
            playerController.transform.localScale = new Vector3(0.16912f, 0.16912f, 0.16912f);
        }
    }
    public void KillPlayer()
    {
        if(playerController.transform.localScale.x <= playerOriginalSize)
        {
            SceneManager.LoadScene(0);
        }
    }

}

