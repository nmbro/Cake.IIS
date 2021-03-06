﻿


namespace Cake.IIS.Bindings
{
    /// <summary>
    /// Class to configure net.pipe binding.
    /// </summary>
    public sealed class HostBindingSettings : BindingSettings
    {
        #region Constructors
        /// <summary>
        /// Creates new predefined instance of <see cref="HostBindingSettings"/>.
        /// </summary>
        public HostBindingSettings(BindingProtocol bindingProtocol) 
            : base(bindingProtocol)
        {
            HostName = "*";
        }

        /// <inheritdoc cref="BindingSettings.BindingInformation"/>
        public override string BindingInformation
        {
            get
            {
                return $"{HostName}";
            }
        }
        #endregion
    }
}