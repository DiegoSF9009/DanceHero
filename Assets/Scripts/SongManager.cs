using UnityEngine;
using UnityEngine.Events;

public class SongManager : MonoBehaviour
{
    [SerializeField]

    
    private Animator character;
    [SerializeField]

    private UnityEvent onSetSong;
    [SerializeField]

    private UnityEvent onSongCancel;
    [SerializeField]

    private CharacterData characterData;

    private SongData currentSong;

    public void CancelSong() 
    {
        onSongCancel?.Invoke();
        StopSong();
    }

    public void SetSong(SongData song) 
      
    {
        onSetSong?.Invoke();
        currentSong  = song;
        PlaySong();
    }

    public void PlaySong() 
    
    {
        SoundManager.instance.PlayMusic(currentSong.songName);
        character.Play(currentSong.animationName, 0, 0f);

    }

    public void StopSong()
    {
        onSongCancel?.Invoke();
        SoundManager.instance.PlayMusic(currentSong.songName);
        character.Play(characterData.idleAnimationName, 0, 0f);

    }

}
