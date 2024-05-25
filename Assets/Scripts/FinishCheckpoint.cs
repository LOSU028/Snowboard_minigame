using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishCheckpoint : MonoBehaviour
{
    [SerializeField] float timeToReload = 1f;
    [SerializeField] ParticleSystem finishfx;

    bool played = false;
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            finishfx.Play();
             Invoke("ReloadScene", timeToReload);
             if(!played){
                GetComponent<AudioSource>().Play();
                played = true;
             }
        }
    }

    void ReloadScene(){ //IS THAT A PERSONA REFERENCE?! >:O
        SceneManager.LoadScene(0); 
    }

}
