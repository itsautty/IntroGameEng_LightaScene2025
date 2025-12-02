using UnityEngine;
using UnityEngine.Playables;

public class Timeline4Trigger : MonoBehaviour
{
    public PlayableDirector timeline;


    void OnTriggerEnter(Collider other)
    {
        timeline.Play();
        Destroy(this.gameObject);
    }
}
