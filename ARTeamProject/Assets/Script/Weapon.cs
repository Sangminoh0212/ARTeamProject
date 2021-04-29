using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private GameObject Flame, Light, Electric;
    [SerializeField] private ParticleSystem m_FlameThrower, m_LightThrower;
    public GameObject ElectricParticle;
    public List<AudioSource> WeaponSound;

    void Start()
    {
        // ��ü�� �޾ƿ���
        Flame = GameObject.FindWithTag("Flame");
        Light = GameObject.FindWithTag("Light");
        Electric = GameObject.FindWithTag("Electric");
        // ��ü SetActive(false)�ϱ�
        Flame.SetActive(false);
        Light.SetActive(false);
        Electric.SetActive(false);
        // �� ���⺰ �Ѿ˵� ��ƼŬ ��� ���α�
        m_FlameThrower.Stop();
        m_LightThrower.Stop();
        ElectricParticle.SetActive(false);
    }

    void Stop()
    {
        m_FlameThrower.Stop();
        m_LightThrower.Stop();
        ElectricParticle.SetActive(false);
    }

    //Update is called once per frame
    void Update()
    {
        
        // ��ġ && ��ƼŬ���� �÷��� �ǰ� ���� ���� �� 
        if (Input.GetMouseButtonUp(0)&&!m_FlameThrower.isPlaying &&!m_LightThrower.isPlaying&&!ElectricParticle.activeSelf)
        {
            // Flame��ü�� SetActive(true)��
            if(Flame&&Flame.activeSelf)
            {
                // Flame particle 2�ʰ� �߻�
                m_FlameThrower.Play();
                WeaponSound[0].Play();
                Invoke("Stop", 1);
            }
            // Light��ü�� SetActive(true)�� 
            if (Light && Light.activeSelf)
            {
                // Light particle 2�ʰ� �߻�
                m_LightThrower.Play();
                WeaponSound[1].Play();
                Invoke("Stop", 1);
            }
            // Electric��ü�� SetActive(true)��
            if (Electric && Electric.activeSelf)
            {
                // Electric particle 2�ʰ� �߻�
                ElectricParticle.SetActive(true);
                WeaponSound[2].Play();
                Invoke("Stop", 1);
            }
        }
    }

    public void FireChange()
    {
        Stop();
        Flame.gameObject.SetActive(true);
        Light.gameObject.SetActive(false);
        Electric.gameObject.SetActive(false);
    }

    public void LightChange()
    {
        Stop();
        Flame.gameObject.SetActive(false);
        Light.gameObject.SetActive(true);
        Electric.gameObject.SetActive(false);
    }

    public void ElectricChange()
    {
        Stop();
        Flame.gameObject.SetActive(false);
        Light.gameObject.SetActive(false);
        Electric.gameObject.SetActive(true);
    }
}
