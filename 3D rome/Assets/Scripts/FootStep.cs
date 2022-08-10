using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStep : MonoBehaviour
{
    [SerializeField] private AudioClip[] clips;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Step(){
        AudioClip clip = getRandomClip();
        audioSource.PlayOneShot(clip);
    }

    private AudioClip getRandomClip(){
        return clips[UnityEngine.Random.Range(0, clips.Length)];
    }
}
