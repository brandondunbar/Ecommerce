/* 
 * E-commerce API
 *
 * API for E-commerce Platform
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon.dunbar97@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;
namespace IO.Swagger.Model
{
    /// <summary>
    /// PlatformSettingsUpdateShippingConfig
    /// </summary>
    [DataContract]
        public partial class PlatformSettingsUpdateShippingConfig :  IEquatable<PlatformSettingsUpdateShippingConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformSettingsUpdateShippingConfig" /> class.
        /// </summary>
        /// <param name="defaultProvider">Default shipping provider (e.g., \&quot;FedEx\&quot;, \&quot;UPS\&quot;)..</param>
        /// <param name="rates">rates.</param>
        public PlatformSettingsUpdateShippingConfig(string defaultProvider = default(string), List<PlatformSettingsUpdateShippingConfigRates> rates = default(List<PlatformSettingsUpdateShippingConfigRates>))
        {
            this.DefaultProvider = defaultProvider;
            this.Rates = rates;
        }
        
        /// <summary>
        /// Default shipping provider (e.g., \&quot;FedEx\&quot;, \&quot;UPS\&quot;).
        /// </summary>
        /// <value>Default shipping provider (e.g., \&quot;FedEx\&quot;, \&quot;UPS\&quot;).</value>
        [DataMember(Name="defaultProvider", EmitDefaultValue=false)]
        public string DefaultProvider { get; set; }

        /// <summary>
        /// Gets or Sets Rates
        /// </summary>
        [DataMember(Name="rates", EmitDefaultValue=false)]
        public List<PlatformSettingsUpdateShippingConfigRates> Rates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlatformSettingsUpdateShippingConfig {\n");
            sb.Append("  DefaultProvider: ").Append(DefaultProvider).Append("\n");
            sb.Append("  Rates: ").Append(Rates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PlatformSettingsUpdateShippingConfig);
        }

        /// <summary>
        /// Returns true if PlatformSettingsUpdateShippingConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of PlatformSettingsUpdateShippingConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlatformSettingsUpdateShippingConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultProvider == input.DefaultProvider ||
                    (this.DefaultProvider != null &&
                    this.DefaultProvider.Equals(input.DefaultProvider))
                ) && 
                (
                    this.Rates == input.Rates ||
                    this.Rates != null &&
                    input.Rates != null &&
                    this.Rates.SequenceEqual(input.Rates)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DefaultProvider != null)
                    hashCode = hashCode * 59 + this.DefaultProvider.GetHashCode();
                if (this.Rates != null)
                    hashCode = hashCode * 59 + this.Rates.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
