using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayCard : MonoBehaviour
{
    public Button TitleCardButton;
    public GameObject card;
    // Start is called before the first frame update
    void Start()
    {
        TitleCardButton.onClick.AddListener(PlayVideo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PlayVideo()
    {
        card.SetActive(true);
    }

}
