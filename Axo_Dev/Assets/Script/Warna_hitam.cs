
using UnityEngine;

public class Warna_hitam : MonoBehaviour
{
	
	public Camera m_camera;
	public GameObject brush;
	public GameObject kanvas;
	public bool kanvas2 = false;

	LineRenderer currentLineRenderer;
	Vector2 lastPos;



	 private void Start() {
		
	currentLineRenderer = null;
	}

	private void Update ()
	{
		Drawing ();
		if(Input.GetMouseButtonDown(0)){
			Vector3 klik = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			BoxCollider2D kanvas1 = kanvas.GetComponent<BoxCollider2D>();
			if (kanvas1.OverlapPoint (klik)) {
				kanvas2 = true;
			//	Debug.Log("area gambar");
			} else {
				kanvas2 = false;
			} 
		}
		
		
	
	}

	void Drawing ()
	{
		if (Input.GetKeyDown (KeyCode.Mouse0) && kanvas2 == true) {
			CreateBrush ();
		} else if (Input.GetKey (KeyCode.Mouse0) && kanvas2 == true) {
			PointToMousePos ();
		} else {
			currentLineRenderer = null;
		}

	}

	void CreateBrush ()
	{
		GameObject brushInstance = Instantiate (brush);
		currentLineRenderer = brushInstance.GetComponent<LineRenderer> ();
		Vector2 mousePos = m_camera.ScreenToWorldPoint (Input.mousePosition);

		//because you gotta have 2 points to start a line renderer, 
		currentLineRenderer.SetPosition (0, mousePos);
		currentLineRenderer.SetPosition (1, mousePos);
	}

	void AddAPoint (Vector2 pointPos)
	{
		currentLineRenderer.positionCount++;
		int positionIndex = currentLineRenderer.positionCount - 1;
		currentLineRenderer.SetPosition (positionIndex, pointPos);
	}

	void PointToMousePos ()
	{
		Vector2 mousePos = m_camera.ScreenToWorldPoint (Input.mousePosition);
		if (lastPos != mousePos) {
			AddAPoint (mousePos);
			lastPos = mousePos;
		}
	}
}
