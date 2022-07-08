using UnityEngine;
using UnityEngine.UI;

public class SequenceAudio : MonoBehaviour
{
    [SerializeField] AudioSource MagicAudioSource = null;

    [Header("Audio Clips")]
    [SerializeField] AudioClip magicSound = null;

    public void PlayMagicSound()
    {
        MagicAudioSource.PlayOneShot(magicSound);
    }
}
