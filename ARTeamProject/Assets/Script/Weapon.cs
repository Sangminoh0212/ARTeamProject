using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private GameObject Flame, Light, Electric;
    [SerializeField] private ParticleSystem m_FlameThrower, m_LightThrower;
    public GameObject ElectricParticle;
    
    void Start()
    {
        // ��ü�� �޾ƿ���
        Flame = GameObject.FindWithTag("Flame");
        Light = GameObject.FindWithTag("Light");
        Electric = GameObject.FindWithTag("Electric");
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
        
        // �ϴ� ��ġ�� �νĹ޴´�. 
        if (Input.GetMouseButtonDown(0))
        {
            // Flame��ü�� SetActive(true)��
            if(Flame&&Flame.activeSelf)
            {
                // Flame particle 2�ʰ� �߻�
                m_FlameThrower.Play();
                Invoke("Stop", 2);
            }
            // Light��ü�� SetActive(true)�� 
            if (Light && Light.activeSelf)
            {
                // Light particle 2�ʰ� �߻�
                m_LightThrower.Play();
                Invoke("Stop", 2);
            }
            // Electric��ü�� SetActive(true)��
            if (Electric && Electric.activeSelf)
            {
                // Electric particle 2�ʰ� �߻�
                ElectricParticle.SetActive(true);
                Invoke("Stop", 2);
            }
        }
    }
}
