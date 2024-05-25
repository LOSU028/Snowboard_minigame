using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SnowTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem snowfx;
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Floor"){
            snowfx.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other){
        if(other.gameObject.tag == "Floor"){
            snowfx.Stop();
        }
    }
}
