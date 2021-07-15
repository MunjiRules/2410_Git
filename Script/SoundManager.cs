using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{

    Dictionary<string, AudioClip> AudioClipList
        = new Dictionary<string, AudioClip>();

    [SerializeField]
    int SFXChannelCount = 5;

    
    List<AudioSource> SFX = new List<AudioSource>();

    //List<GameObject> SFXChannel;
    //GameObject BGMCHANNEL;

    AudioSource BGM;

    public float BGMVolume = 1f;

    public float SFXVolume = 1f;
    public string BGMName;
    private void Awake()
    {
        var sounds = FindObjectsOfType<SoundManager>();
        if (sounds.Length != 1)
            Destroy(gameObject);
        else
            DontDestroyOnLoad(gameObject);

        Init();
    }
    public void Init()
    {
        if (SFX.Count != 0)
        {
            return;
        }
        for (int i = 0; i < SFXChannelCount; i++)
        {
            GameObject SFXChannel = new GameObject();
            SFXChannel.transform.SetParent(transform);
            SFXChannel.transform.name = "SFXChannel" + i;

            AudioSource temp = SFXChannel.AddComponent<AudioSource>();
            temp.loop = false;
            temp.playOnAwake = false;
            SFX.Add(temp);
        }

        GameObject BGMChannelObject = new GameObject();
        BGMChannelObject.transform.SetParent(transform);
        BGMChannelObject.transform.name = "BGMChannel";
        BGM = BGMChannelObject.AddComponent<AudioSource>();
        BGM.loop = true;

        if (PlayerPrefs.HasKey("SFXVolume") && PlayerPrefs.HasKey("BGMVolume"))
        {
            BGMVolume = PlayerPrefs.GetFloat("BGMVolume");
            SFXVolume = PlayerPrefs.GetFloat("SFXVolume");
            ChangeVolumeBGM(BGMVolume);
            ChangeVolumeSFX(SFXVolume);
        }
        else
        {
            BGMVolume = 0.5f;
            SFXVolume = 0.5f;

            PlayerPrefs.SetFloat("BGMVolume", BGMVolume);
            PlayerPrefs.SetFloat("SFXVolume", SFXVolume);
        }
        loadSounds();
    }

    public void ChangeVolumeSFX(float val)
    {
        SFXVolume = val;
        for (int i = 0; i < SFX.Count; i++)
        {
            SFX[i].volume = SFXVolume;
        }
        PlayerPrefs.SetFloat("SFXVolume", val);
    }
    public void ChangeVolumeBGM(float val)
    {
        BGMVolume = val;
        PlayerPrefs.SetFloat("BGMVolume", val);
        BGM.volume = val;
    }

    private void loadSounds()
    {
        AudioClip aud = null;
        object[] temp = Resources.LoadAll<AudioClip>("Sounds");

        for (int i = 0; i < temp.Length; i++)
        {
            aud = temp[i] as AudioClip;
            AudioClipList.Add(aud.name, aud);
        }
    }

    public void PlaySFX(string soundName)
    {
        if (!AudioClipList.ContainsKey(soundName))
            return;
        for (int i = 0; i < SFX.Count; i++)
        {
            if (SFX[i].isPlaying)
                continue;
            SFX[i].clip = AudioClipList[soundName];
            SFX[i].Play();
            return;
        }
        GameObject SFXChannel = new GameObject();
        SFXChannel.transform.SetParent(transform);
        SFXChannel.transform.name = "SFXChannel" + SFX.Count;


        AudioSource temp = SFXChannel.AddComponent<AudioSource>();
        temp.volume = PlayerPrefs.GetFloat("SFXVolume");
        temp.loop = false;
        temp.playOnAwake = false;
        SFX.Add(temp);

        temp.clip = AudioClipList[soundName];
        temp.Play();
    }

    public void PlayBGM(string BgmName)
    {
        if (BGM.isPlaying)
        {
            BGM.Stop();
        }
        if (BgmName != null)
        {
            BGM.clip = AudioClipList[BgmName];
            BGMName = BgmName;
            BGM.Play();
        }
    }
    public void StopSFX()
    {
        if (BGM.isPlaying)
        {
            for (int i = 0; i < SFX.Count; i++)
            {
                if (!SFX[i].isPlaying)
                    break;
                SFX[i].Stop();
            }
        }
    }
   
    public void PlayBGM()
    {
        if (BGM.clip != null)
        {
            BGM.Play();
        }
    }
    public void StopBGM()
    {
        if (BGM.isPlaying)
        {
            BGM.Stop();
        }
    }

    public float BGMLength()
    {
        return BGM.clip.length;
    }

    public void BGMLoop(bool loop)
    {
        BGM.loop = loop;
    }

    public bool isPlayingBGM()
    {
        return BGM.isPlaying;
    }

}
