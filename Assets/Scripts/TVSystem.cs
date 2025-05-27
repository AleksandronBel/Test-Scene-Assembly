using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TVSystem : MonoBehaviour
{
    [SerializeField] private List<VideoPlayer> _videosList;

    private void OnEnable()
    {
        foreach (var videos in _videosList)
            videos.gameObject.SetActive(true);
    }
}