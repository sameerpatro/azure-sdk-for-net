// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the certificate source parameters using user&apos;s keyvault certificate for enabling SSL. </summary>
    public partial class UserManagedHttpsOptions : CustomDomainHttpsOptions
    {
        /// <summary> Initializes a new instance of UserManagedHttpsOptions. </summary>
        /// <param name="protocolType"> Defines the TLS extension protocol that is used for secure delivery. </param>
        /// <param name="certificateSourceParameters"> Defines the certificate source parameters using user&apos;s keyvault certificate for enabling SSL. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateSourceParameters"/> is null. </exception>
        public UserManagedHttpsOptions(ProtocolType protocolType, KeyVaultCertificateSourceParameters certificateSourceParameters) : base(protocolType)
        {
            if (certificateSourceParameters == null)
            {
                throw new ArgumentNullException(nameof(certificateSourceParameters));
            }

            CertificateSourceParameters = certificateSourceParameters;
            CertificateSource = CertificateSource.AzureKeyVault;
        }

        /// <summary> Initializes a new instance of UserManagedHttpsOptions. </summary>
        /// <param name="certificateSource"> Defines the source of the SSL certificate. </param>
        /// <param name="protocolType"> Defines the TLS extension protocol that is used for secure delivery. </param>
        /// <param name="minimumTlsVersion"> TLS protocol version that will be used for Https. </param>
        /// <param name="certificateSourceParameters"> Defines the certificate source parameters using user&apos;s keyvault certificate for enabling SSL. </param>
        internal UserManagedHttpsOptions(CertificateSource certificateSource, ProtocolType protocolType, MinimumTlsVersion? minimumTlsVersion, KeyVaultCertificateSourceParameters certificateSourceParameters) : base(certificateSource, protocolType, minimumTlsVersion)
        {
            CertificateSourceParameters = certificateSourceParameters;
            CertificateSource = certificateSource;
        }

        /// <summary> Defines the certificate source parameters using user&apos;s keyvault certificate for enabling SSL. </summary>
        public KeyVaultCertificateSourceParameters CertificateSourceParameters { get; set; }
    }
}
