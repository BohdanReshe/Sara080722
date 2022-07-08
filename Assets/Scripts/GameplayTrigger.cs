using UnityEngine;
using UnityEngine.Playables;

[RequireComponent(typeof(PlayableDirector))]

public class GameplayTrigger : MonoBehaviour

{
    [SerializeField] SequenceAudio sequenceAudio = null;

    public bool repeatable = false;

    private void Start()
    {
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (enabled && collision.CompareTag("Player"))
        {
            GetComponent<PlayableDirector>().Play();
            sequenceAudio.PlayMagicSound();
            if (!repeatable)
                enabled = false;
        }
    }
}
