using System;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class TypewriterEffect : MonoBehaviour
{
    private TMP_Text _textBox;

    [Header("Test String")] 
    [SerializeField] private string testText;

    private int _currentVisibleCharacterIndex;
    private Coroutine _typewriterCoroutine;

    private WaitForSeconds _simpleDelay;
    private WaitForSeconds _interpunctuationDelay;

    [Header("Typewriter Settings")] 
    [SerializeField] private float charactersPerSecond = 2;
    [SerializeField] private float interpunctuationDelay = 0.5f;

    private void Awake()
    {
        _textBox = GetComponent<TMP_Text>();

        _simpleDelay = new WaitForSeconds(1 / charactersPerSecond);
        _interpunctuationDelay = new WaitForSeconds(interpunctuationDelay);
    }

    private void Start()
    {
        SetText(testText);
    }

    private void SetText(string text)
    {
        _textBox.text = text;
        _textBox.maxVisibleCharacters = 0;
    }
}
