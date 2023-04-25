using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Meta.WitAi.TTS.Data;
using Meta.WitAi.TTS;
using Meta.WitAi.TTS.Utilities;

public class Speak : MonoBehaviour
{
        public TTSSpeaker ttsSpeaker;

    private void Start()
    {
      ttsSpeaker = FindAnyObjectByType<TTSSpeaker>();
        SpeakText("Hello");
    }
    public void SpeakText(string text)
    {
        ttsSpeaker.Speak("Hello, I am your Text-to-Speech system.");
    }
}
    