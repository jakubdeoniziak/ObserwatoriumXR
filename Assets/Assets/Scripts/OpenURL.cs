using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
   public void OpenPage()
    {
        Application.OpenURL("https://planetarium.olsztyn.pl/o-obserwatorium");
    }

    public void OpenGitHub()
    {
        Application.OpenURL("https://github.com/jakubdeoniziak/ObserwatoriumXR");
    }

}
