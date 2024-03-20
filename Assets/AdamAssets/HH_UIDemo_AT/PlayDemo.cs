using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayDemo : MonoBehaviour
{
    public Button playButton;
    public GameObject demo;
    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(PlayVideo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PlayVideo()
    {
        demo.SetActive(true);
    }

}
