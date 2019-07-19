using UnityEngine;
using UnityEngine.UI;


public class Skalar : MonoBehaviour
{
    AudioSource audioSource;
    public Text text;
    bool tulisan;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        tulisan = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Mute() {
        //audioSource.mute = !audioSource.mute;
        if (tulisan)
        {
            audioSource.Stop();
            text.text = "Musik OFF";
            tulisan = false;
        }
        else {
            audioSource.Play();
            text.text = "Musik ON";
            tulisan = true;
        }
    }
}
