using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlWarna : MonoBehaviour
{
    public GameObject brush_hitam;
	public GameObject brush_putih;
	public GameObject brush_biru;
	public GameObject brush_kuning;
	public GameObject brush_hijau;
	public GameObject brush_merah;

    public GameObject warna_hitam = null;
	public GameObject warna_putih = null;
	public GameObject warna_biru = null;
	public GameObject warna_kuning = null;
	public GameObject warna_hijau = null;
	public GameObject warna_merah = null;

    void Update(){
        if(Input.GetMouseButtonDown(0)){
			Vector3 klik = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			BoxCollider2D warna_hitam1 = warna_hitam.GetComponent<BoxCollider2D>();
			BoxCollider2D warna_putih1 = warna_putih.GetComponent<BoxCollider2D>();
			BoxCollider2D warna_biru1 = warna_biru.GetComponent<BoxCollider2D>();
			BoxCollider2D warna_kuning1 = warna_kuning.GetComponent<BoxCollider2D>();
			BoxCollider2D warna_hijau1 = warna_hijau.GetComponent<BoxCollider2D>();
			BoxCollider2D warna_merah1 = warna_merah.GetComponent<BoxCollider2D>();		
		
			if (warna_hitam1.OverlapPoint (klik)) {
				
                brush_hitam.SetActive(true);
                brush_putih.SetActive(false);
                brush_biru.SetActive(false);
                brush_kuning.SetActive(false);
                brush_hijau.SetActive(false);
                brush_merah.SetActive(false);
			} else if (warna_putih1.OverlapPoint (klik)) {
				brush_hitam.SetActive(false);
                brush_putih.SetActive(true);
                brush_biru.SetActive(false);
                brush_kuning.SetActive(false);
                brush_hijau.SetActive(false);
                brush_merah.SetActive(false);
			} else if (warna_biru1.OverlapPoint (klik)) {
				brush_hitam.SetActive(false);
                brush_putih.SetActive(false);
                brush_biru.SetActive(true);
                brush_kuning.SetActive(false);
                brush_hijau.SetActive(false);
                brush_merah.SetActive(false);
			} else if (warna_kuning1.OverlapPoint (klik)) {
				brush_hitam.SetActive(false);
                brush_putih.SetActive(false);
                brush_biru.SetActive(false);
                brush_kuning.SetActive(true);
                brush_hijau.SetActive(false);
                brush_merah.SetActive(false);
			} else if (warna_hijau1.OverlapPoint (klik)) {
				brush_hitam.SetActive(false);
                brush_putih.SetActive(false);
                brush_biru.SetActive(false);
                brush_kuning.SetActive(false);
                brush_hijau.SetActive(true);
                brush_merah.SetActive(false);
			} else if (warna_merah1.OverlapPoint (klik)) {
				brush_hitam.SetActive(false);
                brush_putih.SetActive(false);
                brush_biru.SetActive(false);
                brush_kuning.SetActive(false);
                brush_hijau.SetActive(false);
                brush_merah.SetActive(true);
			}
		}


    }
}


