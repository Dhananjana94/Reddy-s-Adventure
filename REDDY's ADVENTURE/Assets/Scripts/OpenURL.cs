using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class OpenURL : MonoBehaviour
{
    //if we want to open url in different window use this code 
    public void FB()
    {
#if !UNITY_EDITOR
        openWindow("https://www.facebook.com/");
#endif
    }

    public void GooglePlus()
    {
#if !UNITY_EDITOR
        openWindow("https://www.google.com/");
#endif
    }

    public void Tweet()
    {
#if !UNITY_EDITOR
        openWindow("https://twitter.com/?lang=en");
#endif
    }

    public void Telegram()
    {
#if !UNITY_EDITOR
        openWindow("https://telegram.org/");
#endif
    }


    [DllImport("__Internal")]
    private static extern void openWindow(string url);
}
