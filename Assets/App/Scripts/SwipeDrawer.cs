using System;
using System.Collections;
using UnityEngine;

public class SwipeDrawerTouch : MonoBehaviour {
    [SerializeField] private RectTransform leftDrawer;
    [SerializeField] private RectTransform rightDrawer;
    //[SerializeField] private Camera mainCamera;
    [SerializeField] private float sensitive = 0.01f;
    [SerializeField] private float offSetDrag = 50.0f;
    [SerializeField] private float animationDuration = 0.3f;
    
    public event Action DragEvent;
    public event Action<Vector3> ClickEvent;
    public event Action<Vector2> ChangeDragEvent;

    [SerializeField] 
    private Vector2 _currentPosition;
    
    [SerializeField] 
    private Vector2 _lastPosition;
    
    [SerializeField] 
    private Vector2 _beginPosition;
    
    
    [SerializeField] 
    private bool _firstClick;
    
    [SerializeField] 
    private bool _isDrag;
    
    [SerializeField] 
    private bool _isSwipe;
    
    [SerializeField] 
    private bool _isLeftOpen;
    
    public void Update() {
        UpdateMouseButtons();
        DragEvent?.Invoke();
        HandlerLeftRightPanels();
    }
    
    private void UpdateMouseButtons() {
        if (Input.GetMouseButtonDown(0)) {
            DragEvent += Drag;
            _lastPosition = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0)) {
            Click();
            _firstClick = false;
            _isDrag = false;
            _isSwipe = false;
            DragEvent -= Drag;
        }
    }

    private void Click() {
        if (_isDrag) return;
        //Vector3 targetPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        //ClickEvent?.Invoke(targetPosition);
    }

    private void Drag() {
        _currentPosition = Input.mousePosition;
        if (_currentPosition != _lastPosition) _isDrag = true;
        if (_firstClick == false) {
            _lastPosition = _currentPosition;
            _beginPosition = _lastPosition;
            _firstClick = true;
        }
        //Vector2 delta = _currentPosition - _lastPosition;
        //ChangeDragEvent?.Invoke(delta * sensitive);
        //_lastPosition = _currentPosition;
        
        float deltaX = _currentPosition.x - _beginPosition.x;
        if (deltaX > offSetDrag) {
            _isSwipe = true;
        }
        else _isSwipe = false;
    }


    private void HandlerLeftRightPanels() {
        if (_isLeftOpen) return;
        if (_isSwipe) {
            StartCoroutine(AnimateDrawer(leftDrawer, leftDrawer.anchoredPosition.x, 0));
            _isLeftOpen = true;
        }
    }
    
    IEnumerator AnimateDrawer(RectTransform drawer, float startX, float endX)
    {
        float elapsed = 0;
        while (elapsed < animationDuration)
        {
            elapsed += Time.deltaTime;
            float t = elapsed / animationDuration;
            float newX = Mathf.Lerp(startX, endX, t);
            drawer.anchoredPosition = new Vector2(newX, drawer.anchoredPosition.y);
            yield return null;
        }
        drawer.anchoredPosition = new Vector2(endX, drawer.anchoredPosition.y);
    }
    
    
    // [Header("Шторки")]
    // public RectTransform leftDrawer;
    // public RectTransform rightDrawer;
    //
    // [Header("Настройки свайпа")]
    // public float swipeThresholdCm = 0.7f;      // порог в сантиметрах (0.7 см = ~28 пикселей на обычном экране)
    // public float animationDuration = 0.3f;
    // public bool debugMode = false;              // включить для отладки на телефоне
    //
    // [Header("Зона свайпа (опционально)")]
    // public RectTransform swipeArea;             // если null - весь экран
    //
    // private Vector2 startTouchPos;
    // private bool isSwiping = false;
    // private bool isLeftOpen = false;
    // private bool isRightOpen = false;
    // private float startLeftPos, startRightPos;
    // private float actualSwipeThresholdPixels;
    // private int activeTouchId = -1;
    //
    // void Start()
    // {
    //     if (leftDrawer != null) startLeftPos = leftDrawer.anchoredPosition.x;
    //     if (rightDrawer != null) startRightPos = rightDrawer.anchoredPosition.x;
    //     
    //     // Конвертируем сантиметры в пиксели с учётом DPI экрана
    //     float dpi = Screen.dpi > 0 ? Screen.dpi : 160f;
    //     actualSwipeThresholdPixels = swipeThresholdCm * (dpi / 2.54f);
    //     
    //     if (debugMode) Debug.Log($"DPI: {dpi}, Threshold: {actualSwipeThresholdPixels}px ({swipeThresholdCm}cm)");
    // }
    //
    // void Update()
    // {
    //     HandleTouches();
    //     
    //     // Для тестирования в редакторе
    //     if (Input.GetMouseButtonDown(0)) HandleMouseDown();
    //     if (Input.GetMouseButton(0)) HandleMouseDrag();
    //     if (Input.GetMouseButtonUp(0)) HandleMouseUp();
    // }
    //
    // void HandleTouches()
    // {
    //     if (Input.touchCount == 0)
    //     {
    //         if (isSwiping) CancelSwipe();
    //         return;
    //     }
    //     
    //     foreach (Touch touch in Input.touches)
    //     {
    //         // Если ещё нет активного свайпа - берём первый палец
    //         if (activeTouchId == -1 && touch.phase == TouchPhase.Began)
    //         {
    //             // Проверяем, попадает ли касание в зону свайпа (если задана)
    //             if (IsTouchInSwipeArea(touch.position))
    //             {
    //                 activeTouchId = touch.fingerId;
    //                 startTouchPos = touch.position;
    //                 isSwiping = true;
    //                 
    //                 if (debugMode) Debug.Log($"Touch начат: {touch.position}");
    //             }
    //         }
    //         
    //         // Обрабатываем активный палец
    //         if (touch.fingerId == activeTouchId)
    //         {
    //             switch (touch.phase)
    //             {
    //                 case TouchPhase.Moved:
    //                     HandleSwipeDrag(touch.position);
    //                     break;
    //                 case TouchPhase.Ended:
    //                 case TouchPhase.Canceled:
    //                     HandleSwipeEnd(touch.position);
    //                     activeTouchId = -1;
    //                     isSwiping = false;
    //                     break;
    //             }
    //         }
    //     }
    // }
    //
    // bool IsTouchInSwipeArea(Vector2 screenPos)
    // {
    //     if (swipeArea == null) return true;
    //     
    //     // Конвертируем экранные координаты в локальные координаты зоны свайпа
    //     RectTransformUtility.ScreenPointToLocalPointInRectangle(
    //         swipeArea, screenPos, null, out Vector2 localPoint);
    //     
    //     Rect rect = swipeArea.rect;
    //     bool inside = rect.Contains(localPoint);
    //     
    //     if (debugMode) Debug.Log($"Touch внутри зоны: {inside}");
    //     return inside;
    // }
    //
    // void HandleSwipeDrag(Vector2 currentPos)
    // {
    //     if (!isSwiping) return;
    //     
    //     Vector2 delta = currentPos - startTouchPos;
    //     
    //     // Игнорируем вертикальные свайпы
    //     if (Mathf.Abs(delta.x) < Mathf.Abs(delta.y)) return;
    //     
    //     // Свайп вправо -> тянем левую шторку
    //     if (delta.x > 0 && !isRightOpen && leftDrawer != null)
    //     {
    //         float newX = Mathf.Clamp(startLeftPos + delta.x, -GetWidth(leftDrawer), 0);
    //         leftDrawer.anchoredPosition = new Vector2(newX, leftDrawer.anchoredPosition.y);
    //     }
    //     // Свайп влево -> тянем правую шторку
    //     else if (delta.x < 0 && !isLeftOpen && rightDrawer != null)
    //     {
    //         float newX = Mathf.Clamp(startRightPos + delta.x, 0, GetWidth(rightDrawer));
    //         rightDrawer.anchoredPosition = new Vector2(newX, rightDrawer.anchoredPosition.y);
    //     }
    // }
    //
    // void HandleSwipeEnd(Vector2 endPos)
    // {
    //     if (!isSwiping) return;
    //     
    //     Vector2 delta = endPos - startTouchPos;
    //     
    //     if (debugMode) Debug.Log($"Свайп закончен, delta: {delta.x}, порог: {actualSwipeThresholdPixels}");
    //     
    //     // Свайп вправо
    //     if (delta.x > actualSwipeThresholdPixels && !isRightOpen)
    //     {
    //         OpenLeftDrawer();
    //     }
    //     // Свайп влево
    //     else if (delta.x < -actualSwipeThresholdPixels && !isLeftOpen)
    //     {
    //         OpenRightDrawer();
    //     }
    //     else
    //     {
    //         // Возвращаем шторки на место
    //         if (delta.x > 0 && !isRightOpen) CloseLeftDrawer();
    //         else if (delta.x < 0 && !isLeftOpen) CloseRightDrawer();
    //     }
    // }
    //
    // // --- Обработка мыши для тестирования в редакторе ---
    // void HandleMouseDown()
    // {
    //     if (IsTouchInSwipeArea(Input.mousePosition))
    //     {
    //         startTouchPos = Input.mousePosition;
    //         isSwiping = true;
    //         if (debugMode) Debug.Log("Мышь нажата");
    //     }
    // }
    //
    // void HandleMouseDrag()
    // {
    //     if (!isSwiping) return;
    //     HandleSwipeDrag(Input.mousePosition);
    // }
    //
    // void HandleMouseUp()
    // {
    //     if (!isSwiping) return;
    //     HandleSwipeEnd(Input.mousePosition);
    //     isSwiping = false;
    // }
    // // --- Конец обработки мыши ---
    //
    // void CancelSwipe()
    // {
    //     isSwiping = false;
    //     activeTouchId = -1;
    //     
    //     if (leftDrawer != null && leftDrawer.anchoredPosition.x > startLeftPos + 10)
    //         CloseLeftDrawer();
    //     if (rightDrawer != null && rightDrawer.anchoredPosition.x < startRightPos - 10)
    //         CloseRightDrawer();
    // }
    //
    // void OpenLeftDrawer()
    // {
    //     if (leftDrawer == null) return;
    //     isLeftOpen = true;
    //     StartCoroutine(AnimateDrawer(leftDrawer, leftDrawer.anchoredPosition.x, 0));
    // }
    //
    // void CloseLeftDrawer()
    // {
    //     if (leftDrawer == null) return;
    //     isLeftOpen = false;
    //     StartCoroutine(AnimateDrawer(leftDrawer, leftDrawer.anchoredPosition.x, -GetWidth(leftDrawer)));
    // }
    //
    // void OpenRightDrawer()
    // {
    //     if (rightDrawer == null) return;
    //     isRightOpen = true;
    //     StartCoroutine(AnimateDrawer(rightDrawer, rightDrawer.anchoredPosition.x, 0));
    // }
    //
    // void CloseRightDrawer()
    // {
    //     if (rightDrawer == null) return;
    //     isRightOpen = false;
    //     StartCoroutine(AnimateDrawer(rightDrawer, rightDrawer.anchoredPosition.x, GetWidth(rightDrawer)));
    // }
    //
    // IEnumerator AnimateDrawer(RectTransform drawer, float startX, float endX)
    // {
    //     float elapsed = 0;
    //     while (elapsed < animationDuration)
    //     {
    //         elapsed += Time.deltaTime;
    //         float t = elapsed / animationDuration;
    //         float newX = Mathf.Lerp(startX, endX, t);
    //         drawer.anchoredPosition = new Vector2(newX, drawer.anchoredPosition.y);
    //         yield return null;
    //     }
    //     drawer.anchoredPosition = new Vector2(endX, drawer.anchoredPosition.y);
    // }
    //
    // float GetWidth(RectTransform rect)
    // {
    //     return rect.rect.width;
    // }
    //
    // // Публичные методы для вызова из кнопок
    // public void ToggleLeftDrawer()
    // {
    //     if (isLeftOpen) CloseLeftDrawer();
    //     else OpenLeftDrawer();
    // }
    //
    // public void ToggleRightDrawer()
    // {
    //     if (isRightOpen) CloseRightDrawer();
    //     else OpenRightDrawer();
    // }
    //
    // public void CloseAllDrawers()
    // {
    //     if (isLeftOpen) CloseLeftDrawer();
    //     if (isRightOpen) CloseRightDrawer();
    // }
}