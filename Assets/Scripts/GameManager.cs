using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Image imgFade;
    // Start is called before the first frame update
    void Start()
    {
       Invoke("Fade", 1);
    }
    void Fade()
    {
        imgFade.CrossFadeAlpha(0, 2, true);
    }
}
