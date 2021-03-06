﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Drawing;

namespace Duality.Cloning.Surrogates
{
	public class BitmapSurrogate : CloneSurrogate<Bitmap>
	{
		protected override bool IsImmutableTarget
		{
			get { return true; }
		}

		public override void CreateTargetObject(Bitmap source, ref Bitmap target, ICloneTargetSetup setup)
		{
			target = new Bitmap(source.Width, source.Height);
		}
		public override void SetupCloneTargets(Bitmap source, Bitmap target, ICloneTargetSetup setup) {}
		public override void CopyDataTo(Bitmap source, Bitmap target, ICloneOperation operation)
		{
			target.SetPixelDataIntArgb(source.GetPixelDataIntArgb());
		}
	}
}
