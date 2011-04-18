﻿using System.ComponentModel.DataAnnotations;

namespace Cyclops.Core.Configuration
{
    /// <summary>
    /// Connection configuration
    /// </summary>
    public class ConnectionConfig
    {
        private string networkHost = string.Empty;

        public ConnectionConfig()
        {
            Port = 5222;
        }

        /// <summary>
        /// Server address
        /// </summary>
        //[RegularExpression("")]
        public string Server { get; set; }

        /// <summary>
        /// Physical server address
        /// </summary>
        //[RegularExpression("")]
        public string NetworkHost
        {
            get { return string.IsNullOrEmpty(networkHost) ? Server : networkHost; }
            set { networkHost = value; }
        }

        /// <summary>
        /// Port
        /// </summary>
        [Range(0, 65535)]
        public int Port { get; set; }

        /// <summary>
        /// User
        /// </summary>
        //[RegularExpression("")]
        public string User { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        //[RegularExpression("")]
        [Display(AutoGenerateField = false)]
        public string EncodedPassword { get; set; }

        /*
         * TODO: Proxy 
         */

        public override string ToString()
        {
            return string.Format("Server: {0}; NetworkHost: {1}; User: {2}; Port: {3};", Server, NetworkHost, User, Port);
        }
    }
}