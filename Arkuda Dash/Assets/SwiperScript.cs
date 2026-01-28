using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwiperScript : MonoBehaviour
{
    public RectTransform[] panels;
    public float swipeDuration = 0.5f;

    private int currentIndex = 0;
    private bool isSwiping = false;

    float PageWidth
    {
        get
        {
            // Parent is the container/viewport that defines visible width
            RectTransform parent = panels[0].parent as RectTransform;
            return parent.rect.width; // UI units that match anchoredPosition
        }
    }

    public void NextPanel()
    {
        if (currentIndex < panels.Length - 1 && !isSwiping)
        {
            currentIndex++;
            StartCoroutine(SwipeToPanel());
        }
    }

    public void PreviousPanel()
    {
        if (currentIndex > 0 && !isSwiping)
        {
            currentIndex--;
            StartCoroutine(SwipeToPanel());
        }
    }

    private IEnumerator SwipeToPanel()
    {
        isSwiping = true;

        float elapsed = 0f;
        Vector2[] startPositions = new Vector2[panels.Length];
        Vector2[] targetPositions = new Vector2[panels.Length];

        float w = PageWidth;

        for (int i = 0; i < panels.Length; i++)
        {
            startPositions[i] = panels[i].anchoredPosition;
            targetPositions[i] = new Vector2((i - currentIndex) * w, startPositions[i].y);
        }

        while (elapsed < swipeDuration)
        {
            elapsed += Time.deltaTime;
            float t = elapsed / swipeDuration;

            for (int i = 0; i < panels.Length; i++)
                panels[i].anchoredPosition = Vector2.Lerp(startPositions[i], targetPositions[i], t);

            yield return null;
        }

        for (int i = 0; i < panels.Length; i++)
            panels[i].anchoredPosition = targetPositions[i];

        isSwiping = false;
    }

}
