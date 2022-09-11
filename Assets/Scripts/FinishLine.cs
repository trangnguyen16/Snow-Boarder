using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public ParticleSystem FinishEffect;
    
    public float delaytime = 0.8f;
    public float bootSpeed = 15f;
    //Tai sao ham nay ko chay?
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("xong");
    }

    #region xu ly va cham
    void OnTriggerEnter2D(Collider2D other)
    {
        


       
        if(other.tag == "Player")
        {
            FindObjectOfType<PlayerControler>().DisableControls();
            FinishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", delaytime);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
    #endregion
}
