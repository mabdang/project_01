using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class click_head : MonoBehaviour
{
	public Text penjelasan;
	public GameObject kepala = null;
	public GameObject tangan_kanan = null;
	public GameObject tangan_kiri = null;
	public GameObject kaki_kanan = null;
	public GameObject kaki_kiri = null;
	public GameObject badan = null;


	// Use this for initialization
	
	// Update is called once per frame
	void Update ()
	{


		if (Input.GetMouseButtonDown (0)) {
			Vector3 klik = Camera.main.ScreenToWorldPoint (Input.mousePosition);		
			PolygonCollider2D kepalah = kepala.GetComponent <PolygonCollider2D> ();
			PolygonCollider2D tangan_kananh = tangan_kanan.GetComponent <PolygonCollider2D> ();
			PolygonCollider2D tangan_kirih = tangan_kiri.GetComponent <PolygonCollider2D> ();
			PolygonCollider2D kaki_kananh = kaki_kanan.GetComponent <PolygonCollider2D> ();
			PolygonCollider2D kaki_kirih = kaki_kiri.GetComponent <PolygonCollider2D> ();
			PolygonCollider2D badanh = badan.GetComponent <PolygonCollider2D> ();


			if (kepalah.OverlapPoint (klik)) {
				penjelasan.text = "kepala";
			} else if (tangan_kananh.OverlapPoint (klik)) {
				penjelasan.text = "tangan kanan";
			} else if (tangan_kirih.OverlapPoint (klik)) {
				penjelasan.text = "tangan kiri";
			} else if (kaki_kananh.OverlapPoint (klik)) {
				penjelasan.text = "kaki kanan";
			} else if (kaki_kirih.OverlapPoint (klik)) {
				penjelasan.text = "kaki kiri";
			} else if (badanh.OverlapPoint (klik)) {
				penjelasan.text = "badan";
			} 
		}

		
	}
}
