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
    /// InventoryUpdate
    /// </summary>
    [DataContract]
        public partial class InventoryUpdate :  IEquatable<InventoryUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryUpdate" /> class.
        /// </summary>
        /// <param name="productId">Unique identifier for the product. (required).</param>
        /// <param name="currentStock">The updated stock level for the product. (required).</param>
        /// <param name="restockDate">Optional date and time when the product was restocked..</param>
        /// <param name="threshold">Updated restock threshold. When the stock drops below this value, a restock might be necessary..</param>
        /// <param name="notes">Any additional notes or comments about the inventory update..</param>
        public InventoryUpdate(long? productId = default(long?), int? currentStock = default(int?), DateTime? restockDate = default(DateTime?), int? threshold = default(int?), string notes = default(string))
        {
            // to ensure "productId" is required (not null)
            if (productId == null)
            {
                throw new InvalidDataException("productId is a required property for InventoryUpdate and cannot be null");
            }
            else
            {
                this.ProductId = productId;
            }
            // to ensure "currentStock" is required (not null)
            if (currentStock == null)
            {
                throw new InvalidDataException("currentStock is a required property for InventoryUpdate and cannot be null");
            }
            else
            {
                this.CurrentStock = currentStock;
            }
            this.RestockDate = restockDate;
            this.Threshold = threshold;
            this.Notes = notes;
        }
        
        /// <summary>
        /// Unique identifier for the product.
        /// </summary>
        /// <value>Unique identifier for the product.</value>
        [DataMember(Name="productId", EmitDefaultValue=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// The updated stock level for the product.
        /// </summary>
        /// <value>The updated stock level for the product.</value>
        [DataMember(Name="currentStock", EmitDefaultValue=false)]
        public int? CurrentStock { get; set; }

        /// <summary>
        /// Optional date and time when the product was restocked.
        /// </summary>
        /// <value>Optional date and time when the product was restocked.</value>
        [DataMember(Name="restockDate", EmitDefaultValue=false)]
        public DateTime? RestockDate { get; set; }

        /// <summary>
        /// Updated restock threshold. When the stock drops below this value, a restock might be necessary.
        /// </summary>
        /// <value>Updated restock threshold. When the stock drops below this value, a restock might be necessary.</value>
        [DataMember(Name="threshold", EmitDefaultValue=false)]
        public int? Threshold { get; set; }

        /// <summary>
        /// Any additional notes or comments about the inventory update.
        /// </summary>
        /// <value>Any additional notes or comments about the inventory update.</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryUpdate {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  CurrentStock: ").Append(CurrentStock).Append("\n");
            sb.Append("  RestockDate: ").Append(RestockDate).Append("\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(input as InventoryUpdate);
        }

        /// <summary>
        /// Returns true if InventoryUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of InventoryUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.CurrentStock == input.CurrentStock ||
                    (this.CurrentStock != null &&
                    this.CurrentStock.Equals(input.CurrentStock))
                ) && 
                (
                    this.RestockDate == input.RestockDate ||
                    (this.RestockDate != null &&
                    this.RestockDate.Equals(input.RestockDate))
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    (this.Threshold != null &&
                    this.Threshold.Equals(input.Threshold))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
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
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.CurrentStock != null)
                    hashCode = hashCode * 59 + this.CurrentStock.GetHashCode();
                if (this.RestockDate != null)
                    hashCode = hashCode * 59 + this.RestockDate.GetHashCode();
                if (this.Threshold != null)
                    hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
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
