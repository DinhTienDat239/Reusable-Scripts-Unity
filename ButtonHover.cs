using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHover : MonoBehaviour
{
    [SerializeField]
    Image _buttonSprite;
    [SerializeField]
    Sprite _originSprite;
    [SerializeField]
    Sprite _hoverSprite;
    [SerializeField]
    Text _text;
    [SerializeField]
    Color _textOriginColor;
    [SerializeField]
    Color _textHoverColor;
    // Start is called before the first frame update
    void Start()
    {
        _buttonSprite.sprite = _originSprite;
        _text.color = _textOriginColor;
    }

    public void OnHoverIn()
    {
        _buttonSprite.sprite = _hoverSprite;
        _text.color = _textHoverColor;
    }
    public void OnHoverOut()
    {
        _buttonSprite.sprite = _originSprite;
        _text.color = _textOriginColor;
    }
}
