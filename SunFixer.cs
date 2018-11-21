/*
	SunFixer.cs

	Expose control of the sun rotation rounding misfeature of KSP 1.3+.

	Copyright (C) 2018 Bill Currie <bill@taniwha.org>

	Author: Bill Currie <bill@taniwha.org>
	Date: 2018/5/1

	This program is free software; you can redistribute it and/or
	modify it under the terms of the GNU General Public License
	as published by the Free Software Foundation; either version 3
	of the License, or (at your option) any later version.

	This program is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	See the GNU General Public License for more details.

	You should have received a copy of the GNU General Public License
	along with this program; if not, write to:

		Free Software Foundation, Inc.
		59 Temple Place - Suite 330
		Boston, MA  02111-1307, USA

*/
using UnityEngine;

namespace SunFixer {

	[KSPAddon (KSPAddon.Startup.MainMenu, true)]
	public class SunFixer : MonoBehaviour
	{
		void Start ()
		{
			GameObject.DontDestroyOnLoad(this);

			GameEvents.onGameSceneLoadRequested.Add(onGameSceneLoadRequested);
		}

		void OnDestroy ()
		{
			GameEvents.onGameSceneLoadRequested.Remove(onGameSceneLoadRequested);
		}

		void onGameSceneLoadRequested (GameScenes scene)
		{
			Sun[] suns = Resources.FindObjectsOfTypeAll<Sun>();
			if (suns == null)
			{
				return;
			}
			for (Int32 i = 0; i < suns.Length; i++)
			{
				if (suns[i] != null)
				{
					suns[i].sunRotationPrecisionDefault = 12;
				}
			}
		}
	}
}
