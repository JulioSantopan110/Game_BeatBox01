using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx : MonoBehaviour
{
    public static AudioClip SplashStart, SplashEnd, SoundChat, MusicSound, SoundWalk, SoundMenu;
    static AudioSource audioSrc, musicSource;

    void Start()
    {
        SplashStart = Resources.Load<AudioClip>("Splash_Start");
        SplashEnd = Resources.Load<AudioClip>("Splash_End");
        SoundChat = Resources.Load<AudioClip>("chat");
        SoundWalk = Resources.Load<AudioClip>("walk");
        SoundMenu = Resources.Load<AudioClip>("menu");

        audioSrc = GetComponent<AudioSource>();
    }

    public  static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "Splash_Start":
                audioSrc.PlayOneShot(SplashStart);
                break;
            case "Splash_End":
                audioSrc.PlayOneShot(SplashEnd);
                break;
            case "chat":
                audioSrc.PlayOneShot(SoundChat);
                break;
            case "walk":
                audioSrc.PlayOneShot(SoundWalk);
                break;
            case "menu":
                audioSrc.PlayOneShot(SoundMenu);
                break;
        }
    }
}
