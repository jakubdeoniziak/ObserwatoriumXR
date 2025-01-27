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

    //  Start jest wywo�ywany przed aktualizacj� pierwszej klatki
    IEnumerator Start()
    {
        // Sprawd�, czy u�ytkownik ma w��czon� us�ug� lokalizacji.
        if (!Input.location.isEnabledByUser)
        {
            Debug.Log("Lokalizacja nie jest w��czona na urz�dzeniu lub aplikacja nie ma uprawnie� dost�pu do lokalizacji.");
            debugTxt.text = "Lokalizacja nie jest w��czona na urz�dzeniu lub aplikacja nie ma uprawnie� dost�pu do lokalizacji.";
        }
        // Uruchamia us�ug� lokalizacji.
        Input.location.Start();

        // Czeka, a� us�uga lokalizacji zostanie zainicjowana
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        //  Je�li us�uga nie zostanie zainicjowana w ci�gu 20 sekund, anuluje korzystanie z us�ugi lokalizacji.
        if (maxWait < 1)
        {
            Debug.Log("Timed out");
            debugTxt.text += "\nTimed Out";
            yield break;
        }

        // Je�li po��czenie nie powiedzie si�, anuluje to korzystanie z us�ugi lokalizacji.
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            Debug.LogError("Unable to determine device location");
            debugTxt.text += ("\nUnable to determine device location");

            yield break;
        }
        else
        {
            // Je�li po��czenie si� powiedzie, pobierana jest bie��ca lokalizacja urz�dzenia i wy�wietlana w oknie konsoli.
            Debug.Log("Lokalizacja: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp);
            debugTxt.text
               = "\nLokalizacja: \nSzereko�c: " + Input.location.lastData.latitude
                + " \nD�ugo��: " + Input.location.lastData.longitude
                + " \nWysoko��: " + Input.location.lastData.altitude
                + " \nDok�adno�� w poziomie: " + Input.location.lastData.horizontalAccuracy
                + " \nCzas: " + Input.location.lastData.timestamp;

            gps_ok = true;

        }


    }
    // Aktualizacja jest wywo�ywana raz na klatk�
    void Update()
    {
        if (gps_ok)
        {
            debugTxt.text = "GPS:...";

            debugTxt.text
                = "\nLokalizacja: \nD�ugo��: " + Input.location.lastData.latitude
                + " \nWysoko��: " + Input.location.lastData.longitude
                + " \nDok�adno�� w poziomie: " + Input.location.lastData.horizontalAccuracy;

        }
    }
    //kod z:https://github.com/TemporalCoder/UnityAR/blob/main/LocationStuff.cs
}
