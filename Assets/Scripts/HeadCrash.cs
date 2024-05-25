using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadCrash : MonoBehaviour
{
    [SerializeField] float timeToReloadCrash = .5f;
    [SerializeField] ParticleSystem crashfx;
    [SerializeField] AudioClip crashSFX;
    bool played = false;
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Floor"){
            FindObjectOfType<PlayerController>().StopControls();
            if(!played){
                crashfx.Play();
                GetComponent<AudioSource>().PlayOneShot(crashSFX);
                played = true;
            }
            Invoke("ReloadScene", timeToReloadCrash);
        }
    }

    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
