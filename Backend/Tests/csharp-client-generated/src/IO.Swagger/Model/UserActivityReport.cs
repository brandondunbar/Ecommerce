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
    /// UserActivityReport
    /// </summary>
    [DataContract]
        public partial class UserActivityReport :  IEquatable<UserActivityReport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserActivityReport" /> class.
        /// </summary>
        /// <param name="startDate">The start date for the report period. (required).</param>
        /// <param name="endDate">The end date for the report period. (required).</param>
        /// <param name="totalUsers">Total number of registered users on the platform. (required).</param>
        /// <param name="activeUsers">Number of users who were active during the report period. (required).</param>
        /// <param name="averageSessionDuration">Average time (in minutes) a user spends on the platform per session. (required).</param>
        /// <param name="topVisitedPages">topVisitedPages.</param>
        /// <param name="dailyLogins">dailyLogins.</param>
        public UserActivityReport(DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), int? totalUsers = default(int?), int? activeUsers = default(int?), float? averageSessionDuration = default(float?), List<UserActivityReportTopVisitedPages> topVisitedPages = default(List<UserActivityReportTopVisitedPages>), List<UserActivityReportDailyLogins> dailyLogins = default(List<UserActivityReportDailyLogins>))
        {
            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new InvalidDataException("startDate is a required property for UserActivityReport and cannot be null");
            }
            else
            {
                this.StartDate = startDate;
            }
            // to ensure "endDate" is required (not null)
            if (endDate == null)
            {
                throw new InvalidDataException("endDate is a required property for UserActivityReport and cannot be null");
            }
            else
            {
                this.EndDate = endDate;
            }
            // to ensure "totalUsers" is required (not null)
            if (totalUsers == null)
            {
                throw new InvalidDataException("totalUsers is a required property for UserActivityReport and cannot be null");
            }
            else
            {
                this.TotalUsers = totalUsers;
            }
            // to ensure "activeUsers" is required (not null)
            if (activeUsers == null)
            {
                throw new InvalidDataException("activeUsers is a required property for UserActivityReport and cannot be null");
            }
            else
            {
                this.ActiveUsers = activeUsers;
            }
            // to ensure "averageSessionDuration" is required (not null)
            if (averageSessionDuration == null)
            {
                throw new InvalidDataException("averageSessionDuration is a required property for UserActivityReport and cannot be null");
            }
            else
            {
                this.AverageSessionDuration = averageSessionDuration;
            }
            this.TopVisitedPages = topVisitedPages;
            this.DailyLogins = dailyLogins;
        }
        
        /// <summary>
        /// The start date for the report period.
        /// </summary>
        /// <value>The start date for the report period.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The end date for the report period.
        /// </summary>
        /// <value>The end date for the report period.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Total number of registered users on the platform.
        /// </summary>
        /// <value>Total number of registered users on the platform.</value>
        [DataMember(Name="totalUsers", EmitDefaultValue=false)]
        public int? TotalUsers { get; set; }

        /// <summary>
        /// Number of users who were active during the report period.
        /// </summary>
        /// <value>Number of users who were active during the report period.</value>
        [DataMember(Name="activeUsers", EmitDefaultValue=false)]
        public int? ActiveUsers { get; set; }

        /// <summary>
        /// Average time (in minutes) a user spends on the platform per session.
        /// </summary>
        /// <value>Average time (in minutes) a user spends on the platform per session.</value>
        [DataMember(Name="averageSessionDuration", EmitDefaultValue=false)]
        public float? AverageSessionDuration { get; set; }

        /// <summary>
        /// Gets or Sets TopVisitedPages
        /// </summary>
        [DataMember(Name="topVisitedPages", EmitDefaultValue=false)]
        public List<UserActivityReportTopVisitedPages> TopVisitedPages { get; set; }

        /// <summary>
        /// Gets or Sets DailyLogins
        /// </summary>
        [DataMember(Name="dailyLogins", EmitDefaultValue=false)]
        public List<UserActivityReportDailyLogins> DailyLogins { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserActivityReport {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  TotalUsers: ").Append(TotalUsers).Append("\n");
            sb.Append("  ActiveUsers: ").Append(ActiveUsers).Append("\n");
            sb.Append("  AverageSessionDuration: ").Append(AverageSessionDuration).Append("\n");
            sb.Append("  TopVisitedPages: ").Append(TopVisitedPages).Append("\n");
            sb.Append("  DailyLogins: ").Append(DailyLogins).Append("\n");
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
            return this.Equals(input as UserActivityReport);
        }

        /// <summary>
        /// Returns true if UserActivityReport instances are equal
        /// </summary>
        /// <param name="input">Instance of UserActivityReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserActivityReport input)
        {
            if (input == null)
                return false;

            return 
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
                    this.TotalUsers == input.TotalUsers ||
                    (this.TotalUsers != null &&
                    this.TotalUsers.Equals(input.TotalUsers))
                ) && 
                (
                    this.ActiveUsers == input.ActiveUsers ||
                    (this.ActiveUsers != null &&
                    this.ActiveUsers.Equals(input.ActiveUsers))
                ) && 
                (
                    this.AverageSessionDuration == input.AverageSessionDuration ||
                    (this.AverageSessionDuration != null &&
                    this.AverageSessionDuration.Equals(input.AverageSessionDuration))
                ) && 
                (
                    this.TopVisitedPages == input.TopVisitedPages ||
                    this.TopVisitedPages != null &&
                    input.TopVisitedPages != null &&
                    this.TopVisitedPages.SequenceEqual(input.TopVisitedPages)
                ) && 
                (
                    this.DailyLogins == input.DailyLogins ||
                    this.DailyLogins != null &&
                    input.DailyLogins != null &&
                    this.DailyLogins.SequenceEqual(input.DailyLogins)
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
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.TotalUsers != null)
                    hashCode = hashCode * 59 + this.TotalUsers.GetHashCode();
                if (this.ActiveUsers != null)
                    hashCode = hashCode * 59 + this.ActiveUsers.GetHashCode();
                if (this.AverageSessionDuration != null)
                    hashCode = hashCode * 59 + this.AverageSessionDuration.GetHashCode();
                if (this.TopVisitedPages != null)
                    hashCode = hashCode * 59 + this.TopVisitedPages.GetHashCode();
                if (this.DailyLogins != null)
                    hashCode = hashCode * 59 + this.DailyLogins.GetHashCode();
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
