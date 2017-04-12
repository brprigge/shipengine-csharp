/* 
 * ShipEngine
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace ShipEngine.ApiClient.Model
{
    /// <summary>
    ///     ModifyBatchRequest
    /// </summary>
    [DataContract]
    public class ModifyBatchRequest : IEquatable<ModifyBatchRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ModifyBatchRequest" /> class.
        /// </summary>
        /// <param name="shipmentIds">ShipmentIds.</param>
        /// <param name="rateIds">RateIds.</param>
        public ModifyBatchRequest(List<string> shipmentIds = default(List<string>),
            List<string> rateIds = default(List<string>))
        {
            ShipmentIds = shipmentIds;
            RateIds = rateIds;
        }

        /// <summary>
        ///     Gets or Sets ShipmentIds
        /// </summary>
        [DataMember(Name = "shipment_ids", EmitDefaultValue = false)]
        public List<string> ShipmentIds { get; set; }

        /// <summary>
        ///     Gets or Sets RateIds
        /// </summary>
        [DataMember(Name = "rate_ids", EmitDefaultValue = false)]
        public List<string> RateIds { get; set; }

        /// <summary>
        ///     Returns true if ModifyBatchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ModifyBatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifyBatchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
            {
                return false;
            }

            return
                (
                    ShipmentIds == other.ShipmentIds ||
                    ShipmentIds != null &&
                    ShipmentIds.SequenceEqual(other.ShipmentIds)
                ) &&
                (
                    RateIds == other.RateIds ||
                    RateIds != null &&
                    RateIds.SequenceEqual(other.RateIds)
                );
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyBatchRequest {\n");
            sb.Append("  ShipmentIds: ").Append(ShipmentIds).Append("\n");
            sb.Append("  RateIds: ").Append(RateIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return Equals(obj as ModifyBatchRequest);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                var hash = 41;
                // Suitable nullity checks etc, of course :)
                if (ShipmentIds != null)
                {
                    hash = hash * 59 + ShipmentIds.GetHashCode();
                }
                if (RateIds != null)
                {
                    hash = hash * 59 + RateIds.GetHashCode();
                }
                return hash;
            }
        }
    }
}