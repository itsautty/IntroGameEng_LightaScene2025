using UnityEngine;
using UnityEngine.Playables;

public class Timeline3Trigger : MonoBehaviour

{
    public PlayableDirector timeline;


    void OnTriggerEnter(Collider other)
    {
        timeline.Play();
        Destroy(this.gameObject);
    }
}

