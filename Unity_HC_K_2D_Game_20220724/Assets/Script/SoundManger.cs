using UnityEngine;

namespace Su
{
    [RequireComponent(typeof(AudioSource))]
    public class SoundManger : MonoBehaviour
    {
        public static SoundManger instance;

        private AudioSource aud;

        private void Awake()
        {
            instance = this;
            aud = GetComponent<AudioSource>();
        }

        public void PlaySound(AudioClip sound,Vector2 rangeVolume)
        {
            aud.PlayOneShot(sound, Random.Range(rangeVolume.x, rangeVolume.y));
        }
    }

}
