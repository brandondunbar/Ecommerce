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
    /// Partnership
    /// </summary>
    [DataContract]
        public partial class Partnership :  IEquatable<Partnership>, IValidatableObject
    {
        /// <summary>
        /// Type or nature of the partnership.
        /// </summary>
        /// <value>Type or nature of the partnership.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PartnershipTypeEnum
        {
            /// <summary>
            /// Enum Collaboration for value: Collaboration
            /// </summary>
            [EnumMember(Value = "Collaboration")]
            Collaboration = 1,
            /// <summary>
            /// Enum Integration for value: Integration
            /// </summary>
            [EnumMember(Value = "Integration")]
            Integration = 2,
            /// <summary>
            /// Enum Sponsorship for value: Sponsorship
            /// </summary>
            [EnumMember(Value = "Sponsorship")]
            Sponsorship = 3,
            /// <summary>
            /// Enum Other for value: Other
            /// </summary>
            [EnumMember(Value = "Other")]
            Other = 4        }
        /// <summary>
        /// Type or nature of the partnership.
        /// </summary>
        /// <value>Type or nature of the partnership.</value>
        [DataMember(Name="partnershipType", EmitDefaultValue=false)]
        public PartnershipTypeEnum PartnershipType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Partnership" /> class.
        /// </summary>
        /// <param name="partnershipId">Unique identifier for the partnership. (required).</param>
        /// <param name="partnerName">Name of the partner organization or business. (required).</param>
        /// <param name="contactPerson">Name of the primary contact person at the partner organization..</param>
        /// <param name="contactEmail">Email address for communication with the partner. (required).</param>
        /// <param name="partnershipType">Type or nature of the partnership. (required).</param>
        /// <param name="startDate">Date and time when the partnership agreement started..</param>
        /// <param name="endDate">Date and time when the partnership agreement is set to end..</param>
        /// <param name="terms">Detailed terms and conditions of the partnership..</param>
        /// <param name="benefits">Benefits accrued from the partnership, for both parties..</param>
        /// <param name="isActive">Indicates whether the partnership is currently active..</param>
        public Partnership(long? partnershipId = default(long?), string partnerName = default(string), string contactPerson = default(string), string contactEmail = default(string), PartnershipTypeEnum partnershipType = default(PartnershipTypeEnum), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), string terms = default(string), string benefits = default(string), bool? isActive = default(bool?))
        {
            // to ensure "partnershipId" is required (not null)
            if (partnershipId == null)
            {
                throw new InvalidDataException("partnershipId is a required property for Partnership and cannot be null");
            }
            else
            {
                this.PartnershipId = partnershipId;
            }
            // to ensure "partnerName" is required (not null)
            if (partnerName == null)
            {
                throw new InvalidDataException("partnerName is a required property for Partnership and cannot be null");
            }
            else
            {
                this.PartnerName = partnerName;
            }
            // to ensure "contactEmail" is required (not null)
            if (contactEmail == null)
            {
                throw new InvalidDataException("contactEmail is a required property for Partnership and cannot be null");
            }
            else
            {
                this.ContactEmail = contactEmail;
            }
            // to ensure "partnershipType" is required (not null)
            if (partnershipType == null)
            {
                throw new InvalidDataException("partnershipType is a required property for Partnership and cannot be null");
            }
            else
            {
                this.PartnershipType = partnershipType;
            }
            this.ContactPerson = contactPerson;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Terms = terms;
            this.Benefits = benefits;
            this.IsActive = isActive;
        }
        
        /// <summary>
        /// Unique identifier for the partnership.
        /// </summary>
        /// <value>Unique identifier for the partnership.</value>
        [DataMember(Name="partnershipId", EmitDefaultValue=false)]
        public long? PartnershipId { get; set; }

        /// <summary>
        /// Name of the partner organization or business.
        /// </summary>
        /// <value>Name of the partner organization or business.</value>
        [DataMember(Name="partnerName", EmitDefaultValue=false)]
        public string PartnerName { get; set; }

        /// <summary>
        /// Name of the primary contact person at the partner organization.
        /// </summary>
        /// <value>Name of the primary contact person at the partner organization.</value>
        [DataMember(Name="contactPerson", EmitDefaultValue=false)]
        public string ContactPerson { get; set; }

        /// <summary>
        /// Email address for communication with the partner.
        /// </summary>
        /// <value>Email address for communication with the partner.</value>
        [DataMember(Name="contactEmail", EmitDefaultValue=false)]
        public string ContactEmail { get; set; }


        /// <summary>
        /// Date and time when the partnership agreement started.
        /// </summary>
        /// <value>Date and time when the partnership agreement started.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Date and time when the partnership agreement is set to end.
        /// </summary>
        /// <value>Date and time when the partnership agreement is set to end.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Detailed terms and conditions of the partnership.
        /// </summary>
        /// <value>Detailed terms and conditions of the partnership.</value>
        [DataMember(Name="terms", EmitDefaultValue=false)]
        public string Terms { get; set; }

        /// <summary>
        /// Benefits accrued from the partnership, for both parties.
        /// </summary>
        /// <value>Benefits accrued from the partnership, for both parties.</value>
        [DataMember(Name="benefits", EmitDefaultValue=false)]
        public string Benefits { get; set; }

        /// <summary>
        /// Indicates whether the partnership is currently active.
        /// </summary>
        /// <value>Indicates whether the partnership is currently active.</value>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Partnership {\n");
            sb.Append("  PartnershipId: ").Append(PartnershipId).Append("\n");
            sb.Append("  PartnerName: ").Append(PartnerName).Append("\n");
            sb.Append("  ContactPerson: ").Append(ContactPerson).Append("\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  PartnershipType: ").Append(PartnershipType).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
            sb.Append("  Benefits: ").Append(Benefits).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
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
            return this.Equals(input as Partnership);
        }

        /// <summary>
        /// Returns true if Partnership instances are equal
        /// </summary>
        /// <param name="input">Instance of Partnership to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Partnership input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PartnershipId == input.PartnershipId ||
                    (this.PartnershipId != null &&
                    this.PartnershipId.Equals(input.PartnershipId))
                ) && 
                (
                    this.PartnerName == input.PartnerName ||
                    (this.PartnerName != null &&
                    this.PartnerName.Equals(input.PartnerName))
                ) && 
                (
                    this.ContactPerson == input.ContactPerson ||
                    (this.ContactPerson != null &&
                    this.ContactPerson.Equals(input.ContactPerson))
                ) && 
                (
                    this.ContactEmail == input.ContactEmail ||
                    (this.ContactEmail != null &&
                    this.ContactEmail.Equals(input.ContactEmail))
                ) && 
                (
                    this.PartnershipType == input.PartnershipType ||
                    (this.PartnershipType != null &&
                    this.PartnershipType.Equals(input.PartnershipType))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Terms == input.Terms ||
                    (this.Terms != null &&
                    this.Terms.Equals(input.Terms))
                ) && 
                (
                    this.Benefits == input.Benefits ||
                    (this.Benefits != null &&
                    this.Benefits.Equals(input.Benefits))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
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
                if (this.PartnershipId != null)
                    hashCode = hashCode * 59 + this.PartnershipId.GetHashCode();
                if (this.PartnerName != null)
                    hashCode = hashCode * 59 + this.PartnerName.GetHashCode();
                if (this.ContactPerson != null)
                    hashCode = hashCode * 59 + this.ContactPerson.GetHashCode();
                if (this.ContactEmail != null)
                    hashCode = hashCode * 59 + this.ContactEmail.GetHashCode();
                if (this.PartnershipType != null)
                    hashCode = hashCode * 59 + this.PartnershipType.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Terms != null)
                    hashCode = hashCode * 59 + this.Terms.GetHashCode();
                if (this.Benefits != null)
                    hashCode = hashCode * 59 + this.Benefits.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
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