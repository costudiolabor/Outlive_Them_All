using System;
using System.Collections;
using UnityEngine;

public class SwipeDrawerTouch : MonoBehaviour
{
    [SerializeField] private RectTransform parentClosePanel;
    [SerializeField] private RectTransform parentOpenPanel;
    [SerializeField] private RectTransform leftPanel;
    [SerializeField] private RectTransform rightPanel;
    //[SerializeField] private float sensitive = 0.01f;
    [SerializeField] private float offSetDrag = 50.0f;
    [SerializeField] private float animationDuration = 0.3f;

    private float _startPositionLeftPanelX;
    private float _startPositionRightPanelX;
    private bool _lockCoroutine;
    private float _currentPosition;
    private float _beginPosition;
    private bool _firstClick;
    private bool _isSwipe;
    private bool _isLeftOpen;
    private bool _isRightOpen;
    private bool _isLeftInRightSwipe;
    private float _startPositionX;
    private float _endPositionX;

    private RectTransform _lastParent;
    
    private const float EndPositionLeftPanelX = 0;
    private const float EndPositionRightPanelX = 0;
    public event Action DragEvent;

    private void Start() {
        _startPositionLeftPanelX = leftPanel.anchoredPosition.x;
        _startPositionRightPanelX = rightPanel.anchoredPosition.x;
    }

    public void Update() {
        UpdateMouseButtons();
        DragEvent?.Invoke();
        HandlerLeftRightPanels();
    }
    
    private void UpdateMouseButtons() {
        if (Input.GetMouseButtonDown(0)) {
            DragEvent += Drag;
        }
        if (Input.GetMouseButtonUp(0)) {
            _firstClick = false;
            _isSwipe = false;
            DragEvent -= Drag;
        }
    }

    private void Drag() {
        _currentPosition = Input.mousePosition.x;
        if (_firstClick == false) {
            _beginPosition = _currentPosition;
            _firstClick = true;
        }
        float deltaX = _currentPosition - _beginPosition;
        _isLeftInRightSwipe = deltaX > 0;
        deltaX = Mathf.Abs(deltaX);
        
        if (deltaX > offSetDrag) { _isSwipe = true; }
        else _isSwipe = false;
    }

    private void HandlerLeftRightPanels() {
        if (_lockCoroutine) return;
        if (!_isSwipe) return;
        if (_isLeftInRightSwipe == true) {
            if (_isRightOpen == true) { CloseRightPanel(); }
            else if (_isLeftOpen == false) { OpenLeftPanel(); }
        }
        else {
            if (_isLeftOpen == true) { CloseLeftPanel(); }
            else if (_isRightOpen == false) { OpenRightPanel(); }
        }
    }
    
    private void OpenLeftPanel() {
        _startPositionX = _startPositionLeftPanelX;
        _endPositionX = EndPositionLeftPanelX;
        _isLeftOpen = true;
        rightPanel.SetParent(parentClosePanel);
        leftPanel.SetParent(parentOpenPanel);
        StartCoroutine(AnimatePanel(leftPanel, _startPositionX, _endPositionX));
    }
    
    private void CloseLeftPanel() {
        _startPositionX = EndPositionLeftPanelX;
        _endPositionX = _startPositionLeftPanelX;
        _isLeftOpen = false;
        StartCoroutine(AnimatePanel(leftPanel, _startPositionX, _endPositionX));
    }
    
    private void OpenRightPanel() {
        _startPositionX = _startPositionRightPanelX;
        _endPositionX = EndPositionRightPanelX;
        _isRightOpen = true;
        leftPanel.SetParent(parentClosePanel);
        rightPanel.SetParent(parentOpenPanel);
        StartCoroutine(AnimatePanel(rightPanel, _startPositionX, _endPositionX));
    }
    
    private void CloseRightPanel() {
        _startPositionX = EndPositionRightPanelX;
        _endPositionX = _startPositionRightPanelX;
        _isRightOpen = false;
        StartCoroutine(AnimatePanel(rightPanel, _startPositionX, _endPositionX));
    }
    
    
    IEnumerator AnimatePanel(RectTransform panel, float startX, float endX) {
        if (_lockCoroutine) yield break;
        _lockCoroutine = true;
        float elapsed = 0;
        while (elapsed < animationDuration) {
            elapsed += Time.deltaTime;
            float t = elapsed / animationDuration;
            float newX = Mathf.Lerp(startX, endX, t);
            panel.anchoredPosition = new Vector2(newX, panel.anchoredPosition.y);
            yield return null;
        }
        panel.anchoredPosition = new Vector2(endX, panel.anchoredPosition.y);
        _lockCoroutine = false;
    }
}