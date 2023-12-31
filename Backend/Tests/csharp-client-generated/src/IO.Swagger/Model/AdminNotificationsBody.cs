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
    /// AdminNotificationsBody
    /// </summary>
    [DataContract]
        public partial class AdminNotificationsBody :  IEquatable<AdminNotificationsBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminNotificationsBody" /> class.
        /// </summary>
        /// <param name="userId">Unique identifier of the target user. (required).</param>
        /// <param name="title">Title or header of the notification. (required).</param>
        /// <param name="message">Detailed message or content of the notification. (required).</param>
        /// <param name="type">Type or category of the notification (e.g., \&quot;order update\&quot;, \&quot;promotion\&quot;)..</param>
        public AdminNotificationsBody(long? userId = default(long?), string title = default(string), string message = default(string), string type = default(string))
        {
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for AdminNotificationsBody and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for AdminNotificationsBody and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new InvalidDataException("message is a required property for AdminNotificationsBody and cannot be null");
            }
            else
            {
                this.Message = message;
            }
            this.Type = type;
        }
        
        /// <summary>
        /// Unique identifier of the target user.
        /// </summary>
        /// <value>Unique identifier of the target user.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public long? UserId { get; set; }

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
        /// Type or category of the notification (e.g., \&quot;order update\&quot;, \&quot;promotion\&quot;).
        /// </summary>
        /// <value>Type or category of the notification (e.g., \&quot;order update\&quot;, \&quot;promotion\&quot;).</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdminNotificationsBody {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as AdminNotificationsBody);
        }

        /// <summary>
        /// Returns true if AdminNotificationsBody instances are equal
        /// </summary>
        /// <param name="input">Instance of AdminNotificationsBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdminNotificationsBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
