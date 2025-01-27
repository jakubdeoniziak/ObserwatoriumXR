using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;
public class Location : MonoBehaviour
{
    [SerializeField]
    private char unit = 'K';

    public TMP_Text debugTxt;
    public bool gps_ok = false;
    float PI = Mathf.PI;

    bool measureDistance = false;

    //  Start jest wywo³ywany przed aktualizacj¹ pierwszej klatki
    IEnumerator Start()
    {
        // SprawdŸ, czy u¿ytkownik ma w³¹czon¹ us³ugê lokalizacji.
        if (!Input.location.isEnabledByUser)
        {
            Debug.Log("Lokalizacja nie jest w³¹czona na urz¹dzeniu lub aplikacja nie ma uprawnieñ dostêpu do lokalizacji.");
            debugTxt.text = "Lokalizacja nie jest w³¹czona na urz¹dzeniu lub aplikacja nie ma uprawnieñ dostêpu do lokalizacji.";
        }
        // Uruchamia us³ugê lokalizacji.
        Input.location.Start();

        // Czeka, a¿ us³uga lokalizacji zostanie zainicjowana
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        //  Jeœli us³uga nie zostanie zainicjowana w ci¹gu 20 sekund, anuluje korzystanie z us³ugi lokalizacji.
        if (maxWait < 1)
        {
            Debug.Log("Timed out");
            debugTxt.text += "\nTimed Out";
            yield break;
        }

        // Jeœli po³¹czenie nie powiedzie siê, anuluje to korzystanie z us³ugi lokalizacji.
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            Debug.LogError("Unable to determine device location");
            debugTxt.text += ("\nUnable to determine device location");

            yield break;
        }
        else
        {
            // Jeœli po³¹czenie siê powiedzie, pobierana jest bie¿¹ca lokalizacja urz¹dzenia i wyœwietlana w oknie konsoli.
            Debug.Log("Lokalizacja: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp);
            debugTxt.text
               = "\nLokalizacja: \nSzerekoœc: " + Input.location.lastData.latitude
                + " \nD³ugoœæ: " + Input.location.lastData.longitude
                + " \nWysokoœæ: " + Input.location.lastData.altitude
                + " \nDok³adnoœæ w poziomie: " + Input.location.lastData.horizontalAccuracy
                + " \nCzas: " + Input.location.lastData.timestamp;

            gps_ok = true;

        }


    }
    // Aktualizacja jest wywo³ywana raz na klatkê
    void Update()
    {
        if (gps_ok)
        {
            debugTxt.text = "GPS:...";

            debugTxt.text
                = "\nLokalizacja: \nD³ugoœæ: " + Input.location.lastData.latitude
                + " \nWysokoœæ: " + Input.location.lastData.longitude
                + " \nDok³adnoœæ w poziomie: " + Input.location.lastData.horizontalAccuracy;

        }
    }
    //kod z:https://github.com/TemporalCoder/UnityAR/blob/main/LocationStuff.cs
}
