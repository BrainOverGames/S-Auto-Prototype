using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideosToLoad : MonoBehaviour 
{
	public RawImage image;
	public GameObject playIcon;
	public VideoClip videoToPlay;

	private VideoPlayer videoPlayer;
	private VideoSource videoSource;

	private AudioSource audioSource;

	private bool isPaused = false;
	private bool firstRun=true;
	
	IEnumerator playVideo()
	{
		playIcon.SetActive (false);
		firstRun = false;
		videoPlayer = gameObject.AddComponent<VideoPlayer> ();
		audioSource = gameObject.AddComponent<AudioSource> ();
		videoPlayer.playOnAwake = false;
		audioSource.playOnAwake = false;
		audioSource.Pause ();

		videoPlayer.source = VideoSource.VideoClip;
		videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
		videoPlayer.EnableAudioTrack (0,true);
		videoPlayer.SetTargetAudioSource (0, audioSource);
		videoPlayer.clip = videoToPlay;
		videoPlayer.Prepare ();
		WaitForSeconds waitTime = new WaitForSeconds (1);
		while (!videoPlayer.isPrepared) 
		{
			Debug.Log ("Preparing video");
			yield return waitTime;
			break;
		}
		image.texture = videoPlayer.texture;
		videoPlayer.Play ();
		audioSource.Play ();

	}

	public void PlayPause()
	{
		if (!firstRun && !isPaused) {
			videoPlayer.Pause ();
			audioSource.Pause ();
			isPaused = true;
			playIcon.SetActive (true);
		} else if (!firstRun && isPaused) {
			videoPlayer.Play ();
			audioSource.Play ();
			isPaused = false;
			playIcon.SetActive (false);
		} 
		else 
		{
			StartCoroutine (playVideo());
		}
	}
}
