using System;
using System.Collections;
using BepInEx;
using UnityEngine;


namespace FlatHead
{
	
	[BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
	public class Plugin : BaseUnityPlugin
	{

		void OnEnable()
		{
			Flat();
		}

		void OnDisable()
		{
			UnFlat();
		}

		void Update()
		{
			Flat();
		}

		public void Flat()
		{
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				vrrig.headMesh.transform.localScale = new Vector3(1f, 0.5f, 1f);
			}
		}
  		public void UnFlat()
		{
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				vrrig.headMesh.transform.localScale = new Vector3(1f, 1f, 1f);
			}
		}
	}
}
