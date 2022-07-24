using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputChecker : MonoBehaviour
{
    [SerializeField] private Image Punch;
    [SerializeField] private Image Kick;
    [Space]
    [SerializeField] private Image Up;
    [SerializeField] private Image Down;
    [SerializeField] private Image Left;
    [SerializeField] private Image Right;
    [Space]
    [SerializeField] private Image DownRight;
    [SerializeField] private Image DownLeft;
    [SerializeField] private Image UpRight;
    [SerializeField] private Image UpLeft;

    private List<Image> Images = new List<Image>();

    public void InstantiateImage(Image prefab)
    {
        Image image = Instantiate(prefab, transform);
        image.transform.SetSiblingIndex(0);

        Images.Add(image);
        if (Images.Count > 14)
        {
            Destroy(Images[0].gameObject);
            Images.RemoveAt(0);
        }
    }
}