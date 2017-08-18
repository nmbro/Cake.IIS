﻿#region Using Statements
using Cake.Core.IO;
#endregion



namespace Cake.IIS
{
    public class VirtualDirectorySettings : IDirectorySettings
    {
        #region Constructor (1)
        public VirtualDirectorySettings()
        {

        }
        #endregion





        #region Properties (8)
        public string ComputerName { get; set; }

        public DirectoryPath PhysicalDirectory { get; set; }

        public DirectoryPath WorkingDirectory { get; set; }
        public string SiteName { get; set; }

        public string ApplicationPath { get; set; }

        public string Path { get; set; }

        public AuthenticationSettings Authentication { get; set; }

        public AuthorizationSettings Authorization { get; set; }
        #endregion
    }
}
