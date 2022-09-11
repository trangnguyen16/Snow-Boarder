using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DastTrail : MonoBehaviour
{
    public ParticleSystem dustParticcles;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            dustParticcles.Play();
        }
    }
    public void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            dustParticcles.Stop();
        }
    }
}
