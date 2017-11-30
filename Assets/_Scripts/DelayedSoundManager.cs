using UnityEngine;

public class DelayedSoundManager : MonoBehaviour 
{
    public AudioSource audioSourcePacmandMusic;
    public AudioSource audioSourceDies;

    /// <summary>
    /// play the pacman music immediately
    /// </summary>
    public void ACTION_PlayMusicNow()
    {
        audioSourcePacmandMusic.Play();
    }

    /// <summary>
    /// play the pacman dies sound after a 1.0 second delay
    /// </summary>
    public void ACTION_PlayDiesSoundAfterDelay()
    {
        float delay = 1.0F;
        audioSourceDies.PlayDelayed(delay);
    }
}