using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour

{
    [SerializeField] public ParticleSystem Crash;
    [SerializeField] public float Delaytime;
    public bool hasCrash = false;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground" && !hasCrash)
        {
            hasCrash = true;//dk la chua co crash sau khi vao thi da cham gan cos crash
            FindObjectOfType<PlayerControler>().DisableControls();
            Crash.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", Delaytime);
        }
    }
    void ReloadScene()
        {
        SceneManager.LoadScene(0);        
        }
}