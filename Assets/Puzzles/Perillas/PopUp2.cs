using UnityEngine;
using DG.Tweening;

public class PopUp2 : MonoBehaviour
{
    [SerializeField] private float duration = 0.5f;   // Duraci�n del efecto de pop
    [SerializeField] private float scaleFactor = 1f; // Escalado m�ximo durante el pop
    private Vector2 originalScale;
    public RectTransform rect;


    private void OnEnable()
    {
        originalScale = rect.localScale; // Guardamos el tama�o original
        ShowPopup();
    }

    public void ShowPopup()
    {
        // Reiniciamos el tama�o y aplicamos el efecto de pop
        rect.localScale = Vector3.zero;
        rect.DOScale(originalScale * scaleFactor, duration / 2)
                 .SetEase(Ease.OutBack) // Suavizado de entrada
                 .OnComplete(() => rect.DOScale(originalScale, duration / 2)
                 .SetEase(Ease.InBack)); // Suavizado de salida al tama�o original
    }
}
