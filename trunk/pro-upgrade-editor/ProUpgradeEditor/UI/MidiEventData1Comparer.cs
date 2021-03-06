using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using EditorResources.Components;
using ProUpgradeEditor.Common;

using Sanford.Multimedia.Midi;
using X360;
using X360.FATX;
using X360.Other;
using XPackage;
using ZipLib.SharpZipLib.Core;
using ZipLib.SharpZipLib.Zip;


namespace ProUpgradeEditor.UI
{
    public class MidiEventData1Comparer : IEqualityComparer<MidiEvent>
    {
        public bool Equals(MidiEvent x, MidiEvent y)
        {
            return x.Data1 == y.Data1;
        }


        public int GetHashCode(MidiEvent obj)
        {
            return obj.Data1;
        }
    }
}