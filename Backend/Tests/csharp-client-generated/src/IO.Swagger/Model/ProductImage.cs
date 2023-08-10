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
    /// ProductImage
    /// </summary>
    [DataContract]
        public partial class ProductImage :  IEquatable<ProductImage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductImage" /> class.
        /// </summary>
        /// <param name="id">Unique identifier for the image..</param>
        /// <param name="url">URL where the image can be accessed..</param>
        /// <param name="altText">Alternative text for the image, useful for accessibility..</param>
        /// <param name="uploadedAt">Date and time when the image was uploaded..</param>
        public ProductImage(string id = default(string), string url = default(string), string altText = default(string), DateTime? uploadedAt = default(DateTime?))
        {
            this.Id = id;
            this.Url = url;
            this.AltText = altText;
            this.UploadedAt = uploadedAt;
        }
        
        /// <summary>
        /// Unique identifier for the image.
        /// </summary>
        /// <value>Unique identifier for the image.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// URL where the image can be accessed.
        /// </summary>
        /// <value>URL where the image can be accessed.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Alternative text for the image, useful for accessibility.
        /// </summary>
        /// <value>Alternative text for the image, useful for accessibility.</value>
        [DataMember(Name="altText", EmitDefaultValue=false)]
        public string AltText { get; set; }

        /// <summary>
        /// Date and time when the image was uploaded.
        /// </summary>
        /// <value>Date and time when the image was uploaded.</value>
        [DataMember(Name="uploadedAt", EmitDefaultValue=false)]
        public DateTime? UploadedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductImage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  AltText: ").Append(AltText).Append("\n");
            sb.Append("  UploadedAt: ").Append(UploadedAt).Append("\n");
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
            return this.Equals(input as ProductImage);
        }

        /// <summary>
        /// Returns true if ProductImage instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductImage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.AltText == input.AltText ||
                    (this.AltText != null &&
                    this.AltText.Equals(input.AltText))
                ) && 
                (
                    this.UploadedAt == input.UploadedAt ||
                    (this.UploadedAt != null &&
                    this.UploadedAt.Equals(input.UploadedAt))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.AltText != null)
                    hashCode = hashCode * 59 + this.AltText.GetHashCode();
                if (this.UploadedAt != null)
                    hashCode = hashCode * 59 + this.UploadedAt.GetHashCode();
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
