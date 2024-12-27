using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTypingEffect : MonoBehaviour
{
    [SerializeField]
    Text _text;

    Coroutine _coroutine;
    public bool isTyping;
    private void Start()
    {
    }

    public void StartTyping(float delayTime)
    {
        if(_coroutine != null)
            StopCoroutine(_coroutine);
        _coroutine = StartCoroutine(Typing(delayTime));
    }
    public void StartTyping(float delayTime, string text)
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);
        _coroutine = StartCoroutine(TypingString(delayTime,text));
    }
    IEnumerator Typing(float delayTime)
    {
        isTyping = true;
        yield return new WaitForSeconds(delayTime); 
        string value = _text.text;
        _text.text = "";
        foreach (char c in value.ToCharArray())
        {
            _text.text += c.ToString();
            yield return new WaitForSeconds(0.0225f);
        }
        isTyping = false;
    }
    IEnumerator TypingString(float delayTime, string text)
    {
        isTyping = true;
        yield return new WaitForSeconds(delayTime);
        _text.text = "";
        foreach (char c in text.ToCharArray())
        {
            _text.text += c.ToString();
            yield return new WaitForSeconds(0.03f);
        }
        isTyping = false;
    }
    public void StopTyping()
    {
        isTyping = false;
        StopCoroutine(_coroutine);
    }
}
