using System;
using System.Runtime.InteropServices;

namespace Rubberduck.VBEditor.DisposableWrappers.VBA
{
    public class VBProject : SafeComWrapper<Microsoft.Vbe.Interop.VBProject>, IEquatable<VBProject>
    {
        public VBProject(Microsoft.Vbe.Interop.VBProject vbProject)
            :base(vbProject)
        {
        }

        public Application Application
        {
            get { return new Application(IsWrappingNullReference ? null : InvokeResult(() => ComObject.Application)); }
        }

        public Application Parent
        {
            get { return new Application(IsWrappingNullReference ? null : InvokeResult(() => ComObject.Parent)); }
        }

        public string HelpFile
        {
            get { return IsWrappingNullReference ? string.Empty : InvokeResult(() => ComObject.HelpFile); }
            set { Invoke(() => ComObject.HelpFile = value); }
        }

        public int HelpContextID
        {
            get { return IsWrappingNullReference ? 0 : InvokeResult(() => ComObject.HelpContextID); }
            set  { Invoke(() => ComObject.HelpContextID = value); }
        }

        public string Description 
        {
            get { return IsWrappingNullReference ? string.Empty : InvokeResult(() => ComObject.Description); }
            set { Invoke(() => ComObject.Description = value); } 
        }

        public string Name
        {
            get { return IsWrappingNullReference ? string.Empty : InvokeResult(() => ComObject.Name); }
            set { Invoke(() => ComObject.Name = value); }
        }

        public EnvironmentMode Mode
        {
            get { return IsWrappingNullReference ? 0 : (EnvironmentMode)InvokeResult(() => ComObject.Mode); }
        }

        public VBProjects Collection
        {
            get { return new VBProjects(IsWrappingNullReference ? null : InvokeResult(() => ComObject.Collection)); }
        }

        public References References
        {
            get { return new References(IsWrappingNullReference ? null : InvokeResult(() => ComObject.References)); }
        }

        public VBComponents VBComponents
        {
            get { return new VBComponents(IsWrappingNullReference ? null : InvokeResult(() => ComObject.VBComponents)); }
        }

        public ProjectProtection Protection
        {
            get { return IsWrappingNullReference ? 0 : (ProjectProtection)InvokeResult(() => ComObject.Protection); }
        }

        public bool Saved
        {
            get { return !IsWrappingNullReference && InvokeResult(() => ComObject.Saved); }
        }

        public ProjectType Type
        {
            get { return IsWrappingNullReference ? 0 : (ProjectType)InvokeResult(() => ComObject.Type); }
        }

        public string FileName
        {
            get { return IsWrappingNullReference ? String.Empty : InvokeResult(() => ComObject.FileName); }
        }

        public string BuildFileName
        {
            get { return IsWrappingNullReference ? string.Empty : InvokeResult(() => ComObject.BuildFileName); }
        }

        public VBE VBE
        {
            get { return new VBE(IsWrappingNullReference ? null : InvokeResult(() => ComObject.VBE)); }
        }

        public void SaveAs(string fileName)
        {
            Invoke(() => ComObject.SaveAs(fileName));
        }

        public void MakeCompiledFile()
        {
            Invoke(() => ComObject.MakeCompiledFile());
        }

        public override void Release()
        {
            if (!IsWrappingNullReference)
            {
                References.Release();
                VBComponents.Release();
                Marshal.ReleaseComObject(ComObject);
            }
        }

        public override bool Equals(SafeComWrapper<Microsoft.Vbe.Interop.VBProject> other)
        {
            return IsEqualIfNull(other) || other.ComObject == ComObject;
        }

        public bool Equals(VBProject other)
        {
            return Equals(other as SafeComWrapper<Microsoft.Vbe.Interop.VBProject>);
        }

        public override int GetHashCode()
        {
            return IsWrappingNullReference ? 0 : ComObject.GetHashCode();
        }
    }
}