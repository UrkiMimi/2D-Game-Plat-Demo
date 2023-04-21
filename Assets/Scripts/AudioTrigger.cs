using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    /* I'm making this completely seperate from the player script because
    that script got messy fast and its horrible to manage.*/

    public AudioSource snd;
    // Start is called before the first frame update
    void Start()
    {
        snd = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Up"))
            snd.Play();
    }
}
