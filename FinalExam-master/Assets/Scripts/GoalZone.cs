using UnityEngine;
using System.Collections.Generic;

public class GoalZone : MonoBehaviour
{

    public AudioSource goalAudio;

    // Reference to all the particle systems we want to fire when a goal is scored.
    public List<ParticleSystem> goalParticleSystems;

    /* If you're working with a triggered collision (intersection),
   * this is called when the triggered collision starts. */
    void OnTriggerStay(Collider collider)
    {
        goalAudio.Play();

        Destroy(collider.gameObject);
    }

}

 
