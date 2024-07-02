using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    List<CinemachineVirtualCamera> cams;

    [SerializeField]
    Volume volume;

    [SerializeField]
    TextMeshProUGUI text;

    float currentExpoValue = 0f;
    float targetExpoValue = 0f;

    void Start()
    {
        ChangeCam(0);
        text.text = "Système solaire";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            ChangeCam(0);
            targetExpoValue = .5f;
            text.text = "Système solaire";
        }

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            ChangeCam(1);
            targetExpoValue = 0.8f;
            text.text = "Mercure";
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            ChangeCam(2);
            targetExpoValue = 1f;
            text.text = "Vénus";
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            ChangeCam(3);
            targetExpoValue = 1.2f;
            text.text = "Terre";
        }

        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            ChangeCam(4);
            targetExpoValue = 1.3f;
            text.text = "Mars";
        }

        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            ChangeCam(5);
            targetExpoValue = 1.4f;
            text.text = "Jupiter";
        }

        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            ChangeCam(6);
            targetExpoValue = 1.5f;
            text.text = "Saturne";
        }

        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            ChangeCam(7);
            targetExpoValue = 1.6f;
            text.text = "Uranus";
        }

        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            ChangeCam(8);
            targetExpoValue = 1.7f;
            text.text = "Neptune";
        }

        currentExpoValue = Mathf.Lerp(currentExpoValue, targetExpoValue, 0.01f);
        ChangeExpo(currentExpoValue);
    }

    private void ChangeExpo(float value)
    {
        ColorAdjustments tmp;

        if (volume.profile.TryGet<ColorAdjustments>(out tmp))
        {
            tmp.postExposure.value = value;
        }
    }

    private void ChangeCam(int camToRender)
    {
        foreach (CinemachineVirtualCamera item in cams)
        {
            item.Priority = 0;
        }

        cams[camToRender].Priority = 10;
    }
}
