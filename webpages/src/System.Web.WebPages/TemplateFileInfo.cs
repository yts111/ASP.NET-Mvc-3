﻿
namespace System.Web.WebPages {
    /// <summary>
    /// TemplateFileInfo specifies properties of a template such as VirtualPath. 
    /// This type allows us to modify the behavior of ITemplateFile between releases without changing the interface.
    /// </summary>
    public class TemplateFileInfo {
        private readonly string _virtualPath;

        public TemplateFileInfo(string virtualPath) {
            _virtualPath = virtualPath;
        }

        public string VirtualPath {
            get {
                return _virtualPath;
            }
        }
    }
}
