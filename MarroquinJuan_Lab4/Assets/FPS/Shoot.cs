using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Characters.FirstPerson
{
    public class Shoot : MonoBehaviour
    {
        public FirstPersonController fps;
        public float upRecoil;
        public float sideRecoil;
        private AudioSource sound;
        // Start is called before the first frame update
        void Start()
        {
            sound = GetComponent<AudioSource>();
        }
        // Update is called once per frame
        void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                //fps.m_MouseLook.AddRecoil(upRecoil,sideRecoil);
                sound.Play();
            }
        }
    }
}
