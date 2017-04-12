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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace ShipEngine.ApiClient.Model
{
    /// <summary>
    ///     ShipmentAddTagResponse
    /// </summary>
    [DataContract]
    public class ShipmentAddTagResponse : IEquatable<ShipmentAddTagResponse>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ShipmentAddTagResponse" /> class.
        /// </summary>
        /// <param name="shipmentId">ShipmentId.</param>
        /// <param name="tag">Tag.</param>
        public ShipmentAddTagResponse(string shipmentId = default(string), TagResponse tag = default(TagResponse))
        {
            ShipmentId = shipmentId;
            Tag = tag;
        }

        /// <summary>
        ///     Gets or Sets ShipmentId
        /// </summary>
        [DataMember(Name = "shipment_id", EmitDefaultValue = false)]
        public string ShipmentId { get; set; }

        /// <summary>
        ///     Gets or Sets Tag
        /// </summary>
        [DataMember(Name = "tag", EmitDefaultValue = false)]
        public TagResponse Tag { get; set; }

        /// <summary>
        ///     Returns true if ShipmentAddTagResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ShipmentAddTagResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentAddTagResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
            {
                return false;
            }

            return
                (
                    ShipmentId == other.ShipmentId ||
                    ShipmentId != null &&
                    ShipmentId.Equals(other.ShipmentId)
                ) &&
                (
                    Equals(Tag, other.Tag) ||
                    Tag != null &&
                    Tag.Equals(other.Tag)
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
            sb.Append("class ShipmentAddTagResponse {\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
            return Equals(obj as ShipmentAddTagResponse);
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
                if (ShipmentId != null)
                {
                    hash = hash * 59 + ShipmentId.GetHashCode();
                }
                if (Tag != null)
                {
                    hash = hash * 59 + Tag.GetHashCode();
                }
                return hash;
            }
        }
    }
}