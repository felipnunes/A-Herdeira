using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MistySounds : MonoBehaviour
{
    AudioSource steps;
    // Start is called before the first frame update
    void Start()
    {
        steps = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.GetComponent<Miaty_animation>().is_walking && this.gameObject.GetComponent<Misty_controller>().GetOnGround() == true)
        {
            //PlayStepsSound();
        }   
    }

    private void PlayStepsSound()
    {
        if (steps.isPlaying == false)
        {
            steps.Play();
        }
    }
}
