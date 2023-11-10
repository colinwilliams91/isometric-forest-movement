using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFX : MonoBehaviour
{
    [Header("Particles")]
    [SerializeField] ParticleSystem _fx_dust;
    [SerializeField] ParticleSystem _fx_player_hit;

    Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void KickupDust()
    {
        ParticleSystem dustFX = Instantiate(_fx_dust, transform);

        dustFX.Play();

        Destroy(dustFX, dustFX.main.duration + dustFX.main.startLifetime.constantMax);
    }
}
