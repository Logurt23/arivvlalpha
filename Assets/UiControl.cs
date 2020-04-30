using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiControl : MonoBehaviour {

    public GameObject darken;
    public GameObject menu;

    public void OnMenuClicked() {
        bool state = (menu.activeSelf);
        menu.SetActive(!state);
        darken.SetActive(!state);
    }

}
