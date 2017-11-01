using UnityEngine;
using System.Collections;

public class _GunProperties : MonoBehaviour {

	//Amount of type of bullets loaded in the gun

	private int typeBulletP;

	public int typeBullet{
		get{
			return typeBulletP;
		} 
		set{
			typeBulletP = value;
		}
	}

	//=================================//

	private int posBulletP;

	public int posBullet{
		get{
			return posBulletP;
		} 
		set{
			posBulletP = value;
		}
	}

	//====================================//

	private int forceBulletP;

	public int forceBullet{
		get{
			return forceBulletP;
		} 
		set{
			forceBulletP = value;
		}
	}

	//====================================//

	private int amountBulletsP;

	public int amountBullets{
		get{
			return amountBulletsP;
		} 
		set{
			amountBulletsP = value;
		}
	}

	//====================================//

}
