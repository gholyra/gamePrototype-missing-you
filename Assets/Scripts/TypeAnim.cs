using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TypeAnim : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scenePhrase;
    
    private string phrase;

    private int currentVisibleCharacterIndex;
    private Coroutine typewriterCoroutine;
    
    private void Awake()
    {
        phrase = scenePhrase.text;
    }

    private void Start()
    {
        for (int i = 0; i < phrase.Length; i++)
        {
            
        }
        Debug.Log(phrase);
    }
}
