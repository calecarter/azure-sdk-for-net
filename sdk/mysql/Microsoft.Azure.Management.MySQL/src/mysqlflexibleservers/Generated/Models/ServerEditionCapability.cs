// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MySQL.FlexibleServers.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Server edition capabilities.
    /// </summary>
    public partial class ServerEditionCapability
    {
        /// <summary>
        /// Initializes a new instance of the ServerEditionCapability class.
        /// </summary>
        public ServerEditionCapability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerEditionCapability class.
        /// </summary>
        /// <param name="name">Server edition name</param>
        /// <param name="supportedStorageEditions">A list of supported storage
        /// editions</param>
        /// <param name="supportedServerVersions">A list of supported server
        /// versions.</param>
        /// <param name="status">The status of the capability.</param>
        public ServerEditionCapability(string name = default(string), IList<StorageEditionCapability> supportedStorageEditions = default(IList<StorageEditionCapability>), IList<ServerVersionCapability> supportedServerVersions = default(IList<ServerVersionCapability>), string status = default(string))
        {
            Name = name;
            SupportedStorageEditions = supportedStorageEditions;
            SupportedServerVersions = supportedServerVersions;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets server edition name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets a list of supported storage editions
        /// </summary>
        [JsonProperty(PropertyName = "supportedStorageEditions")]
        public IList<StorageEditionCapability> SupportedStorageEditions { get; private set; }

        /// <summary>
        /// Gets a list of supported server versions.
        /// </summary>
        [JsonProperty(PropertyName = "supportedServerVersions")]
        public IList<ServerVersionCapability> SupportedServerVersions { get; private set; }

        /// <summary>
        /// Gets the status of the capability.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

    }
}
