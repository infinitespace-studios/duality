﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Reflection;

using Duality;
using Duality.Cloning;
using Duality.Drawing;
using Duality.Resources;
using Duality.Components;
using Duality.Components.Renderers;

using OpenTK;
using NUnit.Framework;

namespace Duality.Tests.Cloning.HelperObjects
{
	internal class SkipFieldTestObject
	{
		public string StringField;
		[CloneField(CloneFieldFlags.Skip)]
		public int SkipField;
		[NonSerialized]
		public int NonSerializedSkipField;
		[NonSerialized]
		[CloneField(CloneFieldFlags.DontSkip)]
		public int NonSerializedField;
		public AlwaysSkippedObject SkippedObject;
			
		public SkipFieldTestObject(Random rnd)
		{
			this.StringField = rnd.Next().ToString();
			this.SkipField = rnd.Next();
			this.NonSerializedSkipField = rnd.Next();
			this.NonSerializedField = rnd.Next();
			this.SkippedObject = new AlwaysSkippedObject();
		}
	}
	[CloneBehavior(CloneBehavior.WeakReference)]
	internal class AlwaysSkippedObject {}
}
