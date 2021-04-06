using UnityEngine;
using System.Collections;

public class disappearAfter : MonoBehaviour {

	//This script will fade away a textmesh in 5 seconds.
    
	void Start () {
        StartCoroutine(fadeOut());

	}

    IEnumerator fadeOut()
    {
		yield return new WaitForSeconds(5.0f);
        float opacity = 1f;

        while (opacity > 0f)
        {
            opacity = opacity - 0.1f;
			this.GetComponent<TextMesh>().color = new Color(1f, 1f, 1f,opacity);
            yield return new WaitForSeconds(0.1f);
        }
        yield return null;
    }

	private void Update()
	{
		transform.Translate(0f, -1f * Time.deltaTime, 0f);
	}


	

}
