using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class music : MonoBehaviour
{

    bool isMute;

    public void Mute()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;
    }
}