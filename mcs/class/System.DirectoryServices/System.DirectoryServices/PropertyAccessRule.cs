/******************************************************************************
* The MIT License
*
* Permission is hereby granted, free of charge, to any person obtaining  a copy
* of this software and associated documentation files (the Software), to deal
* in the Software without restriction, including  without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to  permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED AS IS, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
* SOFTWARE.
*******************************************************************************/
using System;
using System.Security.AccessControl;
using System.Security.Principal;

namespace System.DirectoryServices
{
	public sealed class PropertyAccessRule : ActiveDirectoryAccessRule
	{
		public PropertyAccessRule (IdentityReference identity, AccessControlType type, PropertyAccess access) : base(identity, (int)AccessControlType.Allow, type, Guid.Empty, false, InheritanceFlags.None, PropagationFlags.None, Guid.Empty)
		{
		}

		public PropertyAccessRule (IdentityReference identity, AccessControlType type, PropertyAccess access, Guid propertyType) : base(identity, (int)AccessControlType.Allow, type, propertyType, false, InheritanceFlags.None, PropagationFlags.None, Guid.Empty)
		{
		}

		public PropertyAccessRule (IdentityReference identity, AccessControlType type, PropertyAccess access, ActiveDirectorySecurityInheritance inheritanceType) : base(identity, (int)AccessControlType.Allow, type, Guid.Empty, false, InheritanceFlags.None, PropagationFlags.None, Guid.Empty)
		{
		}

		public PropertyAccessRule (IdentityReference identity, AccessControlType type, PropertyAccess access, Guid propertyType, ActiveDirectorySecurityInheritance inheritanceType) : base(identity, (int)AccessControlType.Allow, type, propertyType, false, InheritanceFlags.None, PropagationFlags.None, Guid.Empty)
		{
		}

		public PropertyAccessRule (IdentityReference identity, AccessControlType type, PropertyAccess access, ActiveDirectorySecurityInheritance inheritanceType, Guid inheritedObjectType) : base(identity, (int)AccessControlType.Allow, type, Guid.Empty, false, InheritanceFlags.None, PropagationFlags.None, inheritedObjectType)
		{
		}

		public PropertyAccessRule (IdentityReference identity, AccessControlType type, PropertyAccess access, Guid propertyType, ActiveDirectorySecurityInheritance inheritanceType, Guid inheritedObjectType) : base(identity, (int)AccessControlType.Allow, type, propertyType, false, InheritanceFlags.None, PropagationFlags.None, inheritedObjectType)
		{
		}
	}
}
