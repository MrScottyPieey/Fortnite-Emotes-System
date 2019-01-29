using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


[RequireComponent(typeof(AudioSource))]

public class EmotePicker : MonoBehaviour
{
    private Animation anim;
    public AudioClip clip;



    void Start()
    {


    }


    void Update()
    {

    }


    public void FlossDance()
    {
        anim.Play("FlossDance");
    }


    public void TEST4()
    {
        anim.Play("FlossDance");
    }

    public void TEST3()
    {
        anim.Play("FlossDance");
    }

    public void TEST2()
    {
        anim.Play("FlossDance");
    }

    public void TEST1()
    {
        anim.Play("FlossDance");
    }


    public void TEST()
    {
        anim.Play("FlossDance");
    }

    public void MattesDance()
    {
        AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));
    }
      
}
