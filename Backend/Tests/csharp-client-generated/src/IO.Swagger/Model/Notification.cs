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
    /// Notification
    /// </summary>
    [DataContract]
        public partial class Notification :  IEquatable<Notification>, IValidatableObject
    {
        /// <summary>
        /// Current status of the notification.
        /// </summary>
        /// <value>Current status of the notification.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum Unread for value: unread
            /// </summary>
            [EnumMember(Value = "unread")]
            Unread = 1,
            /// <summary>
            /// Enum Read for value: read
            /// </summary>
            [EnumMember(Value = "read")]
            Read = 2        }
        /// <summary>
        /// Current status of the notification.
        /// </summary>
        /// <value>Current status of the notification.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class.
        /// </summary>
        /// <param name="id">Unique identifier for the notification..</param>
        /// <param name="title">Title or header of the notification..</param>
        /// <param name="message">Detailed message or content of the notification..</param>
        /// <param name="date">Date and time when the notification was created..</param>
        /// <param name="status">Current status of the notification..</param>
        public Notification(long? id = default(long?), string title = default(string), string message = default(string), DateTime? date = default(DateTime?), StatusEnum? status = default(StatusEnum?))
        {
            this.Id = id;
            this.Title = title;
            this.Message = message;
            this.Date = date;
            this.Status = status;
        }
        
        /// <summary>
        /// Unique identifier for the notification.
        /// </summary>
        /// <value>Unique identifier for the notification.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Title or header of the notification.
        /// </summary>
        /// <value>Title or header of the notification.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Detailed message or content of the notification.
        /// </summary>
        /// <value>Detailed message or content of the notification.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Date and time when the notification was created.
        /// </summary>
        /// <value>Date and time when the notification was created.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Notification {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as Notification);
        }

        /// <summary>
        /// Returns true if Notification instances are equal
        /// </summary>
        /// <param name="input">Instance of Notification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notification input)
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
