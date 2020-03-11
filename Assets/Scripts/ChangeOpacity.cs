using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOpacity : MonoBehaviour
{
	public float alphaLevel = .5f;
	public int fois = 0;
	public int plus = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		float time = Time.time;
		if ((time > 0 && time < 0.170) || (time > 2.668 && time < 2.84) || (time > 4.001 && time < 4.17) || (time > 5.334 && time < 5.493)) alphaLevel += .10f;
		if (((time > (2.668 + 5.333*fois) && time < (2.84 + 5.333*fois)) || (time > (4.001 + 5.333*fois) && time < (4.17 + 5.333*fois)) || (time > (5.334 + 5.333*fois) && time < (5.493 + 5.333*fois))) && time < 53) alphaLevel += .05f;
		else if (alphaLevel > 0) alphaLevel -= .05f;
		if (time > 5.493*(fois+1)) fois += 1;
		GetComponent<SpriteRenderer>().color = new Color (1, 1, 1, alphaLevel);
    }
}